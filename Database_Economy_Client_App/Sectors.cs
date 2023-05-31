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
    public partial class Sectors : Form
    {
        public Sectors()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = sQL_EconomyDataSet.Regions;
                sectorsTableAdapter.Update(sQL_EconomyDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void Sectors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Sectors". При необходимости она может быть перемещена или удалена.
            this.sectorsTableAdapter.Fill(this.sQL_EconomyDataSet.Sectors);

        }

        private void выйтиИзПроектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void удалитьТекущуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                sectorsTableAdapter.Update(sQL_EconomyDataSet);
            }
        }
    }
}
