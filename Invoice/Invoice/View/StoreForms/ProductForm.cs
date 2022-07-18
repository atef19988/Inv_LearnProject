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
namespace Invoice.View.StoreForms
{
    public partial class ProductForm : DevExpress.XtraEditors.XtraForm
    {
        ProcductControl ConProcduct;
        private Procduct OProcduct;

        public ProductForm()
        {
           ConProcduct = new ProcductControl();
        
            InitializeComponent();
        }
        int id = 1;

       

        private void  SetData()
        {
            OProcduct = new Procduct();
            OProcduct.Id = id;
            OProcduct.ProName = ProName.Text;
            OProcduct.SalePrice = Convert.ToDecimal(SpnSalePrice.EditValue);
            OProcduct.BuyPrice = Convert.ToDecimal(SpnBuyPrice.EditValue);
            OProcduct.Qty = Convert.ToDecimal(SpnBl.EditValue);
        }
        private void GetData()
        {
            id = Convert.ToInt32(Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OProcduct.Id)));
            ProName.Text = Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OProcduct.ProName)).ToString();
            SpnSalePrice.Text = Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OProcduct.SalePrice)).ToString();
            SpnBuyPrice.Text = Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OProcduct.BuyPrice)).ToString();
            SpnBl.EditValue = Convert.ToDecimal(Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OProcduct.Qty)));
        }
        void RefreshData()
        {
            Cgv.DataSource= ConProcduct.GetData().Select(a => new { Id = a.Id, ProName = a.ProName, Qty=a.Qty, SalePrice=a.SalePrice,BuyPrice=a.BuyPrice });
        }
 

        private void ProductForm_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            SetData();

            ConProcduct.Insert(OProcduct);
            RefreshData();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            SetData();
            ConProcduct.Update(OProcduct);
            RefreshData();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            ConProcduct.Delete(id);
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