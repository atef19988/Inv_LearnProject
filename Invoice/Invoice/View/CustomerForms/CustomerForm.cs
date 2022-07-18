using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bl.Bl;
using Bl.Models;
namespace Invoice.View.CustomerForms
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        CustomerControl ConCustomer;
        private Customer OCustomer;

        public CustomerForm()
        {
           ConCustomer = new CustomerControl();
        
            InitializeComponent();
        }
        int id = 1;

       

        private void  SetData()
        {
            OCustomer = new Customer();
            OCustomer.Id = id;
            OCustomer.CustName = CustName.Text;
            OCustomer.Phone = Phone.Text;
            OCustomer.Fax = Fax.Text;
            OCustomer.OpiningBl = Convert.ToDecimal(SpnBl.EditValue);
        }
        private void GetData()
        {
            id = Convert.ToInt32(Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OCustomer.Id)));
            CustName.Text = Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OCustomer.CustName)).ToString();
            Phone.Text = Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OCustomer.Phone)).ToString();
            Fax.Text = Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OCustomer.Fax)).ToString();
            SpnBl.EditValue = Convert.ToDecimal(Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OCustomer.OpiningBl)));
        }
        void RefreshData()
        {
            Cgv.DataSource= ConCustomer.GetData().Select(a => new { Id = a.Id, CustName = a.CustName, OpiningBl=a.OpiningBl, Phone=a.Phone,Fax=a.Fax });
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
      
        }
        private void CustomerForm_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            SetData();

            ConCustomer.Insert(OCustomer);
            RefreshData();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            SetData();
            ConCustomer.Update(OCustomer);
            RefreshData();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            ConCustomer.Delete(id);
            RefreshData();
        }

        private void Gv_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GetData();
        }

        private void Gv_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
       
        }

        
    }
}