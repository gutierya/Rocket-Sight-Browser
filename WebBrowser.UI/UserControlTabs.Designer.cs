namespace WebBrowser.UI
{
    partial class UserControlTabs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTabs));
            this.toolStripUserCtrl = new System.Windows.Forms.ToolStrip();
            this.userBackBtn = new System.Windows.Forms.ToolStripButton();
            this.userFwdBtn = new System.Windows.Forms.ToolStripButton();
            this.userRefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.userHomeBtn = new System.Windows.Forms.ToolStripButton();
            this.userAddyTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.userGoBtn = new System.Windows.Forms.ToolStripButton();
            this.userBookmarkBtn = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.userCtrlWebBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripUserCtrl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripUserCtrl
            // 
            this.toolStripUserCtrl.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolStripUserCtrl.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripUserCtrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userBackBtn,
            this.userFwdBtn,
            this.userRefreshBtn,
            this.userHomeBtn,
            this.userAddyTextBox,
            this.userGoBtn,
            this.userBookmarkBtn});
            this.toolStripUserCtrl.Location = new System.Drawing.Point(0, 0);
            this.toolStripUserCtrl.Name = "toolStripUserCtrl";
            this.toolStripUserCtrl.Size = new System.Drawing.Size(1708, 39);
            this.toolStripUserCtrl.TabIndex = 0;
            this.toolStripUserCtrl.Text = "toolStrip1";
            // 
            // userBackBtn
            // 
            this.userBackBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBackBtn.Image")));
            this.userBackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userBackBtn.Name = "userBackBtn";
            this.userBackBtn.Size = new System.Drawing.Size(36, 36);
            this.userBackBtn.Text = "toolStripButton1";
            this.userBackBtn.Click += new System.EventHandler(this.userBackBtn_Click);
            // 
            // userFwdBtn
            // 
            this.userFwdBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userFwdBtn.Image = ((System.Drawing.Image)(resources.GetObject("userFwdBtn.Image")));
            this.userFwdBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userFwdBtn.Name = "userFwdBtn";
            this.userFwdBtn.Size = new System.Drawing.Size(36, 36);
            this.userFwdBtn.Text = "toolStripButton2";
            this.userFwdBtn.Click += new System.EventHandler(this.userFwdBtn_Click);
            // 
            // userRefreshBtn
            // 
            this.userRefreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userRefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("userRefreshBtn.Image")));
            this.userRefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userRefreshBtn.Name = "userRefreshBtn";
            this.userRefreshBtn.Size = new System.Drawing.Size(36, 36);
            this.userRefreshBtn.Text = "toolStripButton3";
            this.userRefreshBtn.Click += new System.EventHandler(this.userRefreshBtn_Click);
            // 
            // userHomeBtn
            // 
            this.userHomeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("userHomeBtn.Image")));
            this.userHomeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userHomeBtn.Name = "userHomeBtn";
            this.userHomeBtn.Size = new System.Drawing.Size(36, 36);
            this.userHomeBtn.Text = "toolStripButton1";
            this.userHomeBtn.Click += new System.EventHandler(this.userHomeBtn_Click);
            // 
            // userAddyTextBox
            // 
            this.userAddyTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.userAddyTextBox.Name = "userAddyTextBox";
            this.userAddyTextBox.Size = new System.Drawing.Size(600, 39);
            this.userAddyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userAddyTextBox_KeyPress);
            // 
            // userGoBtn
            // 
            this.userGoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userGoBtn.Image = ((System.Drawing.Image)(resources.GetObject("userGoBtn.Image")));
            this.userGoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userGoBtn.Name = "userGoBtn";
            this.userGoBtn.Size = new System.Drawing.Size(36, 36);
            this.userGoBtn.Text = "toolStripButton1";
            this.userGoBtn.Click += new System.EventHandler(this.userGoBtn_Click);
            // 
            // userBookmarkBtn
            // 
            this.userBookmarkBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBookmarkBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBookmarkBtn.Image")));
            this.userBookmarkBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userBookmarkBtn.Name = "userBookmarkBtn";
            this.userBookmarkBtn.Size = new System.Drawing.Size(36, 36);
            this.userBookmarkBtn.Text = "toolStripButton1";
            this.userBookmarkBtn.Click += new System.EventHandler(this.userBookmarkBtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1708, 563);
            this.webBrowser1.TabIndex = 1;
            // 
            // userCtrlWebBrowser
            // 
            this.userCtrlWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrlWebBrowser.Location = new System.Drawing.Point(0, 39);
            this.userCtrlWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.userCtrlWebBrowser.Name = "userCtrlWebBrowser";
            this.userCtrlWebBrowser.Size = new System.Drawing.Size(1708, 563);
            this.userCtrlWebBrowser.TabIndex = 2;
            this.userCtrlWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1708, 46);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 40);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 41);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.userCtrlWebBrowser);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStripUserCtrl);
            this.Name = "UserControlTabs";
            this.Size = new System.Drawing.Size(1708, 602);
            this.Load += new System.EventHandler(this.UserControlTabs_Load);
            this.toolStripUserCtrl.ResumeLayout(false);
            this.toolStripUserCtrl.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripUserCtrl;
        private System.Windows.Forms.ToolStripButton userBackBtn;
        private System.Windows.Forms.ToolStripButton userFwdBtn;
        private System.Windows.Forms.ToolStripButton userRefreshBtn;
        private System.Windows.Forms.ToolStripButton userHomeBtn;
        private System.Windows.Forms.ToolStripTextBox userAddyTextBox;
        private System.Windows.Forms.ToolStripButton userGoBtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser userCtrlWebBrowser;
        private System.Windows.Forms.ToolStripButton userBookmarkBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}
