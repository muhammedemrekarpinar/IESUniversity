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

namespace SQLMARKET_V2.PMenu
{
    public partial class PersonelMenu : Form
    {
        public PersonelMenu()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataSet ds = new DataSet();
        SqlDataReader rdr;

        private void PersonelMenu_Load(object sender, EventArgs e)
        {
            btn_add.TabStop = false;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_delete.TabStop = false;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_end.TabStop = false;
            btn_end.FlatStyle = FlatStyle.Flat;
            btn_end.FlatAppearance.BorderSize = 0;
            filler();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Barkod No";
            dataGridView1.Columns[1].Name = "Ürün Adı";
            dataGridView1.Columns[2].Name = "Ürün Adedi";
            dataGridView1.Columns[3].Name = "Ürün Fiyatı";
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(52, 52, 52);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 58, 58);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
        }

        private void dGW_Klist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_BN.Text = dGW_Klist.CurrentRow.Cells["BarkodNO"].Value.ToString();
            txt_UName.Text = dGW_Klist.CurrentRow.Cells["ÜrünAdı"].Value.ToString();
            txt_Fiyat.Text = dGW_Klist.CurrentRow.Cells["ÜrünFiyatı"].Value.ToString();
        }

        public void filler()
        {
            ConnectionStr conn = new ConnectionStr();
            adpt = new SqlDataAdapter("Select UUID as BarkodNO,UrunAdi as ÜrünAdı,UrunFiyati as ÜrünFiyatı from Urun", conn.con());
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


        private void btn_add_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt16(txt_Count.Text);
            y = Convert.ToInt16(txt_Fiyat.Text);
            z = x * y;
            dataGridView1.Rows.Add(txt_UName.Text, txt_BN.Text, txt_Count.Text, z);
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            lbl_GTOP.Text = toplam.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            if (dataGridView1.Rows.Count == 0)
            {
                lbl_GTOP.Text = "";
            }
        }


        private void btn_end_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionStr conn = new ConnectionStr();
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    cmd = new SqlCommand("Update Urun set UrunMiktari=UrunMiktari-'" + dataGridView1.Rows[i].Cells["Ürün Adedi"].Value.ToString() + "'where UUID='" + dataGridView1.Rows[i].Cells["Barkod No"].Value.ToString() + "'", conn.con());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Satış işlemi gerçekleşti");
                }
                dataGridView1.Rows.Clear();
            }
            catch (SqlException E)
            {
                MessageBox.Show("İşlem Başarısız");
            }
        }

        private void txt_BN_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_UName.Text == "")
            {
                txt_Fiyat.Text = "";
                txt_UName.Text = "";
            }
            ConnectionStr conn = new ConnectionStr();
            cmd = new SqlCommand("Select UUID,UrunAdi,UrunFiyati from Urun where UUID like '" + txt_BN.Text + "'", conn.con());
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txt_UName.Text = rdr["UrunAdi"].ToString();
                txt_Fiyat.Text = rdr["UrunFiyati"].ToString();
            }
        }

        private void txt_UName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
