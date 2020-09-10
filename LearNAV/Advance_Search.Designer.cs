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
            this.components = new System.ComponentModel.Container();
            this.results_lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_accs = new Guna.UI2.WinForms.Guna2GradientButton();
            this.grp_filter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.g_level_filt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grp_sp_filters = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chk_tag = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chk_author = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chk_ID = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btn_advanced = new Guna.UI2.WinForms.Guna2Button();
            this.adsearch_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.exit_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl1.SuspendLayout();
            this.grp_filter.SuspendLayout();
            this.grp_sp_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.results_lv.Location = new System.Drawing.Point(10, 113);
            this.results_lv.MultiSelect = false;
            this.results_lv.Name = "results_lv";
            this.results_lv.Size = new System.Drawing.Size(632, 394);
            this.results_lv.TabIndex = 9;
            this.results_lv.UseCompatibleStateImageBehavior = false;
            this.results_lv.View = System.Windows.Forms.View.Details;
            this.results_lv.SelectedIndexChanged += new System.EventHandler(this.results_lv_SelectedIndexChanged);
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
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tags";
            this.columnHeader4.Width = 268;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.pnl1.Controls.Add(this.results_lv);
            this.pnl1.Controls.Add(this.btn_accs);
            this.pnl1.Controls.Add(this.grp_filter);
            this.pnl1.Controls.Add(this.grp_sp_filters);
            this.pnl1.Controls.Add(this.btn_advanced);
            this.pnl1.Controls.Add(this.adsearch_txtbox);
            this.pnl1.Controls.Add(this.pictureBox2);
            this.pnl1.Location = new System.Drawing.Point(12, 57);
            this.pnl1.Name = "pnl1";
            this.pnl1.ShadowDecoration.Parent = this.pnl1;
            this.pnl1.Size = new System.Drawing.Size(660, 575);
            this.pnl1.TabIndex = 10;
            // 
            // btn_accs
            // 
            this.btn_accs.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btn_accs.CheckedState.Parent = this.btn_accs;
            this.btn_accs.CustomImages.Parent = this.btn_accs;
            this.btn_accs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(127)))));
            this.btn_accs.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(154)))));
            this.btn_accs.Font = new System.Drawing.Font("Gelion Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accs.ForeColor = System.Drawing.Color.White;
            this.btn_accs.HoverState.Parent = this.btn_accs;
            this.btn_accs.Location = new System.Drawing.Point(459, 502);
            this.btn_accs.Name = "btn_accs";
            this.btn_accs.ShadowDecoration.Parent = this.btn_accs;
            this.btn_accs.Size = new System.Drawing.Size(183, 38);
            this.btn_accs.TabIndex = 24;
            this.btn_accs.Text = "Access";
            // 
            // grp_filter
            // 
            this.grp_filter.BackColor = System.Drawing.Color.Transparent;
            this.grp_filter.BorderThickness = 2;
            this.grp_filter.Controls.Add(this.g_level_filt);
            this.grp_filter.CustomBorderThickness = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.grp_filter.FillColor = System.Drawing.Color.Transparent;
            this.grp_filter.Font = new System.Drawing.Font("Gelion Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_filter.ForeColor = System.Drawing.Color.White;
            this.grp_filter.Location = new System.Drawing.Point(205, 46);
            this.grp_filter.Name = "grp_filter";
            this.grp_filter.ShadowDecoration.Parent = this.grp_filter;
            this.grp_filter.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.grp_filter.Size = new System.Drawing.Size(190, 64);
            this.grp_filter.TabIndex = 14;
            this.grp_filter.Text = "Grade Level Filter";
            // 
            // g_level_filt
            // 
            this.g_level_filt.BackColor = System.Drawing.Color.Transparent;
            this.g_level_filt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.g_level_filt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.g_level_filt.FocusedColor = System.Drawing.Color.Empty;
            this.g_level_filt.FocusedState.Parent = this.g_level_filt;
            this.g_level_filt.Font = new System.Drawing.Font("Gelion Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g_level_filt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.g_level_filt.FormattingEnabled = true;
            this.g_level_filt.HoverState.Parent = this.g_level_filt;
            this.g_level_filt.ItemHeight = 17;
            this.g_level_filt.Items.AddRange(new object[] {
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10",
            "All"});
            this.g_level_filt.ItemsAppearance.Parent = this.g_level_filt;
            this.g_level_filt.Location = new System.Drawing.Point(12, 30);
            this.g_level_filt.Name = "g_level_filt";
            this.g_level_filt.ShadowDecoration.BorderRadius = 15;
            this.g_level_filt.ShadowDecoration.Parent = this.g_level_filt;
            this.g_level_filt.Size = new System.Drawing.Size(165, 23);
            this.g_level_filt.TabIndex = 24;
            this.g_level_filt.SelectedIndexChanged += new System.EventHandler(this.g_level_filt_SelectedIndexChanged_1);
            // 
            // grp_sp_filters
            // 
            this.grp_sp_filters.BackColor = System.Drawing.Color.Transparent;
            this.grp_sp_filters.BorderThickness = 2;
            this.grp_sp_filters.Controls.Add(this.chk_tag);
            this.grp_sp_filters.Controls.Add(this.chk_author);
            this.grp_sp_filters.Controls.Add(this.chk_ID);
            this.grp_sp_filters.CustomBorderThickness = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.grp_sp_filters.FillColor = System.Drawing.Color.Transparent;
            this.grp_sp_filters.Font = new System.Drawing.Font("Gelion Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_sp_filters.ForeColor = System.Drawing.Color.White;
            this.grp_sp_filters.Location = new System.Drawing.Point(10, 46);
            this.grp_sp_filters.Name = "grp_sp_filters";
            this.grp_sp_filters.ShadowDecoration.Parent = this.grp_sp_filters;
            this.grp_sp_filters.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.grp_sp_filters.Size = new System.Drawing.Size(190, 64);
            this.grp_sp_filters.TabIndex = 12;
            this.grp_sp_filters.Text = "Specific Category Filters";
            // 
            // chk_tag
            // 
            this.chk_tag.AutoSize = true;
            this.chk_tag.BackColor = System.Drawing.Color.Transparent;
            this.chk_tag.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_tag.CheckedState.BorderRadius = 2;
            this.chk_tag.CheckedState.BorderThickness = 0;
            this.chk_tag.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_tag.Font = new System.Drawing.Font("Gelion Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_tag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_tag.Location = new System.Drawing.Point(134, 34);
            this.chk_tag.Name = "chk_tag";
            this.chk_tag.Size = new System.Drawing.Size(55, 20);
            this.chk_tag.TabIndex = 13;
            this.chk_tag.Text = "Tags";
            this.chk_tag.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_tag.UncheckedState.BorderRadius = 2;
            this.chk_tag.UncheckedState.BorderThickness = 0;
            this.chk_tag.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_tag.UseVisualStyleBackColor = false;
            this.chk_tag.CheckedChanged += new System.EventHandler(this.chk_tag_CheckedChanged_1);
            // 
            // chk_author
            // 
            this.chk_author.AutoSize = true;
            this.chk_author.BackColor = System.Drawing.Color.Transparent;
            this.chk_author.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_author.CheckedState.BorderRadius = 2;
            this.chk_author.CheckedState.BorderThickness = 0;
            this.chk_author.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_author.Font = new System.Drawing.Font("Gelion Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_author.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_author.Location = new System.Drawing.Point(59, 34);
            this.chk_author.Name = "chk_author";
            this.chk_author.Size = new System.Drawing.Size(65, 20);
            this.chk_author.TabIndex = 12;
            this.chk_author.Text = "Author";
            this.chk_author.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_author.UncheckedState.BorderRadius = 2;
            this.chk_author.UncheckedState.BorderThickness = 0;
            this.chk_author.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_author.UseVisualStyleBackColor = false;
            this.chk_author.CheckedChanged += new System.EventHandler(this.chk_author_CheckedChanged_1);
            // 
            // chk_ID
            // 
            this.chk_ID.AutoSize = true;
            this.chk_ID.BackColor = System.Drawing.Color.Transparent;
            this.chk_ID.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_ID.CheckedState.BorderRadius = 2;
            this.chk_ID.CheckedState.BorderThickness = 0;
            this.chk_ID.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_ID.Font = new System.Drawing.Font("Gelion Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_ID.Location = new System.Drawing.Point(13, 34);
            this.chk_ID.Name = "chk_ID";
            this.chk_ID.Size = new System.Drawing.Size(40, 20);
            this.chk_ID.TabIndex = 11;
            this.chk_ID.Text = "ID";
            this.chk_ID.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_ID.UncheckedState.BorderRadius = 2;
            this.chk_ID.UncheckedState.BorderThickness = 0;
            this.chk_ID.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_ID.UseVisualStyleBackColor = false;
            this.chk_ID.CheckedChanged += new System.EventHandler(this.chk_ID_CheckedChanged_1);
            // 
            // btn_advanced
            // 
            this.btn_advanced.CheckedState.Parent = this.btn_advanced;
            this.btn_advanced.CustomImages.Parent = this.btn_advanced;
            this.btn_advanced.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(121)))));
            this.btn_advanced.Font = new System.Drawing.Font("Gelion Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_advanced.ForeColor = System.Drawing.Color.White;
            this.btn_advanced.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.btn_advanced.HoverState.Parent = this.btn_advanced;
            this.btn_advanced.Location = new System.Drawing.Point(502, 4);
            this.btn_advanced.Name = "btn_advanced";
            this.btn_advanced.ShadowDecoration.Parent = this.btn_advanced;
            this.btn_advanced.Size = new System.Drawing.Size(140, 33);
            this.btn_advanced.TabIndex = 23;
            this.btn_advanced.Text = "Perform Search";
            this.btn_advanced.Click += new System.EventHandler(this.btn_advanced_Click);
            // 
            // adsearch_txtbox
            // 
            this.adsearch_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adsearch_txtbox.DefaultText = "Enter keywords...";
            this.adsearch_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adsearch_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adsearch_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adsearch_txtbox.DisabledState.Parent = this.adsearch_txtbox;
            this.adsearch_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adsearch_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adsearch_txtbox.FocusedState.Parent = this.adsearch_txtbox;
            this.adsearch_txtbox.Font = new System.Drawing.Font("Gelion Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsearch_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adsearch_txtbox.HoverState.Parent = this.adsearch_txtbox;
            this.adsearch_txtbox.Location = new System.Drawing.Point(10, 4);
            this.adsearch_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adsearch_txtbox.Name = "adsearch_txtbox";
            this.adsearch_txtbox.PasswordChar = '\0';
            this.adsearch_txtbox.PlaceholderText = "";
            this.adsearch_txtbox.SelectedText = "";
            this.adsearch_txtbox.SelectionStart = 17;
            this.adsearch_txtbox.ShadowDecoration.Parent = this.adsearch_txtbox;
            this.adsearch_txtbox.Size = new System.Drawing.Size(499, 33);
            this.adsearch_txtbox.TabIndex = 0;
            this.adsearch_txtbox.TextChanged += new System.EventHandler(this.adsearch_txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gelion Black", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Advanced Search";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnl1;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.pnl1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            this.guna2Elipse3.TargetControl = this.btn_accs;
            // 
            // exit_btn
            // 
            this.exit_btn.CheckedState.Parent = this.exit_btn;
            this.exit_btn.CustomImages.Parent = this.exit_btn;
            this.exit_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.HoverState.Parent = this.exit_btn;
            this.exit_btn.Location = new System.Drawing.Point(657, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exit_btn.ShadowDecoration.Parent = this.exit_btn;
            this.exit_btn.Size = new System.Drawing.Size(15, 15);
            this.exit_btn.TabIndex = 25;
            this.exit_btn.Text = "guna2CircleButton1";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LearNAV.Properties.Resources.SPLASH1;
            this.pictureBox2.Location = new System.Drawing.Point(401, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Advance_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(685, 654);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Advance_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advance Search";
            this.pnl1.ResumeLayout(false);
            this.grp_filter.ResumeLayout(false);
            this.grp_sp_filters.ResumeLayout(false);
            this.grp_sp_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader glevel;
        public Guna.UI2.WinForms.Guna2Panel pnl1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ListView results_lv;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public Guna.UI2.WinForms.Guna2TextBox adsearch_txtbox;
        public Guna.UI2.WinForms.Guna2Button btn_advanced;
        public Guna.UI2.WinForms.Guna2GroupBox grp_sp_filters;
        public Guna.UI2.WinForms.Guna2CheckBox chk_tag;
        public Guna.UI2.WinForms.Guna2CheckBox chk_author;
        public Guna.UI2.WinForms.Guna2CheckBox chk_ID;
        public Guna.UI2.WinForms.Guna2GroupBox grp_filter;
        public Guna.UI2.WinForms.Guna2ComboBox g_level_filt;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public Guna.UI2.WinForms.Guna2GradientButton btn_accs;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        public Guna.UI2.WinForms.Guna2CircleButton exit_btn;
    }
}