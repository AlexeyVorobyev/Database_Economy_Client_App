namespace Database_Economy_Client_App
{
    partial class Sectors_Regions
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
            this.созранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вуернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзПроектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sectorsRegionsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorsRegionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_EconomyDataSet = new Database_Economy_Client_App.SQL_EconomyDataSet();
            this.sectors_RegionsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.Sectors_RegionsTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsRegionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созранитьИзмененияToolStripMenuItem,
            this.удалитьТекущуюЗаписьToolStripMenuItem,
            this.вуернутьсяToolStripMenuItem,
            this.выйтиИзПроектаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // созранитьИзмененияToolStripMenuItem
            // 
            this.созранитьИзмененияToolStripMenuItem.Name = "созранитьИзмененияToolStripMenuItem";
            this.созранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.созранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.созранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.созранитьИзмененияToolStripMenuItem_Click);
            // 
            // удалитьТекущуюЗаписьToolStripMenuItem
            // 
            this.удалитьТекущуюЗаписьToolStripMenuItem.Name = "удалитьТекущуюЗаписьToolStripMenuItem";
            this.удалитьТекущуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.удалитьТекущуюЗаписьToolStripMenuItem.Text = "Удалить текущую запись";
            this.удалитьТекущуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьТекущуюЗаписьToolStripMenuItem_Click);
            // 
            // вуернутьсяToolStripMenuItem
            // 
            this.вуернутьсяToolStripMenuItem.Name = "вуернутьсяToolStripMenuItem";
            this.вуернутьсяToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.вуернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вуернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вуернутьсяToolStripMenuItem_Click);
            // 
            // выйтиИзПроектаToolStripMenuItem
            // 
            this.выйтиИзПроектаToolStripMenuItem.Name = "выйтиИзПроектаToolStripMenuItem";
            this.выйтиИзПроектаToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.выйтиИзПроектаToolStripMenuItem.Text = "Выйти из проекта";
            this.выйтиИзПроектаToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзПроектаToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectorsRegionsIDDataGridViewTextBoxColumn,
            this.sectorsIDDataGridViewTextBoxColumn,
            this.regionsIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sectorsRegionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 421);
            this.dataGridView1.TabIndex = 1;
            // 
            // sectorsRegionsIDDataGridViewTextBoxColumn
            // 
            this.sectorsRegionsIDDataGridViewTextBoxColumn.DataPropertyName = "Sectors_RegionsID";
            this.sectorsRegionsIDDataGridViewTextBoxColumn.HeaderText = "Sectors_RegionsID";
            this.sectorsRegionsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectorsRegionsIDDataGridViewTextBoxColumn.Name = "sectorsRegionsIDDataGridViewTextBoxColumn";
            this.sectorsRegionsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectorsRegionsIDDataGridViewTextBoxColumn.Width = 153;
            // 
            // sectorsIDDataGridViewTextBoxColumn
            // 
            this.sectorsIDDataGridViewTextBoxColumn.DataPropertyName = "SectorsID";
            this.sectorsIDDataGridViewTextBoxColumn.HeaderText = "SectorsID";
            this.sectorsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectorsIDDataGridViewTextBoxColumn.Name = "sectorsIDDataGridViewTextBoxColumn";
            this.sectorsIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // regionsIDDataGridViewTextBoxColumn
            // 
            this.regionsIDDataGridViewTextBoxColumn.DataPropertyName = "RegionsID";
            this.regionsIDDataGridViewTextBoxColumn.HeaderText = "RegionsID";
            this.regionsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regionsIDDataGridViewTextBoxColumn.Name = "regionsIDDataGridViewTextBoxColumn";
            // 
            // sectorsRegionsBindingSource
            // 
            this.sectorsRegionsBindingSource.DataMember = "Sectors_Regions";
            this.sectorsRegionsBindingSource.DataSource = this.sQL_EconomyDataSet;
            // 
            // sQL_EconomyDataSet
            // 
            this.sQL_EconomyDataSet.DataSetName = "SQL_EconomyDataSet";
            this.sQL_EconomyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectors_RegionsTableAdapter
            // 
            this.sectors_RegionsTableAdapter.ClearBeforeFill = true;
            // 
            // Sectors_Regions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sectors_Regions";
            this.Text = "таблица Sectors_Regions";
            this.Load += new System.EventHandler(this.Sectors_Regions_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsRegionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem созранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вуернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПроектаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQL_EconomyDataSet sQL_EconomyDataSet;
        private System.Windows.Forms.BindingSource sectorsRegionsBindingSource;
        private SQL_EconomyDataSetTableAdapters.Sectors_RegionsTableAdapter sectors_RegionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorsRegionsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionsIDDataGridViewTextBoxColumn;
    }
}