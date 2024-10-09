namespace RandomFileOpener
{
    partial class RandomFileOpenerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            browseButton = new Button();
            folderPathLabel = new Label();
            openButton = new Button();
            SuspendLayout();
            // 
            // browseButton
            // 
            browseButton.Location = new Point(12, 53);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(98, 34);
            browseButton.TabIndex = 0;
            browseButton.Text = "browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // folderPathLabel
            // 
            folderPathLabel.AutoSize = true;
            folderPathLabel.Location = new Point(12, 21);
            folderPathLabel.Name = "folderPathLabel";
            folderPathLabel.Size = new Size(73, 15);
            folderPathLabel.TabIndex = 1;
            folderPathLabel.Text = "Folder Path: ";
            // 
            // openButton
            // 
            openButton.Location = new Point(277, 53);
            openButton.Name = "openButton";
            openButton.Size = new Size(98, 34);
            openButton.TabIndex = 2;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // RandomFileOpenerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 99);
            Controls.Add(openButton);
            Controls.Add(folderPathLabel);
            Controls.Add(browseButton);
            Name = "RandomFileOpenerForm";
            Text = "Open Random File";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseButton;
        private Label folderPathLabel;
        private Button openButton;
    }
}
