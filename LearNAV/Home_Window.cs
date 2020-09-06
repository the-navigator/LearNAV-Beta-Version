using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using LearNAV_Engine;
using MetroFramework;
using System.IO;



namespace LearNAV
{
    public partial class Home_Window : MetroFramework.Forms.MetroForm
    {


        DatabaseConnection LNEngine_con = new DatabaseConnection();
        //Database Connection is a class in LearNAV Engine. Check LearNAV Engine to edit function.
        static string connection_string = "DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3"; //Datbase is yet to be finished
       /* GLOBAL VARIABLES */
       /*  ----------------------------------------------- */
        SQLiteConnection db_cn = new SQLiteConnection(connection_string);
        SQLiteDataReader reader = null; 
        SQLiteCommand list_Con = new SQLiteCommand();
        SQLiteCommand comn = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataTable dt = new DataTable();
        ListViewItem selected_to_open = new ListViewItem();

        string TotalNum;
       /*  ----------------------------------------------- */
       // NO VARIABLES were made for each column //


        public Home_Window()
        {
            InitializeComponent();
        }

        private void Home_Window_Load(object sender, EventArgs e)
        {
            search_results.Items.Clear();
            InitialDataLoad();
            TotalNum = search_results.Items.Count.ToString();
            all_cnt.Text = TotalNum;
        }

        public void LoadData()
        {
            try
            {
                LNEngine_con.ShowFiltered();


                if (LNEngine_con.dt.Rows.Count > 0)
                {
                    for (int i = 0; i < LNEngine_con.dt.Rows.Count; i++)
                    {

                        DataRow dr = LNEngine_con.dt.Rows[i];
                        ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                        fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                        fetched_data.SubItems.Add(dr["ResourceLoc"].ToString());
                        search_results.Items.Add(fetched_data);

                    }
                }
                else

                    MessageBox.Show("No data were imported!" + " Counted Data: " + LNEngine_con.rowcount.ToString(),
                        "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void InitialDataLoad()
        {
            if (File.Exists(Environment.CurrentDirectory + "\\ResourceFiles\\version.txt"))
            {
                LoadData();

            }else
            {
                MessageBox.Show("No Resource Files Detected! Please import resources first!", "Error!", MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                Extract frm = new Extract();
                frm.Show();
                frm.Focus();
                this.Hide();
            }
        }
      
        private void search_string_txtbox_OnValueChanged(object sender, EventArgs e)
        {
      
           //insert code here

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Resource_Viewer frm = new Resource_Viewer();
            frm.Show();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            Advance_Search frm2 = new Advance_Search();
            frm2.Show();
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
           
        }

        private void content_ratio_bar_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void search_string_txtbox_OnValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                Filter f = new Filter(); //Filter is a LearNAV Engine Class.
                search_results.Items.Clear();
                f.FilterName(search_string_txtbox.Text);
             

                if (f.dt.Rows.Count > 0)
                {
                    for (int i = 0; i < f.dt.Rows.Count; i++)
                    {

                        DataRow dr = f.dt.Rows[i];
                        ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                        fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                        fetched_data.SubItems.Add(dr["ResourceLoc"].ToString());
                        search_results.Items.Add(fetched_data);
                     

                        
                    }
                }
               else
                    MessageBox.Show("Unable to perform Search Query"  , "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }

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


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            selected_to_open = search_results.SelectedItems[0];
            OpenResourceSelected(Environment.CurrentDirectory + "\\ResourceFiles\\" + selected_to_open.SubItems[2].Text);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Advance_Search frm2 = new Advance_Search();
            frm2.Show();
        }

        private void btn_acs_Click(object sender, EventArgs e)
        {
            selected_to_open = search_results.SelectedItems[0];
            OpenResourceSelected(Environment.CurrentDirectory + "\\ResourceFiles\\" + selected_to_open.SubItems[2].Text);
        }


    }
       


    }

