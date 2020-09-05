using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using LearNAV_Engine;
using MetroFramework;

namespace LearNAV
{
    public partial class Advance_Search : MetroFramework.Forms.MetroForm
    {

        ListViewItem selected_to_open = new ListViewItem();

        public int glevel_int;
        public int type;
        public Advance_Search()
        {
            InitializeComponent();
        }

        private void adsearch_txtbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (adsearch_txtbox.Text == "Enter keywords")
            {
                adsearch_txtbox.Text = "";

            }
        }
        
        private void btn_search_ad_Click(object sender, EventArgs e)
        {
        }


        private void LoadData()
        {

        }

        private void chk_ID_CheckedChanged(object sender, EventArgs e)
        {

            //chk_ID.Checked = true;
            if (chk_author.Checked == true)
            {
                chk_author.Checked = false;
                type = 1;

            }
            if (chk_tag.Checked == true)
            {
                chk_tag.Checked = false;
                type = 1;
            }
            type = 1;
            adsearch_txtbox.Focus();
        }

        private void chk_author_CheckedChanged(object sender, EventArgs e)
        {
            // chk_author.Checked = true;
            if (chk_ID.Checked == true)
            {
                chk_ID.Checked = false;
                type = 2;
            }
            if (chk_tag.Checked == true)
            {
                chk_tag.Checked = false;
                type = 2;

            }
            type = 2;
            adsearch_txtbox.Focus();
        }

        private void chk_tag_CheckedChanged(object sender, EventArgs e)
        {
            // chk_tag.Checked = true;
            if (chk_author.Checked == true)
            {
                chk_author.Checked = false;
                type = 3;

            }
            if (chk_ID.Checked == true)
            {
                chk_ID.Checked = false;
                type = 3;

            }
            type = 3;
            adsearch_txtbox.Focus();
        }

        private void adsearch_txtbox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(adsearch_txtbox.Text) == true)
                {
                    MessageBox.Show("Please place correct search keywords", "Error",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
                else

                    search_type();


            }
        }










        private void display_data()
        {

        }

        private void g_levelfilter_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void adsearch_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            // remove first
            if (adsearch_txtbox.Text == "Enter keywords...")
            {
                adsearch_txtbox.Text = "";
            }
            //
            if (type == 0)
            {
                MessageBox.Show("Please select a search category", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                search_type();
            }
        }


        private void search_type()
        {

            AdvanceSearching a = new AdvanceSearching();
            if (g_level_filt.SelectedItem.ToString() == "" | g_level_filt.SelectedItem.ToString() == "All" 
            | String.IsNullOrWhiteSpace(g_level_filt.SelectedItem.ToString()))
            {
                switch (type)
                {
                    case 1:
                        a.perform_search("ID", adsearch_txtbox.Text, "");
                        results_lv.Items.Clear();
                        if (a.dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < a.dt.Rows.Count; i++)
                            {

                                DataRow dr = a.dt.Rows[i];
                                ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                                fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                                fetched_data.SubItems.Add(dr["Author"].ToString());
                                //  fetched_data.SubItems.Add(dr["GradeLevel"].ToString());
                                fetched_data.SubItems.Add(dr["w_tags"].ToString());
                                results_lv.Items.Add(fetched_data);



                            }
                        }
                        break;
                    case 2:
                        a.perform_search("Author", adsearch_txtbox.Text, "");
                        results_lv.Items.Clear();
                        if (a.dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < a.dt.Rows.Count; i++)
                            {

                                DataRow dr = a.dt.Rows[i];
                                ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                                fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                                fetched_data.SubItems.Add(dr["Author"].ToString());
                                //   fetched_data.SubItems.Add(dr["GradeLevel"].ToString());
                                fetched_data.SubItems.Add(dr["w_tags"].ToString());

                                results_lv.Items.Add(fetched_data);



                            }
                        }
                        break;
                    case 3:
                        a.perform_search("Tags", adsearch_txtbox.Text, "");
                        results_lv.Items.Clear();
                        if (a.dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < a.dt.Rows.Count; i++)
                            {

                                DataRow dr = a.dt.Rows[i];
                                ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                                fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                                fetched_data.SubItems.Add(dr["Author"].ToString());
                                // fetched_data.SubItems.Add(dr["GradeLevel"].ToString());
                                fetched_data.SubItems.Add(dr["w_tags"].ToString());
                                results_lv.Items.Add(fetched_data);



                            }
                        }
                        break;
                }

            }
            else
            {
                switch (glevel_int)
                {
                    case 11:
                        g_level_filtered_comms("G7");
                        break;
                    case 12:
                        g_level_filtered_comms("G8");
                        break;
                    case 13:
                        g_level_filtered_comms("G9");
                        break;
                    case 14:
                        g_level_filtered_comms("G10");
                        break;
                        //ADD CODES HERE
                }
            }
        }


        private void g_level_filt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (g_level_filt.SelectedItem.ToString())
            {
                case "Grade 7":
                    glevel_int = 11;
                    break;
                case "Grade 8":
                    glevel_int = 12;
                    break;
                case "Grade 9":
                    glevel_int = 13;
                    break;
                case "Grade 10":
                    glevel_int = 14;
                    break;

                    //ADD CODES HERE

            }
            adsearch_txtbox.Focus();
        }
        private void g_level_filtered_comms(string glevel)
        {
            AdvanceSearching a = new AdvanceSearching();
            switch (type)
            {
                case 1:
                    a.perform_search("ID", adsearch_txtbox.Text, glevel);
                    results_lv.Items.Clear();
                    if (a.dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < a.dt.Rows.Count; i++)
                        {

                            DataRow dr = a.dt.Rows[i];
                            ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                            fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                            fetched_data.SubItems.Add(dr["Author"].ToString());
                            //  fetched_data.SubItems.Add(dr["GradeLevel"].ToString());
                            fetched_data.SubItems.Add(dr["w_tags"].ToString());
                            results_lv.Items.Add(fetched_data);



                        }
                    }
                    break;
                case 2:
                    a.perform_search("Author", adsearch_txtbox.Text, glevel);
                    results_lv.Items.Clear();
                    if (a.dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < a.dt.Rows.Count; i++)
                        {

                            DataRow dr = a.dt.Rows[i];
                            ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                            fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                            fetched_data.SubItems.Add(dr["Author"].ToString());
                            //   fetched_data.SubItems.Add(dr["GradeLevel"].ToString());
                            fetched_data.SubItems.Add(dr["w_tags"].ToString());

                            results_lv.Items.Add(fetched_data);



                        }
                    }
                    break;
                case 3:
                    a.perform_search("Tags", adsearch_txtbox.Text, glevel);
                    results_lv.Items.Clear();
                    if (a.dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < a.dt.Rows.Count; i++)
                        {

                            DataRow dr = a.dt.Rows[i];
                            ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                            fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                            fetched_data.SubItems.Add(dr["Author"].ToString());
                            // fetched_data.SubItems.Add(dr["GradeLevel"].ToString());
                            fetched_data.SubItems.Add(dr["w_tags"].ToString());
                            results_lv.Items.Add(fetched_data);



                        }
                    }
                    break;
            }












        }
    }
}

        
    

