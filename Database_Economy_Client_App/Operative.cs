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

namespace Database_Economy_Client_App
{
    public partial class Operative : Form
    {
        public Operative()
        {
            InitializeComponent();
        }

        public void Refresh()
        {
            this.general_View2TableAdapter.FillByParametrs(this.sQL_EconomyDataSet1.General_View2, comboBox1.Text, comboBox2.Text, comboBox3.Text);
        }
        private void Operative_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Parametrs". При необходимости она может быть перемещена или удалена.
            this.parametrsTableAdapter.Fill(this.sQL_EconomyDataSet.Parametrs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Sectors". При необходимости она может быть перемещена или удалена.
            this.sectorsTableAdapter.Fill(this.sQL_EconomyDataSet.Sectors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Regions". При необходимости она может быть перемещена или удалена.
            this.regionsTableAdapter.Fill(this.sQL_EconomyDataSet.Regions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.General_View". При необходимости она может быть перемещена или удалена.
            this.general_View2TableAdapter.FillByParametrs(this.sQL_EconomyDataSet1.General_View2,comboBox1.Text,comboBox2.Text,comboBox3.Text);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOperative addOperative = new AddOperative(Convert.ToString(comboBox1.SelectedValue), Convert.ToString(comboBox2.SelectedValue), Convert.ToString(comboBox3.SelectedValue),this);
            addOperative.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Удалить текущую строку с ID " + id, "Удаление",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "DELETE FROM Fact_Parametrs WHERE Fact_ParametrsID = " + id;
                SqlCommand command = new SqlCommand(sqlExpression,Program.MainForm.connect);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                this.Refresh();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOperative addOperative = new AddOperative(Convert.ToString(comboBox1.SelectedValue), Convert.ToString(comboBox2.SelectedValue), Convert.ToString(comboBox3.SelectedValue), this, dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());
            addOperative.Show();
        }
    }
}
