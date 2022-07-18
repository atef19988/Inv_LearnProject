using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InvBackEnd.Bl;
using InvBackEnd.Models;
using DevExpress.XtraEditors.Repository;

namespace InvProjectByDevAndoop.FormVeiw.CustomerAndSales
{   
    public partial class CustomerForm : FormsMasterUi.FormMasterUi
    {


        CustomerBl customerBl;
        CustomerTb OcustomerTb;
        public CustomerForm()
        {
            InitializeComponent();      
            customerBl = new CustomerBl();
            OcustomerTb = new CustomerTb();
        }
        int Id=0;
        void SetData( )
        {
            OcustomerTb.CustName = TxtCustName.Text;
            OcustomerTb.Phone = TxtPhone.Text;
            OcustomerTb.OpiningBl = SpnBl.Text;
        }
        void SetDataLoop(int i )
        {
            OcustomerTb.CustName = Gv.GetRowCellValue(i, nameof(OcustomerTb.CustName)).ToString();
            OcustomerTb.Phone = Gv.GetRowCellValue(i, nameof(OcustomerTb.Phone)).ToString();

        }
        public override void RefreshData()
        {

     

            //insert data int inv Descrption
            //for (int i = 0; i < Gv.RowCount; i++)
            //{
            //    SetDataLoop(i);
            //    customerBl.Insert(OcustomerTb);
            //}

            //fill grid control 
            Cgv.DataSource = customerBl.GetData().Select(a => new { a.Id, a.CustName, a.Phone, a.OpiningBl }).ToList();
            Gv.OptionsBehavior.Editable = true;

            //Change type Column
            #region Change type Column
            RepositoryItemLookUpEdit lpe = new RepositoryItemLookUpEdit();
            lpe.DataSource = customerBl.GetData();
            lpe.ValueMember = nameof(OcustomerTb.Id);
            lpe.DisplayMember = nameof(OcustomerTb.CustName);
            Gv.Columns[nameof(OcustomerTb.Id)].ColumnEdit = lpe;

            RepositoryItemCalcEdit calcEdit = new RepositoryItemCalcEdit();
            Gv.Columns[nameof(OcustomerTb.Phone)].ColumnEdit = calcEdit;

            #endregion
            lookUpEdit1.Properties.DataSource = customerBl.GetData();
            lookUpEdit1.Properties.DisplayMember = nameof(OcustomerTb.CustName);
            lookUpEdit1.Properties.ValueMember = nameof(OcustomerTb.Id);

            //Get Sum
            decimal x;
            for (int i = 0; i < Gv.RowCount; i++)
            {
                x = +Convert.ToDecimal(Gv.GetRowCellValue(i, nameof(OcustomerTb.Id)));
            }
            Gv.SetRowCellValue(0, "Id", 5);

            base.RefreshData();
        }

        public override bool CheckData()
        {
            return base.CheckData();
        }
        public override void Add()
        {   
            SetData();
            customerBl.Insert(OcustomerTb);
            base.Add();
        }

        public override void Edit()
        {
            SetData();
            OcustomerTb.Id = Id;
            customerBl.Update(OcustomerTb);
            base.Edit();
        }

        public override void Delete()
        {
            customerBl.Delete(Id);
            base.Delete();
        }

        public override void GetData()
        {
            Id = Convert.ToInt32(Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OcustomerTb.Id)));
            TxtCustName.Text = Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OcustomerTb.CustName)).ToString();
            TxtPhone.Text = Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OcustomerTb.Phone)).ToString();
            SpnBl.EditValue = Gv.GetRowCellValue(Gv.FocusedRowHandle, nameof(OcustomerTb.OpiningBl)).ToString();
            base.GetData();
        }

      


     
       
      
 

        private void Gv_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            GetData();
        }

        private void CustomerForm_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
