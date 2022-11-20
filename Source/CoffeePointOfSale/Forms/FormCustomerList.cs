using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormCustomerList : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        public FormCustomerList(IAppSettings appSettings) : base(appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;
        }

        private void bReturnToMain_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }
    }
}
