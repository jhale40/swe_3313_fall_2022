using EasyNetQ;
using System.Diagnostics;

namespace WackyChat;

public partial class MainForm : Form
{
    private readonly object _syncLock = new();
    private int _msgCount = 0;
    private IBus? _bus;
    private RabbitMqConfig? _rabbitMqConfig;

    public MainForm()
    {
        InitializeComponent();
    }

    private void OnClearClick(object sender, EventArgs e)
    {
        lock (_syncLock)
        {
            txtInboundMessages.Text = "";
            txtInboundMessages.Focus();
        }
    }

    private void OnLoad(object sender, EventArgs e)
    {
        Task.Run(async () => await ConfigureBus(txtInboundMessages, lblMostRecentMsg)).Wait();
    }

    private void OnOutboundMsgKeyPress(object sender, KeyPressEventArgs e)
    {
        //do not send message until return key is clicked
        if (e.KeyChar != (char)Keys.Return) return;

        var outboundMsg = txtOutboundMsg.Text;
        if (string.IsNullOrWhiteSpace(outboundMsg)) return;

        //reset text box
        txtOutboundMsg.Text = "";

        //send to all wacky chatters
        Task.Run(async () => await SendMessage(outboundMsg)).Wait();
    }

    private async Task ConfigureBus(TextBox inboundMessageTextBox, Label mostRecentMsgLabel)
    {
        _rabbitMqConfig = RabbitMqConfig.GetConfig();
        _bus = RabbitHutch.CreateBus(_rabbitMqConfig.ConnectionString);

        //subscribe to messages
        await _bus.PubSub.SubscribeAsync<WackyChatMessage>(
            _rabbitMqConfig.WhoAmI,
            msg =>
                ShowInboundMessage(msg, inboundMessageTextBox, mostRecentMsgLabel),
            subscriptionConfig => subscriptionConfig.WithExpires(5 * 60 * 1000));
    }

    private void ShowInboundMessage(WackyChatMessage inboundMessage, TextBox textBox, Label mostRecentMsgLabel)
    {
        //don't show my own messages if "no show" is unchecked
        if (!chkShowMyMessages.Checked && inboundMessage.From == _rabbitMqConfig!.WhoAmI) return;

        lock (_syncLock) //one at a time
        {
            _msgCount++;
            textBox.Invoke((MethodInvoker)delegate
            {
                textBox.AppendText(
                    $"{inboundMessage.From} at {inboundMessage.SentAt} " +
                    $"said:{Environment.NewLine}-> {inboundMessage.Text}" +
                    $"{Environment.NewLine}{Environment.NewLine}");
            });

            mostRecentMsgLabel.Invoke((MethodInvoker)delegate
            {
                mostRecentMsgLabel.Text = $@"{_msgCount} messages, last from {inboundMessage.From}";
            });
        }
    }

    private void CloseBus()
    {
        _bus!.Dispose(); //clean up when form is closing
    }

    private async Task SendMessage(string text)
    {
        var msg = new WackyChatMessage { Text = text, From = _rabbitMqConfig!.WhoAmI };
        await _bus!.PubSub.PublishAsync(msg);
    }

    private void OnFormClosing(object sender, FormClosingEventArgs e)
    {
        CloseBus();
    }

    private void OnShowMyMessagesChanged(object sender, EventArgs e)
    {
        txtOutboundMsg.Focus();
    }
}