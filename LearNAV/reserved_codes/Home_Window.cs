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



namespace LearNAV
{
    public partial class Home_Window : Form
    {


        DatabaseConnection con = new DatabaseConnection();
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

            TotalNum = search_results.Items.Count.ToString();
            all_cnt.Text = TotalNum;




        }

     

        void InitialDataLoad(int id)
        {
            try
            {
                con.ShowFiltered(id);
            //    con.dt.Fill
                ListViewItem iniload = new ListViewItem();
                for (int i = 0; i < con.dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                    fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                    fetched_data.SubItems.Add(dr["ResourceLoc"].ToString());
                    search_results.Items.Add(fetched_data);

                }
            
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Load_Data(string comtext)
        {
                search_results.Items.Clear();
                comn.Connection = db_cn;
                comn.CommandText = comtext;
            

                    if (db_cn.State == ConnectionState.Open)
                    {
                        reader = comn.ExecuteReader();
                        while (reader.Read())
                        {



                            ListViewItem dt = new ListViewItem();
                            string search_var;


                            dt.Text = reader.GetValue(0).ToString(); //first column (ID)
                            search_var = reader.GetValue(1).ToString();

                            dt.SubItems.Add(reader.GetValue(1).ToString()); //second column (NAme)
                            dt.SubItems.Add(reader.GetValue(2).ToString()); //thir column  (Location)
                            search_results.Items.Add(dt);
                            current_cnt.Text = search_results.Items.Count.ToString();

                        }
                    
                }
          
          
            

        }
        /*
        public void VersionCheck()
        {

        }
         * */
        /*
        private void btn_searchtxt_Click(object sender, EventArgs e)
        {

            //search_results.Clear();
            search_results.Items.Clear();
            if (db_cn.State == ConnectionState.Open) {
                db_cn.Close();
                db_cn.Open();
                Load_Data("SELECT * FROM ResourceDB WHERE ResourceN LIKE '%" + search_string_txtbox.Text + "%'");
                if (search_results.Items.Count == 0)
                {
                    db_cn.Close();
                    MessageBox.Show("No resource was detected", "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (search_results.Items.Count > 1)
                {
                    db_cn.Close();
                    MessageBox.Show("Resource was found!");

                }
            }
            else if (db_cn.State == ConnectionState.Closed) {
                db_cn.Open();
                Load_Data("SELECT * FROM ResourceDB WHERE ResourceN LIKE '%" + search_string_txtbox.Text + "%'");
                if (search_results.Items.Count == 0)
                {
                    db_cn.Close();
                    MessageBox.Show("No resource was detected", "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (search_results.Items.Count > 1)
                {
                    db_cn.Close();
                    MessageBox.Show("Resource was found!");

                }
            }

          


           
           
        }
        */
        private void search_string_txtbox_OnValueChanged(object sender, EventArgs e)
        {
      
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
               // current_cnt.Text = search_results.Items.Count.ToString();
            }


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
                    Resource_Extract_Tool frm = new Resource_Extract_Tool();
                    frm.Show();
                    //change this soon
                    this.Hide();
                   
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
            this.Hide();

        }


    }
       


    }

