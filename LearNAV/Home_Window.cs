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
using System.IO;



namespace LearNAV
{
    public partial class Home_Window : MetroFramework.Forms.MetroForm
    {


        DatabaseConnection con = new DatabaseConnection();
	//	Filter f = new Filter();
        private OleDbConnection db_cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + "\\" + "LearNAV_DB2.accdb");
        OleDbDataReader reader = null;
        OleDbCommand list_Con = new OleDbCommand();
        OleDbCommand comn = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        ListViewItem selected_to_open = new ListViewItem();
        string TotalNum;



        //search alg
        // private DataView dv;
        // private static Item_S[] item_s;



        public Home_Window()
        {
            InitializeComponent();
        }

        private void Home_Window_Load(object sender, EventArgs e)
        {
            search_results.Items.Clear();
            /*
            if (db_cn.State == ConnectionState.Open)
            {
                db_cn.Close();
                db_cn.Open();
                Load_Data("SELECT * FROM ResourceDB");


            }
            else if (db_cn.State == ConnectionState.Closed)
            {
                db_cn.Open();
                Load_Data("SELECT * FROM ResourceDB");

            }
            */

            InitialDataLoad();

            TotalNum = search_results.Items.Count.ToString();
            all_cnt.Text = TotalNum;




        }

        public void LoadData()
        {
            try
            {
                con.ShowFiltered();


                if (con.dt.Rows.Count > 0)
                {
                    for (int i = 0; i < con.dt.Rows.Count; i++)
                    {

                        DataRow dr = con.dt.Rows[i];
                        ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                        fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                        fetched_data.SubItems.Add(dr["ResourceLoc"].ToString());
                        search_results.Items.Add(fetched_data);

                    }
                }
                else
                    MessageBox.Show("No data were imported!" + " Counted Data: " + con.rowcount.ToString(),
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
            /*
            search_results.Items.Clear();
            if (db_cn.State == ConnectionState.Open)
            {
                db_cn.Close();
                db_cn.Open();
                Load_Data("SELECT * FROM ResourceDB WHERE ResourceN LIKE '%" + search_string_txtbox.Text + "%'");

            }
            else if (db_cn.State == ConnectionState.Closed)
            {
                db_cn.Open();
                Load_Data("SELECT * FROM ResourceDB WHERE ResourceN LIKE '%" + search_string_txtbox.Text + "%'");

            }
             * */
            try
            {
                Filter f = new Filter();
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
               // else
                    // MessageBox.Show("Unable to perform Search Query "  , "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
                // MessageBoxButtons answer = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show("Resource not found, extract resources from a file?", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                   // Resource_Extract_Tool frm = new Resource_Extract_Tool();
                    Extract frm = new Extract();
                    frm.Show();
                    //change this soon
                  //  this.Hide();
                   
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


    }
       


    }

