using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Database_Economy_Client_App
{
    public partial class Export : Form
    {
        bool export1 = false, export2 = false, excel = false, html = false, crystal = false;
        SQL_EconomyDataSet.General_View2DataTable view = new SQL_EconomyDataSet.General_View2DataTable();
        SQL_EconomyDataSet.Black_BoxDataTable blackBox = new SQL_EconomyDataSet.Black_BoxDataTable();

        public Export()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (export2) checkBox1.Checked = false;
            else export1 = !export1;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (export1) checkBox2.Checked = false;
            else export2 = !export2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (html || crystal) checkBox3.Checked = false;
            else excel = !excel;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (html || excel) checkBox5.Checked = false;
            else crystal = !crystal;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (excel || crystal) checkBox4.Checked = false;
            else html= !html;
        }

        void ExportToExcel(DataTable table)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream Stream1 = new FileStream(saveFileDialog1.FileName,FileMode.Create);
                try
                {
                    StreamWriter StreamWriterStream1 = new StreamWriter(Stream1,
                   System.Text.Encoding.Unicode);
                    foreach (System.Data.DataColumn Column in table.Columns)
                        StreamWriterStream1.Write(Column.Caption + "\t");
                    StreamWriterStream1.WriteLine();
                    foreach (System.Data.DataRow Row in table.Rows)
                    {
                        foreach (object Entity in Row.ItemArray)
                        {
                            StreamWriterStream1.Write(Entity.ToString() + "\t");
                        }
                        StreamWriterStream1.WriteLine();
                    }
                    StreamWriterStream1.Flush();
                }
                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Stream1.Close();
                Process.Start(Stream1.Name);
            }
        }

        void ExportToHTML(DataTable table, string ThisTitle)
        {
            int i, j;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream Stream1 = new FileStream(saveFileDialog1.FileName,FileMode.Create);
                try
                {
                    StreamWriter StreamWriter1 = new StreamWriter(Stream1);
                    StreamWriter1.WriteLine("<html>");
                    StreamWriter1.WriteLine("<head>");
                    StreamWriter1.WriteLine("<meta content=\"text/html; charset=utf-8\" http - equiv =\"Content-Type\">");
                    StreamWriter1.WriteLine("<title>" + ThisTitle + "</title>");
                    StreamWriter1.WriteLine("</head>");
                    StreamWriter1.WriteLine("<body bgcolor=\"800000\">");
                    StreamWriter1.WriteLine("<table align=\"center\" cols =0 cellspacing = 0 > ");
                   
                    StreamWriter1.WriteLine("<tr>");
                    StreamWriter1.WriteLine("</td>");
                    StreamWriter1.WriteLine("</tr>");
                    StreamWriter1.WriteLine("<tr>");
                    for (j = 0; j < table.Columns.Count; j++)
                    {
                        
                        StreamWriter1.WriteLine("<td><font face=\"Verdana\"size=\"2\" color =\"#ffffff\"><p align=\"center\"><b>");
                        StreamWriter1.WriteLine("" + table.Columns[j].ColumnName);
                        StreamWriter1.WriteLine("</b></font></td>");
                    }
                    StreamWriter1.WriteLine("</tr>");
                    for (i = 0; i < table.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            StreamWriter1.WriteLine("<tr bgcolor=\"3399\">");
                            for (j = 0; j < table.Columns.Count; j++)
                            {
                                StreamWriter1.WriteLine("<td><font face =\"Verdana\"size=\"2\" color=\"#000000\"><p align=\"center\">");
                                StreamWriter1.WriteLine("" + table.Rows[i][j]);
                                StreamWriter1.WriteLine("</font></td>");
                            }
                            StreamWriter1.WriteLine("</tr>");
                        }
                        else
                        {
                            StreamWriter1.WriteLine("<tr>");
                            for (j = 0; j < table.Columns.Count; j++)
                            {
                                StreamWriter1.WriteLine("<td><font face =\"Verdana\"size=\"2\" color=\"#ffffff\"><p align=\"center\">");
                                StreamWriter1.WriteLine("" + table.Rows[i][j]);
                                StreamWriter1.WriteLine("</font></td>");
                            }
                            StreamWriter1.WriteLine("</tr>");
                        }
                    }
                    StreamWriter1.WriteLine("</table></center></body></html>");
                    MessageBox.Show("Экспорт успешно завершен!", "Экспорт...",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamWriter1.Flush();
                }
                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Stream1.Close();
                Process.Start(Stream1.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (excel)
            {
                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.Filter = "Excel files(*.xls)|*.xls";
                saveFileDialog1.Title = "Экспорт: Excel";

                if (export1)
                {
                    general_View2TableAdapter1.Fill(view);
                    ExportToExcel(view);
                }
                else if (export2)
                {
                    black_BoxTableAdapter1.Fill(blackBox);
                    ExportToExcel(blackBox);
                }
                else MessageBox.Show("Не выбран отчета для экспорта", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (html)
            {
                saveFileDialog1.DefaultExt = "html";
                saveFileDialog1.Filter = "EHTML files(*.html)|*.html";
                saveFileDialog1.Title = "Экспорт: HTML";

                if (export1)
                {
                    general_View2TableAdapter1.Fill(view);
                    ExportToHTML(view,checkBox1.Text);
                }
                else if (export2)
                {
                    black_BoxTableAdapter1.Fill(blackBox);
                    ExportToHTML(blackBox,checkBox2.Text);
                }
                else MessageBox.Show("Не выбран отчета для экспорта", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (crystal)
            {
                if (export1)
                {
                    GeneralViewCrystal generalViewCrystal = new GeneralViewCrystal();
                    generalViewCrystal.Show();
                }
                else if (export2)
                {
                    BlackBoxCrystal blackBoxCrystal = new BlackBoxCrystal();
                    blackBoxCrystal.Show();
                }
                else MessageBox.Show("Не выбран отчета для экспорта", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Не выбран вариант экспорта", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
