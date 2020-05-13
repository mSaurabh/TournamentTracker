namespace DataExtractionToolUI
{
    partial class ToolDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolDashboard));
            this.DETLabel = new System.Windows.Forms.Label();
            this.TemplateSelectedListBox = new System.Windows.Forms.CheckedListBox();
            this.TemplateSelectedLabel = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.FilesSelectedListBox = new System.Windows.Forms.ListBox();
            this.RemoveSelectedFilesButton = new System.Windows.Forms.Button();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DETLabel
            // 
            this.DETLabel.AutoSize = true;
            this.DETLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DETLabel.Location = new System.Drawing.Point(12, 9);
            this.DETLabel.Name = "DETLabel";
            this.DETLabel.Size = new System.Drawing.Size(287, 37);
            this.DETLabel.TabIndex = 0;
            this.DETLabel.Text = "Data Extraction Tool UI";
            // 
            // TemplateSelectedListBox
            // 
            this.TemplateSelectedListBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TemplateSelectedListBox.FormattingEnabled = true;
            this.TemplateSelectedListBox.Location = new System.Drawing.Point(19, 136);
            this.TemplateSelectedListBox.Name = "TemplateSelectedListBox";
            this.TemplateSelectedListBox.Size = new System.Drawing.Size(238, 214);
            this.TemplateSelectedListBox.TabIndex = 1;
            // 
            // TemplateSelectedLabel
            // 
            this.TemplateSelectedLabel.AutoSize = true;
            this.TemplateSelectedLabel.Location = new System.Drawing.Point(14, 84);
            this.TemplateSelectedLabel.Name = "TemplateSelectedLabel";
            this.TemplateSelectedLabel.Size = new System.Drawing.Size(181, 30);
            this.TemplateSelectedLabel.TabIndex = 2;
            this.TemplateSelectedLabel.Text = "Template Selected";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(288, 84);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(91, 30);
            this.FilePathLabel.TabIndex = 3;
            this.FilePathLabel.Text = "File Path";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FilePathTextBox.Location = new System.Drawing.Point(385, 81);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(344, 35);
            this.FilePathTextBox.TabIndex = 4;
            this.FilePathTextBox.TextChanged += new System.EventHandler(this.FilePathTextBox_TextChanged);
            // 
            // FilesSelectedListBox
            // 
            this.FilesSelectedListBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FilesSelectedListBox.FormattingEnabled = true;
            this.FilesSelectedListBox.ItemHeight = 30;
            this.FilesSelectedListBox.Location = new System.Drawing.Point(293, 136);
            this.FilesSelectedListBox.Name = "FilesSelectedListBox";
            this.FilesSelectedListBox.Size = new System.Drawing.Size(436, 214);
            this.FilesSelectedListBox.TabIndex = 5;
            // 
            // RemoveSelectedFilesButton
            // 
            this.RemoveSelectedFilesButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedFilesButton.Location = new System.Drawing.Point(564, 367);
            this.RemoveSelectedFilesButton.Name = "RemoveSelectedFilesButton";
            this.RemoveSelectedFilesButton.Size = new System.Drawing.Size(165, 44);
            this.RemoveSelectedFilesButton.TabIndex = 6;
            this.RemoveSelectedFilesButton.Text = "Remove Selected";
            this.RemoveSelectedFilesButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedFilesButton.Click += new System.EventHandler(this.RemoveSelectedFilesButton_Click);
            // 
            // ExtractButton
            // 
            this.ExtractButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractButton.Location = new System.Drawing.Point(234, 456);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(230, 89);
            this.ExtractButton.TabIndex = 7;
            this.ExtractButton.Text = "Generate Output File";
            this.ExtractButton.UseVisualStyleBackColor = true;
            // 
            // ToolDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 578);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.RemoveSelectedFilesButton);
            this.Controls.Add(this.FilesSelectedListBox);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.TemplateSelectedLabel);
            this.Controls.Add(this.TemplateSelectedListBox);
            this.Controls.Add(this.DETLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ToolDashboard";
            this.Text = "DataExtraction Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DETLabel;
        private System.Windows.Forms.CheckedListBox TemplateSelectedListBox;
        private System.Windows.Forms.Label TemplateSelectedLabel;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.ListBox FilesSelectedListBox;
        private System.Windows.Forms.Button RemoveSelectedFilesButton;
        private System.Windows.Forms.Button ExtractButton;
    }
}

