using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using Invoice.View.CustomerForms;
using Invoice.View.StoreForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Invoice
{
    public partial class MainFormFluent : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public MainFormFluent()
        {
            InitializeComponent();
        }

        void OpenForm(Form form)
        {
            form.TopLevel = false;
            form.MdiParent = this;
            form.Show();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerForm());
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductForm());

        }
    }
}
