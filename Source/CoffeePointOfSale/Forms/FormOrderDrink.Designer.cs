namespace CoffeePointOfSale.Forms
{
    partial class FormOrderDrink
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bReturnToMain = new System.Windows.Forms.Button();
            this.bCoffee = new System.Windows.Forms.Button();
            this.bEspresso = new System.Windows.Forms.Button();
            this.bIcedLatte = new System.Windows.Forms.Button();
            this.bGreenTea = new System.Windows.Forms.Button();
            this.b_IcedWater = new System.Windows.Forms.Button();
            this.bLatte = new System.Windows.Forms.Button();
            this.bAddToOrder = new System.Windows.Forms.Button();
            this.bPay = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bReturnToMain
            // 
            this.bReturnToMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bReturnToMain.Location = new System.Drawing.Point(1180, 643);
            this.bReturnToMain.Name = "bReturnToMain";
            this.bReturnToMain.Size = new System.Drawing.Size(115, 38);
            this.bReturnToMain.TabIndex = 1;
            this.bReturnToMain.Text = "Exit";
            this.bReturnToMain.UseVisualStyleBackColor = false;
            this.bReturnToMain.Click += new System.EventHandler(this.bReturnToMain_Click);
            // 
            // bCoffee
            // 
            this.bCoffee.BackColor = System.Drawing.Color.White;
            this.bCoffee.Dock = System.Windows.Forms.DockStyle.Top;
            this.bCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCoffee.Location = new System.Drawing.Point(0, 0);
            this.bCoffee.Name = "bCoffee";
            this.bCoffee.Size = new System.Drawing.Size(342, 73);
            this.bCoffee.TabIndex = 2;
            this.bCoffee.Text = "Coffee";
            this.bCoffee.UseVisualStyleBackColor = false;
            this.bCoffee.Click += new System.EventHandler(this.bCoffee_Click);
            // 
            // bEspresso
            // 
            this.bEspresso.BackColor = System.Drawing.Color.White;
            this.bEspresso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEspresso.Location = new System.Drawing.Point(0, 117);
            this.bEspresso.Name = "bEspresso";
            this.bEspresso.Size = new System.Drawing.Size(342, 73);
            this.bEspresso.TabIndex = 3;
            this.bEspresso.Text = "Espresso";
            this.bEspresso.UseVisualStyleBackColor = false;
            this.bEspresso.Click += new System.EventHandler(this.bEspresso_Click);
            // 
            // bIcedLatte
            // 
            this.bIcedLatte.BackColor = System.Drawing.Color.White;
            this.bIcedLatte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIcedLatte.Location = new System.Drawing.Point(0, 238);
            this.bIcedLatte.Name = "bIcedLatte";
            this.bIcedLatte.Size = new System.Drawing.Size(342, 73);
            this.bIcedLatte.TabIndex = 4;
            this.bIcedLatte.Text = "Iced Latte";
            this.bIcedLatte.UseVisualStyleBackColor = false;
            this.bIcedLatte.Click += new System.EventHandler(this.bIcedLatte_Click);
            // 
            // bGreenTea
            // 
            this.bGreenTea.BackColor = System.Drawing.Color.White;
            this.bGreenTea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGreenTea.Location = new System.Drawing.Point(0, 340);
            this.bGreenTea.Name = "bGreenTea";
            this.bGreenTea.Size = new System.Drawing.Size(342, 73);
            this.bGreenTea.TabIndex = 5;
            this.bGreenTea.Text = "Iced Matcha Green Tea Latte";
            this.bGreenTea.UseVisualStyleBackColor = false;
            this.bGreenTea.Click += new System.EventHandler(this.bGreenTea_Click);
            // 
            // b_IcedWater
            // 
            this.b_IcedWater.BackColor = System.Drawing.Color.White;
            this.b_IcedWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_IcedWater.Location = new System.Drawing.Point(0, 465);
            this.b_IcedWater.Name = "b_IcedWater";
            this.b_IcedWater.Size = new System.Drawing.Size(342, 73);
            this.b_IcedWater.TabIndex = 6;
            this.b_IcedWater.Text = "Iced Water";
            this.b_IcedWater.UseVisualStyleBackColor = false;
            this.b_IcedWater.Click += new System.EventHandler(this.b_IcedWater_Click);
            // 
            // bLatte
            // 
            this.bLatte.BackColor = System.Drawing.Color.White;
            this.bLatte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLatte.Location = new System.Drawing.Point(0, 572);
            this.bLatte.Name = "bLatte";
            this.bLatte.Size = new System.Drawing.Size(342, 73);
            this.bLatte.TabIndex = 7;
            this.bLatte.Text = "Latte";
            this.bLatte.UseVisualStyleBackColor = false;
            this.bLatte.Click += new System.EventHandler(this.bLatte_Click);
            // 
            // bAddToOrder
            // 
            this.bAddToOrder.Location = new System.Drawing.Point(426, 610);
            this.bAddToOrder.Name = "bAddToOrder";
            this.bAddToOrder.Size = new System.Drawing.Size(219, 59);
            this.bAddToOrder.TabIndex = 8;
            this.bAddToOrder.Text = "Add";
            this.bAddToOrder.UseVisualStyleBackColor = true;
            this.bAddToOrder.Click += new System.EventHandler(this.bAddToOrder_Click);
            // 
            // bPay
            // 
            this.bPay.Location = new System.Drawing.Point(1023, 643);
            this.bPay.Name = "bPay";
            this.bPay.Size = new System.Drawing.Size(121, 38);
            this.bPay.TabIndex = 9;
            this.bPay.Text = "Pay";
            this.bPay.UseVisualStyleBackColor = true;
            this.bPay.Click += new System.EventHandler(this.bPay_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(400, 54);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(372, 382);
            this.checkedListBox.TabIndex = 10;
            this.checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(1023, 63);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(272, 229);
            this.listBox.TabIndex = 11;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.bCoffee);
            this.panelMenu.Controls.Add(this.bEspresso);
            this.panelMenu.Controls.Add(this.bIcedLatte);
            this.panelMenu.Controls.Add(this.bGreenTea);
            this.panelMenu.Controls.Add(this.b_IcedWater);
            this.panelMenu.Controls.Add(this.bLatte);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(342, 669);
            this.panelMenu.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1007, 331);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(191, 219);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FormOrderDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.bPay);
            this.Controls.Add(this.bAddToOrder);
            this.Controls.Add(this.bReturnToMain);
            this.Name = "FormOrderDrink";
            this.Text = "FormOrderDrink";
            this.Load += new System.EventHandler(this.FormOrderDrink_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bReturnToMain;
        private Button bCoffee;
        private Button bEspresso;
        private Button bIcedLatte;
        private Button bGreenTea;
        private Button b_IcedWater;
        private Button bLatte;
        private Button bAddToOrder;
        private Button bPay;
        private CheckedListBox checkedListBox;
        private ListBox listBox;
        private Panel panelMenu;
        private RichTextBox richTextBox1;
    }
}