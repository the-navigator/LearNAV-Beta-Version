using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LearNAV
{
    public partial class Resource_Item : UserControl
    {




        public Resource_Item()
        {
            InitializeComponent();
        }

        #region Properties
        
        private string _rsc_name;
        private string _rsc_author;
        private string _rsc_id;
        private string _rsc_loc;
        string rsc_loc_exec;

        [Category("Custom")]
        public string RSC_ID
        {
            get { return _rsc_id; }
            set { _rsc_id = value; lbl_id.Text = value; }
        }
        [Category("Custom")]
        public string RSC_NAME
        {
            get { return _rsc_name; }
            set { _rsc_name = value; lbl_r_name.Text = value; }
        }
        [Category("Custom")]
        public string RSC_AUTHOR
        {
            get { return _rsc_author; }
            set { _rsc_author = value; lbl_author.Text = value; }
        }
        [Category("Custom")]
        public string RSC_LOC
        {
            get { return _rsc_loc; }
            set { _rsc_loc = value; rsc_loc_exec = value; }
        }
        #endregion


 private void Resource_Item_Load(object sender, EventArgs e)
        {
           // lbl_id.Text = _rsc_id;
           // lbl_r_name.Text = _rsc_name;
           // lbl_author.Text = _rsc_author;
            //just remember the location ok?

        }

         private void btn_access_Click(object sender, EventArgs e)
         {
            // OpenResourceSelected(_rsc_loc);
         }
         private void OpenResourceSelected(string item_r_path)
         {

             try
             {
                 System.Diagnostics.Process.Start(item_r_path);
             }
             catch (Exception e)
             {
                 DialogResult result = MessageBox.Show("Resource not found, extract resources from a file?", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                 if (result == DialogResult.OK)
                 {

                     Extract frm = new Extract();
                     frm.Show();
                 }
             }
         }
      
    }



    }

