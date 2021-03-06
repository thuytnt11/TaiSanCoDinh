﻿using System;
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
    public partial class thongketinhtrangUC : UserControl
    {
        public thongketinhtrangUC()
        {
            InitializeComponent();
        }

        private void thongketinhtrangUC_Load(object sender, EventArgs e)
        {
            loadcompo();
        }
        public void loadcompo()
        {
            List<tinhtrangPUB> dstinhtrang = tinhtrangBUS.dstinhtrang();
            cbtinhtrang.DataSource = dstinhtrang;
            cbtinhtrang.DisplayMember = "tentinhtrang";
            cbtinhtrang.ValueMember = "matinhtrang";
        }

        private void btxem_Click(object sender, EventArgs e)
        {
            string tentinhtrang = cbtinhtrang.Text;
            int tinhtrang = int.Parse(cbtinhtrang.SelectedValue.ToString());
            DateTime thoidiem = DateTime.Parse(dtthoidiem.Text);
            List<thietbiPUB> dsthietbi1 = thietbiBUS.dsthietbitt(tinhtrang, thoidiem);
            var dsthietbi = new ObservableCollection<thietbiPUB>(dsthietbi1).ToBindingList();
            griddsthietbi.DataSource = dsthietbi;
            lbtong.Text = "Tổng thiết bị : " + (griddsthietbi.Rows.Count -1);
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

        private void griddsthietbi_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            griddsthietbi.Sort(griddsthietbi.Columns[griddsthietbi.Columns[e.ColumnIndex].Name], ListSortDirection.Ascending);
        }
    }
}
