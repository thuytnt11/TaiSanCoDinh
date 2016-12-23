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
    public partial class quanlythietbiUC : UserControl
    {
        public quanlythietbiUC()
        {
            InitializeComponent();
        }

        private void quanlythietbiUC_Load(object sender, EventArgs e)
        {
            loadds();
            loadloc();
            loadtt();
        }
        public void loadds()
        {
            //var list = new BindingList<Person>(persons);
            List<thietbiPUB> dsthietbi1 = BUS.thietbiBUS.dsthietbi();
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
     
        thietbiPUB tb = new thietbiPUB();
    
        public void loadtt()
        {
            try
            {
                txbtenthietbi.Text = griddsthietbi.CurrentRow.Cells[1].Value.ToString();
                txbdongia.Text = griddsthietbi.CurrentRow.Cells[2].Value.ToString();
                rtxbthongso.Text = griddsthietbi.CurrentRow.Cells[3].Value.ToString();
                txbngaysanxuat.Text = griddsthietbi.CurrentRow.Cells[4].Value.ToString();
                txbngaysudung.Text = griddsthietbi.CurrentRow.Cells[5].Value.ToString();
                txbsoluong.Text = griddsthietbi.CurrentRow.Cells[6].Value.ToString();
                cbdonvitinh.SelectedValue = int.Parse(griddsthietbi.CurrentRow.Cells[7].Value.ToString());
                cbloaithietbi.SelectedValue = int.Parse(griddsthietbi.CurrentRow.Cells[8].Value.ToString());
                cbphongquantri.SelectedValue = int.Parse(griddsthietbi.CurrentRow.Cells[9].Value.ToString());
                cbtinhtrang.SelectedValue = int.Parse(griddsthietbi.CurrentRow.Cells[10].Value.ToString());
                txbngaycapnhat.Text = griddsthietbi.CurrentRow.Cells[11].Value.ToString();
            }
            catch
            { }
        }
        private void griddsthietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txbtenthietbi.Text = griddsthietbi.CurrentRow.Cells[1].Value.ToString();
                txbdongia.Text = griddsthietbi.CurrentRow.Cells[2].Value.ToString();
                rtxbthongso.Text = griddsthietbi.CurrentRow.Cells[3].Value.ToString();
                txbngaysanxuat.Text = griddsthietbi.CurrentRow.Cells[4].Value.ToString();
                txbngaysudung.Text = griddsthietbi.CurrentRow.Cells[5].Value.ToString();
                txbsoluong.Text = griddsthietbi.CurrentRow.Cells[6].Value.ToString();
                cbdonvitinh.SelectedValue = int.Parse(griddsthietbi.CurrentRow.Cells[7].Value.ToString());
                cbloaithietbi.SelectedValue = int.Parse(griddsthietbi.CurrentRow.Cells[8].Value.ToString());
                cbphongquantri.SelectedValue = int.Parse(griddsthietbi.CurrentRow.Cells[9].Value.ToString());
                cbtinhtrang.SelectedValue = int.Parse(griddsthietbi.CurrentRow.Cells[10].Value.ToString());
                txbngaycapnhat.Text = griddsthietbi.CurrentRow.Cells[11].Value.ToString();
            }
            catch
            { }
        }

        private void txbtenthietbi_TextChanged(object sender, EventArgs e)
        {
            loadcompo();
        }
        public void loadcompo()
        {
            //đơn vị tính
            List<donvitinhPUB> dsdonvitinh = BUS.donvitinhBUS.dsdonvitinh();
            cbdonvitinh.DataSource = dsdonvitinh;
            cbdonvitinh.DisplayMember = "tendonvitinh";
            cbdonvitinh.ValueMember = "madonvitinh";
            //loại thiết bị
            List<loaithietbiPUB> dsloaithietbi = BUS.loaithietbiBUS.dsloaithietbi();
            cbloaithietbi.DataSource = dsloaithietbi;
            cbloaithietbi.DisplayMember = "tenloai";
            cbloaithietbi.ValueMember = "maloai";
          
            //phòng quản trị
            List<phongquantriPUB> dsphongquantri = BUS.phongquantriBUS.dsphongquantri();
            cbphongquantri.DataSource = dsphongquantri;
            cbphongquantri.DisplayMember = "tenphongquantri";
            cbphongquantri.ValueMember = "maphongquantri";
            //tình trạng thiết bị
            List<tinhtrangPUB> dstinhtrang = tinhtrangBUS.dstinhtrang();
            cbtinhtrang.DataSource = dstinhtrang;
            cbtinhtrang.DisplayMember = "tentinhtrang";
            cbtinhtrang.ValueMember = "matinhtrang";
           
        }
        public void loadloc()
        {
            //lọc loại
            List<loaithietbiPUB> dsloaithietbi = BUS.loaithietbiBUS.dsloaithietbi();
            cblocl.DataSource = dsloaithietbi;
            cblocl.DisplayMember = "tenloai";
            cblocl.ValueMember = "maloai";
            //lọc tình trạng
            List<tinhtrangPUB> dstinhtrang = tinhtrangBUS.dstinhtrang();
            cbloctt.DataSource = dstinhtrang;
            cbloctt.DisplayMember = "tentinhtrang";
            cbloctt.ValueMember = "matinhtrang";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            themthietbiGUI tb = new themthietbiGUI();
            DialogResult rs = tb.ShowDialog();
            if (rs == DialogResult.Cancel)
                loadds();
        }

        private void btxoa_Click(object sender, EventArgs e)
        { 
                try
                {
                    int matb = int.Parse(griddsthietbi.CurrentRow.Cells[0].Value.ToString());
                    thietbiBUS.xoathietbi(matb);
                    AutoClosingMessageBox.Show("Xóa thành công !", "XÓA", 1000);

                    loadds();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công ! Thiết bị hiện đang được sử dụng tại các đơn vị", "XÓA");
                }
        }
        private void btsua_Click(object sender, EventArgs e)
        {
            if (txbtenthietbi.Text == "" || txbdongia.Text == "" || rtxbthongso.Text == "" || cbtinhtrang.Text == "" || cbdonvitinh.Text == "" || txbngaysanxuat.Text == "" || txbngaysudung.Text == "" || cbloaithietbi.Text == "" || cbphongquantri.Text == "")
            {
                if (txbtenthietbi.Text == "")
                {
                    MessageBox.Show("Tên thiết bị không được để trống");
                }
                if (txbdongia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập giá thiết bị");
                }
                if (rtxbthongso.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông số thiết bị");
                }
                if (cbtinhtrang.Text == "")
                {
                    MessageBox.Show("Chọn tình trạng của thiết bị");
                }
                if (cbdonvitinh.Text == "")
                {
                    MessageBox.Show("Chọn đơn vị tính của thiết bị");
                }
                if (cbloaithietbi.Text == "")
                {
                    MessageBox.Show("Chọn loại thiết bị");
                }
                if (cbphongquantri.Text == "")
                {
                    MessageBox.Show("Chọn phòng quản trị");
                }
            }
            else
            {
                try
                {
                    int mathietbi = int.Parse(griddsthietbi.CurrentRow.Cells[0].Value.ToString());
                    string tenthietbi = txbtenthietbi.Text;
                    int dongia = int.Parse(txbdongia.Text);
                    string thongsokythuat = rtxbthongso.Text;
                    DateTime ngaysanxuat = DateTime.Parse(txbngaysanxuat.Text);
                    DateTime ngayduavaosudung = DateTime.Parse(txbngaysudung.Text);
                    DateTime ngaycapnhat = DateTime.Parse(txbngaycapnhat.Text);
                    int soluong = int.Parse(txbsoluong.Text);
                    int madonvitinh = int.Parse(cbdonvitinh.SelectedValue.ToString());
                    int maloai = int.Parse(cbloaithietbi.SelectedValue.ToString());
                    int maphongquantri = int.Parse(cbphongquantri.SelectedValue.ToString());
                    int matinhtrang = int.Parse(cbtinhtrang.SelectedValue.ToString());
                    thietbiBUS.suathietbi(mathietbi, tenthietbi, dongia, thongsokythuat, ngaysanxuat, ngayduavaosudung, ngaycapnhat, soluong, madonvitinh, maloai, maphongquantri, matinhtrang);
                    AutoClosingMessageBox.Show("Sửa thành công !", "SỬA", 1000);
                    loadds();
                }
                catch
                {
                    AutoClosingMessageBox.Show("Sửa không thành công", "SỬA", 1000);
                }
            }
        }
        public void loaddsloctt()
        {
            try {
                int tinhtrang = int.Parse(cbloctt.SelectedValue.ToString());
                List<thietbiPUB> dsthietbiloctt = BUS.thietbiBUS.dsthietbiloctt(tinhtrang);
                griddsthietbi.DataSource = dsthietbiloctt;
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
            catch { }
        }

        private void cbloctt_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddsloctt();
        }
        public void loaddslocl()
        {
            try {
                int loai = int.Parse(cblocl.SelectedValue.ToString());

                List<thietbiPUB> dsthietbilocl = BUS.thietbiBUS.dsthietbilocl(loai);

                griddsthietbi.DataSource = dsthietbilocl;
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
            catch { }
        }

        private void cblocl_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddslocl();
        }

        private void cbtinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbngaycapnhat.Text = DateTime.Now.ToString();
        }
        private void txbtenthietbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == (char)8) )
            {
                e.Handled = true;
                AutoClosingMessageBox.Show("Vui lòng chỉ nhập số và chữ","TRỢ GIÚP",1000);
            }
        }

        private void txbdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
                AutoClosingMessageBox.Show("Vui lòng chỉ nhập số nguyên dương","TRỢ GIÚP",1000);
            }
        }

        private void txbsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
                AutoClosingMessageBox.Show("Vui lòng chỉ nhập số", "TRỢ GIÚP",1000);
            }
        }

        private void txbtim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
                AutoClosingMessageBox.Show("Vui lòng chỉ nhập số và chữ", "TRỢ GIÚP",1000);
            }
        }

        private void txbngaysanxuat_ValueChanged(object sender, EventArgs e)
        {
            DateTime hientai = DateTime.Now;
            DateTime ngaysanxuat = DateTime.Parse(txbngaysanxuat.Text);
            if(ngaysanxuat > hientai)
            {
                AutoClosingMessageBox.Show("Ngày sản xuất không được lớn hơn ngày hiện tại", "TRỢ GIÚP",1000);
                txbngaysanxuat.Text = griddsthietbi.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void txbngaysudung_ValueChanged(object sender, EventArgs e)
        {
            DateTime hientai = DateTime.Now;
            DateTime ngaysanxuat = DateTime.Parse(txbngaysanxuat.Text);
            DateTime ngaysudung = DateTime.Parse(txbngaysudung.Text);
            if (ngaysudung > hientai)
            {
                AutoClosingMessageBox.Show("Ngày sản xuất không được lớn hơn ngày hiện tại", "TRỢ GIÚP",1000);
                txbngaysudung.Text = griddsthietbi.CurrentRow.Cells[5].Value.ToString();
            }
            if (ngaysudung < ngaysanxuat)
            {
                AutoClosingMessageBox.Show("Ngày sử dụng không được nhỏ hơn ngày sản xuất", "TRỢ GIÚP",1000);
                txbngaysudung.Text = griddsthietbi.CurrentRow.Cells[5].Value.ToString();
            }
        }
        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void txbtim_TextChanged(object sender, EventArgs e)
        {
            string ten = txbtim.Text;
            List<thietbiPUB> dsthietbitim = BUS.thietbiBUS.dsthietbitim(ten);
            griddsthietbi.DataSource = dsthietbitim;
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            loadds();
            loadtt();
        }
    }
}
