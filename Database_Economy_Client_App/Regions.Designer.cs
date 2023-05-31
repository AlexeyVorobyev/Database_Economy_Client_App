namespace Database_Economy_Client_App
{
    partial class Regions
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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sQL_EconomyDataSet = new Database_Economy_Client_App.SQL_EconomyDataSet();
            this.regionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.RegionsTableAdapter();
            this.regionsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDescriptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 28);
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 24);
            this.toolStripMenuItem2.Text = "Удалить текущую запись";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regionsIDDataGridViewTextBoxColumn,
            this.regionNameDataGridViewTextBoxColumn,
            this.regionDescriptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.regionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // sQL_EconomyDataSet
            // 
            this.sQL_EconomyDataSet.DataSetName = "SQL_EconomyDataSet";
            this.sQL_EconomyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // regionsIDDataGridViewTextBoxColumn
            // 
            this.regionsIDDataGridViewTextBoxColumn.DataPropertyName = "RegionsID";
            this.regionsIDDataGridViewTextBoxColumn.HeaderText = "RegionsID";
            this.regionsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regionsIDDataGridViewTextBoxColumn.Name = "regionsIDDataGridViewTextBoxColumn";
            this.regionsIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionNameDataGridViewTextBoxColumn
            // 
            this.regionNameDataGridViewTextBoxColumn.DataPropertyName = "Region_Name";
            this.regionNameDataGridViewTextBoxColumn.HeaderText = "Region_Name";
            this.regionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regionNameDataGridViewTextBoxColumn.Name = "regionNameDataGridViewTextBoxColumn";
            this.regionNameDataGridViewTextBoxColumn.Width = 124;
            // 
            // regionDescriptDataGridViewTextBoxColumn
            // 
            this.regionDescriptDataGridViewTextBoxColumn.DataPropertyName = "Region_Descript";
            this.regionDescriptDataGridViewTextBoxColumn.HeaderText = "Region_Descript";
            this.regionDescriptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regionDescriptDataGridViewTextBoxColumn.Name = "regionDescriptDataGridViewTextBoxColumn";
            this.regionDescriptDataGridViewTextBoxColumn.Width = 137;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(94, 24);
            this.toolStripMenuItem3.Text = "Вернуться";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem4.Text = "Выйти из проекта";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // Regions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Regions";
            this.Text = "Таблица Regions";
            this.Load += new System.EventHandler(this.Regions_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQL_EconomyDataSet sQL_EconomyDataSet;
        private System.Windows.Forms.BindingSource regionsBindingSource;
        private SQL_EconomyDataSetTableAdapters.RegionsTableAdapter regionsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDescriptDataGridViewTextBoxColumn;
    }
}