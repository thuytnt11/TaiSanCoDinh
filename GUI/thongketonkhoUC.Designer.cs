namespace GUI
{
    partial class thongketonkhoUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thongketonkhoUC));
            this.label1 = new System.Windows.Forms.Label();
            this.griddsthietbi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmathietbi = new System.Windows.Forms.TextBox();
            this.txbtenthietbi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbsoluongton = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.griddsthietbi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mốc thời điểm thống kê tồn kho";
            // 
            // griddsthietbi
            // 
            this.griddsthietbi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.griddsthietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddsthietbi.Location = new System.Drawing.Point(4, 260);
            this.griddsthietbi.Name = "griddsthietbi";
            this.griddsthietbi.Size = new System.Drawing.Size(995, 257);
            this.griddsthietbi.TabIndex = 2;
            this.griddsthietbi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griddsthietbi_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã thiết bị";
            // 
            // txbmathietbi
            // 
            this.txbmathietbi.Enabled = false;
            this.txbmathietbi.Location = new System.Drawing.Point(253, 112);
            this.txbmathietbi.Name = "txbmathietbi";
            this.txbmathietbi.Size = new System.Drawing.Size(217, 20);
            this.txbmathietbi.TabIndex = 4;
            // 
            // txbtenthietbi
            // 
            this.txbtenthietbi.Enabled = false;
            this.txbtenthietbi.Location = new System.Drawing.Point(253, 182);
            this.txbtenthietbi.Name = "txbtenthietbi";
            this.txbtenthietbi.Size = new System.Drawing.Size(217, 20);
            this.txbtenthietbi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên thiết bị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng tồn kho tại thời điểm trên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbsoluongton);
            this.groupBox1.Controls.Add(this.lbsoluong);
            this.groupBox1.Location = new System.Drawing.Point(615, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lbsoluongton
            // 
            this.lbsoluongton.AutoSize = true;
            this.lbsoluongton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsoluongton.Location = new System.Drawing.Point(85, 30);
            this.lbsoluongton.Name = "lbsoluongton";
            this.lbsoluongton.Size = new System.Drawing.Size(0, 39);
            this.lbsoluongton.TabIndex = 1;
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsoluong.Location = new System.Drawing.Point(79, 46);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(0, 42);
            this.lbsoluong.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(722, 19);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 57);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "XEM";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(513, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // thongketonkhoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbtenthietbi);
            this.Controls.Add(this.txbmathietbi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.griddsthietbi);
            this.Controls.Add(this.label1);
            this.Name = "thongketonkhoUC";
            this.Size = new System.Drawing.Size(1002, 520);
            this.Load += new System.EventHandler(this.thongketonkhoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griddsthietbi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView griddsthietbi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmathietbi;
        private System.Windows.Forms.TextBox txbtenthietbi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbsoluongton;
        private System.Windows.Forms.Label lbsoluong;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
