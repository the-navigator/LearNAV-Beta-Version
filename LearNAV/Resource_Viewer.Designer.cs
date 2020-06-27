namespace LearNAV
{
    partial class Resource_Viewer
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
            this.resource_list = new MaterialSkin.Controls.MaterialListView();
            this.rname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rauthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LearNAV.Properties.Resources.Resource_Viewer;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // resource_list
            // 
            this.resource_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resource_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rname,
            this.rauthor,
            this.rtag});
            this.resource_list.Depth = 0;
            this.resource_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.resource_list.ForeColor = System.Drawing.Color.DarkCyan;
            this.resource_list.FullRowSelect = true;
            this.resource_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.resource_list.Location = new System.Drawing.Point(12, 46);
            this.resource_list.MouseLocation = new System.Drawing.Point(-1, -1);
            this.resource_list.MouseState = MaterialSkin.MouseState.OUT;
            this.resource_list.Name = "resource_list";
            this.resource_list.OwnerDraw = true;
            this.resource_list.Size = new System.Drawing.Size(414, 361);
            this.resource_list.TabIndex = 2;
            this.resource_list.UseCompatibleStateImageBehavior = false;
            this.resource_list.View = System.Windows.Forms.View.Details;
            this.resource_list.SelectedIndexChanged += new System.EventHandler(this.resource_list_SelectedIndexChanged);
            this.resource_list.DoubleClick += new System.EventHandler(this.resource_list_DoubleClick);
            // 
            // rname
            // 
            this.rname.Text = "Resource Name";
            this.rname.Width = 158;
            // 
            // rauthor
            // 
            this.rauthor.Text = "Author";
            this.rauthor.Width = 97;
            // 
            // rtag
            // 
            this.rtag.Text = "Tags";
            this.rtag.Width = 128;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resource_Viewer
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(438, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resource_list);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resource_Viewer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource_Viewer";
            this.Load += new System.EventHandler(this.Resource_Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialListView resource_list;
        private System.Windows.Forms.ColumnHeader rname;
        private System.Windows.Forms.ColumnHeader rauthor;
        private System.Windows.Forms.ColumnHeader rtag;
        private System.Windows.Forms.Button button1;

    }
}