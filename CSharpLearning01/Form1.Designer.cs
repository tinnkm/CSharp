namespace CSharpLearning01
{
    partial class Form1
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
            this.filetree = new System.Windows.Forms.TreeView();
            this.open = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showdetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // filetree
            // 
            this.filetree.Location = new System.Drawing.Point(12, 60);
            this.filetree.Name = "filetree";
            this.filetree.Size = new System.Drawing.Size(195, 338);
            this.filetree.TabIndex = 0;
          
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(354, 13);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 1;
            this.open.Text = "导入目录";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 21);
            this.textBox1.TabIndex = 2;
            // 
            // showdetail
            // 
            this.showdetail.Location = new System.Drawing.Point(242, 60);
            this.showdetail.Multiline = true;
            this.showdetail.Name = "showdetail";
            this.showdetail.Size = new System.Drawing.Size(201, 338);
            this.showdetail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "=>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showdetail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.filetree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView filetree;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox showdetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

