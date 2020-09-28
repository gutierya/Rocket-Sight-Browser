namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxSearchResults = new System.Windows.Forms.TextBox();
            this.resultsLabelforList = new System.Windows.Forms.Label();
            this.insertLabelforList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(123, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(468, 479);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(845, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search Bookmark:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(845, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear Bookmark:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(845, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 68);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Bookmark:";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxSearchResults
            // 
            this.textBoxSearchResults.Location = new System.Drawing.Point(741, 138);
            this.textBoxSearchResults.Name = "textBoxSearchResults";
            this.textBoxSearchResults.Size = new System.Drawing.Size(400, 31);
            this.textBoxSearchResults.TabIndex = 4;
            // 
            // resultsLabelforList
            // 
            this.resultsLabelforList.AutoSize = true;
            this.resultsLabelforList.Location = new System.Drawing.Point(265, 66);
            this.resultsLabelforList.Name = "resultsLabelforList";
            this.resultsLabelforList.Size = new System.Drawing.Size(146, 25);
            this.resultsLabelforList.TabIndex = 5;
            this.resultsLabelforList.Text = "Output Below:";
            // 
            // insertLabelforList
            // 
            this.insertLabelforList.AutoSize = true;
            this.insertLabelforList.Location = new System.Drawing.Point(840, 66);
            this.insertLabelforList.Name = "insertLabelforList";
            this.insertLabelforList.Size = new System.Drawing.Size(248, 25);
            this.insertLabelforList.TabIndex = 6;
            this.insertLabelforList.Text = "Enter a Search text item:";
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 712);
            this.Controls.Add(this.insertLabelforList);
            this.Controls.Add(this.resultsLabelforList);
            this.Controls.Add(this.textBoxSearchResults);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxSearchResults;
        private System.Windows.Forms.Label resultsLabelforList;
        private System.Windows.Forms.Label insertLabelforList;
    }
}