
namespace Chapter14ProgramCreateDatabase
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectServer = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCardTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListFriends = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsSentReceivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuSelectServer,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectServerToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectServerToolStripMenuItem
            // 
            this.selectServerToolStripMenuItem.Name = "selectServerToolStripMenuItem";
            this.selectServerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selectServerToolStripMenuItem.Text = "Select Server";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // mnuSelectServer
            // 
            this.mnuSelectServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCardTypeToolStripMenuItem,
            this.addNewFriendToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addNewCardToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuEdit});
            this.mnuSelectServer.Name = "mnuSelectServer";
            this.mnuSelectServer.Size = new System.Drawing.Size(86, 24);
            this.mnuSelectServer.Text = "Database";
            this.mnuSelectServer.Click += new System.EventHandler(this.mnuSelectServer_Click);
            // 
            // addNewCardTypeToolStripMenuItem
            // 
            this.addNewCardTypeToolStripMenuItem.Name = "addNewCardTypeToolStripMenuItem";
            this.addNewCardTypeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewCardTypeToolStripMenuItem.Text = "Add New Card Type";
            // 
            // addNewFriendToolStripMenuItem
            // 
            this.addNewFriendToolStripMenuItem.Name = "addNewFriendToolStripMenuItem";
            this.addNewFriendToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewFriendToolStripMenuItem.Text = "Add New Friend";
            this.addNewFriendToolStripMenuItem.Click += new System.EventHandler(this.addNewFriendToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // addNewCardToolStripMenuItem
            // 
            this.addNewCardToolStripMenuItem.Name = "addNewCardToolStripMenuItem";
            this.addNewCardToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewCardToolStripMenuItem.Text = "Add New Card";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(224, 26);
            this.mnuEdit.Text = "Edit Friend Record";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListFriends,
            this.cardsSentReceivedToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // mnuListFriends
            // 
            this.mnuListFriends.Name = "mnuListFriends";
            this.mnuListFriends.Size = new System.Drawing.Size(228, 26);
            this.mnuListFriends.Text = "List a Table";
            this.mnuListFriends.Click += new System.EventHandler(this.mnuListFriends_Click);
            // 
            // cardsSentReceivedToolStripMenuItem
            // 
            this.cardsSentReceivedToolStripMenuItem.Name = "cardsSentReceivedToolStripMenuItem";
            this.cardsSentReceivedToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.cardsSentReceivedToolStripMenuItem.Text = "Cards Sent/Received";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Database Management Subsystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectServer;
        private System.Windows.Forms.ToolStripMenuItem addNewCardTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addNewCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem selectServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuListFriends;
        private System.Windows.Forms.ToolStripMenuItem cardsSentReceivedToolStripMenuItem;
    }
}

