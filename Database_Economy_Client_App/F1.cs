using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Economy_Client_App
{
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();
        }

        public System.Data.SqlClient.SqlConnection connect;
        private void App_Load(object sender, EventArgs e)
        {
            String connectionString = "Data Source = LAPTOP-0HSOMLDM; Initial Catalog = SQL_Economy; Integrated Security = True";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Regions regions = new Regions();
            regions.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Sectors sectors = new Sectors();
            sectors.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Measures measures = new Measures();
            measures.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Parametrs parametrs = new Parametrs();
            parametrs.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Sectors_Regions sectors_Regions = new Sectors_Regions();
            sectors_Regions.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Operative operative = new Operative();
            operative.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.Show();
        }
    }
}
