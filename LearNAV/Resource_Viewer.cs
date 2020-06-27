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


namespace LearNAV
{
    public partial class Resource_Viewer : Form
    {
        private OleDbConnection db_cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + "\\" + "LearNAV_DB2.accdb");
        OleDbDataReader reader = null;
        OleDbCommand list_Con = new OleDbCommand();
        OleDbCommand comn = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        ListViewItem selected_to_open = new ListViewItem();



        public Resource_Viewer()
        {
            InitializeComponent();
        }

        private void Resource_Viewer_Load(object sender, EventArgs e)
        {
            db_cn.Open();
            Load_Data("SELECT * FROM ResourceDB");
           // MessageBox.Show(Environment.CurrentDirectory);
        }

        private void Load_Data(string filter)
        {
            comn.Connection = db_cn;
            comn.CommandText = filter;

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
                    resource_list.Items.Add(dt);


                }
            }
        }

        private void resource_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resource_list_DoubleClick(object sender, EventArgs e)
        {
            selected_to_open = resource_list.SelectedItems[0];
            OpenResource(Environment.CurrentDirectory + "\\ResourceFiles\\" + selected_to_open.SubItems[2].Text);
           // MessageBox.Show(Environment.CurrentDirectory + "ResourceFiles\\" + selected_to_open.SubItems[2].Text);
        }

        private void OpenResource(string item_r_path)
        {
           
            try
            {
                System.Diagnostics.Process.Start(item_r_path);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected_to_open = resource_list.SelectedItems[0];
            OpenResource(Environment.CurrentDirectory + "\\ResourceFiles\\" + selected_to_open.SubItems[2].Text);
        }
        
    }
}
