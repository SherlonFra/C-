
namespace Chapter12ProgramQuickSort
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lstSorted = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of items:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(133, 22);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 1;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(26, 77);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(101, 23);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(158, 77);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(254, 76);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(26, 149);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(121, 260);
            this.lstOutput.TabIndex = 5;
            // 
            // lstSorted
            // 
            this.lstSorted.FormattingEnabled = true;
            this.lstSorted.ItemHeight = 16;
            this.lstSorted.Location = new System.Drawing.Point(181, 149);
            this.lstSorted.Name = "lstSorted";
            this.lstSorted.Size = new System.Drawing.Size(120, 260);
            this.lstSorted.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.lstSorted);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.ListBox lstSorted;
    }
}

