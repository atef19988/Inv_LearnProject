namespace InvProjectByDevAndoop.FormVeiw.CustomerAndSales
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Cgv = new DevExpress.XtraGrid.GridControl();
            this.Gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.SpnBl = new DevExpress.XtraEditors.SpinEdit();
            this.TxtPhone = new DevExpress.XtraEditors.TextEdit();
            this.TxtCustName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpnBl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCustName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.layoutControl1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(222, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(570, 648);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lookUpEdit1);
            this.layoutControl1.Controls.Add(this.Cgv);
            this.layoutControl1.Controls.Add(this.SpnBl);
            this.layoutControl1.Controls.Add(this.TxtPhone);
            this.layoutControl1.Controls.Add(this.TxtCustName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(729, 310, 812, 500);
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(570, 648);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Cgv
            // 
            this.Cgv.Location = new System.Drawing.Point(12, 140);
            this.Cgv.MainView = this.Gv;
            this.Cgv.MenuManager = this.fluentFormDefaultManager1;
            this.Cgv.Name = "Cgv";
            this.Cgv.Size = new System.Drawing.Size(546, 496);
            this.Cgv.TabIndex = 4;
            this.Cgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gv});
            // 
            // Gv
            // 
            this.Gv.GridControl = this.Cgv;
            this.Gv.Name = "Gv";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // SpnBl
            // 
            this.SpnBl.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpnBl.Location = new System.Drawing.Point(12, 80);
            this.SpnBl.MenuManager = this.fluentFormDefaultManager1;
            this.SpnBl.Name = "SpnBl";
            this.SpnBl.Properties.Appearance.Font = new System.Drawing.Font("Neo Sans Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpnBl.Properties.Appearance.Options.UseFont = true;
            this.SpnBl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpnBl.Size = new System.Drawing.Size(368, 30);
            this.SpnBl.StyleController = this.layoutControl1;
            this.SpnBl.TabIndex = 3;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(12, 46);
            this.TxtPhone.MenuManager = this.fluentFormDefaultManager1;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Properties.Appearance.Font = new System.Drawing.Font("Neo Sans Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPhone.Properties.Appearance.Options.UseFont = true;
            this.TxtPhone.Size = new System.Drawing.Size(368, 30);
            this.TxtPhone.StyleController = this.layoutControl1;
            this.TxtPhone.TabIndex = 2;
            // 
            // TxtCustName
            // 
            this.TxtCustName.Location = new System.Drawing.Point(12, 12);
            this.TxtCustName.MenuManager = this.fluentFormDefaultManager1;
            this.TxtCustName.Name = "TxtCustName";
            this.TxtCustName.Properties.Appearance.Font = new System.Drawing.Font("Neo Sans Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCustName.Properties.Appearance.Options.UseFont = true;
            this.TxtCustName.Size = new System.Drawing.Size(368, 30);
            this.TxtCustName.StyleController = this.layoutControl1;
            this.TxtCustName.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(570, 648);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Neo Sans Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.TxtCustName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(550, 34);
            this.layoutControlItem1.Text = "أسم العميل";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(166, 24);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Neo Sans Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.TxtPhone;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(550, 34);
            this.layoutControlItem2.Text = "رقم الهاتف";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(166, 24);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Cgv;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(550, 500);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Neo Sans Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.SpnBl;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(550, 34);
            this.layoutControlItem3.Text = "رصيد افتتاحى للعميل";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(166, 24);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(960, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(12, 114);
            this.lookUpEdit1.MenuManager = this.fluentFormDefaultManager1;
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(368, 22);
            this.lookUpEdit1.StyleController = this.layoutControl1;
            this.lookUpEdit1.TabIndex = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lookUpEdit1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(550, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(166, 16);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 687);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.FluentDesignFormControl = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.Activated += new System.EventHandler(this.CustomerForm_Activated);
            this.Controls.SetChildIndex(this.fluentDesignFormContainer1, 0);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpnBl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCustName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit SpnBl;
        private DevExpress.XtraEditors.TextEdit TxtPhone;
        private DevExpress.XtraEditors.TextEdit TxtCustName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl Cgv;
        private DevExpress.XtraGrid.Views.Grid.GridView Gv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}