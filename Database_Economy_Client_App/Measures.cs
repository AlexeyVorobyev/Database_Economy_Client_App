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
    public partial class Measures : Form
    {
        public Measures()
        {
            InitializeComponent();
        }

        private void Measures_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Measures". При необходимости она может быть перемещена или удалена.
            this.measuresTableAdapter.Fill(this.sQL_EconomyDataSet.Measures);

        }

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = sQL_EconomyDataSet.Regions;
                measuresTableAdapter.Update(sQL_EconomyDataSet);
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
                measuresTableAdapter.Update(sQL_EconomyDataSet);
            }
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выйтиИзПроектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
