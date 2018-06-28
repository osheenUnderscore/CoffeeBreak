using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// custom added
using System.IO;


namespace CoffeeBreak
{
    public partial class CoffeeBreak : Form
    {
        public CoffeeBreak()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeShutdown(1);
        }

        private void TimeShutdown(int seconds)
        {
            // run command, show popup. For testing
            //string strCmdShutdown;
            //strCmdShutdown = "/C shutdown -s -t " + seconds;
            //strCmdShutdown = "/C cd D:\\Programming && dir && type 'hello' > newfile.txt";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdShutdown);

            //System.Diagnostics.Process.Start("CMD.exe", strCmdShutdown);

            //System.IO.File.WriteAllText(@"D:\\Programming\\newfile.txt", "text");

            // print to file. For testing
            //string path = @"D:\Programming\newfile.txt";
            //FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

            try
            {
                StreamWriter textOut = new StreamWriter("D:\\Programming\\newfile.txt");
                textOut.WriteLine("hello");
                textOut.Close();
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("filepath not found.",
                "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("dir not found.",
                "Directory Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }            finally
            {
                System.Diagnostics.Process.Start("CMD.exe", "/C echo DONE!!!!!");
            }
            //StreamWriter textOut = new StreamWriter("D:\\Programming\\newfile.txt");
            //textOut.WriteLine("hello");
            //textOut.Close();
            //System.Diagnostics.Process.Start("CMD.exe", "/C echo DONE!!!!!");
            //File.WriteAllText(@"D:\Programming\file.txt", strCmdShutdown);

            // sending command to cmd.exe without it popping up
            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "/C cd D:\\Programming | type hello > newfile.txt";
            //process.StartInfo = startInfo;
            //process.Start();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
