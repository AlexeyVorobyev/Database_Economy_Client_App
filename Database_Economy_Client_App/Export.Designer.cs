namespace Database_Economy_Client_App
{
    partial class Export
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.general_View2TableAdapter1 = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.General_View2TableAdapter();
            this.black_BoxTableAdapter1 = new Database_Economy_Client_App.SQL_EconomyDataSetTableAdapters.Black_BoxTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(216, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Список снятых показателей";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(38, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(354, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Отчет динамики изменения снятых показателей";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(38, 141);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Экспорт в Excel";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(38, 167);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(137, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Экспорт в HTML";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Форма экспорта:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // general_View2TableAdapter1
            // 
            this.general_View2TableAdapter1.ClearBeforeFill = true;
            // 
            // black_BoxTableAdapter1
            // 
            this.black_BoxTableAdapter1.ClearBeforeFill = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(38, 194);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(120, 21);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Crystal Report";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 229);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Export";
            this.Text = "Отчеты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private SQL_EconomyDataSetTableAdapters.General_View2TableAdapter general_View2TableAdapter1;
        private SQL_EconomyDataSetTableAdapters.Black_BoxTableAdapter black_BoxTableAdapter1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}