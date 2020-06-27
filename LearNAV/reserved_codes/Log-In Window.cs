using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// For the Database
using System.Data.OleDb;
using System.IO;

namespace LearNAV
{
    public partial class LogIn_Window : Form
    {
        /* 
         * Log-In System forked from the original "The Navigator
         * Check for bugs and errors for Database
         * System:
         * 1. Setup Connection to the Database
         * 2. When Log-In Button is cliked, will check for the user's profile within the Database
         * 3. Logs in the current user.
         * 
         * Coding: juju ^_^
         */
        private OleDbConnection lgin_cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + "\\" + "LearNAV_DB2.accdb");
       // OleDbDataAdapter da;
        OleDbDataReader reader = null;
        OleDbCommand CheckProfile = new OleDbCommand();
        // OleDbCommand name_set = new OleDbCommand();

        public LogIn_Window()
        {
            InitializeComponent();

            //checks for LearNAV Engine
            if (!!File.Exists(Environment.CurrentDirectory + "LearNAV Engine.dll"))
            {
                this.Hide();
                Application.Exit();
           MessageBox.Show("LearNAV_Engine.dll is missing from your computer", "Initalization Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
              
               






            }
        }
        // Error Handler, to check for missing Values on the fields of textboxes.

        private void Error_Handler()
        {
           MessageBox.Show
                ("Incomplete Data, Please fill all text fields", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

            if (lgin_username_textbox.Text == "")
            {
                lgin_username_textbox.Focus();

            }
            else if (lgin_password_textbox.Text == "")
            {

                lgin_password_textbox.Focus();

            }
        }
        private void Log_In_Button_Click(object sender, EventArgs e)
        {
            //check if password is present
            if (lgin_username_textbox.Text == "")
            {

                Error_Handler();


            }
            else if (lgin_password_textbox.Text == "")
            {

                Error_Handler();

            }
            else
            {

                Log_In(lgin_username_textbox.Text, lgin_password_textbox.Text);

            }

        }

        private void Log_In(string username_txt, string password_txt)
        {
            lgin_cn.Open();
            CheckProfile.Connection = lgin_cn;
            CheckProfile.CommandText = "select * from ProfileDBSt where FirstN= '" + username_txt + "' AND LRN= '" + password_txt + "'";
            reader = CheckProfile.ExecuteReader();
            int lgin = 0;
            while (reader.Read())
            {

                lgin = lgin + 1;


            }
            if (lgin == 1)
            {
                //MainBrowser_Navig_form frm1 = new MainBrowser_Navig_form(); PLEASE INSERT NEW FORM
                Home_Window frm_main = new Home_Window();
                frm_main.Show();


                lgin_cn.Close();



                //frm1.Show();
                this.Hide();





            }


            if (lgin > 1)
            {
                lgin_cn.Open();

                reader = CheckProfile.ExecuteReader();

                MessageBox.Show("Duplicate Account, Invalid.");
                lgin_cn.Close();
                reader = CheckProfile.ExecuteReader();




            }

            if (lgin < 1)
            {
                lgin_cn.Close();

                lgin_cn.Open();


                MessageBox.Show("User not Detected", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                lgin_cn.Close();

                lgin_cn.Close();


            }
        }

        private void Log_In_Button_Click_1(object sender, EventArgs e)
        {
            //check if password is present
            if (lgin_username_textbox.Text == "")
            {

                Error_Handler();


            }
            else if (lgin_password_textbox.Text == "")
            {

                Error_Handler();

            }
            else
            {

                Log_In(lgin_username_textbox.Text, lgin_password_textbox.Text);

            }
        }

       

        private void lgin_password_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Enter))
            {
                if (lgin_username_textbox.Text == "")
                {

                    Error_Handler();


                }
                else if (lgin_password_textbox.Text == "")
                {


                    Error_Handler();
                }
                else
                {

                    Log_In(lgin_username_textbox.Text, lgin_password_textbox.Text);

                }


            }

            if (e.KeyCode == (Keys.Up))
            {

                lgin_username_textbox.Focus();


            }
        }

        private void lgin_username_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (lgin_password_textbox.Text == "")
                {


                    Error_Handler();

                }
                else if (lgin_username_textbox.Text == "")
                {


                    Error_Handler();

                }
                else
                {


                    Log_In(lgin_username_textbox.Text, lgin_password_textbox.Text);

                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                lgin_password_textbox.Focus();

            }
        }

        private void lgin_username_textbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void LogIn_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Close();
            }
        }


    }

}
