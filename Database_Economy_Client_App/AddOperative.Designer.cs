namespace Database_Economy_Client_App
{
    partial class AddOperative
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.regionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_EconomyDataSet = new Database_Economy_Client_App.SQL_EconomyDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.parametrsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fKSectorsRegionsSectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.regionsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.RegionsTableAdapter();
            this.sectorsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.SectorsTableAdapter();
            this.sectors_RegionsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.Sectors_RegionsTableAdapter();
            this.parametrsTableAdapter = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.ParametrsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSectorsRegionsSectorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.regionsBindingSource;
            this.comboBox1.DisplayMember = "Region_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "RegionsID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // regionsBindingSource
            // 
            this.regionsBindingSource.DataMember = "Regions";
            this.regionsBindingSource.DataSource = this.sQL_EconomyDataSet;
            // 
            // sQL_EconomyDataSet
            // 
            this.sQL_EconomyDataSet.DataSetName = "SQL_EconomyDataSet";
            this.sQL_EconomyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.parametrsBindingSource;
            this.comboBox2.DisplayMember = "Parametr_Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 117);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "ParametrsID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // parametrsBindingSource
            // 
            this.parametrsBindingSource.DataMember = "Parametrs";
            this.parametrsBindingSource.DataSource = this.sQL_EconomyDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.sectorsBindingSource;
            this.comboBox3.DisplayMember = "Sector_Name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(91, 87);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "SectorsID";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataMember = "Sectors";
            this.sectorsBindingSource.DataSource = this.sQL_EconomyDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Регион";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сектор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Параметр";
            // 
            // fKSectorsRegionsSectorsBindingSource
            // 
            this.fKSectorsRegionsSectorsBindingSource.DataMember = "FKSectors_Regions_Sectors";
            this.fKSectorsRegionsSectorsBindingSource.DataSource = this.sectorsBindingSource;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Значение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 9;
            // 
            // regionsTableAdapter
            // 
            this.regionsTableAdapter.ClearBeforeFill = true;
            // 
            // sectorsTableAdapter
            // 
            this.sectorsTableAdapter.ClearBeforeFill = true;
            // 
            // sectors_RegionsTableAdapter
            // 
            this.sectors_RegionsTableAdapter.ClearBeforeFill = true;
            // 
            // parametrsTableAdapter
            // 
            this.parametrsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddOperative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 302);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddOperative";
            this.Text = "AddOperative";
            this.Load += new System.EventHandler(this.AddOperative_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_EconomyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSectorsRegionsSectorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private SQL_EconomyDataSet sQL_EconomyDataSet;
        private System.Windows.Forms.BindingSource regionsBindingSource;
        private SQL_EconomyDataSetTableAdapters.RegionsTableAdapter regionsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private SQL_EconomyDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource fKSectorsRegionsSectorsBindingSource;
        private SQL_EconomyDataSetTableAdapters.Sectors_RegionsTableAdapter sectors_RegionsTableAdapter;
        private System.Windows.Forms.BindingSource parametrsBindingSource;
        private SQL_EconomyDataSetTableAdapters.ParametrsTableAdapter parametrsTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}