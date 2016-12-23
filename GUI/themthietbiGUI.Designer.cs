namespace GUI
{
    partial class themthietbiGUI
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(themthietbiGUI));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btthem = new DevExpress.XtraEditors.SimpleButton();
            this.btthoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnhaplai = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbngaysudung = new System.Windows.Forms.DateTimePicker();
            this.txbngaysanxuat = new System.Windows.Forms.DateTimePicker();
            this.cbtinhtrang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbdonvitinh = new System.Windows.Forms.ComboBox();
            this.cbphongquantri = new System.Windows.Forms.ComboBox();
            this.cbloaithietbi = new System.Windows.Forms.ComboBox();
            this.rtxbthongso = new System.Windows.Forms.RichTextBox();
            this.txbdongia = new System.Windows.Forms.TextBox();
            this.txbtenthietbi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(975, 49);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 287);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(975, 31);
            // 
            // btthem
            // 
            this.btthem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Appearance.Options.UseFont = true;
            this.btthem.Image = ((System.Drawing.Image)(resources.GetObject("btthem.Image")));
            this.btthem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(37, 27);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(149, 69);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btthoat
            // 
            this.btthoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Appearance.Options.UseFont = true;
            this.btthoat.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.Image")));
            this.btthoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btthoat.Location = new System.Drawing.Point(118, 112);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(70, 103);
            this.btthoat.TabIndex = 2;
            this.btthoat.Text = "Thoát";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btthoat);
            this.groupBox2.Controls.Add(this.btnhaplai);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(755, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 230);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnhaplai
            // 
            this.btnhaplai.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhaplai.Appearance.Options.UseFont = true;
            this.btnhaplai.Image = ((System.Drawing.Image)(resources.GetObject("btnhaplai.Image")));
            this.btnhaplai.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnhaplai.Location = new System.Drawing.Point(37, 112);
            this.btnhaplai.Name = "btnhaplai";
            this.btnhaplai.Size = new System.Drawing.Size(75, 103);
            this.btnhaplai.TabIndex = 1;
            this.btnhaplai.Text = "Nhập lại";
            this.btnhaplai.Click += new System.EventHandler(this.btnhaplai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbngaysudung);
            this.groupBox1.Controls.Add(this.txbngaysanxuat);
            this.groupBox1.Controls.Add(this.cbtinhtrang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbdonvitinh);
            this.groupBox1.Controls.Add(this.cbphongquantri);
            this.groupBox1.Controls.Add(this.cbloaithietbi);
            this.groupBox1.Controls.Add(this.rtxbthongso);
            this.groupBox1.Controls.Add(this.txbdongia);
            this.groupBox1.Controls.Add(this.txbtenthietbi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 230);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin thiết bị";
            // 
            // txbngaysudung
            // 
            this.txbngaysudung.Location = new System.Drawing.Point(540, 107);
            this.txbngaysudung.Name = "txbngaysudung";
            this.txbngaysudung.Size = new System.Drawing.Size(183, 22);
            this.txbngaysudung.TabIndex = 26;
            this.txbngaysudung.ValueChanged += new System.EventHandler(this.txbngaysudung_ValueChanged);
            // 
            // txbngaysanxuat
            // 
            this.txbngaysanxuat.Location = new System.Drawing.Point(540, 65);
            this.txbngaysanxuat.Name = "txbngaysanxuat";
            this.txbngaysanxuat.Size = new System.Drawing.Size(183, 22);
            this.txbngaysanxuat.TabIndex = 25;
            this.txbngaysanxuat.ValueChanged += new System.EventHandler(this.txbngaysanxuat_ValueChanged);
            // 
            // cbtinhtrang
            // 
            this.cbtinhtrang.FormattingEnabled = true;
            this.cbtinhtrang.Location = new System.Drawing.Point(127, 191);
            this.cbtinhtrang.Name = "cbtinhtrang";
            this.cbtinhtrang.Size = new System.Drawing.Size(183, 24);
            this.cbtinhtrang.TabIndex = 20;
     
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tình trạng";
            // 
            // cbdonvitinh
            // 
            this.cbdonvitinh.FormattingEnabled = true;
            this.cbdonvitinh.Location = new System.Drawing.Point(540, 22);
            this.cbdonvitinh.Name = "cbdonvitinh";
            this.cbdonvitinh.Size = new System.Drawing.Size(183, 24);
            this.cbdonvitinh.TabIndex = 18;

            // 
            // cbphongquantri
            // 
            this.cbphongquantri.FormattingEnabled = true;
            this.cbphongquantri.Location = new System.Drawing.Point(540, 191);
            this.cbphongquantri.Name = "cbphongquantri";
            this.cbphongquantri.Size = new System.Drawing.Size(183, 24);
            this.cbphongquantri.TabIndex = 17;

            // 
            // cbloaithietbi
            // 
            this.cbloaithietbi.FormattingEnabled = true;
            this.cbloaithietbi.Location = new System.Drawing.Point(540, 146);
            this.cbloaithietbi.Name = "cbloaithietbi";
            this.cbloaithietbi.Size = new System.Drawing.Size(183, 24);
            this.cbloaithietbi.TabIndex = 16;
  
            // 
            // rtxbthongso
            // 
            this.rtxbthongso.Location = new System.Drawing.Point(127, 107);
            this.rtxbthongso.Name = "rtxbthongso";
            this.rtxbthongso.Size = new System.Drawing.Size(183, 75);
            this.rtxbthongso.TabIndex = 12;
            this.rtxbthongso.Text = "";

            // 
            // txbdongia
            // 
            this.txbdongia.Location = new System.Drawing.Point(127, 67);
            this.txbdongia.Name = "txbdongia";
            this.txbdongia.Size = new System.Drawing.Size(183, 22);
            this.txbdongia.TabIndex = 10;
            this.txbdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbdongia_KeyPress);
            // 
            // txbtenthietbi
            // 
            this.txbtenthietbi.Location = new System.Drawing.Point(127, 30);
            this.txbtenthietbi.Name = "txbtenthietbi";
            this.txbtenthietbi.Size = new System.Drawing.Size(183, 22);
            this.txbtenthietbi.TabIndex = 9;
           
            this.txbtenthietbi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbtenthietbi_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phòng quản trị ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Loại thiết bị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn vị tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sử dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thông số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thiết bị";
            // 
            // themthietbiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 318);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "themthietbiGUI";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.themthietbiGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraEditors.SimpleButton btthem;
        private DevExpress.XtraEditors.SimpleButton btthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnhaplai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbdonvitinh;
        private System.Windows.Forms.ComboBox cbphongquantri;
        private System.Windows.Forms.ComboBox cbloaithietbi;
        private System.Windows.Forms.RichTextBox rtxbthongso;
        private System.Windows.Forms.TextBox txbdongia;
        private System.Windows.Forms.TextBox txbtenthietbi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtinhtrang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txbngaysudung;
        private System.Windows.Forms.DateTimePicker txbngaysanxuat;
    }
}