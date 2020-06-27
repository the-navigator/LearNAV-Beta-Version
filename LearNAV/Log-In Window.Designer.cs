namespace LearNAV
{
    partial class LogIn_Window
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
            this.lgin_username_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lgin_password_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Log_In_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lgin_username_textbox
            // 
            this.lgin_username_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lgin_username_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgin_username_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lgin_username_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.lgin_username_textbox.HintText = "";
            this.lgin_username_textbox.isPassword = false;
            this.lgin_username_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.lgin_username_textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.lgin_username_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lgin_username_textbox.LineThickness = 4;
            this.lgin_username_textbox.Location = new System.Drawing.Point(240, 119);
            this.lgin_username_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.lgin_username_textbox.Name = "lgin_username_textbox";
            this.lgin_username_textbox.Size = new System.Drawing.Size(303, 33);
            this.lgin_username_textbox.TabIndex = 1;
            this.lgin_username_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lgin_username_textbox.OnValueChanged += new System.EventHandler(this.lgin_username_textbox_OnValueChanged);
            this.lgin_username_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lgin_username_textbox_KeyDown);
            // 
            // lgin_password_textbox
            // 
            this.lgin_password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lgin_password_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgin_password_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lgin_password_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.lgin_password_textbox.HintText = "";
            this.lgin_password_textbox.isPassword = false;
            this.lgin_password_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.lgin_password_textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.lgin_password_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lgin_password_textbox.LineThickness = 4;
            this.lgin_password_textbox.Location = new System.Drawing.Point(240, 181);
            this.lgin_password_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.lgin_password_textbox.Name = "lgin_password_textbox";
            this.lgin_password_textbox.Size = new System.Drawing.Size(303, 33);
            this.lgin_password_textbox.TabIndex = 2;
            this.lgin_password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lgin_password_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lgin_password_textbox_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LearNAV.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Log_In_Button
            // 
            this.Log_In_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_In_Button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Log_In_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Log_In_Button.BorderRadius = 0;
            this.Log_In_Button.ButtonText = "Log-In";
            this.Log_In_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_In_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Log_In_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Log_In_Button.Iconimage = null;
            this.Log_In_Button.Iconimage_right = null;
            this.Log_In_Button.Iconimage_right_Selected = null;
            this.Log_In_Button.Iconimage_Selected = null;
            this.Log_In_Button.IconMarginLeft = 0;
            this.Log_In_Button.IconMarginRight = 0;
            this.Log_In_Button.IconRightVisible = true;
            this.Log_In_Button.IconRightZoom = 0D;
            this.Log_In_Button.IconVisible = true;
            this.Log_In_Button.IconZoom = 90D;
            this.Log_In_Button.IsTab = false;
            this.Log_In_Button.Location = new System.Drawing.Point(453, 222);
            this.Log_In_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Log_In_Button.Name = "Log_In_Button";
            this.Log_In_Button.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.Log_In_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Log_In_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Log_In_Button.selected = false;
            this.Log_In_Button.Size = new System.Drawing.Size(90, 32);
            this.Log_In_Button.TabIndex = 3;
            this.Log_In_Button.Text = "Log-In";
            this.Log_In_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Log_In_Button.Textcolor = System.Drawing.Color.White;
            this.Log_In_Button.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_In_Button.Click += new System.EventHandler(this.Log_In_Button_Click_1);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Register";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(369, 222);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(76, 32);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.Text = "Register";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(556, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogIn_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(588, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.Log_In_Button);
            this.Controls.Add(this.lgin_password_textbox);
            this.Controls.Add(this.lgin_username_textbox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn_Window";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_Window_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lgin_username_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lgin_password_textbox;
        private Bunifu.Framework.UI.BunifuFlatButton Log_In_Button;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Button button1;
    }
}

