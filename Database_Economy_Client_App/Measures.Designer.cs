namespace Database_Economy_Client_App
{
    partial class Measures
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
            this.выйтиИзПроектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.measuresIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_EconomyDataSet = new Database_Economy_Client_App.SQL_EconomyDataSet();
            this.measuresTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.MeasuresTableAdapter();
            this.IsDeleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuresBindingSource)).BeginInit();
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
            this.выйтиИзПроектаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // удалитьТекущуюЗаписьToolStripMenuItem
            // 
            this.удалитьТекущуюЗаписьToolStripMenuItem.Name = "удалитьТекущуюЗаписьToolStripMenuItem";
            this.удалитьТекущуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.удалитьТекущуюЗаписьToolStripMenuItem.Text = "Удалить текущую запись";
            this.удалитьТекущуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьТекущуюЗаписьToolStripMenuItem_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // выйтиИзПроектаToolStripMenuItem
            // 
            this.выйтиИзПроектаToolStripMenuItem.Name = "выйтиИзПроектаToolStripMenuItem";
            this.выйтиИзПроектаToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.выйтиИзПроектаToolStripMenuItem.Text = "Выйти из проекта";
            this.выйтиИзПроектаToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзПроектаToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.measuresIDDataGridViewTextBoxColumn,
            this.measureNameDataGridViewTextBoxColumn,
            this.IsDeleted});
            this.dataGridView1.DataSource = this.measuresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 419);
            this.dataGridView1.TabIndex = 1;
            // 
            // measuresIDDataGridViewTextBoxColumn
            // 
            this.measuresIDDataGridViewTextBoxColumn.DataPropertyName = "MeasuresID";
            this.measuresIDDataGridViewTextBoxColumn.HeaderText = "MeasuresID";
            this.measuresIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measuresIDDataGridViewTextBoxColumn.Name = "measuresIDDataGridViewTextBoxColumn";
            this.measuresIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.measuresIDDataGridViewTextBoxColumn.Width = 112;
            // 
            // measureNameDataGridViewTextBoxColumn
            // 
            this.measureNameDataGridViewTextBoxColumn.DataPropertyName = "Measure_Name";
            this.measureNameDataGridViewTextBoxColumn.HeaderText = "Measure_Name";
            this.measureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measureNameDataGridViewTextBoxColumn.Name = "measureNameDataGridViewTextBoxColumn";
            this.measureNameDataGridViewTextBoxColumn.Width = 137;
            // 
            // measuresBindingSource
            // 
            this.measuresBindingSource.DataMember = "Measures";
            this.measuresBindingSource.DataSource = this.sQL_EconomyDataSet;
            // 
            // sQL_EconomyDataSet
            // 
            this.sQL_EconomyDataSet.DataSetName = "SQL_EconomyDataSet";
            this.sQL_EconomyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // measuresTableAdapter
            // 
            this.measuresTableAdapter.ClearBeforeFill = true;
            // 
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "IsDeleted";
            this.IsDeleted.MinimumWidth = 6;
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.ReadOnly = true;
            this.IsDeleted.Width = 73;
            // 
            // Measures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Measures";
            this.Text = "Таблица Measures";
            this.Load += new System.EventHandler(this.Measures_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПроектаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQL_EconomyDataSet sQL_EconomyDataSet;
        private System.Windows.Forms.BindingSource measuresBindingSource;
        private SQL_EconomyDataSetTableAdapters.MeasuresTableAdapter measuresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn measuresIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDeleted;
    }
}