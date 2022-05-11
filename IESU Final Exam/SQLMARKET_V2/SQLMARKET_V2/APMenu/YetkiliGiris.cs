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
    public partial class YetkiliGiris : Form
    {
        
        SqlDataAdapter adpt;
        SqlCommand cmd;
        SqlDataReader dr;
        public YetkiliGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            string query = "SELECT * FROM ACC WHERE ID=@ID AND Pass=@Pass";
            cmd = new SqlCommand(query, conn.con());
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Pass", textBox2.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                MessageBox.Show("Giriş Yapıldı");
                YetkiliMenu adm = new YetkiliMenu();
                adm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Kullanıcı veya Şifre hatalı!");
            }
        }


        private void YetkiliGiris_Load(object sender, EventArgs e)
        {
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox2.TextAlign = HorizontalAlignment.Center;
        }
    }
}
