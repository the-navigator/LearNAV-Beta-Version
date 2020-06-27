using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// using System.IO.Compression;
using Ionic;
using Ionic.Zip;






namespace LearNAV
{
    public partial class Resource_Extract_Tool : Form
    {
       
        string path_extrct;
        private int totalFiles;
        //private int transfered;
        string target_path = Environment.CurrentDirectory + "\\ResourceFiles";
        string target_pathdb = Environment.CurrentDirectory;
        public Resource_Extract_Tool()

          
        {
            InitializeComponent();
            extract_bg.DoWork += extract_bg_DoWork;
        }

        private void extract_btn_Click(object sender, EventArgs e)
        {
            if (txt_loc.Text == "")
            {
                MessageBox.Show("Please locate a file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
               // extract_bg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.extract_bg_DoWork); 
                extract_bg.RunWorkerAsync();

            }
                
            
        }

        private void locate_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = File_accss.ShowDialog();
            if (result == DialogResult.OK)
            { 
              
          path_extrct = File_accss.FileName;
               /* if (!System.IO.Directory.Exists(path_extrct))
                {
                    System.IO.Directory.CreateDirectory(path_extrct);

                }
                else
                {
                    ZipFile.ExtractToDirectory(File_accss.FileName, path_extrct);
                }*/
       
            }
        }

        private void File_accss_FileOk(object sender, CancelEventArgs e)
        {
            txt_loc.Text = File_accss.FileName;

        }

        private void extract_bg_DoWork(object sender, DoWorkEventArgs e)
        {
           // ZipFile.ExtractToDirectory(File_accss.FileName, path_extrct);
            TransferResource();
        }

        private void extract_bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //extract_bg.CancelAsync();
           
        }

        void TransferResource()
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(path_extrct))
                {
                    zip.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(zip_ExtractProgress);
                    totalFiles = zip.Count;
                    foreach (ZipEntry e in zip)
                    {
                        if (e.FileName == "LearNAV_DB2.accdb")
                        {
                            e.Extract(target_pathdb, ExtractExistingFileAction.OverwriteSilently);
                        }
                        else
                        {

                            listBox2.Items.Add(e.FileName);
                            zip.ExtractAll(target_path, ExtractExistingFileAction.OverwriteSilently);
                            
                        }
                        // IMPORTANT!! 
                        // Include separate extraction for the Database File
                    }

                }
               

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                
                DialogResult resultans = MessageBox.Show("Extract resource file finished! Would you like to return to the Home Window?", "Extract finished!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultans == DialogResult.Yes)
                {
                    this.Hide();
                    //
					/*
                    Home_Window frm = new Home_Window();
                    frm.Load_Data("SELECT * FROM ResourceDB");
                    frm.Show();
					*/
                    //
                }
            }
        }
        void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
           
                //progress_track.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);

         /*   if (e.EventType != ZipProgressEventType.Extracting_BeforeExtractEntry)
                return;
            transfered++;
            
               // progress_track.Value = Convert.ToInt32(100 * transfered/totalFiles);
          * */
            if (e.TotalBytesToTransfer > 0)
            {
                progress_track.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
            }
        }

        private void extract_bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
         //   progress_track.Value = e.ProgressPercentage;
         
        }
    }
}
