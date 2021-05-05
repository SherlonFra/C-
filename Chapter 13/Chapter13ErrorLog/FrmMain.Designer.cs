
namespace Chapter13ErrorLog
{
    partial class FrmMain
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
            this.rbDivideBy0 = new System.Windows.Forms.RadioButton();
            this.rbFileNotFound = new System.Windows.Forms.RadioButton();
            this.rbNumericOverflow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThrow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtErrorMsgs = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDivideBy0
            // 
            this.rbDivideBy0.AutoSize = true;
            this.rbDivideBy0.Location = new System.Drawing.Point(6, 31);
            this.rbDivideBy0.Name = "rbDivideBy0";
            this.rbDivideBy0.Size = new System.Drawing.Size(99, 21);
            this.rbDivideBy0.TabIndex = 0;
            this.rbDivideBy0.TabStop = true;
            this.rbDivideBy0.Text = "Divide by 0";
            this.rbDivideBy0.UseVisualStyleBackColor = true;
            // 
            // rbFileNotFound
            // 
            this.rbFileNotFound.AutoSize = true;
            this.rbFileNotFound.Location = new System.Drawing.Point(130, 31);
            this.rbFileNotFound.Name = "rbFileNotFound";
            this.rbFileNotFound.Size = new System.Drawing.Size(115, 21);
            this.rbFileNotFound.TabIndex = 1;
            this.rbFileNotFound.TabStop = true;
            this.rbFileNotFound.Text = "File not found";
            this.rbFileNotFound.UseVisualStyleBackColor = true;
            // 
            // rbNumericOverflow
            // 
            this.rbNumericOverflow.AutoSize = true;
            this.rbNumericOverflow.Location = new System.Drawing.Point(286, 31);
            this.rbNumericOverflow.Name = "rbNumericOverflow";
            this.rbNumericOverflow.Size = new System.Drawing.Size(140, 21);
            this.rbNumericOverflow.TabIndex = 2;
            this.rbNumericOverflow.TabStop = true;
            this.rbNumericOverflow.Text = "Numeric Overflow";
            this.rbNumericOverflow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDivideBy0);
            this.groupBox1.Controls.Add(this.rbNumericOverflow);
            this.groupBox1.Controls.Add(this.rbFileNotFound);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exception";
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(491, 13);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(75, 31);
            this.btnThrow.TabIndex = 4;
            this.btnThrow.Text = "Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(491, 50);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtErrorMsgs
            // 
            this.txtErrorMsgs.Location = new System.Drawing.Point(18, 103);
            this.txtErrorMsgs.Name = "txtErrorMsgs";
            this.txtErrorMsgs.Size = new System.Drawing.Size(548, 251);
            this.txtErrorMsgs.TabIndex = 6;
            this.txtErrorMsgs.Text = "";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 370);
            this.Controls.Add(this.txtErrorMsgs);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Error Logger";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDivideBy0;
        private System.Windows.Forms.RadioButton rbFileNotFound;
        private System.Windows.Forms.RadioButton rbNumericOverflow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox txtErrorMsgs;
    }
}

