namespace JsonToCSVBuilder
{
    partial class CSVBuilder
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
            this.Button_CreateCSV = new System.Windows.Forms.Button();
            this.txt_InputJsonTextBox = new System.Windows.Forms.RichTextBox();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.cb_isHeaderOnly = new System.Windows.Forms.CheckBox();
            this.lbl_filepath = new System.Windows.Forms.Label();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.lbl_csvlabel = new System.Windows.Forms.Label();
            this.lbl_IncludeHeaders = new System.Windows.Forms.Label();
            this.cb_RecordNam = new System.Windows.Forms.CheckBox();
            this.cb_RandomEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Button_CreateCSV
            // 
            this.Button_CreateCSV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_CreateCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CreateCSV.Location = new System.Drawing.Point(663, 722);
            this.Button_CreateCSV.Name = "Button_CreateCSV";
            this.Button_CreateCSV.Size = new System.Drawing.Size(125, 23);
            this.Button_CreateCSV.TabIndex = 0;
            this.Button_CreateCSV.Text = "CreateCSV";
            this.Button_CreateCSV.UseVisualStyleBackColor = false;
            this.Button_CreateCSV.Click += new System.EventHandler(this.Button_CreateCSV_Click);
            // 
            // txt_InputJsonTextBox
            // 
            this.txt_InputJsonTextBox.Location = new System.Drawing.Point(12, 88);
            this.txt_InputJsonTextBox.Name = "txt_InputJsonTextBox";
            this.txt_InputJsonTextBox.Size = new System.Drawing.Size(776, 630);
            this.txt_InputJsonTextBox.TabIndex = 1;
            this.txt_InputJsonTextBox.Text = "";
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(101, 9);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(156, 22);
            this.txt_FilePath.TabIndex = 2;
            // 
            // txt_fileName
            // 
            this.txt_fileName.Location = new System.Drawing.Point(101, 51);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(157, 22);
            this.txt_fileName.TabIndex = 3;
            // 
            // cb_isHeaderOnly
            // 
            this.cb_isHeaderOnly.AutoSize = true;
            this.cb_isHeaderOnly.Location = new System.Drawing.Point(594, 11);
            this.cb_isHeaderOnly.Name = "cb_isHeaderOnly";
            this.cb_isHeaderOnly.Size = new System.Drawing.Size(163, 21);
            this.cb_isHeaderOnly.TabIndex = 4;
            this.cb_isHeaderOnly.Text = "Create Headers Only";
            this.cb_isHeaderOnly.UseVisualStyleBackColor = true;
            // 
            // lbl_filepath
            // 
            this.lbl_filepath.AutoSize = true;
            this.lbl_filepath.Location = new System.Drawing.Point(23, 10);
            this.lbl_filepath.Name = "lbl_filepath";
            this.lbl_filepath.Size = new System.Drawing.Size(66, 17);
            this.lbl_filepath.TabIndex = 5;
            this.lbl_filepath.Text = "Filepath :";
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Location = new System.Drawing.Point(23, 51);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(73, 17);
            this.lbl_filename.TabIndex = 6;
            this.lbl_filename.Text = "Filename :";
            // 
            // lbl_csvlabel
            // 
            this.lbl_csvlabel.AutoSize = true;
            this.lbl_csvlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_csvlabel.Location = new System.Drawing.Point(261, 53);
            this.lbl_csvlabel.Name = "lbl_csvlabel";
            this.lbl_csvlabel.Size = new System.Drawing.Size(37, 17);
            this.lbl_csvlabel.TabIndex = 7;
            this.lbl_csvlabel.Text = ".csv";
            // 
            // lbl_IncludeHeaders
            // 
            this.lbl_IncludeHeaders.AutoSize = true;
            this.lbl_IncludeHeaders.Location = new System.Drawing.Point(312, 10);
            this.lbl_IncludeHeaders.Name = "lbl_IncludeHeaders";
            this.lbl_IncludeHeaders.Size = new System.Drawing.Size(123, 17);
            this.lbl_IncludeHeaders.TabIndex = 8;
            this.lbl_IncludeHeaders.Text = "Include Headers : ";
            // 
            // cb_RecordNam
            // 
            this.cb_RecordNam.AutoSize = true;
            this.cb_RecordNam.Checked = true;
            this.cb_RecordNam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_RecordNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_RecordNam.Location = new System.Drawing.Point(368, 31);
            this.cb_RecordNam.Name = "cb_RecordNam";
            this.cb_RecordNam.Size = new System.Drawing.Size(113, 21);
            this.cb_RecordNam.TabIndex = 9;
            this.cb_RecordNam.Text = "RecordName";
            this.cb_RecordNam.UseVisualStyleBackColor = true;
            // 
            // cb_RandomEnabled
            // 
            this.cb_RandomEnabled.AutoSize = true;
            this.cb_RandomEnabled.Checked = true;
            this.cb_RandomEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_RandomEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_RandomEnabled.Location = new System.Drawing.Point(368, 57);
            this.cb_RandomEnabled.Name = "cb_RandomEnabled";
            this.cb_RandomEnabled.Size = new System.Drawing.Size(145, 21);
            this.cb_RandomEnabled.TabIndex = 10;
            this.cb_RandomEnabled.Text = "IsRandomEnabled";
            this.cb_RandomEnabled.UseVisualStyleBackColor = true;
            // 
            // CSVBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 750);
            this.Controls.Add(this.cb_RandomEnabled);
            this.Controls.Add(this.cb_RecordNam);
            this.Controls.Add(this.lbl_IncludeHeaders);
            this.Controls.Add(this.lbl_csvlabel);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.lbl_filepath);
            this.Controls.Add(this.cb_isHeaderOnly);
            this.Controls.Add(this.txt_fileName);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.txt_InputJsonTextBox);
            this.Controls.Add(this.Button_CreateCSV);
            this.Name = "CSVBuilder";
            this.Text = "JCB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_CreateCSV;
        private System.Windows.Forms.RichTextBox txt_InputJsonTextBox;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.CheckBox cb_isHeaderOnly;
        private System.Windows.Forms.Label lbl_filepath;
        private System.Windows.Forms.Label lbl_filename;
        private System.Windows.Forms.Label lbl_csvlabel;
        private System.Windows.Forms.Label lbl_IncludeHeaders;
        private System.Windows.Forms.CheckBox cb_RecordNam;
        private System.Windows.Forms.CheckBox cb_RandomEnabled;
    }
}

