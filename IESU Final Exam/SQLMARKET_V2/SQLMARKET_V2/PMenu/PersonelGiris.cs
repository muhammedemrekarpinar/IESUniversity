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
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }
        
        SqlCommand cmd;
        SqlDataReader dr;

        private void PersonelGiris_Load(object sender, EventArgs e)
        {
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox2.TextAlign = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionStr conn = new ConnectionStr();
            string query = "SELECT * FROM KAccount WHERE KID=@KID AND KPass=@KPass";
            cmd = new SqlCommand(query, conn.con());
            cmd.Parameters.AddWithValue("@KID", textBox1.Text);
            cmd.Parameters.AddWithValue("@KPass", textBox2.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                MessageBox.Show("Giriş Yapıldı");
                PersonelMenu pm = new PersonelMenu();
                pm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Kullanıcı veya Şifre hatalı!");
            }
        }
    }
}
