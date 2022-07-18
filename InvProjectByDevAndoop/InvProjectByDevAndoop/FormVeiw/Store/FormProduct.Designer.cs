namespace InvProjectByDevAndoop.FormVeiw.Store
{
    partial class FormProduct
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.spnqty = new DevExpress.XtraEditors.SpinEdit();
            this.spnBuy = new DevExpress.XtraEditors.SpinEdit();
            this.spnsale = new DevExpress.XtraEditors.SpinEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnqty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnsale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spnqty);
            this.layoutControl1.Controls.Add(this.spnBuy);
            this.layoutControl1.Controls.Add(this.spnsale);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(260, 39);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(561, 636);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // spnqty
            // 
            this.spnqty.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnqty.Location = new System.Drawing.Point(12, 94);
            this.spnqty.Name = "spnqty";
            this.spnqty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnqty.Size = new System.Drawing.Size(462, 24);
            this.spnqty.StyleController = this.layoutControl1;
            this.spnqty.TabIndex = 8;
            // 
            // spnBuy
            // 
            this.spnBuy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnBuy.Location = new System.Drawing.Point(12, 66);
            this.spnBuy.Name = "spnBuy";
            this.spnBuy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnBuy.Size = new System.Drawing.Size(462, 24);
            this.spnBuy.StyleController = this.layoutControl1;
            this.spnBuy.TabIndex = 7;
            // 
            // spnsale
            // 
            this.spnsale.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnsale.Location = new System.Drawing.Point(12, 38);
            this.spnsale.Name = "spnsale";
            this.spnsale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnsale.Size = new System.Drawing.Size(462, 24);
            this.spnsale.StyleController = this.layoutControl1;
            this.spnsale.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(462, 22);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 122);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(537, 502);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(561, 636);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(541, 506);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(541, 26);
            this.layoutControlItem2.Text = "اسم المنتج";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spnsale;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(541, 28);
            this.layoutControlItem3.Text = "سعر البيع";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(63, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spnBuy;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(541, 28);
            this.layoutControlItem4.Text = "سعر الشراء";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(63, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spnqty;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(541, 28);
            this.layoutControlItem5.Text = "الكمية";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(63, 16);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 675);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnqty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnsale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit spnqty;
        private DevExpress.XtraEditors.SpinEdit spnBuy;
        private DevExpress.XtraEditors.SpinEdit spnsale;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}