using Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters;
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
    public partial class Sectors_Regions : Form
    {
        public Sectors_Regions()
        {
            InitializeComponent();
        }

        private void созранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = sQL_EconomyDataSet.Regions;
                sectors_RegionsTableAdapter.Update(sQL_EconomyDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void удалитьТекущуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                sectors_RegionsTableAdapter.Update(sQL_EconomyDataSet);
            }
        }

        private void вуернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выйтиИзПроектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sectors_Regions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Sectors_Regions". При необходимости она может быть перемещена или удалена.
            this.sectors_RegionsTableAdapter.Fill(this.sQL_EconomyDataSet.Sectors_Regions);

        }
    }
}
