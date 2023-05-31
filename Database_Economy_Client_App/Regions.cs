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
    public partial class Regions : Form
    {
        public Regions()
        {
            InitializeComponent();
        }

        private void Regions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Regions". При необходимости она может быть перемещена или удалена.
            this.regionsTableAdapter.Fill(this.sQL_EconomyDataSet.Regions);

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0 )
            {
                CurMan.RemoveAt(CurMan.Position);
                regionsTableAdapter.Update(sQL_EconomyDataSet);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = sQL_EconomyDataSet.Regions;
                regionsTableAdapter.Update(sQL_EconomyDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
