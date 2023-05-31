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
    public partial class Parametrs : Form
    {
        public Parametrs()
        {
            InitializeComponent();
        }

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = sQL_EconomyDataSet.Regions;
                parametrsTableAdapter.Update(sQL_EconomyDataSet);
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
                parametrsTableAdapter.Update(sQL_EconomyDataSet);
            }
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Parametrs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Parametrs". При необходимости она может быть перемещена или удалена.
            this.parametrsTableAdapter.Fill(this.sQL_EconomyDataSet.Parametrs);

        }
    }
}
