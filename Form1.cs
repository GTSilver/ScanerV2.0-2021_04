using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scaner_2._0
{
    public partial class Form1 : Form
    {
        static long filesScaned = 0;
        static long foldersScaned = 0;
        static long sizeScaned = 0;
        static Stopwatch timeScaned;
        static Thread scanningThread;
        static Thread calculationThread;
        static StreamWriter resultFile;
        static StreamWriter errorsFile;


        public Form1()
        {
            InitializeComponent();
        }

        private void Input_TB_TextChanged(object sender, EventArgs e)
        {
            var value = (Input_TB.Text);
            if (value.Length > 0)
                if (value[value.Length - 1] != '\\')
                {
                    value += @"\";
                    Input_TB.Text = value;
                }
        }

        private void Output_TB_TextChanged(object sender, EventArgs e)
        {
            var value = (Output_TB.Text);
            if (value.Length > 0)
                if (value[value.Length - 1] != '\\')
                {
                    value += @"\";
                    Output_TB.Text = value;
                }
        }

        private void BrowseInput_B_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog())
                if (folder.ShowDialog() == DialogResult.OK)
                    Input_TB.Text = folder.SelectedPath;
        }

        private void BrowseOutput_B_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog())
                if (folder.ShowDialog() == DialogResult.OK)
                    Output_TB.Text = folder.SelectedPath;
        }

        private void Start_B_Click(object sender, EventArgs e)
        {
            StartProcedure();
        }

        private void Stop_B_Click(object sender, EventArgs e)
        {
            StopProcedure();
        }

        private string GetSwitcherProcedure()
        {
            string result;

            if (Separator_RB1.Checked)
                result = "\t";
            else if (Separator_RB2.Checked)
                result = "/";
            else if (Separator_RB3.Checked)
                result = "*";
            else if (Separator_RB4.Checked)
                result = "\"";
            else if (Separator_RB5.Checked)
                result = "<";
            else if (Separator_RB6.Checked)
                result = ">";
            else throw new NotImplementedException();

            return result;
        }

        private void OffInterface()
        {
            Stop_B.Enabled = true;
            Start_B.Enabled = false;
            Input_TB.Enabled = false;
            Output_TB.Enabled = false;
            Separator_RB1.Enabled = false;
            Separator_RB2.Enabled = false;
            Separator_RB3.Enabled = false;
            Separator_RB4.Enabled = false;
            Separator_RB5.Enabled = false;
            Separator_RB6.Enabled = false;
            BrowseInput_B.Enabled = false;
            BrowseOutput_B.Enabled = false;

            filesScaned = 0;
            foldersScaned = 0;
            sizeScaned = 0;

            timeScaned = new Stopwatch();
            timeScaned.Start();
        }

        private void OnInterface()
        {
            Stop_B.Enabled = false;
            Start_B.Enabled = true;
            Input_TB.Enabled = true;
            Output_TB.Enabled = true;
            Separator_RB1.Enabled = true;
            Separator_RB2.Enabled = true;
            Separator_RB3.Enabled = true;
            Separator_RB4.Enabled = true;
            Separator_RB5.Enabled = true;
            Separator_RB6.Enabled = true;
            BrowseInput_B.Enabled = true;
            BrowseOutput_B.Enabled = true;

            timeScaned.Stop();
            var elapsedTime = timeScaned.Elapsed;
            string time = String.Format
                (
                "{0:00}:{1:00}:{2:00}.{3:000}",
                elapsedTime.Hours,
                elapsedTime.Minutes,
                elapsedTime.Seconds,
                elapsedTime.Milliseconds
                );

            Files_L.Text = filesScaned.ToString();
            Folders_L.Text = foldersScaned.ToString();
            Size_L.Text = (sizeScaned/1024/1024).ToString();
            Time_L.Text = time;
        }

        public void Scanning()
        {
            var imputPath = Input_TB.Text;
            var outputPath = Output_TB.Text;
            var separator = GetSwitcherProcedure();

            resultFile = new StreamWriter(outputPath + "Scanning result.txt", true, Encoding.Default, 10);
            errorsFile = new StreamWriter(outputPath + "Scanning errors folers.txt", true, Encoding.Default, 10);

            ScanFolder(imputPath, separator);

            Invoke((MethodInvoker)delegate () { StopProcedure(); });
        }

        private void ScanFolder(string imputPath, string separator)
        {
            try
            {
                var allfiles = Directory.GetFiles(imputPath).ToList();
                var allfolders = Directory.GetDirectories(imputPath).Select(x => x + "\\").ToList();

                foreach (var folder in allfolders)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(folder);

                    string name = directoryInfo.Name;
                    string size = "-";
                    string createDate = directoryInfo.CreationTime.ToShortDateString();
                    string createTime = directoryInfo.CreationTime.ToLongTimeString();
                    string changeDate = directoryInfo.LastWriteTime.ToShortDateString();
                    string changeTime = directoryInfo.LastWriteTime.ToLongTimeString();
                    string lastOpenDate = directoryInfo.LastAccessTime.ToShortDateString();
                    string lastOpenTime = directoryInfo.LastAccessTime.ToLongTimeString();
                    string extension = "-";
                    string directoryPath = folder.Remove(folder.LastIndexOf(name));
                    
                    resultFile.WriteLine
                        (
                        name + separator +
                        size + separator +
                        createDate + separator + 
                        createTime + separator +
                        changeDate + separator + 
                        changeTime + separator +
                        lastOpenDate + separator + 
                        lastOpenTime + separator +
                        extension + separator +
                        directoryPath
                        );

                    foldersScaned++;
                }

                foreach (var files in allfiles)
                {
                    FileInfo fileInfo = new FileInfo(files);

                    string name = fileInfo.Name;
                    string size = fileInfo.Length.ToString();
                    string createDate = fileInfo.CreationTime.ToShortDateString();
                    string createTime = fileInfo.CreationTime.ToLongTimeString();
                    string changeDate = fileInfo.LastWriteTime.ToShortDateString();
                    string changeTime = fileInfo.LastWriteTime.ToLongTimeString();
                    string lastOpenDate = fileInfo.LastAccessTime.ToShortDateString();
                    string lastOpenTime = fileInfo.LastAccessTime.ToLongTimeString();
                    string extension = fileInfo.Extension;
                    string directoryPath = fileInfo.Directory.ToString() + "\\";

                    resultFile.WriteLine
                        (
                        name + separator +
                        size + separator +
                        createDate + separator +
                        createTime + separator +
                        changeDate + separator +
                        changeTime + separator +
                        lastOpenDate + separator +
                        lastOpenTime + separator +
                        extension + separator +
                        directoryPath
                        );

                    sizeScaned += fileInfo.Length;
                    filesScaned++;
                }

                foreach (var folder in allfolders)
                    ScanFolder(folder, separator);
            }

            catch { try { errorsFile.WriteLine(imputPath); } catch { } }
        }

        public void Calculation()
        {
            while (true)
            {
                Thread.Sleep(50);

                var elapsedTime = timeScaned.Elapsed;
                string time = String.Format
                    (
                    "{0:00}:{1:00}:{2:00}.{3:000}",
                    elapsedTime.Hours,
                    elapsedTime.Minutes,
                    elapsedTime.Seconds,
                    elapsedTime.Milliseconds
                    );

                Invoke((MethodInvoker)delegate ()
                {
                    Files_L.Text = filesScaned.ToString();
                    Folders_L.Text = foldersScaned.ToString();
                    Size_L.Text = (sizeScaned / 1024 / 1024).ToString();
                    Time_L.Text = time;
                });
            }
        }

        private void StartProcedure()
        {
            OffInterface();

            scanningThread = new Thread(new ThreadStart(Scanning));
            scanningThread.Start();

            calculationThread = new Thread(new ThreadStart(Calculation));
            calculationThread.Start();
        }

        private void StopProcedure()
        {
            try { scanningThread.Abort(); }
            catch { MessageBox.Show("Error:\n" + "Scanning is not active. There is nothing to stop."); }

            try { calculationThread.Abort(); }
            catch { MessageBox.Show("Error:\n" + "Calculation is not active. There is nothing to stop."); }

            try { resultFile.Close(); }
            catch { MessageBox.Show("Error:\n" + "File \"Scanning result.txt\" is not opened. There is nothing to close."); }

            try { errorsFile.Close(); }
            catch { MessageBox.Show("Error:\n" + "File \"Scanning errors folers.txt\" is not opened. There is nothing to close."); }

            OnInterface();
        }
    }
}
