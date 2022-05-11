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
    public partial class Kategori_Marka : Form
    {
        public Kategori_Marka()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataSet ds = new DataSet();

        private void Kategori_Marka_Load(object sender, EventArgs e)
        {
            filler1();
            //
            filler2();
            //
            btn_add.TabStop = false;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_update.TabStop = false;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_delete.TabStop = false;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.FlatAppearance.BorderSize = 0;
            //
            btn_add2.TabStop = false;
            btn_add2.FlatStyle = FlatStyle.Flat;
            btn_add2.FlatAppearance.BorderSize = 0;
            btn_update2.TabStop = false;
            btn_update2.FlatStyle = FlatStyle.Flat;
            btn_update2.FlatAppearance.BorderSize = 0;
            btn_delete2.TabStop = false;
            btn_delete2.FlatStyle = FlatStyle.Flat;
            btn_delete2.FlatAppearance.BorderSize = 0;

        }

        private void filler1()
        {
            ConnectionStr conn = new ConnectionStr();
            adpt = new SqlDataAdapter("Select * From Category", conn.con());
            adpt.Fill(ds, "Category");
            dGW_Klist1.DataSource = ds.Tables["Category"];
            dGW_Klist1.RowsDefaultCellStyle.BackColor = Color.FromArgb(52, 52, 52);
            dGW_Klist1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dGW_Klist1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 58, 58);
            dGW_Klist1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dGW_Klist1.EnableHeadersVisualStyles = false;
            dGW_Klist1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGW_Klist1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGW_Klist1.RowHeadersVisible = false;
        }

        private void filler2()
        {
            ConnectionStr conn = new ConnectionStr();
            adpt = new SqlDataAdapter("Select * From TradeMark", conn.con());
            adpt.Fill(ds, "TradeMark");
            dGW_Klist2.DataSource = ds.Tables["TradeMark"];
            dGW_Klist2.RowsDefaultCellStyle.BackColor = Color.FromArgb(52, 52, 52);
            dGW_Klist2.RowsDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dGW_Klist2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 58, 58);
            dGW_Klist2.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dGW_Klist2.EnableHeadersVisualStyles = false;
            dGW_Klist2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGW_Klist2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGW_Klist2.RowHeadersVisible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {
                cmd = new SqlCommand("INSERT INTO Category(Kategori)VALUES(@Kategori)", conn.con());
                cmd.Parameters.AddWithValue("@Kategori", txt_Kategori.Text);
                cmd.ExecuteNonQuery();
                ds.Tables["Category"].Clear();
                filler1();
                MessageBox.Show("Kategori Eklendi");
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
                MessageBox.Show("Ekleme İşlemi Başarısız " + E.ToString());
            }
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {
                cmd = new SqlCommand("INSERT INTO TradeMark(Marka)VALUES(@Marka)", conn.con());
                cmd.Parameters.AddWithValue("@Marka", txt_Marka.Text);
                cmd.ExecuteNonQuery();
                ds.Tables["TradeMark"].Clear();
                filler2();
                MessageBox.Show("Marka Eklendi");
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
                MessageBox.Show("Ekleme İşlemi Başarısız " + E.ToString());
            }
        }

        private void dGW_Klist1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            l_ID1.Text = dGW_Klist1.CurrentRow.Cells["KtgrID"].Value.ToString();
            txt_Kategori.Text = dGW_Klist1.CurrentRow.Cells["Kategori"].Value.ToString();
        }

        private void dGW_Klist2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            l_ID2.Text = dGW_Klist2.CurrentRow.Cells["MarkaID"].Value.ToString();
            txt_Marka.Text = dGW_Klist2.CurrentRow.Cells["Marka"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {
                cmd = new SqlCommand("update Category set Kategori=@Kategori where KtgrID=@KtgrID", conn.con());
                cmd.Parameters.AddWithValue("@Ktgr_ID", l_ID1.Text);
                cmd.Parameters.AddWithValue("@Kategori", txt_Kategori.Text);
                cmd.ExecuteNonQuery();
                ds.Tables["Category"].Clear();
                filler1();
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

        private void btn_update2_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {
                cmd = new SqlCommand("update TradeMark set Marka=@Marka where MarkaID=@MarkaID", conn.con());
                cmd.Parameters.AddWithValue("@MarkaID", l_ID2.Text);
                cmd.Parameters.AddWithValue("@Marka", txt_Marka.Text);
                cmd.ExecuteNonQuery();
                ds.Tables["TradeMark"].Clear();
                filler2();
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
                cmd = new SqlCommand("delete from Category where KtgrID='" + dGW_Klist1.CurrentRow.Cells["KtgrID"].Value.ToString() + "'", conn.con());
                cmd.ExecuteNonQuery();
                ds.Tables["Category"].Clear();
                filler1();
                MessageBox.Show("Silme Başarılı.");
            }
            catch (SqlException E)
            {
                MessageBox.Show("İşlem Başarısız." + E.ToString());
            }
        }

        private void btn_delete2_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {
                cmd = new SqlCommand("delete from TradeMark where MarkaID='" + dGW_Klist2.CurrentRow.Cells["MarkaID"].Value.ToString() + "'", conn.con());
                cmd.ExecuteNonQuery();
                ds.Tables["TradeMark"].Clear();
                filler2();
                MessageBox.Show("Silme Başarılı.");
            }
            catch (SqlException E)
            {
                MessageBox.Show("İşlem Başarısız." + E.ToString());
            }
        }
    }
}
