namespace Scaner_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input_TB = new System.Windows.Forms.TextBox();
            this.Output_TB = new System.Windows.Forms.TextBox();
            this.Start_B = new System.Windows.Forms.Button();
            this.BrowseInput_B = new System.Windows.Forms.Button();
            this.BrowseOutput_B = new System.Windows.Forms.Button();
            this.Separator_RB3 = new System.Windows.Forms.RadioButton();
            this.Separator_RB4 = new System.Windows.Forms.RadioButton();
            this.Separator_RB5 = new System.Windows.Forms.RadioButton();
            this.Separator_RB6 = new System.Windows.Forms.RadioButton();
            this.Separator_RB1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Separator_RB2 = new System.Windows.Forms.RadioButton();
            this.Stop_B = new System.Windows.Forms.Button();
            this.Desine_L1 = new System.Windows.Forms.Label();
            this.Desine_L2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Size_L = new System.Windows.Forms.Label();
            this.Folders_L = new System.Windows.Forms.Label();
            this.Files_L = new System.Windows.Forms.Label();
            this.Desine_L6 = new System.Windows.Forms.Label();
            this.Desine_L3 = new System.Windows.Forms.Label();
            this.Desine_L4 = new System.Windows.Forms.Label();
            this.Desine_L7 = new System.Windows.Forms.Label();
            this.Time_L = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_TB
            // 
            this.Input_TB.Location = new System.Drawing.Point(84, 6);
            this.Input_TB.Name = "Input_TB";
            this.Input_TB.Size = new System.Drawing.Size(168, 20);
            this.Input_TB.TabIndex = 0;
            this.Input_TB.Text = "C:\\";
            this.Input_TB.TextChanged += new System.EventHandler(this.Input_TB_TextChanged);
            // 
            // Output_TB
            // 
            this.Output_TB.Location = new System.Drawing.Point(84, 32);
            this.Output_TB.Name = "Output_TB";
            this.Output_TB.Size = new System.Drawing.Size(168, 20);
            this.Output_TB.TabIndex = 1;
            this.Output_TB.Text = "D:\\";
            this.Output_TB.TextChanged += new System.EventHandler(this.Output_TB_TextChanged);
            // 
            // Start_B
            // 
            this.Start_B.Location = new System.Drawing.Point(206, 58);
            this.Start_B.Name = "Start_B";
            this.Start_B.Size = new System.Drawing.Size(127, 23);
            this.Start_B.TabIndex = 2;
            this.Start_B.Text = "Start";
            this.Start_B.UseVisualStyleBackColor = true;
            this.Start_B.Click += new System.EventHandler(this.Start_B_Click);
            // 
            // BrowseInput_B
            // 
            this.BrowseInput_B.Location = new System.Drawing.Point(258, 4);
            this.BrowseInput_B.Name = "BrowseInput_B";
            this.BrowseInput_B.Size = new System.Drawing.Size(75, 23);
            this.BrowseInput_B.TabIndex = 4;
            this.BrowseInput_B.Text = "Open";
            this.BrowseInput_B.UseVisualStyleBackColor = true;
            this.BrowseInput_B.Click += new System.EventHandler(this.BrowseInput_B_Click);
            // 
            // BrowseOutput_B
            // 
            this.BrowseOutput_B.Location = new System.Drawing.Point(258, 30);
            this.BrowseOutput_B.Name = "BrowseOutput_B";
            this.BrowseOutput_B.Size = new System.Drawing.Size(75, 23);
            this.BrowseOutput_B.TabIndex = 5;
            this.BrowseOutput_B.Text = "Open";
            this.BrowseOutput_B.UseVisualStyleBackColor = true;
            this.BrowseOutput_B.Click += new System.EventHandler(this.BrowseOutput_B_Click);
            // 
            // Separator_RB3
            // 
            this.Separator_RB3.AutoSize = true;
            this.Separator_RB3.Location = new System.Drawing.Point(9, 31);
            this.Separator_RB3.Name = "Separator_RB3";
            this.Separator_RB3.Size = new System.Drawing.Size(29, 17);
            this.Separator_RB3.TabIndex = 7;
            this.Separator_RB3.Text = "*";
            this.Separator_RB3.UseVisualStyleBackColor = true;
            // 
            // Separator_RB4
            // 
            this.Separator_RB4.AutoSize = true;
            this.Separator_RB4.Location = new System.Drawing.Point(39, 31);
            this.Separator_RB4.Name = "Separator_RB4";
            this.Separator_RB4.Size = new System.Drawing.Size(30, 17);
            this.Separator_RB4.TabIndex = 9;
            this.Separator_RB4.Text = "\"";
            this.Separator_RB4.UseVisualStyleBackColor = true;
            // 
            // Separator_RB5
            // 
            this.Separator_RB5.AutoSize = true;
            this.Separator_RB5.Location = new System.Drawing.Point(9, 49);
            this.Separator_RB5.Name = "Separator_RB5";
            this.Separator_RB5.Size = new System.Drawing.Size(31, 17);
            this.Separator_RB5.TabIndex = 10;
            this.Separator_RB5.Text = "<";
            this.Separator_RB5.UseVisualStyleBackColor = true;
            // 
            // Separator_RB6
            // 
            this.Separator_RB6.AutoSize = true;
            this.Separator_RB6.Location = new System.Drawing.Point(39, 49);
            this.Separator_RB6.Name = "Separator_RB6";
            this.Separator_RB6.Size = new System.Drawing.Size(31, 17);
            this.Separator_RB6.TabIndex = 11;
            this.Separator_RB6.Text = ">";
            this.Separator_RB6.UseVisualStyleBackColor = true;
            // 
            // Separator_RB1
            // 
            this.Separator_RB1.AutoSize = true;
            this.Separator_RB1.Checked = true;
            this.Separator_RB1.Location = new System.Drawing.Point(9, 13);
            this.Separator_RB1.Name = "Separator_RB1";
            this.Separator_RB1.Size = new System.Drawing.Size(32, 17);
            this.Separator_RB1.TabIndex = 12;
            this.Separator_RB1.TabStop = true;
            this.Separator_RB1.Text = "T";
            this.Separator_RB1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Separator_RB2);
            this.groupBox1.Controls.Add(this.Separator_RB6);
            this.groupBox1.Controls.Add(this.Separator_RB1);
            this.groupBox1.Controls.Add(this.Separator_RB3);
            this.groupBox1.Controls.Add(this.Separator_RB4);
            this.groupBox1.Controls.Add(this.Separator_RB5);
            this.groupBox1.Location = new System.Drawing.Point(15, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 68);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Separator";
            // 
            // Separator_RB2
            // 
            this.Separator_RB2.AutoSize = true;
            this.Separator_RB2.Location = new System.Drawing.Point(39, 13);
            this.Separator_RB2.Name = "Separator_RB2";
            this.Separator_RB2.Size = new System.Drawing.Size(30, 17);
            this.Separator_RB2.TabIndex = 13;
            this.Separator_RB2.Text = "/";
            this.Separator_RB2.UseVisualStyleBackColor = true;
            // 
            // Stop_B
            // 
            this.Stop_B.Enabled = false;
            this.Stop_B.Location = new System.Drawing.Point(206, 103);
            this.Stop_B.Name = "Stop_B";
            this.Stop_B.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Stop_B.Size = new System.Drawing.Size(127, 23);
            this.Stop_B.TabIndex = 14;
            this.Stop_B.Text = "Stop";
            this.Stop_B.UseVisualStyleBackColor = true;
            this.Stop_B.Click += new System.EventHandler(this.Stop_B_Click);
            // 
            // Desine_L1
            // 
            this.Desine_L1.AutoSize = true;
            this.Desine_L1.Location = new System.Drawing.Point(6, 16);
            this.Desine_L1.Name = "Desine_L1";
            this.Desine_L1.Size = new System.Drawing.Size(31, 13);
            this.Desine_L1.TabIndex = 15;
            this.Desine_L1.Text = "Files:";
            // 
            // Desine_L2
            // 
            this.Desine_L2.AutoSize = true;
            this.Desine_L2.Location = new System.Drawing.Point(6, 32);
            this.Desine_L2.Name = "Desine_L2";
            this.Desine_L2.Size = new System.Drawing.Size(44, 13);
            this.Desine_L2.TabIndex = 16;
            this.Desine_L2.Text = "Folders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Size_L);
            this.groupBox2.Controls.Add(this.Folders_L);
            this.groupBox2.Controls.Add(this.Files_L);
            this.groupBox2.Controls.Add(this.Desine_L6);
            this.groupBox2.Controls.Add(this.Desine_L2);
            this.groupBox2.Controls.Add(this.Desine_L1);
            this.groupBox2.Location = new System.Drawing.Point(92, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scanned items";
            // 
            // Size_L
            // 
            this.Size_L.AutoSize = true;
            this.Size_L.Location = new System.Drawing.Point(55, 48);
            this.Size_L.Name = "Size_L";
            this.Size_L.Size = new System.Drawing.Size(13, 13);
            this.Size_L.TabIndex = 20;
            this.Size_L.Text = "0";
            // 
            // Folders_L
            // 
            this.Folders_L.AutoSize = true;
            this.Folders_L.Location = new System.Drawing.Point(55, 32);
            this.Folders_L.Name = "Folders_L";
            this.Folders_L.Size = new System.Drawing.Size(13, 13);
            this.Folders_L.TabIndex = 18;
            this.Folders_L.Text = "0";
            // 
            // Files_L
            // 
            this.Files_L.AutoSize = true;
            this.Files_L.Location = new System.Drawing.Point(55, 16);
            this.Files_L.Name = "Files_L";
            this.Files_L.Size = new System.Drawing.Size(13, 13);
            this.Files_L.TabIndex = 17;
            this.Files_L.Text = "0";
            // 
            // Desine_L6
            // 
            this.Desine_L6.AutoSize = true;
            this.Desine_L6.Location = new System.Drawing.Point(6, 48);
            this.Desine_L6.Name = "Desine_L6";
            this.Desine_L6.Size = new System.Drawing.Size(54, 13);
            this.Desine_L6.TabIndex = 19;
            this.Desine_L6.Text = "Size (Mb):";
            // 
            // Desine_L3
            // 
            this.Desine_L3.AutoSize = true;
            this.Desine_L3.Location = new System.Drawing.Point(12, 9);
            this.Desine_L3.Name = "Desine_L3";
            this.Desine_L3.Size = new System.Drawing.Size(61, 13);
            this.Desine_L3.TabIndex = 19;
            this.Desine_L3.Text = "Scan folder";
            // 
            // Desine_L4
            // 
            this.Desine_L4.AutoSize = true;
            this.Desine_L4.Location = new System.Drawing.Point(12, 35);
            this.Desine_L4.Name = "Desine_L4";
            this.Desine_L4.Size = new System.Drawing.Size(66, 13);
            this.Desine_L4.TabIndex = 20;
            this.Desine_L4.Text = "Result folder";
            // 
            // Desine_L7
            // 
            this.Desine_L7.AutoSize = true;
            this.Desine_L7.Location = new System.Drawing.Point(219, 85);
            this.Desine_L7.Name = "Desine_L7";
            this.Desine_L7.Size = new System.Drawing.Size(33, 13);
            this.Desine_L7.TabIndex = 21;
            this.Desine_L7.Text = "Time:";
            // 
            // Time_L
            // 
            this.Time_L.AutoSize = true;
            this.Time_L.Location = new System.Drawing.Point(247, 85);
            this.Time_L.Name = "Time_L";
            this.Time_L.Size = new System.Drawing.Size(70, 13);
            this.Time_L.TabIndex = 21;
            this.Time_L.Text = "00:00:00.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 130);
            this.Controls.Add(this.Time_L);
            this.Controls.Add(this.Desine_L7);
            this.Controls.Add(this.Desine_L4);
            this.Controls.Add(this.Desine_L3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Stop_B);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BrowseOutput_B);
            this.Controls.Add(this.BrowseInput_B);
            this.Controls.Add(this.Start_B);
            this.Controls.Add(this.Output_TB);
            this.Controls.Add(this.Input_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Scanner 2.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_TB;
        private System.Windows.Forms.TextBox Output_TB;
        private System.Windows.Forms.Button Start_B;
        private System.Windows.Forms.Button BrowseInput_B;
        private System.Windows.Forms.Button BrowseOutput_B;
        private System.Windows.Forms.RadioButton Separator_RB3;
        private System.Windows.Forms.RadioButton Separator_RB4;
        private System.Windows.Forms.RadioButton Separator_RB5;
        private System.Windows.Forms.RadioButton Separator_RB6;
        private System.Windows.Forms.RadioButton Separator_RB1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Separator_RB2;
        private System.Windows.Forms.Button Stop_B;
        private System.Windows.Forms.Label Desine_L1;
        private System.Windows.Forms.Label Desine_L2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Folders_L;
        private System.Windows.Forms.Label Files_L;
        private System.Windows.Forms.Label Desine_L3;
        private System.Windows.Forms.Label Desine_L4;
        private System.Windows.Forms.Label Size_L;
        private System.Windows.Forms.Label Desine_L6;
        private System.Windows.Forms.Label Desine_L7;
        private System.Windows.Forms.Label Time_L;
    }
}

