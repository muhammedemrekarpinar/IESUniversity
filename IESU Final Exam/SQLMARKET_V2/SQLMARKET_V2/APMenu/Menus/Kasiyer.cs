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

namespace SQLMARKET_V2.APMenu
{
    public partial class Kasiyer : Form
    {
        public Kasiyer()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataSet ds = new DataSet();

        public void filler()
        {
            ConnectionStr conn = new ConnectionStr();
            adpt = new SqlDataAdapter("Select KID as KullanıcıAdı,KPass as Şifre,KName as Adı,KSName as Soyadı,KTC as TC, KUID as LID From KAccount", conn.con());
            adpt.Fill(ds, "KAccount");
            dGW_Klist.DataSource = ds.Tables["KAccount"];
            dGW_Klist.RowsDefaultCellStyle.BackColor = Color.FromArgb(52, 52, 52);
            dGW_Klist.RowsDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dGW_Klist.ColumnHeadersDefaultCellStyle.BackColor= Color.FromArgb(58, 58, 58);
            dGW_Klist.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(110, 125, 171);
            dGW_Klist.EnableHeadersVisualStyles = false;
            dGW_Klist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGW_Klist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGW_Klist.RowHeadersVisible = false;
        }

        private void Kasiyer_Load(object sender, EventArgs e)
        {          
            txt_TC.MaxLength = 11;
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

        private void dGW_Klist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {
                cmd = new SqlCommand("update KAccount set KID=@KID,KPass=@KPass,KName=@KName,KSName=@KSName,KTC=@KTC where KUID=@KUID", conn.con());
                cmd.Parameters.AddWithValue("@KUID", LID.Text);
                cmd.Parameters.AddWithValue("@KID", txt_KID.Text);
                cmd.Parameters.AddWithValue("@KPass", txt_KPass.Text);
                cmd.Parameters.AddWithValue("@KName", txt_KSName.Text);
                cmd.Parameters.AddWithValue("@KSName", txt_KName.Text);
                cmd.Parameters.AddWithValue("@KTC", txt_TC.Text);
                cmd.ExecuteNonQuery();
                ds.Tables["KAccount"].Clear();
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {

                cmd = new SqlCommand("delete from KAccount where KUID='" + dGW_Klist.CurrentRow.Cells["LID"].Value.ToString() + "'", conn.con());
                cmd.ExecuteNonQuery();
                ds.Tables["KAccount"].Clear();
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
            //Select KID as KullanıcıAdı,KPass as Şifre,KName as Adı,KSName as Soyadı,KTC as TC, KUID as LID
            LID.Text = dGW_Klist.CurrentRow.Cells["LID"].Value.ToString();
            txt_KID.Text = dGW_Klist.CurrentRow.Cells["KullanıcıAdı"].Value.ToString();
            txt_KPass.Text = dGW_Klist.CurrentRow.Cells["Şifre"].Value.ToString();
            txt_KSName.Text = dGW_Klist.CurrentRow.Cells["Adı"].Value.ToString();
            txt_KName.Text = dGW_Klist.CurrentRow.Cells["Soyadı"].Value.ToString();
            txt_TC.Text = dGW_Klist.CurrentRow.Cells["TC"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            try
            {
                cmd = new SqlCommand("INSERT INTO KAccount(KID,KPass,KName,KSName,KTC)VALUES(@KID,@KPass,@KName,@KSName,@KTC)", conn.con());
                cmd.Parameters.AddWithValue("@KID", txt_KID.Text);
                cmd.Parameters.AddWithValue("@KPass", txt_KPass.Text);
                cmd.Parameters.AddWithValue("@KName", txt_KName.Text);
                cmd.Parameters.AddWithValue("@KSName", txt_KSName.Text);
                cmd.Parameters.AddWithValue("@KTC", txt_TC.Text);
                cmd.ExecuteNonQuery();
                ds.Tables["KAccount"].Clear();
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

        private void txt_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
