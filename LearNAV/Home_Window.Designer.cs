namespace LearNAV
{
    partial class Home_Window
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
            this.search_results = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btn_acs = new MaterialSkin.Controls.MaterialFlatButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_query = new Guna.UI2.WinForms.Guna2Button();
            this.btn_chck_rsc_Data = new Guna.UI2.WinForms.Guna2Button();
            this.btn_accs = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.search_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.frm_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtbox_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bttnacess = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // search_results
            // 
            this.search_results.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader2,
            this.columnHeader3});
            this.search_results.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.search_results.FullRowSelect = true;
            this.search_results.Location = new System.Drawing.Point(28, 347);
            this.search_results.Name = "search_results";
            this.search_results.Size = new System.Drawing.Size(801, 233);
            this.search_results.TabIndex = 4;
            this.search_results.UseCompatibleStateImageBehavior = false;
            this.search_results.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Resource";
            this.columnHeader3.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(512, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "or";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search Results:";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Advance Search";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(201)))), ((int)(((byte)(170)))));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(536, 56);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(172, 31);
            this.bunifuFlatButton3.TabIndex = 16;
            this.bunifuFlatButton3.Text = "Advance Search";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(201)))), ((int)(((byte)(170)))));
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(23, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quick Search";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(842, 634);
            this.shapeContainer1.TabIndex = 21;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Teal;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 700;
            this.lineShape1.X2 = 700;
            this.lineShape1.Y1 = 27;
            this.lineShape1.Y2 = -27;
            // 
            // btn_acs
            // 
            this.btn_acs.AutoSize = true;
            this.btn_acs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_acs.Depth = 0;
            this.btn_acs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acs.Icon = null;
            this.btn_acs.Location = new System.Drawing.Point(47, 583);
            this.btn_acs.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_acs.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_acs.Name = "btn_acs";
            this.btn_acs.Primary = false;
            this.btn_acs.Size = new System.Drawing.Size(144, 36);
            this.btn_acs.TabIndex = 26;
            this.btn_acs.Text = "Access Resource";
            this.btn_acs.UseVisualStyleBackColor = true;
            this.btn_acs.Click += new System.EventHandler(this.btn_acs_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.guna2Panel1.Controls.Add(this.btn_query);
            this.guna2Panel1.Controls.Add(this.btn_chck_rsc_Data);
            this.guna2Panel1.Controls.Add(this.btn_accs);
            this.guna2Panel1.Controls.Add(this.btn_acs);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton1);
            this.guna2Panel1.Controls.Add(this.search_box);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(842, 634);
            this.guna2Panel1.TabIndex = 27;
            // 
            // btn_query
            // 
            this.btn_query.CheckedState.Parent = this.btn_query;
            this.btn_query.CustomImages.Parent = this.btn_query;
            this.btn_query.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btn_query.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_query.ForeColor = System.Drawing.Color.White;
            this.btn_query.HoverState.Parent = this.btn_query;
            this.btn_query.Location = new System.Drawing.Point(28, 571);
            this.btn_query.Name = "btn_query";
            this.btn_query.Padding = new System.Windows.Forms.Padding(15);
            this.btn_query.ShadowDecoration.Parent = this.btn_query;
            this.btn_query.Size = new System.Drawing.Size(88, 32);
            this.btn_query.TabIndex = 30;
            this.btn_query.Text = "Query";
            // 
            // btn_chck_rsc_Data
            // 
            this.btn_chck_rsc_Data.CheckedState.Parent = this.btn_chck_rsc_Data;
            this.btn_chck_rsc_Data.CustomImages.Parent = this.btn_chck_rsc_Data;
            this.btn_chck_rsc_Data.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(108)))), ((int)(((byte)(83)))));
            this.btn_chck_rsc_Data.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_chck_rsc_Data.ForeColor = System.Drawing.Color.White;
            this.btn_chck_rsc_Data.HoverState.Parent = this.btn_chck_rsc_Data;
            this.btn_chck_rsc_Data.Location = new System.Drawing.Point(463, 571);
            this.btn_chck_rsc_Data.Name = "btn_chck_rsc_Data";
            this.btn_chck_rsc_Data.Padding = new System.Windows.Forms.Padding(15);
            this.btn_chck_rsc_Data.ShadowDecoration.Parent = this.btn_chck_rsc_Data;
            this.btn_chck_rsc_Data.Size = new System.Drawing.Size(180, 45);
            this.btn_chck_rsc_Data.TabIndex = 29;
            this.btn_chck_rsc_Data.Text = "Check Resource Data";
            // 
            // btn_accs
            // 
            this.btn_accs.CheckedState.Parent = this.btn_accs;
            this.btn_accs.CustomImages.Parent = this.btn_accs;
            this.btn_accs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.btn_accs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_accs.ForeColor = System.Drawing.Color.White;
            this.btn_accs.HoverState.Parent = this.btn_accs;
            this.btn_accs.Location = new System.Drawing.Point(649, 571);
            this.btn_accs.Name = "btn_accs";
            this.btn_accs.Padding = new System.Windows.Forms.Padding(15);
            this.btn_accs.ShadowDecoration.Parent = this.btn_accs;
            this.btn_accs.Size = new System.Drawing.Size(180, 45);
            this.btn_accs.TabIndex = 28;
            this.btn_accs.Text = "Access Resource";
            this.btn_accs.Click += new System.EventHandler(this.btn_accs_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(297, 535);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton1.TabIndex = 28;
            this.guna2GradientButton1.Text = "guna2GradientButton1";
            // 
            // search_box
            // 
            this.search_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_box.DefaultText = "";
            this.search_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_box.DisabledState.Parent = this.search_box;
            this.search_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_box.FocusedState.Parent = this.search_box;
            this.search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_box.HoverState.Parent = this.search_box;
            this.search_box.Location = new System.Drawing.Point(28, 55);
            this.search_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_box.Name = "search_box";
            this.search_box.PasswordChar = '\0';
            this.search_box.PlaceholderText = "";
            this.search_box.SelectedText = "";
            this.search_box.ShadowDecoration.Parent = this.search_box;
            this.search_box.Size = new System.Drawing.Size(477, 32);
            this.search_box.TabIndex = 7;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // frm_elipse
            // 
            this.frm_elipse.BorderRadius = 19;
            this.frm_elipse.TargetControl = this;
            // 
            // txtbox_elipse
            // 
            this.txtbox_elipse.BorderRadius = 30;
            this.txtbox_elipse.TargetControl = this.search_box;
            // 
            // bttnacess
            // 
            this.bttnacess.BorderRadius = 17;
            this.bttnacess.TargetControl = this.btn_accs;
            // 
            // btn2
            // 
            this.btn2.BorderRadius = 17;
            this.btn2.TargetControl = this.btn_chck_rsc_Data;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 17;
            this.guna2Elipse2.TargetControl = this.btn_query;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::LearNAV.Properties.Resources.settings1;
            
            this.pictureBox4.Location = new System.Drawing.Point(733, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::LearNAV.Properties.Resources.question;
            this.pictureBox3.Location = new System.Drawing.Point(776, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LearNAV.Properties.Resources.greetfin;
            this.pictureBox2.Location = new System.Drawing.Point(28, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(801, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Home_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(842, 634);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_results);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Home_Window";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Home_Window_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView search_results;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialFlatButton btn_acs;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse frm_elipse;
        private Guna.UI2.WinForms.Guna2Elipse txtbox_elipse;
        private Guna.UI2.WinForms.Guna2TextBox search_box;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2Button btn_accs;
        private Guna.UI2.WinForms.Guna2Elipse bttnacess;
        private Guna.UI2.WinForms.Guna2Button btn_query;
        private Guna.UI2.WinForms.Guna2Button btn_chck_rsc_Data;
        private Guna.UI2.WinForms.Guna2Elipse btn2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;

    }
}