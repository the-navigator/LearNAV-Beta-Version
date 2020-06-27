namespace LearNAV
{
    partial class Extract
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_file = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.progress_track = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.extract_bg = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Resource Extract Tool to extract resources that will be used by LearNAV.\r\n1. " +
    "Use this if you have missing resources\r\n2. For Resource Updates on LearNAV\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drag \"learnav-resources.zip\" into this control below:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_file
            // 
            this.txt_file.AllowDrop = true;
            this.txt_file.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_file.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_file.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_file.BorderThickness = 3;
            this.txt_file.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_file.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_file.isPassword = false;
            this.txt_file.Location = new System.Drawing.Point(27, 136);
            this.txt_file.Margin = new System.Windows.Forms.Padding(4);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(526, 33);
            this.txt_file.TabIndex = 4;
            this.txt_file.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
//            this.txt_file.OnValueChanged += new System.EventHandler(this.txt_file_OnValueChanged);
            this.txt_file.DragDrop += new System.Windows.Forms.DragEventHandler(this.bunifuMetroTextbox1_DragDrop);
            this.txt_file.DragOver += new System.Windows.Forms.DragEventHandler(this.bunifuMetroTextbox1_DragOver);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-14, 94);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(639, 35);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // progress_track
            // 
            this.progress_track.BackColor = System.Drawing.Color.Silver;
            this.progress_track.BorderRadius = 5;
            this.progress_track.Location = new System.Drawing.Point(29, 193);
            this.progress_track.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progress_track.MaximumValue = 100;
            this.progress_track.Name = "progress_track";
            this.progress_track.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(201)))), ((int)(((byte)(170)))));
            this.progress_track.Size = new System.Drawing.Size(522, 36);
            this.progress_track.TabIndex = 8;
            this.progress_track.Value = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // extract_bg
            // 
           this.extract_bg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.extract_bg_DoWork);
            this.extract_bg.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.extract_bg_ProgressChanged);
            // 
            // Extract
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 240);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progress_track);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Extract";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Resource Extract Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_file;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuProgressBar progress_track;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker extract_bg;
    }
}