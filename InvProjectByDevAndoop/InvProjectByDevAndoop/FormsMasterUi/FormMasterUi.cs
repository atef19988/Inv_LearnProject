using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InvProjectByDevAndoop.FormsMasterUi
{
    public partial class FormMasterUi : FluentDesignForm
    {
        public FormMasterUi()
        {
            InitializeComponent();
        }
        public virtual bool CheckData()
        {
            return true;
        }

        public virtual void Add()
        {
             

        }

        public virtual void Edit()
        {


        }
        public virtual void Delete()
        {


        }
        public virtual void RefreshData()
        {
            BtnAdd.Visible = true;
            BtnDelete.Visible = false;
            BtnEdit.Visible = false;
        }


        public virtual void GetData()
        {
            BtnAdd.Visible = false ;
            BtnDelete.Visible = true;
            BtnEdit.Visible = true;

        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData() == false)
            {
                return;
            }
            Add();
            RefreshData();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (CheckData() == false)
            {
                return;


            }
            Edit();
            RefreshData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CheckData() == false)
            {
                return;


            }
            Delete();
            RefreshData();
        }

        private void FormMasterUi_Activated(object sender, EventArgs e)
        {
            RefreshData();

        }
    }
}
