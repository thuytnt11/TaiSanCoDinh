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
using System.Collections.ObjectModel;
using System.Data.Entity;

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
            lbsoluongton.Text = griddsthietbi.CurrentRow.Cells[6].Value.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime thoidiem = DateTime.Parse(dateTimePicker1.Text);
            List<thietbiPUB> dsthietbi1 = BUS.thietbiBUS.dsthietbikho(thoidiem);
            var dsthietbi = new ObservableCollection<thietbiPUB>(dsthietbi1).ToBindingList();
            griddsthietbi.DataSource = dsthietbi;
            griddsthietbi.RowHeadersVisible = false;
            griddsthietbi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            griddsthietbi.Columns[0].HeaderText = "Mã thiết bị";
            griddsthietbi.Columns[1].HeaderText = "Tên thiết bị";
            griddsthietbi.Columns[2].HeaderText = "Đơn giá";
            griddsthietbi.Columns[3].HeaderText = "Thông số kỹ thuật";
            griddsthietbi.Columns[4].HeaderText = "Ngày sản xuất";
            griddsthietbi.Columns[5].HeaderText = "Ngày đưa vào sử dụng";
            griddsthietbi.Columns[6].HeaderText = "Số lượng";
            griddsthietbi.Columns[7].HeaderText = "Mã đơn vị tính";
            griddsthietbi.Columns[8].HeaderText = "Mã loại";
            griddsthietbi.Columns[9].HeaderText = "Mã phòng quản trị";
            griddsthietbi.Columns[10].HeaderText = "Tình trạng";
            griddsthietbi.Columns[11].HeaderText = "Ngày cập nhật";
        }
    }
}
