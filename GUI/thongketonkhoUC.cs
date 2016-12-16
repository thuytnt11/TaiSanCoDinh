using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PUB;
using BUS;

namespace GUI
{
    public partial class thongketonkhoUC : UserControl
    {
        public thongketonkhoUC()
        {
            InitializeComponent();
        }

        private void thongketonkhoUC_Load(object sender, EventArgs e)
        {

        }

        private void griddsthietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbmathietbi.Text = griddsthietbi.CurrentRow.Cells[0].Value.ToString();
            txbtenthietbi.Text = griddsthietbi.CurrentRow.Cells[1].Value.ToString();
            lbsoluongton.Text = griddsthietbi.CurrentRow.Cells[2].Value.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime thoidiem = DateTime.Parse(dateTimePicker1.Text);
            List<dskho> dsthietbitk = BUS.thietbiBUS.dsthietbikho(thoidiem);
            griddsthietbi.DataSource = dsthietbitk;
            griddsthietbi.RowHeadersVisible = false;
            griddsthietbi.Columns[0].Width = 350;
            griddsthietbi.Columns[1].Width = 350;
            griddsthietbi.Columns[2].Width = 350;
            griddsthietbi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            griddsthietbi.Columns[0].HeaderText = "Mã thiết bị";
            griddsthietbi.Columns[1].HeaderText = "Tên thiết bị";
            griddsthietbi.Columns[2].HeaderText = "Số lượng tồn kho";
        }
    }
}
