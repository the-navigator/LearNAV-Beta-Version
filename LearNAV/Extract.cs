using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic;
using Ionic.Zip;
using MetroFramework;

namespace LearNAV
{

    public partial class Extract : MetroFramework.Forms.MetroForm
    {
        string path_extrct;
        private int totalFiles;
        //private int transfered;
        string target_path = Environment.CurrentDirectory + "\\ResourceFiles";
        string target_pathdb = Environment.CurrentDirectory;
       
        public Extract()
        {
            InitializeComponent();

            extract_bg.ProgressChanged += new ProgressChangedEventHandler(extract_bg_ProgressChanged);
        }

        private void bunifuMetroTextbox1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;  
        }

        private void bunifuMetroTextbox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                txt_file.Text = files.First(); //select the first one 
            extract_bg.DoWork += new DoWorkEventHandler(extract_bg_DoWork);
            path_extrct = txt_file.Text;
            extract_bg.RunWorkerAsync();

        }

        private void btn_begin_Click(object sender, EventArgs e)
        {
            extract_bg.RunWorkerAsync();
        }
        public void Extract_Files()
        {
           // Extract_Files();
            try
            {
                using (ZipFile zip = ZipFile.Read(path_extrct))
                {
                     zip.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(zip_ExtractProgress);
                    totalFiles = zip.Count;
                    foreach (ZipEntry en in zip)
                    {
                        if (en.FileName == "LearNAV_DB2.accdb")
                        {
                            en.Extract(target_pathdb, ExtractExistingFileAction.OverwriteSilently);
                        }
                        else
                        {
                            //listBox2.Items.Add(e.FileName);
                            zip.ExtractAll(target_path, ExtractExistingFileAction.OverwriteSilently);
                        }
                        // IMPORTANT!! 
                        // Include separate extraction for the Database File
                    }

                }


            }
            catch (Exception v)
            {
                MessageBox.Show(v.Message);

            }
            finally
            {

                DialogResult resultans = MessageBox.Show("Extract resource file finished! Please Restart learnav.", "Extract finished!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultans == DialogResult.Yes)
                {
                    Application.Exit();
                    //
                    /*
                    Home_Window frm = new Home_Window();
                    frm.Load_Data("SELECT * FROM ResourceDB");
                    frm.Show();
                    */
                    //
                }
            }
            /*
            for (int i = 0; i <= 100; i++)
            {
                // Report progress to 'UI' thread
                extract_bg.ReportProgress(i);
                // Simulate long task
                //System.Threading.Thread.Sleep(100);
            }
             * */
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

        private void txt_file_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void extract_bg_DoWork(object sender, DoWorkEventArgs e)
        {
//      
            Extract_Files();
        }

        private void extract_bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           // progress_track.Value = e.ProgressPercentage;
        }
    }
}
