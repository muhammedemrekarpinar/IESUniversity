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
    public partial class StokKontrol : Form
    {
        public StokKontrol()
        {
            InitializeComponent();
        }

        SqlDataAdapter adpt;
        DataSet ds = new DataSet();

        public void filler()
        {
            ConnectionStr conn = new ConnectionStr();
            adpt = new SqlDataAdapter("Select * from Urun where AsgariStok >= UrunMiktari", conn.con());
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

        private void StokKontrol_Load(object sender, EventArgs e)
        {
            filler();
        }

    }
}
