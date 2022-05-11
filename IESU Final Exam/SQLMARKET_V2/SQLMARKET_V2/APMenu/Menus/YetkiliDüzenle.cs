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
    public partial class YetkiliDüzenle : Form
    {
        public YetkiliDüzenle()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataSet ds = new DataSet();
        public void filler()
        {

            ConnectionStr conn = new ConnectionStr();
            adpt = new SqlDataAdapter("Select ID as KullanıcıAdı,Pass as Şifre,UID From ACC", conn.con());
            adpt.Fill(ds, "ACC");
            dGW_Klist.DataSource = ds.Tables["ACC"];
            dGW_Klist.RowsDefaultCellStyle.BackColor = Color.FromArgb(52, 52, 52);
            dGW_Klist.RowsDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dGW_Klist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 58, 58);
            dGW_Klist.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dGW_Klist.EnableHeadersVisualStyles = false;
            dGW_Klist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGW_Klist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGW_Klist.RowHeadersVisible = false;
        }

        private void YetkiliDüzenle_Load(object sender, EventArgs e)
        {
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {
                cmd = new SqlCommand("update ACC set ID=@ID,Pass=@Pass where UID=@UID", conn.con());
                cmd.Parameters.AddWithValue("@UID", LID.Text);
                cmd.Parameters.AddWithValue("@ID", txt_KID.Text);
                cmd.Parameters.AddWithValue("@Pass", txt_KPass.Text);
                cmd.ExecuteNonQuery();
                ds.Tables["ACC"].Clear();
                filler();
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

        private void dGW_Klist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LID.Text = dGW_Klist.CurrentRow.Cells["UID"].Value.ToString();
            txt_KID.Text = dGW_Klist.CurrentRow.Cells["KullanıcıAdı"].Value.ToString();
            txt_KPass.Text = dGW_Klist.CurrentRow.Cells["Şifre"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {
                cmd = new SqlCommand("INSERT INTO ACC(ID,Pass)VALUES(@ID,@Pass)", conn.con());
                cmd.Parameters.AddWithValue("@ID", txt_KID.Text);
                cmd.Parameters.AddWithValue("@Pass", txt_KPass.Text);
                cmd.ExecuteNonQuery();
                ds.Tables["ACC"].Clear();
                filler();
                MessageBox.Show("Kayıt Başarılı");
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
                MessageBox.Show("Kayıt Yapılamadı " + E.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {

                cmd = new SqlCommand("delete from ACC where UID='" + dGW_Klist.CurrentRow.Cells["UID"].Value.ToString() + "'", conn.con());
                cmd.ExecuteNonQuery();
                ds.Tables["ACC"].Clear();
                filler();
                MessageBox.Show("Silme Başarılı.");
            }
            catch (SqlException E)
            {
                MessageBox.Show("İşlem Başarısız." + E.ToString());
            }
        }
    }
}
