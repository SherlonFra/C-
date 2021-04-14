
namespace Chapter05_program_02
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FrmMain()
        {
            InitializeComponent();
        }

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCompleteDateAndTime = new System.Windows.Forms.TextBox();
            this.txtLongDate = new System.Windows.Forms.TextBox();
            this.txtShortDate = new System.Windows.Forms.TextBox();
            this.txtGeneralDateAndTime = new System.Windows.Forms.TextBox();
            this.txtLongTime = new System.Windows.Forms.TextBox();
            this.txtShortTime = new System.Windows.Forms.TextBox();
            this.txtDaysToNewYears = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Date and Time:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Long Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Short Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "General Date and Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Long Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Short Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Days Until New Years:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close_Click);
            // 
            // txtCompleteDateAndTime
            // 
            this.txtCompleteDateAndTime.Location = new System.Drawing.Point(176, 21);
            this.txtCompleteDateAndTime.Name = "txtCompleteDateAndTime";
            this.txtCompleteDateAndTime.Size = new System.Drawing.Size(428, 22);
            this.txtCompleteDateAndTime.TabIndex = 9;
            // 
            // txtLongDate
            // 
            this.txtLongDate.Location = new System.Drawing.Point(176, 56);
            this.txtLongDate.Name = "txtLongDate";
            this.txtLongDate.Size = new System.Drawing.Size(428, 22);
            this.txtLongDate.TabIndex = 10;
            // 
            // txtShortDate
            // 
            this.txtShortDate.Location = new System.Drawing.Point(176, 90);
            this.txtShortDate.Name = "txtShortDate";
            this.txtShortDate.Size = new System.Drawing.Size(428, 22);
            this.txtShortDate.TabIndex = 11;
            // 
            // txtGeneralDateAndTime
            // 
            this.txtGeneralDateAndTime.Location = new System.Drawing.Point(176, 124);
            this.txtGeneralDateAndTime.Name = "txtGeneralDateAndTime";
            this.txtGeneralDateAndTime.Size = new System.Drawing.Size(428, 22);
            this.txtGeneralDateAndTime.TabIndex = 12;
            this.txtGeneralDateAndTime.Text = "\r\n";
            // 
            // txtLongTime
            // 
            this.txtLongTime.Location = new System.Drawing.Point(176, 159);
            this.txtLongTime.Name = "txtLongTime";
            this.txtLongTime.Size = new System.Drawing.Size(428, 22);
            this.txtLongTime.TabIndex = 13;
            // 
            // txtShortTime
            // 
            this.txtShortTime.Location = new System.Drawing.Point(176, 197);
            this.txtShortTime.Name = "txtShortTime";
            this.txtShortTime.Size = new System.Drawing.Size(428, 22);
            this.txtShortTime.TabIndex = 14;
            // 
            // txtDaysToNewYears
            // 
            this.txtDaysToNewYears.Location = new System.Drawing.Point(176, 232);
            this.txtDaysToNewYears.Name = "txtDaysToNewYears";
            this.txtDaysToNewYears.Size = new System.Drawing.Size(428, 22);
            this.txtDaysToNewYears.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 43);
            this.button3.TabIndex = 16;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 378);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDaysToNewYears);
            this.Controls.Add(this.txtShortTime);
            this.Controls.Add(this.txtLongTime);
            this.Controls.Add(this.txtGeneralDateAndTime);
            this.Controls.Add(this.txtShortDate);
            this.Controls.Add(this.txtLongDate);
            this.Controls.Add(this.txtCompleteDateAndTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCompleteDateAndTime;
        private System.Windows.Forms.TextBox txtLongDate;
        private System.Windows.Forms.TextBox txtShortDate;
        private System.Windows.Forms.TextBox txtGeneralDateAndTime;
        private System.Windows.Forms.TextBox txtLongTime;
        private System.Windows.Forms.TextBox txtShortTime;
        private System.Windows.Forms.TextBox txtDaysToNewYears;
        private System.Windows.Forms.Button button3;
    }
}

