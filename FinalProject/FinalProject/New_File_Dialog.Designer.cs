namespace FinalProject
{
    partial class New_File_Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_File_Dialog));
            this.radioButton_HTML = new System.Windows.Forms.RadioButton();
            this.groupBox_File_Type = new System.Windows.Forms.GroupBox();
            this.pictureBox_HTML = new System.Windows.Forms.PictureBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.groupBox_File_Type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HTML)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_HTML
            // 
            this.radioButton_HTML.AutoSize = true;
            this.radioButton_HTML.Location = new System.Drawing.Point(44, 139);
            this.radioButton_HTML.Name = "radioButton_HTML";
            this.radioButton_HTML.Size = new System.Drawing.Size(14, 13);
            this.radioButton_HTML.TabIndex = 0;
            this.radioButton_HTML.TabStop = true;
            this.radioButton_HTML.UseVisualStyleBackColor = true;
            // 
            // groupBox_File_Type
            // 
            this.groupBox_File_Type.Controls.Add(this.pictureBox_HTML);
            this.groupBox_File_Type.Controls.Add(this.radioButton_HTML);
            this.groupBox_File_Type.Location = new System.Drawing.Point(12, 12);
            this.groupBox_File_Type.Name = "groupBox_File_Type";
            this.groupBox_File_Type.Size = new System.Drawing.Size(360, 162);
            this.groupBox_File_Type.TabIndex = 2;
            this.groupBox_File_Type.TabStop = false;
            this.groupBox_File_Type.Text = "File Type";
            // 
            // pictureBox_HTML
            // 
            this.pictureBox_HTML.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_HTML.Image")));
            this.pictureBox_HTML.Location = new System.Drawing.Point(13, 26);
            this.pictureBox_HTML.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_HTML.Name = "pictureBox_HTML";
            this.pictureBox_HTML.Size = new System.Drawing.Size(76, 100);
            this.pictureBox_HTML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_HTML.TabIndex = 0;
            this.pictureBox_HTML.TabStop = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(185, 180);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(100, 180);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // New_File_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.Controls.Add(this.groupBox_File_Type);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "New_File_Dialog";
            this.Text = "File Template";
            this.groupBox_File_Type.ResumeLayout(false);
            this.groupBox_File_Type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HTML)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton_HTML;
        private System.Windows.Forms.GroupBox groupBox_File_Type;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.PictureBox pictureBox_HTML;
    }
}