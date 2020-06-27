namespace LearNAV
{
    partial class Resource_Extract_Tool
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.File_accss = new System.Windows.Forms.OpenFileDialog();
            this.locate_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_loc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.extract_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.extract_bg = new System.ComponentModel.BackgroundWorker();
            this.progress_track = new Bunifu.Framework.UI.BunifuProgressBar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LearNAV.Properties.Resources.resource_extract_tool;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // File_accss
            // 
            this.File_accss.FileName = "openFileDialog1";
            this.File_accss.Filter = "(*.zip)|*zip";
            this.File_accss.Title = "Select LearNAV Resource Zip";
            this.File_accss.FileOk += new System.ComponentModel.CancelEventHandler(this.File_accss_FileOk);
            // 
            // locate_btn
            // 
            this.locate_btn.Activecolor = System.Drawing.Color.Transparent;
            this.locate_btn.BackColor = System.Drawing.Color.Transparent;
            this.locate_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.locate_btn.BorderRadius = 0;
            this.locate_btn.ButtonText = "Select file";
            this.locate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locate_btn.DisabledColor = System.Drawing.Color.Gray;
            this.locate_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(201)))), ((int)(((byte)(170)))));
            this.locate_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.locate_btn.Iconimage = null;
            this.locate_btn.Iconimage_right = null;
            this.locate_btn.Iconimage_right_Selected = null;
            this.locate_btn.Iconimage_Selected = null;
            this.locate_btn.IconMarginLeft = 0;
            this.locate_btn.IconMarginRight = 0;
            this.locate_btn.IconRightVisible = true;
            this.locate_btn.IconRightZoom = 0D;
            this.locate_btn.IconVisible = true;
            this.locate_btn.IconZoom = 90D;
            this.locate_btn.IsTab = false;
            this.locate_btn.Location = new System.Drawing.Point(267, 295);
            this.locate_btn.Name = "locate_btn";
            this.locate_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.locate_btn.OnHovercolor = System.Drawing.Color.Teal;
            this.locate_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.locate_btn.selected = false;
            this.locate_btn.Size = new System.Drawing.Size(113, 35);
            this.locate_btn.TabIndex = 1;
            this.locate_btn.Text = "Select file";
            this.locate_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.locate_btn.Textcolor = System.Drawing.Color.White;
            this.locate_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locate_btn.Click += new System.EventHandler(this.locate_btn_Click);
            // 
            // txt_loc
            // 
            this.txt_loc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_loc.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_loc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_loc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_loc.HintForeColor = System.Drawing.Color.Empty;
            this.txt_loc.HintText = "";
            this.txt_loc.isPassword = false;
            this.txt_loc.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_loc.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_loc.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_loc.LineThickness = 3;
            this.txt_loc.Location = new System.Drawing.Point(14, 295);
            this.txt_loc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_loc.Name = "txt_loc";
            this.txt_loc.Size = new System.Drawing.Size(246, 33);
            this.txt_loc.TabIndex = 2;
            this.txt_loc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // extract_btn
            // 
            this.extract_btn.Activecolor = System.Drawing.Color.Transparent;
            this.extract_btn.BackColor = System.Drawing.Color.Teal;
            this.extract_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.extract_btn.BorderRadius = 0;
            this.extract_btn.ButtonText = "Extract resources";
            this.extract_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.extract_btn.DisabledColor = System.Drawing.Color.Gray;
            this.extract_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(201)))), ((int)(((byte)(170)))));
            this.extract_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.extract_btn.Iconimage = null;
            this.extract_btn.Iconimage_right = null;
            this.extract_btn.Iconimage_right_Selected = null;
            this.extract_btn.Iconimage_Selected = null;
            this.extract_btn.IconMarginLeft = 0;
            this.extract_btn.IconMarginRight = 0;
            this.extract_btn.IconRightVisible = true;
            this.extract_btn.IconRightZoom = 0D;
            this.extract_btn.IconVisible = true;
            this.extract_btn.IconZoom = 90D;
            this.extract_btn.IsTab = false;
            this.extract_btn.Location = new System.Drawing.Point(14, 336);
            this.extract_btn.Name = "extract_btn";
            this.extract_btn.Normalcolor = System.Drawing.Color.Teal;
            this.extract_btn.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.extract_btn.OnHoverTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.extract_btn.selected = false;
            this.extract_btn.Size = new System.Drawing.Size(366, 35);
            this.extract_btn.TabIndex = 3;
            this.extract_btn.Text = "Extract resources";
            this.extract_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.extract_btn.Textcolor = System.Drawing.Color.White;
            this.extract_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extract_btn.Click += new System.EventHandler(this.extract_btn_Click);
            // 
            // extract_bg
            // 
            this.extract_bg.WorkerSupportsCancellation = true;
            this.extract_bg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.extract_bg_DoWork);
            this.extract_bg.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.extract_bg_ProgressChanged);
            this.extract_bg.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.extract_bg_RunWorkerCompleted);
            // 
            // progress_track
            // 
            this.progress_track.BackColor = System.Drawing.Color.White;
            this.progress_track.BorderRadius = 5;
            this.progress_track.Location = new System.Drawing.Point(12, 377);
            this.progress_track.MaximumValue = 100;
            this.progress_track.Name = "progress_track";
            this.progress_track.ProgressColor = System.Drawing.Color.PaleTurquoise;
            this.progress_track.Size = new System.Drawing.Size(368, 28);
            this.progress_track.TabIndex = 4;
            this.progress_track.Value = 0;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(12, 427);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(366, 124);
            this.listBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contained in package:";
            // 
            // Resource_Extract_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(201)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(406, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.progress_track);
            this.Controls.Add(this.extract_btn);
            this.Controls.Add(this.txt_loc);
            this.Controls.Add(this.locate_btn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resource_Extract_Tool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource_Extract_Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog File_accss;
        private Bunifu.Framework.UI.BunifuFlatButton locate_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_loc;
        private Bunifu.Framework.UI.BunifuFlatButton extract_btn;
        private System.ComponentModel.BackgroundWorker extract_bg;
        private Bunifu.Framework.UI.BunifuProgressBar progress_track;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
    }
}