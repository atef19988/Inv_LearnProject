using InvProjectByDevAndoop.FormVeiw.CustomerAndSales;
using InvProjectByDevAndoop.FormVeiw.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InvProjectByDevAndoop
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void OpenForm(Form frm )
        {
            frm.Show(); 

        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         OpenForm(new FormProduct());
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(new CustomerForm());
        }
    }
}
