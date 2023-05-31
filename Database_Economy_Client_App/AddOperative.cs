using Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Economy_Client_App
{
    public partial class AddOperative : Form
    {
        string regionID, sectorID, parametrID, sector_regionID, fact_parametrsID;
        string text1, text2;
        Operative operative;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            regionID = Convert.ToString(comboBox1.SelectedValue);
            sector_regionID = getSectorRegionID();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sectorID = Convert.ToString(comboBox3.SelectedValue);
            sector_regionID = getSectorRegionID();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            parametrID= Convert.ToString(comboBox2.SelectedValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlParameter param;
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите значение снимаемого показателя", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Введите дату снятия показателя", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (fact_parametrsID != null)
            {
                string sqlExpression = "UPDATE Fact_Parametrs SET Sectors_RegionsID = " + sector_regionID + ", ParametrsID = " + parametrID + ", Fact_Parametrs_Value = " + textBox1.Text + ", Date_Record = " + "@DR" + " WHERE Fact_ParametrsID = " + fact_parametrsID;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                try
                {
                    param = new SqlParameter("@DR", Convert.ToDateTime(textBox2.Text));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Формат даты: дд.мм.гггг", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                command.Parameters.Add(param);
            }
            else
            {
                string sqlExpression = "INSERT INTO Fact_Parametrs (Sectors_RegionsID,ParametrsID,Fact_Parametrs_Value,Date_Record) " + "VALUES (@SRID,@PID,@FPV,@DR)";
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                param = new SqlParameter("@SRID", Convert.ToInt32(sector_regionID));
                command.Parameters.Add(param);
                param = new SqlParameter("@PID", Convert.ToInt32(parametrID));
                command.Parameters.Add(param);
                param = new SqlParameter("@FPV", Convert.ToInt32(textBox1.Text));
                command.Parameters.Add(param);

                try
                {
                    param = new SqlParameter("@DR", Convert.ToDateTime(textBox2.Text));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Формат даты: дд.мм.гггг", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                param = new SqlParameter("@DR", Convert.ToDateTime(textBox2.Text));
                command.Parameters.Add(param);
            }
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            operative.Refresh();
            this.Close();
        }

        private void AddOperative_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Parametrs". При необходимости она может быть перемещена или удалена.
            this.parametrsTableAdapter.Fill(this.sQL_EconomyDataSet.Parametrs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Sectors_Regions". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Sectors". При необходимости она может быть перемещена или удалена.
            this.sectorsTableAdapter.Fill(this.sQL_EconomyDataSet.Sectors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_EconomyDataSet.Regions". При необходимости она может быть перемещена или удалена.
            this.regionsTableAdapter.Fill(this.sQL_EconomyDataSet.Regions);
            comboBox1.SelectedValue = regionID;
            comboBox2.SelectedValue = parametrID;
            comboBox3.SelectedValue = sectorID;
            sector_regionID = getSectorRegionID();
            if (fact_parametrsID != null)
            {
                textBox1.Text = text1;
                textBox2.Text = text2;
            }
        }

        private string getSectorRegionID()
        {
            try
            {
                this.sectors_RegionsTableAdapter.getSectors_RegionsID(this.sQL_EconomyDataSet.Sectors_Regions, Convert.ToInt32(regionID), Convert.ToInt32(sectorID));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            DataTable sectorRegionsDT = sQL_EconomyDataSet.Tables[5];

            string res = "";

            foreach (DataRow row in sectorRegionsDT.Rows)
            {
                res = Convert.ToString(row["Sectors_RegionsID"].ToString());
                break;
            }
            return res;
        }

        public AddOperative(string regionID,string sectorID, string parametrID,Operative operative, string text1 = null, string text2 = null, string fact_parametrsID = null)
        {
            this.regionID = regionID;
            this.sectorID = sectorID;
            this.parametrID = parametrID;
            this.operative = operative;
            this.fact_parametrsID = fact_parametrsID;
            this.text1 = text1;
            this.text2 = text2;
            InitializeComponent();
        }
    }
}
