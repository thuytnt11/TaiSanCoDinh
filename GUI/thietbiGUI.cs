using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;

namespace GUI
{
    public partial class thietbiGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public thietbiGUI()
        {
            InitializeComponent();
        }
        private void btthietbi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnmain.Controls.Clear();
            quanlythietbiUC tb = new quanlythietbiUC();
            tb.Dock = System.Windows.Forms.DockStyle.Fill;
            pnmain.Controls.Add(tb);
        }

        private void btthongke_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnmain.Controls.Clear();
            thongketonkhoUC tk = new thongketonkhoUC();
            tk.Dock = System.Windows.Forms.DockStyle.Fill;
            pnmain.Controls.Add(tk);
        }

        private void bttinhtrang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnmain.Controls.Clear();
            thongketinhtrangUC tt = new thongketinhtrangUC();
            tt.Dock = System.Windows.Forms.DockStyle.Fill;
            pnmain.Controls.Add(tt);
        }

        private void thietbiGUI_Load(object sender, EventArgs e)
        {
            quanlythietbiUC tb = new quanlythietbiUC();
            tb.Dock = System.Windows.Forms.DockStyle.Fill;
            pnmain.Controls.Add(tb);
        }
    }
}
