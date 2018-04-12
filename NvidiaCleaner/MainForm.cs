using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;
using System.Security.Principal;
using NvidiaCleaner.Lib;


namespace NvidiaCleaner
{
    public partial class MainForm : Form
    {
        private const string logFileName = "NCleaner.log";
        //Get System path.
        private readonly string _osPath = Path.GetPathRoot(Environment.SystemDirectory);
        private readonly List<string> _errors = new List<string>();
        private double totalCleanedMb=0;

        public MainForm()
        {
            InitializeComponent();
            //Initial Settings.
            cExtracted.Checked = true;
            cDownloaded.Checked = true;
        }
        
        //Calculates the percentage of each checked setting except generate log.
        public int GetBarPercentage()
        {
            int total=0;
            int result=0;

            if (cDownloaded.Checked == true)
                total++;
            if (cExtracted.Checked == true)
                total++;
            if (cRepository.Checked == true)
                total++;
            if (cWindowsDriver.Checked == true)
                total++;

            switch (total)
            {
                case 1:
                    result = 100;
                    break;
                case 2:
                    result = 50;
                    break;
                case 3:
                    result = 33;
                    progressBar.Maximum = 99;
                    break;
                case 4:
                    result = 25;
                    break;
                default:
                    break;
            }
            return result;
        }

        //Method that delets the extracted drivers at System:\NVIDIA path.
        public void DeleteExtractedDrivers()
        {
            string path = _osPath + @"NVIDIA";
            double deletedTotal = 0;
            textArea.Text += @"-----Extracted Drivers-----" + Environment.NewLine;

            if (Directory.Exists(path))
            {
                //MessageBox.Show(_path + @" Exist!");
                textArea.Text += path + @" FOUND! " + Environment.NewLine;

                long sizeB = NVC.GetDirectorySize(path);
                double sizeMB = NVC.SizeConvert(sizeB, "MB");

                try
                {
                    Directory.Delete(path, true);
                    textArea.Text += path + @" Deleted! " + sizeMB + @" MB cleaned!" + Environment.NewLine;
                    deletedTotal += sizeMB;
                    progressBar.Value += GetBarPercentage();
                }
                catch (Exception e)
                {
                    _errors.Add(e.ToString());
                    textArea.Text += path + @" is not deleted! " + Environment.NewLine + @"Error: " + e.Message + Environment.NewLine;
                }  
            }
            else
            {
                textArea.Text += path + @" NOT FOUND! PASSING... " + Environment.NewLine;
                progressBar.Value += GetBarPercentage();
            }

            textArea.Text += @"Total " + deletedTotal + @" MB Deleted in " + path + Environment.NewLine;
            textArea.Text += @"-----Extracted Drivers End-----" + Environment.NewLine + Environment.NewLine;
            totalCleanedMb += deletedTotal;
        }


        //Method that delets the downloaded drivers at System:\ProgramData\NVIDIA Corporation\Downloader path.
        public void DeleteDownloadedDrivers()
        {
            string path = _osPath + @"ProgramData\NVIDIA Corporation\Downloader";
            double deletedTotal = 0;
            textArea.Text += @"-----Downloaded Drivers-----" + Environment.NewLine;

            if (Directory.Exists(path))
            {
                //ONLY DELETE latest and random numbers.
                string whiteList = "config"; //Maybe add latest but not necessary.
                foreach (var dir in Directory.GetDirectories(path))
                {
                    if (!dir.Contains(whiteList))
                    {
                        textArea.Text += dir.Substring(45) + @" FOUND! " + Environment.NewLine;
                        long sizeB = NVC.GetDirectorySize(dir);
                        double sizeMB = NVC.SizeConvert(sizeB, "MB");

                        try
                        {
                            Directory.Delete(dir, true);
                            deletedTotal += sizeMB;
                            textArea.Text += dir.Substring(45) + @" Deleted! " + sizeMB + @" MB cleaned!" + Environment.NewLine + Environment.NewLine;
                        }
                        catch (Exception e)
                        {
                            _errors.Add(e.ToString());
                            textArea.Text += dir + @" is not deleted! " + Environment.NewLine + @"Error: " + e.Message + Environment.NewLine + Environment.NewLine;
                        }
                    }
                }
                progressBar.Value += GetBarPercentage();
            }
            else
            {
                textArea.Text += path + @" NOT FOUND! PASSING... " + Environment.NewLine;
                progressBar.Value += GetBarPercentage();
            }
            textArea.Text += @"Total " + deletedTotal + @" MB Deleted in " + path + Environment.NewLine;
            textArea.Text += @"-----Downloaded Drivers End-----" + Environment.NewLine + Environment.NewLine;
            totalCleanedMb += deletedTotal;
        }

