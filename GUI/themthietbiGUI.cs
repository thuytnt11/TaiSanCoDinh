using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using PUB;
using BUS;

namespace GUI
{
    public partial class themthietbiGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public themthietbiGUI()
        {
            InitializeComponent();

        }

        private void btnhaplai_Click(object sender, EventArgs e)
        {
            txbtenthietbi.Text = "";
            txbdongia.Text = "";
            rtxbthongso.Text = "";
            cbdonvitinh.Text = "";
            txbngaysanxuat.Text = "";
            txbngaysudung.Text = "";
            cbloaithietbi.Text = "";
            cbphongquantri.Text = "";
            cbtinhtrang.Text = "";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void themthietbiGUI_Load(object sender, EventArgs e)
        {
            loadcompo();
        }

        private void btthem_Click(object sender, EventArgs e)
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
                    string tenthietbi = txbtenthietbi.Text;
                    int dongia = int.Parse(txbdongia.Text);
                    string thongsokythuat = rtxbthongso.Text;
                    DateTime ngaysanxuat = DateTime.Parse(txbngaysanxuat.Text);
                    DateTime ngayduavaosudung = DateTime.Parse(txbngaysudung.Text);
                    int soluong = 0;
                    int madonvitinh = int.Parse(cbdonvitinh.SelectedValue.ToString());
                    int maloai = int.Parse(cbloaithietbi.SelectedValue.ToString());
                    int maphongquantri = int.Parse(cbphongquantri.SelectedValue.ToString());
                    int matinhtrang = int.Parse(cbtinhtrang.SelectedValue.ToString());
                    DateTime ngaycapnhat = DateTime.Now;
                    thietbiBUS.themthietbi(tenthietbi, dongia, thongsokythuat, ngaysanxuat, ngayduavaosudung, ngaycapnhat, soluong, madonvitinh, maloai, maphongquantri, matinhtrang);
                    AutoClosingMessageBox.Show("Thêm thành công  !", "THÊM", 1000);

                }
                catch
                {
                    AutoClosingMessageBox.Show("Không thành công !", "THÊM", 1000);
                }
            }
            }

        private void txbtenthietbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
                AutoClosingMessageBox.Show("Vui lòng chỉ nhập số và chữ", "TRỢ GIÚP",1000);
            }
        }

        private void txbdongia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
                AutoClosingMessageBox.Show("Vui lòng chỉ nhập số nguyên dương", "TRỢ GIÚP",1000);
            }
        }

        private void txbngaysanxuat_ValueChanged(object sender, EventArgs e)
        {
            DateTime hientai = DateTime.Now;
            DateTime ngaysanxuat = DateTime.Parse(txbngaysanxuat.Text);
            if (ngaysanxuat > hientai)
            {
                AutoClosingMessageBox.Show("Ngày sản xuất không được lớn hơn ngày hiện tại", "TRỢ GIÚP",1000);
                txbngaysanxuat.Text = hientai.ToString();
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
                txbngaysudung.Text = hientai.ToString();
            }
            if (ngaysudung < ngaysanxuat)
            {
                AutoClosingMessageBox.Show("Ngày sử dụng không được nhỏ hơn ngày sản xuất", "TRỢ GIÚP",1000);
                txbngaysudung.Text = hientai.ToString();
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
    }
}