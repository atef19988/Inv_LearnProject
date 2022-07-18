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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        void OpenForms(Form form)
        { 
            form.MdiParent = this;
            form.Show();
        }

        private void CustForms_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //OpenForms(new CustomerForm());
            CustomerForm form = new CustomerForm();
            form.MdiParent = this;
            form.Show();
        }

        private void ProductForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForms(new ProductForm());
        }
    }
}