        //Method that delets the downloaded drivers at System:\Program Files\NVIDIA Corporation\Installer2 path.
        public void DeleteRepository()
        {
            //DO NOT DELETE THE INSTALLER2 FOLDER ITSELF!!!
            //Delete Repository.
            string path = _osPath + @"Program Files\NVIDIA Corporation\Installer2";
            double deletedTotal = 0;
            textArea.Text += @"-----Repository-----" + Environment.NewLine;

            if (Directory.Exists(path))
            {
                foreach (var dir in Directory.GetDirectories(path))
                {
                    textArea.Text += dir.Substring(47) + @" FOUND! " + Environment.NewLine;
                    long sizeB = NVC.GetDirectorySize(dir);
                    double sizeMB = NVC.SizeConvert(sizeB, "MB");

                    try
                    {
                        Directory.Delete(dir, true);
                        deletedTotal += sizeMB;
                        textArea.Text += dir.Substring(47) + @" Deleted! " + sizeMB + @" MB cleaned!" + Environment.NewLine + Environment.NewLine;
                    }
                    catch (Exception e)
                    {
                        _errors.Add(e.ToString());
                        textArea.Text += dir + @" is not deleted! " + Environment.NewLine + @"Error: " + e.Message + Environment.NewLine + Environment.NewLine;
                    }
                }
                progressBar.Value += GetBarPercentage();
            }
            else
            {
                textArea.Text += path + @" NOT FOUND! PASSING... " + Environment.NewLine;
                progressBar.Value += GetBarPercentage();
            }
            textArea.Text += @"Total " + deletedTotal + @" MB Deleted in " + path + Environment.NewLine;
            textArea.Text += @"-----Repository End-----" + Environment.NewLine + Environment.NewLine;
            totalCleanedMb += deletedTotal;
        }

        public void DeleteLogs()
        {
            string[] path ={ _osPath + @"ProgramData\NVIDIA Corporation\GeForce Experience\Logs", _osPath + @"ProgramData\NVIDIA Corporation\NVIDIA GeForce Experience\Logs"};

            for (int i = 0; i < 2; i++)
            {
                double deletedTotal = 0;
                textArea.Text += @"-----Unneccessary Logs "+(i+1)+@"-----" + Environment.NewLine;
                if (Directory.Exists(path[i]))
                {
                    long sizeB = NVC.GetDirectorySize(path[i]);
                    double sizeMB = NVC.SizeConvert(sizeB, "MB");

                    foreach (var item in Directory.GetFiles(path[i]))
                    {
                        try
                        {
                            if (item.EndsWith(".log"))
                            {
                                File.Delete(item);
                                textArea.Text += item + @" Deleted! " + Environment.NewLine;
                            }
                        }
                        catch (Exception e)
                        {
                            _errors.Add(e.ToString());
                            textArea.Text += item + @" is not deleted! " + Environment.NewLine + @"Error: " + e.Message + Environment.NewLine + Environment.NewLine;
                        }
                    }
                    deletedTotal += sizeMB;
                }
                else
                {
                    textArea.Text += path[i] + @" NOT FOUND! PASSING... " + Environment.NewLine;
                    progressBar.Value += GetBarPercentage();
                }
                textArea.Text += @"Total " + deletedTotal + @" MB Deleted in " + path[i] + Environment.NewLine;
                textArea.Text += @"-----Unneccessary Logs "+(i+1)+@" End-----" + Environment.NewLine + Environment.NewLine;
                totalCleanedMb += deletedTotal;
            } 
        }

        public void DeleteWindowsDrivers()
        {    
            //TODO:Delete Repository using bruteforce. Use powershell script.
        }

        public void GenerateLog()
        {
            //TODO: Implement real log method.

            string path = Environment.CurrentDirectory;

            if (_errors.Count != 0)
            {
                try
                {
                    System.IO.File.WriteAllLines(path + @"\" + logFileName, _errors);
                }
                catch
                {
                    MessageBox.Show(@"Error while creating log.");
                }
            }

            
        }

        private void FreeUpSpaceButton_Click(object sender, EventArgs e)
        {
            //Reset progress bar.
            progressBar.Value = 0;
            //Clear text area in order to write logs.
            textArea.Clear();
            //Disable editing settings.
            tabSettings.Enabled = false;

            GenerateLog();

            try
            {
                if (cExtracted.Checked == true)
                    DeleteExtractedDrivers();

                if (cDownloaded.Checked == true)
                {
                    DeleteDownloadedDrivers();
                    DeleteLogs();
                }          

                if (cRepository.Checked == true)
                    DeleteRepository();

                //if (cWindowsDriver.Checked == true)
                    //DeleteWindowsDrivers();

                //Done Message!
                MessageBox.Show(@"Operation Successfull! " + totalCleanedMb + @" Mb Cleaned!", @"Success!");
            }
            catch (Exception ex)
            {
                _errors.Add(ex.Message);
            }

            //Enable editing settings upon finish.
            tabSettings.Enabled = true;
        }

        private void CWindowsDriver_CheckedChanged(object sender, EventArgs e)
        {
            if (cWindowsDriver.Checked == true)
            {
                MessageBox.Show(@"This process may damage current installed driver if the driver is not running right now. Eg. You are in safe mode, etc.", @"Warning!!!");
            }
        }
    }
}
