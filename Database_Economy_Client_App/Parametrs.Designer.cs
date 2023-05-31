namespace Database_Economy_Client_App
{
    partial class Parametrs
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
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parametrsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measuresIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametrNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametrsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_EconomyDataSet = new Database_Economy_Client_App.SQL_EconomyDataSet();
            this.parametrsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.ParametrsTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИзмененияToolStripMenuItem,
            this.удалитьТекущуюЗаписьToolStripMenuItem,
            this.вернутьсяToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // удалитьТекущуюЗаписьToolStripMenuItem
            // 
            this.удалитьТекущуюЗаписьToolStripMenuItem.Name = "удалитьТекущуюЗаписьToolStripMenuItem";
            this.удалитьТекущуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.удалитьТекущуюЗаписьToolStripMenuItem.Text = "Удалить текущую запись";
            this.удалитьТекущуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьТекущуюЗаписьToolStripMenuItem_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти из проекта";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parametrsIDDataGridViewTextBoxColumn,
            this.measuresIDDataGridViewTextBoxColumn,
            this.parametrNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parametrsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 421);
            this.dataGridView1.TabIndex = 1;
            // 
            // parametrsIDDataGridViewTextBoxColumn
            // 
            this.parametrsIDDataGridViewTextBoxColumn.DataPropertyName = "ParametrsID";
            this.parametrsIDDataGridViewTextBoxColumn.HeaderText = "ParametrsID";
            this.parametrsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parametrsIDDataGridViewTextBoxColumn.Name = "parametrsIDDataGridViewTextBoxColumn";
            this.parametrsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.parametrsIDDataGridViewTextBoxColumn.Width = 111;
            // 
            // measuresIDDataGridViewTextBoxColumn
            // 
            this.measuresIDDataGridViewTextBoxColumn.DataPropertyName = "MeasuresID";
            this.measuresIDDataGridViewTextBoxColumn.HeaderText = "MeasuresID";
            this.measuresIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measuresIDDataGridViewTextBoxColumn.Name = "measuresIDDataGridViewTextBoxColumn";
            this.measuresIDDataGridViewTextBoxColumn.Width = 109;
            // 
            // parametrNameDataGridViewTextBoxColumn
            // 
            this.parametrNameDataGridViewTextBoxColumn.DataPropertyName = "Parametr_Name";
            this.parametrNameDataGridViewTextBoxColumn.HeaderText = "Parametr_Name";
            this.parametrNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parametrNameDataGridViewTextBoxColumn.Name = "parametrNameDataGridViewTextBoxColumn";
            this.parametrNameDataGridViewTextBoxColumn.Width = 135;
            // 
            // parametrsBindingSource
            // 
            this.parametrsBindingSource.DataMember = "Parametrs";
            this.parametrsBindingSource.DataSource = this.sQL_EconomyDataSet;
            // 
            // sQL_EconomyDataSet
            // 
            this.sQL_EconomyDataSet.DataSetName = "SQL_EconomyDataSet";
            this.sQL_EconomyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametrsTableAdapter
            // 
            this.parametrsTableAdapter.ClearBeforeFill = true;
            // 
            // Parametrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parametrs";
            this.Text = "Таблица Parametrs";
            this.Load += new System.EventHandler(this.Parametrs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQL_EconomyDataSet sQL_EconomyDataSet;
        private System.Windows.Forms.BindingSource parametrsBindingSource;
        private SQL_EconomyDataSetTableAdapters.ParametrsTableAdapter parametrsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametrsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measuresIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametrNameDataGridViewTextBoxColumn;
    }
}