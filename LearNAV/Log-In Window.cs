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
using LearNAV_Engine;
using System.Threading
;

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
       
        LoadData l = new LoadData();
        
        public LogIn_Window()
        {
            InitializeComponent();

            //checks for LearNAV Engine
            /*
            if (!File.Exists(Environment.CurrentDirectory + "LearNAV Engine.dll"))
            {
                MessageBox.Show("LearNAV_Engine.dll is missing from your computer", 
                    "Initalization Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                Application.Exit();
          
            }
             * */
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

                //Log_In(lgin_username_textbox.Text, lgin_password_textbox.Text);
                LogInUser(lgin_username_textbox.Text, lgin_password_textbox.Text);

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

               // Log_In(lgin_username_textbox.Text, lgin_password_textbox.Text);
                LogInUser(lgin_username_textbox.Text, lgin_password_textbox.Text);


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

                    //Log_In(lgin_username_textbox.Text, lgin_password_textbox.Text);
                    LogInUser(lgin_username_textbox.Text, lgin_password_textbox.Text);

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


                  //  Log_In(lgin_username_textbox.Text, lgin_password_textbox.Text);
                    LogInUser(lgin_username_textbox.Text, lgin_password_textbox.Text);

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

        public void LogInUser(string us, string pas)
        {
            l.CheckUserProfile(us, pas);
            if (l.log_in_case == true)
            {
                Home_Window frm_main = new Home_Window();
                frm_main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account not Detected, Please try again.", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                Application.Exit();

            }
                /*
            else 
               MessageBox.Show("User account not detected" + "rowcount= " + l.rowcount, "Invalid Account", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
           /* l.db_cn.Close();
            lgin_username_textbox.Text = "";
            lgin_password_textbox.Text = "";
            lgin_username_textbox.Focus();
            * 
            Application.Exit();
       */
        }


    }

}
