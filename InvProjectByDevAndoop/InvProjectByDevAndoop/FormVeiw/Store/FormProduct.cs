using DevExpress.XtraEditors;
using InvBackEnd.Bl;
using InvBackEnd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvProjectByDevAndoop.FormVeiw.Store
{
    public partial class FormProduct : FormsMasterUi.FormMasterUi
    {
        private ProductBl OProductBl;
        private ProductTb OProductTb;

        public FormProduct()
        {
            InitializeComponent();
            OProductBl = new ProductBl();
            OProductTb = new ProductTb();
        }

        int Id = 0;
        void SetData()
        {
            OProductTb.ProductName = txtName.Text;
            OProductTb.SalePrice = Convert.ToDecimal(spnsale.EditValue);
            OProductTb.BuyPrice = Convert.ToDecimal(spnBuy.EditValue);
            OProductTb.Qty = Convert.ToDecimal(spnqty.EditValue);
        }
        public override bool CheckData()
        {
            #region Check Empty Data
            if (txtName.Text == "")
            {
                MessageBox.Show("a7a");
                return false;
            }
            if (Convert.ToInt32(spnBuy.EditValue) != 0)
            {
                MessageBox.Show("a7a");
                return false;
            } 
            #endregion

            return base.CheckData();
        }
      
        public override void Add()
        {
       
            OProductBl.Insert(OProductTb);
            base.Add();
        }
        public override void Edit()
        {
            SetData();
            OProductTb.Id=Id;
            OProductBl.Update(OProductTb);

            base.Edit();
        }
        public override void Delete()
        {
            OProductBl.Delete(Id);
            base.Delete();
        }

     
        public override void RefreshData()
        {
            gridControl1.DataSource = OProductBl.GetData().Select( a => new {a.Id,a.ProductName,a.SalePrice,a.BuyPrice,a.Qty} ).ToList();    

            base.RefreshData();
        }
        public override void GetData()
        {
            #region GetDataFormDgv
            Id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, nameof(ProductTb.Id)));
            txtName.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, nameof(ProductTb.ProductName)));

            spnsale.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, nameof(ProductTb.SalePrice));
            spnBuy.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, nameof(ProductTb.BuyPrice));
            spnqty.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, nameof(ProductTb.Qty));

            #endregion

            base.GetData();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            GetData();
        }
    }
}