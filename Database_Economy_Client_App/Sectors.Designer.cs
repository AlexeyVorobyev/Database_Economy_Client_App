namespace Database_Economy_Client_App
{
    partial class Sectors
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзПроектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sQL_EconomyDataSet = new Database_Economy_Client_App.SQL_EconomyDataSet();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectorsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.SectorsTableAdapter();
            this.sectorsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorDescriptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.удалитьТекущуюЗаписьToolStripMenuItem,
            this.вернутьсяToolStripMenuItem,
            this.выйтиИзПроектаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 24);
            this.toolStripMenuItem1.Text = "Сохранить изменения";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            this.sectorsIDDataGridViewTextBoxColumn,
            this.sectorNameDataGridViewTextBoxColumn,
            this.sectorDescriptDataGridViewTextBoxColumn,
            this.sectorNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sectorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 418);
            this.dataGridView1.TabIndex = 1;
            // 
            // sQL_EconomyDataSet
            // 
            this.sQL_EconomyDataSet.DataSetName = "SQL_EconomyDataSet";
            this.sQL_EconomyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sectorsIDDataGridViewTextBoxColumn
            // 
            this.sectorsIDDataGridViewTextBoxColumn.DataPropertyName = "SectorsID";
            this.sectorsIDDataGridViewTextBoxColumn.HeaderText = "SectorsID";
            this.sectorsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectorsIDDataGridViewTextBoxColumn.Name = "sectorsIDDataGridViewTextBoxColumn";
            this.sectorsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectorsIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // sectorNameDataGridViewTextBoxColumn
            // 
            this.sectorNameDataGridViewTextBoxColumn.DataPropertyName = "Sector_Name";
            this.sectorNameDataGridViewTextBoxColumn.HeaderText = "Sector_Name";
            this.sectorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectorNameDataGridViewTextBoxColumn.Name = "sectorNameDataGridViewTextBoxColumn";
            this.sectorNameDataGridViewTextBoxColumn.Width = 119;
            // 
            // sectorDescriptDataGridViewTextBoxColumn
            // 
            this.sectorDescriptDataGridViewTextBoxColumn.DataPropertyName = "Sector_Descript";
            this.sectorDescriptDataGridViewTextBoxColumn.HeaderText = "Sector_Descript";
            this.sectorDescriptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectorDescriptDataGridViewTextBoxColumn.Name = "sectorDescriptDataGridViewTextBoxColumn";
            this.sectorDescriptDataGridViewTextBoxColumn.Width = 132;
            // 
            // sectorNumberDataGridViewTextBoxColumn
            // 
            this.sectorNumberDataGridViewTextBoxColumn.DataPropertyName = "Sector_Number";
            this.sectorNumberDataGridViewTextBoxColumn.HeaderText = "Sector_Number";
            this.sectorNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectorNumberDataGridViewTextBoxColumn.Name = "sectorNumberDataGridViewTextBoxColumn";
            this.sectorNumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // Sectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sectors";
            this.Text = "Таблица Sectors";
            this.Load += new System.EventHandler(this.Sectors_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПроектаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQL_EconomyDataSet sQL_EconomyDataSet;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private SQL_EconomyDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorDescriptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorNumberDataGridViewTextBoxColumn;
    }
}