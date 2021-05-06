
namespace Chapter14ProgramCreateDatabase
{
    partial class frmServerSelect
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
            this.btnServer = new System.Windows.Forms.Button();
            this.lblDb = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server To Use:";
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(618, 35);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(170, 42);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Select Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Location = new System.Drawing.Point(12, 93);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(118, 17);
            this.lblDb.TabIndex = 3;
            this.lblDb.Text = "Database to Use:";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Items.AddRange(new object[] {
            "DESKTOP-NVG7K5K\\\\SQLEXPRESS"});
            this.cmbServer.Location = new System.Drawing.Point(128, 9);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(660, 24);
            this.cmbServer.TabIndex = 4;
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(128, 93);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(660, 24);
            this.cmbDatabase.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(618, 124);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmServerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 210);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.lblDb);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.label1);
            this.Name = "frmServerSelect";
            this.Text = "frmServerSelect";
            this.Load += new System.EventHandler(this.frmServerSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Button btnClose;
    }
}