using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string newtPath = "";
        public string newtDestPath = "";
        public string licDestPath;
        public Boolean destPathEntered;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewtPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please naviage to NEWT directory and select NEWTPro.exe","Newt Path",MessageBoxButtons.OK,MessageBoxIcon.Information);
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                newtPath = openFileDialog1.FileName;
                MessageBox.Show(newtPath);
            }   
        }

        private void btnStartNewt_Click(object sender, EventArgs e)
        {
            newtDestPath = txtNewtOutput.Text;
  
            if (Convert.ToInt32(txtUpper1.Text) < Convert.ToInt32(txtLower1.Text) ||
                Convert.ToInt32(txtUpper2.Text) < Convert.ToInt32(txtLower2.Text) ||
                Convert.ToInt32(txtUpper3.Text) < Convert.ToInt32(txtLower3.Text) ||
                Convert.ToInt32(txtUpper4.Text) < Convert.ToInt32(txtUpper4.Text))
            {
                MessageBox.Show("The Lower IP Address can not be larger than Upper IP Address", "IP Adress Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StreamWriter writer = new StreamWriter("NEWT.ini");
                {
                    writer.WriteLine("[Config]");
                    writer.WriteLine("lowerIP=\"{0}.{1}.{2}.{3}\"", txtLower1.Text, txtLower2.Text, txtLower3.Text, txtLower4.Text);
                    writer.WriteLine("upperIP=\"{0}.{1}.{2}.{3}\"", txtUpper1.Text, txtUpper2.Text, txtUpper3.Text, txtUpper4.Text);
                    writer.WriteLine("savePath=\"{0}\"", newtDestPath);
                    writer.WriteLine("newtPath=\"{0}\"", newtPath);
                }
                writer.Close();

                StreamWriter writer2 = new StreamWriter("From_P40_PC_Htm.bat");
                {
                    writer2.WriteLine("xcopy \\\\p40-it--coop\\c$\\Users\\achung\\Desktop\\Newt_Directory\testNewtLicense\\*.htm {0} /S /Y /Q EXCLUDE", txtExcelOutput.Text);
                }
                writer2.Close();

                StreamWriter writer3 = new StreamWriter("From_P40_PC_Excel.bat");
                {
                    writer3.WriteLine("xcopy \\\\p40-it--coop\\c$\\Users\\achung\\Desktop\\Newt_Directory\testNewtLicense\\Excel_Refreshed.xlsx {0} /S /Y /Q EXCLUDE", txtExcelOutput.Text);
                }
                writer3.Close();

                Process p = new Process();
                p.StartInfo.Verb = "runas";
                p.StartInfo.FileName = "automateNEWT.exe";
                p.Start();
            }

        }

        private void btnGetLic_Click(object sender, EventArgs e)
        {

            StreamWriter writer2 = new StreamWriter("From_P40_PC_Htm.bat");
            {
                writer2.WriteLine("xcopy \\\\p40-it--coop\\c$\\Users\\achung\\Desktop\\Newt_Directory\\testNewtLicense\\*.htm {0} /S /Y /Q", txtExcelOutput.Text);
            }
            writer2.Close();

            StreamWriter writer3 = new StreamWriter("From_P40_PC_Excel.bat");
            {
                writer3.WriteLine("xcopy \\\\p40-it--coop\\c$\\Users\\achung\\Desktop\\Newt_Directory\\testNewtLicense\\Excel_Refreshed.xlsx {0} /S /Y /Q", txtExcelOutput.Text);
            }
            writer3.Close();

            string dir = System.IO.Directory.GetCurrentDirectory() + "\\testNewtLicense\\start.bat";
            Process.Start(dir);
        }

        private void txtNewtOutput_TextChanged(object sender, EventArgs e)
        {
            newtDestPath = txtExcelOutput.Text;
        }
    }
}
