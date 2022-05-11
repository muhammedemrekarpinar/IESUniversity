using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLMARKET_V2.APMenu.Menus
{
    public partial class Urun : Form
    {
        public Urun()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataSet ds = new DataSet();
        SqlDataReader rdr;

        public void filler()
        {
            ConnectionStr conn = new ConnectionStr();
            adpt = new SqlDataAdapter("Select * from Urun", conn.con());
            adpt.Fill(ds, "Urun");
            dGW_Klist.DataSource = ds.Tables["Urun"];
            dGW_Klist.RowsDefaultCellStyle.BackColor = Color.FromArgb(52, 52, 52);
            dGW_Klist.RowsDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dGW_Klist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 58, 58);
            dGW_Klist.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dGW_Klist.EnableHeadersVisualStyles = false;
            dGW_Klist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGW_Klist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGW_Klist.RowHeadersVisible = false;
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            cmbfiller();
            cmb2filler();
            filler();
            btn_add.TabStop = false;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_update.TabStop = false;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_delete.TabStop = false;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.FlatAppearance.BorderSize = 0;
        }   
        public void cmbfiller()
        {
            ConnectionStr conn = new ConnectionStr();
            cmd = new SqlCommand("Select * from Category", conn.con());
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmb_Kategori.Items.Add(rdr["Kategori"].ToString());
            }
        }
        public void cmb2filler()
        {
            ConnectionStr conn = new ConnectionStr();
            cmd = new SqlCommand("Select * from TradeMark", conn.con());
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmb_Marka.Items.Add(rdr["Marka"].ToString());
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionStr conn = new ConnectionStr();
                cmd = new SqlCommand("INSERT INTO Urun(UrunAdi,Kategori,Marka,AsgariStok,UrunMiktari,UrunFiyati)VALUES(@UrunAdi,@Kategori,@Marka,@AsgariStok,@UrunMiktari,@UrunFiyati)",conn.con());
                cmd.Parameters.AddWithValue("@UrunAdi", txt_UName.Text);
                cmd.Parameters.AddWithValue("@Kategori", cmb_Kategori.Text);
                cmd.Parameters.AddWithValue("@Marka", cmb_Marka.Text);
                cmd.Parameters.AddWithValue("@AsgariStok", txt_AStok.Text);
                cmd.Parameters.AddWithValue("@UrunMiktari", txt_UStok.Text);
                cmd.Parameters.AddWithValue("@UrunFiyati", txt_Fiyat.Text);
                cmd.ExecuteNonQuery();
                ds.Tables["Urun"].Clear();
                filler();
                cmb_Kategori.SelectedIndex = -1;
                cmb_Marka.SelectedIndex = -1;
                MessageBox.Show("Ekleme İşlemi Başarılı");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }
            catch (SqlException E)
            {
                MessageBox.Show("Ekleme İşlemi Başarısız : " + E.ToString());
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {
                cmd = new SqlCommand("update Urun set UrunAdi=@UrunAdi,Kategori=@Kategori,Marka=@Marka,AsgariStok=@AsgariStok,UrunMiktari=@UrunMiktari,UrunFiyati=@UrunFiyati where UUID=@UUID", conn.con());
                cmd.Parameters.AddWithValue("@UrunAdi", txt_UName.Text);
                cmd.Parameters.AddWithValue("@Kategori", cmb_Kategori.Text);
                cmd.Parameters.AddWithValue("@Marka", cmb_Marka.Text);
                cmd.Parameters.AddWithValue("@AsgariStok", txt_AStok.Text);
                cmd.Parameters.AddWithValue("@UrunMiktari", txt_UStok.Text);
                cmd.Parameters.AddWithValue("@UrunFiyati", txt_Fiyat.Text);
                cmd.Parameters.AddWithValue("@UUID", lbl_UID.Text);
                cmd.ExecuteNonQuery();
                ds.Tables["Urun"].Clear();
                filler();
                cmb_Kategori.SelectedIndex = -1;
                cmb_Marka.SelectedIndex = -1;
                MessageBox.Show("Güncelleme Başarılı.");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (SqlException E)
            {
                MessageBox.Show("İşlem Başarısız." + E.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {

                cmd = new SqlCommand("delete from Urun where UUID='" + dGW_Klist.CurrentRow.Cells["UUID"].Value.ToString() + "'", conn.con());
                cmd.ExecuteNonQuery();
                ds.Tables["Urun"].Clear();
                filler();
                MessageBox.Show("Silme Başarılı.");
            }
            catch (SqlException E)
            {
                MessageBox.Show("İşlem Başarısız." + E.ToString());
            }
        }

        private void dGW_Klist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_UName.Text = dGW_Klist.CurrentRow.Cells["UrunAdi"].Value.ToString();
            cmb_Kategori.Text = dGW_Klist.CurrentRow.Cells["Kategori"].Value.ToString();
            cmb_Marka.Text = dGW_Klist.CurrentRow.Cells["Marka"].Value.ToString();
            txt_AStok.Text = dGW_Klist.CurrentRow.Cells["AsgariStok"].Value.ToString();
            txt_UStok.Text = dGW_Klist.CurrentRow.Cells["UrunMiktari"].Value.ToString();
            txt_Fiyat.Text = dGW_Klist.CurrentRow.Cells["UrunFiyati"].Value.ToString();
            lbl_UID.Text = dGW_Klist.CurrentRow.Cells["UUID"].Value.ToString();
        }
    }
}
