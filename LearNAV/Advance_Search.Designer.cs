namespace LearNAV
{
    partial class Advance_Search
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
            this.adsearch_txtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_tag = new MaterialSkin.Controls.MaterialCheckBox();
            this.chk_author = new MaterialSkin.Controls.MaterialCheckBox();
            this.chk_ID = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.g_level_filt = new System.Windows.Forms.ComboBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.results_lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // adsearch_txtbox
            // 
            this.adsearch_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adsearch_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adsearch_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.adsearch_txtbox.HintForeColor = System.Drawing.Color.Empty;
            this.adsearch_txtbox.HintText = "";
            this.adsearch_txtbox.isPassword = false;
            this.adsearch_txtbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.adsearch_txtbox.LineIdleColor = System.Drawing.Color.Gray;
            this.adsearch_txtbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.adsearch_txtbox.LineThickness = 3;
            this.adsearch_txtbox.Location = new System.Drawing.Point(31, 53);
            this.adsearch_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.adsearch_txtbox.Name = "adsearch_txtbox";
            this.adsearch_txtbox.Size = new System.Drawing.Size(659, 33);
            this.adsearch_txtbox.TabIndex = 1;
            this.adsearch_txtbox.Text = "Enter keywords...";
            this.adsearch_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adsearch_txtbox.OnValueChanged += new System.EventHandler(this.adsearch_txtbox_OnValueChanged);
            this.adsearch_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adsearch_txtbox_KeyDown);
            this.adsearch_txtbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.adsearch_txtbox_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_tag);
            this.groupBox1.Controls.Add(this.chk_author);
            this.groupBox1.Controls.Add(this.chk_ID);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.groupBox1.Location = new System.Drawing.Point(31, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            // 
            // chk_tag
            // 
            this.chk_tag.AutoSize = true;
            this.chk_tag.Depth = 0;
            this.chk_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_tag.Location = new System.Drawing.Point(118, 29);
            this.chk_tag.Margin = new System.Windows.Forms.Padding(0);
            this.chk_tag.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_tag.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_tag.Name = "chk_tag";
            this.chk_tag.Ripple = true;
            this.chk_tag.Size = new System.Drawing.Size(61, 30);
            this.chk_tag.TabIndex = 2;
            this.chk_tag.Text = "Tags";
            this.chk_tag.UseVisualStyleBackColor = true;
            this.chk_tag.CheckedChanged += new System.EventHandler(this.chk_tag_CheckedChanged);
            // 
            // chk_author
            // 
            this.chk_author.AutoSize = true;
            this.chk_author.Depth = 0;
            this.chk_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_author.Location = new System.Drawing.Point(46, 29);
            this.chk_author.Margin = new System.Windows.Forms.Padding(0);
            this.chk_author.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_author.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_author.Name = "chk_author";
            this.chk_author.Ripple = true;
            this.chk_author.Size = new System.Drawing.Size(72, 30);
            this.chk_author.TabIndex = 1;
            this.chk_author.Text = "Author";
            this.chk_author.UseVisualStyleBackColor = true;
            this.chk_author.CheckedChanged += new System.EventHandler(this.chk_author_CheckedChanged);
            // 
            // chk_ID
            // 
            this.chk_ID.AutoSize = true;
            this.chk_ID.Depth = 0;
            this.chk_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_ID.Location = new System.Drawing.Point(3, 29);
            this.chk_ID.Margin = new System.Windows.Forms.Padding(0);
            this.chk_ID.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_ID.Name = "chk_ID";
            this.chk_ID.Ripple = true;
            this.chk_ID.Size = new System.Drawing.Size(43, 30);
            this.chk_ID.TabIndex = 0;
            this.chk_ID.Text = "ID";
            this.chk_ID.UseVisualStyleBackColor = true;
            this.chk_ID.CheckedChanged += new System.EventHandler(this.chk_ID_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.g_level_filt);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.groupBox3.Location = new System.Drawing.Point(228, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 69);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grade Level";
            // 
            // g_level_filt
            // 
            this.g_level_filt.FormattingEnabled = true;
            this.g_level_filt.Items.AddRange(new object[] {
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10",
            "All"});
            this.g_level_filt.Location = new System.Drawing.Point(6, 29);
            this.g_level_filt.Name = "g_level_filt";
            this.g_level_filt.Size = new System.Drawing.Size(139, 25);
            this.g_level_filt.TabIndex = 0;
            this.g_level_filt.Text = "All";
            this.g_level_filt.SelectedIndexChanged += new System.EventHandler(this.g_level_filt_SelectedIndexChanged);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(201)))), ((int)(((byte)(170)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Access!";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(551, 506);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(201)))), ((int)(((byte)(170)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(201)))), ((int)(((byte)(170)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(133, 28);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Access!";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // results_lv
            // 
            this.results_lv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.results_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.results_lv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_lv.FullRowSelect = true;
            this.results_lv.GridLines = true;
            this.results_lv.Location = new System.Drawing.Point(28, 168);
            this.results_lv.MultiSelect = false;
            this.results_lv.Name = "results_lv";
            this.results_lv.Size = new System.Drawing.Size(656, 332);
            this.results_lv.TabIndex = 9;
            this.results_lv.UseCompatibleStateImageBehavior = false;
            this.results_lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Resource Name";
            this.columnHeader2.Width = 184;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author";
            this.columnHeader3.Width = 151;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tags";
            this.columnHeader4.Width = 268;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LearNAV.Properties.Resources.SPLASH1;
            this.pictureBox2.Location = new System.Drawing.Point(385, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Advance_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 545);
            this.Controls.Add(this.results_lv);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adsearch_txtbox);
            this.MaximizeBox = false;
            this.Name = "Advance_Search";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Advance Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox adsearch_txtbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialCheckBox chk_tag;
        private MaterialSkin.Controls.MaterialCheckBox chk_author;
        private MaterialSkin.Controls.MaterialCheckBox chk_ID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.ColumnHeader glevel;
        private System.Windows.Forms.ComboBox g_level_filt;
        private System.Windows.Forms.ListView results_lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}