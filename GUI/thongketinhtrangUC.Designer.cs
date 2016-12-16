namespace GUI
{
    partial class thongketinhtrangUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thongketinhtrangUC));
            this.label1 = new System.Windows.Forms.Label();
            this.cbtinhtrang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btxem = new DevExpress.XtraEditors.SimpleButton();
            this.lbtong = new System.Windows.Forms.Label();
            this.griddsthietbi = new System.Windows.Forms.DataGridView();
            this.dtthoidiem = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.griddsthietbi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tình trạng";
            // 
            // cbtinhtrang
            // 
            this.cbtinhtrang.FormattingEnabled = true;
            this.cbtinhtrang.Location = new System.Drawing.Point(183, 40);
            this.cbtinhtrang.Name = "cbtinhtrang";
            this.cbtinhtrang.Size = new System.Drawing.Size(239, 21);
            this.cbtinhtrang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mốc thời gian";
            // 
            // btxem
            // 
            this.btxem.Image = ((System.Drawing.Image)(resources.GetObject("btxem.Image")));
            this.btxem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btxem.Location = new System.Drawing.Point(424, 84);
            this.btxem.Name = "btxem";
            this.btxem.Size = new System.Drawing.Size(119, 61);
            this.btxem.TabIndex = 4;
            this.btxem.Text = "XEM";
            this.btxem.Click += new System.EventHandler(this.btxem_Click);
            // 
            // lbtong
            // 
            this.lbtong.AutoSize = true;
            this.lbtong.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtong.Location = new System.Drawing.Point(363, 155);
            this.lbtong.Name = "lbtong";
            this.lbtong.Size = new System.Drawing.Size(0, 33);
            this.lbtong.TabIndex = 5;
            // 
            // griddsthietbi
            // 
            this.griddsthietbi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.griddsthietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddsthietbi.Location = new System.Drawing.Point(4, 200);
            this.griddsthietbi.Name = "griddsthietbi";
            this.griddsthietbi.Size = new System.Drawing.Size(995, 317);
            this.griddsthietbi.TabIndex = 6;
            // 
            // dtthoidiem
            // 
            this.dtthoidiem.Location = new System.Drawing.Point(679, 40);
            this.dtthoidiem.Name = "dtthoidiem";
            this.dtthoidiem.Size = new System.Drawing.Size(229, 20);
            this.dtthoidiem.TabIndex = 7;
            // 
            // thongketinhtrangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtthoidiem);
            this.Controls.Add(this.griddsthietbi);
            this.Controls.Add(this.lbtong);
            this.Controls.Add(this.btxem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbtinhtrang);
            this.Controls.Add(this.label1);
            this.Name = "thongketinhtrangUC";
            this.Size = new System.Drawing.Size(1002, 520);
            this.Load += new System.EventHandler(this.thongketinhtrangUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griddsthietbi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtinhtrang;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btxem;
        private System.Windows.Forms.Label lbtong;
        private System.Windows.Forms.DataGridView griddsthietbi;
        private System.Windows.Forms.DateTimePicker dtthoidiem;
    }
}
