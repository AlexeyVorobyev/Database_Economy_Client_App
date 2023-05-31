namespace Database_Economy_Client_App
{
    partial class Operative
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalView2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_EconomyDataSet1 = new Database_Economy_Client_App.SQL_EconomyDataSet();
            this.sQL_EconomyDataSet = new Database_Economy_Client_App.SQL_EconomyDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.regionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.RegionsTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectorsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.SectorsTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.parametrsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parametrsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.ParametrsTableAdapter();
            this.sectors_RegionsTableAdapter1 = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.Sectors_RegionsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.factParametrsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factParametrsValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalView2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.general_View2TableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.General_View2TableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalView2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalView2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // generalView2BindingSource
            // 
            this.generalView2BindingSource.DataMember = "General_View2";
            this.generalView2BindingSource.DataSource = this.sQL_EconomyDataSet1;
            // 
            // sQL_EconomyDataSet1
            // 
            this.sQL_EconomyDataSet1.DataSetName = "SQL_EconomyDataSet";
            this.sQL_EconomyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sQL_EconomyDataSet
            // 
            this.sQL_EconomyDataSet.DataSetName = "SQL_EconomyDataSet";
            this.sQL_EconomyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.regionsBindingSource;
            this.comboBox1.DisplayMember = "Region_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(367, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "RegionsID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // regionsBindingSource
            // 
            this.regionsBindingSource.DataMember = "Regions";
            this.regionsBindingSource.DataSource = this.sQL_EconomyDataSet;
            // 
            // regionsTableAdapter
            // 
            this.regionsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sectorsBindingSource;
            this.comboBox2.DisplayMember = "Sector_Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(349, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "SectorsID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataMember = "Sectors";
            this.sectorsBindingSource.DataSource = this.sQL_EconomyDataSet;
            // 
            // sectorsTableAdapter
            // 
            this.sectorsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.parametrsBindingSource;
            this.comboBox3.DisplayMember = "Parametr_Name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 61);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(708, 24);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "ParametrsID";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // parametrsBindingSource
            // 
            this.parametrsBindingSource.DataMember = "Parametrs";
            this.parametrsBindingSource.DataSource = this.sQL_EconomyDataSet;
            // 
            // parametrsTableAdapter
            // 
            this.parametrsTableAdapter.ClearBeforeFill = true;
            // 
            // sectors_RegionsTableAdapter1
            // 
            this.sectors_RegionsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factParametrsIDDataGridViewTextBoxColumn,
            this.measureNameDataGridViewTextBoxColumn,
            this.factParametrsValueDataGridViewTextBoxColumn,
            this.dateRecordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.generalView2BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 367);
            this.dataGridView1.TabIndex = 5;
            // 
            // factParametrsIDDataGridViewTextBoxColumn
            // 
            this.factParametrsIDDataGridViewTextBoxColumn.DataPropertyName = "Fact_ParametrsID";
            this.factParametrsIDDataGridViewTextBoxColumn.HeaderText = "Fact_ParametrsID";
            this.factParametrsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.factParametrsIDDataGridViewTextBoxColumn.Name = "factParametrsIDDataGridViewTextBoxColumn";
            // 
            // measureNameDataGridViewTextBoxColumn
            // 
            this.measureNameDataGridViewTextBoxColumn.DataPropertyName = "Measure_Name";
            this.measureNameDataGridViewTextBoxColumn.HeaderText = "Measure_Name";
            this.measureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measureNameDataGridViewTextBoxColumn.Name = "measureNameDataGridViewTextBoxColumn";
            // 
            // factParametrsValueDataGridViewTextBoxColumn
            // 
            this.factParametrsValueDataGridViewTextBoxColumn.DataPropertyName = "Fact_Parametrs_Value";
            this.factParametrsValueDataGridViewTextBoxColumn.HeaderText = "Fact_Parametrs_Value";
            this.factParametrsValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.factParametrsValueDataGridViewTextBoxColumn.Name = "factParametrsValueDataGridViewTextBoxColumn";
            // 
            // dateRecordDataGridViewTextBoxColumn
            // 
            this.dateRecordDataGridViewTextBoxColumn.DataPropertyName = "Date_Record";
            this.dateRecordDataGridViewTextBoxColumn.HeaderText = "Date_Record";
            this.dateRecordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateRecordDataGridViewTextBoxColumn.Name = "dateRecordDataGridViewTextBoxColumn";
            // 
            // generalView2BindingSource1
            // 
            this.generalView2BindingSource1.DataMember = "General_View2";
            this.generalView2BindingSource1.DataSource = this.sQL_EconomyDataSet1;
            // 
            // general_View2TableAdapter
            // 
            this.general_View2TableAdapter.ClearBeforeFill = true;
            // 
            // Operative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Operative";
            this.Text = "Оперативные данные";
            this.Load += new System.EventHandler(this.Operative_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalView2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalView2BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private SQL_EconomyDataSet sQL_EconomyDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource regionsBindingSource;
        private SQL_EconomyDataSetTableAdapters.RegionsTableAdapter regionsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private SQL_EconomyDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource parametrsBindingSource;
        private SQL_EconomyDataSetTableAdapters.ParametrsTableAdapter parametrsTableAdapter;
        private SQL_EconomyDataSetTableAdapters.Sectors_RegionsTableAdapter sectors_RegionsTableAdapter1;
        private SQL_EconomyDataSet sQL_EconomyDataSet1;
        private System.Windows.Forms.BindingSource generalView2BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource generalView2BindingSource1;
        private SQL_EconomyDataSetTableAdapters.General_View2TableAdapter general_View2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn factParametrsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factParametrsValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecordDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}