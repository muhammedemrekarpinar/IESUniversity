using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLMARKET_V2.APMenu
{
    public partial class YetkiliMenu : Form
    {
        public YetkiliMenu()
        {
            InitializeComponent();
        }

        

        private void YetkiliMenu_Load(object sender, EventArgs e)
        {
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            //
            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            //
            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            //
            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            //
            button5.TabStop = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            //
            button6.TabStop = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_frm.Controls.Clear();
            Kasiyer KFRM = new Kasiyer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_frm.Controls.Add(KFRM);
            KFRM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_frm.Controls.Clear();
            Menus.Kategori_Marka UFRM = new Menus.Kategori_Marka() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_frm.Controls.Add(UFRM);
            UFRM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnl_frm.Controls.Clear();
            Menus.Urun KFRM = new Menus.Urun() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_frm.Controls.Add(KFRM);
            KFRM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnl_frm.Controls.Clear();
            Menus.StokKontrol KFRM = new Menus.StokKontrol() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_frm.Controls.Add(KFRM);
            KFRM.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnl_frm.Controls.Clear();
            Menus.YetkiliDüzenle KFRM = new Menus.YetkiliDüzenle() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_frm.Controls.Add(KFRM);
            KFRM.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris MP = new Giris();
            MP.ShowDialog();
            this.Close();
        }
    }
}
