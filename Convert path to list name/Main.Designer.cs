namespace Convert_path_to_list_name
{
    partial class Main
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
            this.folderPath = new System.Windows.Forms.TextBox();
            this.browserButton = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.runButton = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder";
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(111, 36);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(320, 26);
            this.folderPath.TabIndex = 1;
            // 
            // browserButton
            // 
            this.browserButton.Location = new System.Drawing.Point(463, 32);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(75, 34);
            this.browserButton.TabIndex = 2;
            this.browserButton.Text = "Browser";
            this.browserButton.UseVisualStyleBackColor = true;
            this.browserButton.Click += new System.EventHandler(this.browserButton_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "txt";
            this.saveDialog.Filter = "Text|*.txt|All files | *.*";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(231, 90);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(80, 32);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 153);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Convert all of files in folder or list name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
    }
}

