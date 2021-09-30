using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DILL
{
    public partial class EditProcess : Form
    {
        public static int processadded = 0;
        private static string pid = null;
        private DILL main = new DILL();

        public EditProcess()
        {
            InitializeComponent();
            Setup();
        }

        public void SaveError(string e)
        {
            DialogResult dr = MessageBox.Show($"Oops: \nAn error has occurred, Check Logs in C:/Windows/Temp\n\nDo you want to see the eror log?", $"{this.Text} Error", MessageBoxButtons.YesNo);
            if (Directory.Exists("C://Windows//Temp//DILL//Logs"))
            {
                StreamWriter sw = new StreamWriter("C://Windows//Temp//DILL//Logs//Errors.txt");
                sw.Write($"====================== ERRORS ========================\n-\n{e}\n-");
                sw.Close();
            }
            else
            {
                Directory.CreateDirectory("C://Windows//Temp//DILL//Logs");
                StreamWriter sw = new StreamWriter("C://Windows//Temp//DILL//Logs//Errors.txt");
                sw.Write($"====================== ERRORS ========================\n-\n{e}\n-");
                sw.Close();
            }
            if (dr == DialogResult.Yes)
            {
                Process.Start("C://Windows//Temp//DILL//Logs//Errors.txt");
            }
            else
            {
                return;
            }
        }

        private void Resources()
        {
            try
            {
                string path_icon = "C:\\Windows\\Temp\\DILL\\Images\\Icon\\jsusx.ico";
                if (File.Exists(path_icon))
                {
                    this.Icon = Icon.ExtractAssociatedIcon(path_icon);
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    this.MaximizeBox = false;
                }
                else
                {
                    Directory.CreateDirectory("C:\\Windows\\Temp\\DILL\\Images\\Icon");
                    var wb = new WebClient();
                    wb.DownloadFile("https://portfolio.jsusx.com/assets/img/p2.ico", path_icon);
                    Resources();
                }

            }
            catch (Exception e)
            {
                SaveError(e.ToString());
            }
        }


        public void LoadProcess()
        {
            Process[] process = Process.GetProcesses();
            foreach (Process p in process)
            {
                if (!p.ProcessName.Contains("svchost") && 
                    !p.ProcessName.Contains("System") &&
                    !p.ProcessName.Contains("Isass") &&
                    !p.ProcessName.Contains("smss") &&
                    !p.ProcessName.Contains("services") &&
                    !p.ProcessName.Contains("Registry") &&
                    !p.ProcessName.Contains("csrss") &&
                    !p.ProcessName.Contains("WmiPrvSE") &&
                    !p.ProcessName.Contains("sqlwriter") &&
                    !p.ProcessName.Contains("OfficeClickToRun") &&
                    !p.ProcessName.Contains("winlogon") &&
                    !p.ProcessName.Contains("ApMsgFwd") &&
                    !p.ProcessName.Contains("RAVBg64") &&
                    !p.ProcessName.Contains("fontdrvhost") &&
                    !p.ProcessName.Contains("ApMsgFwd") &&
                    !p.ProcessName.Contains("Taskmgr") &&
                    !p.ProcessName.Contains("SgrmBroker"))
                {
                    cbProcessList.Items.Add($"{p.ProcessName} - {p.Id}");
                }
                else
                {
                    ;
                }

            }
        }

        public void Setup()
        {            
            //
            LoadProcess();
            CenterToScreen();
            BackColor = Color.White;
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(200,200,200);
            btnAdd.Select();
            Resources();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbProcessList.SelectedIndex != -1)
            {
                processadded = int.Parse(pid);
                MessageBox.Show("Added");
                Hide();
            }
            else
            {
                MessageBox.Show("Select Process","Error -" + this.Text);
            }

        }

        private void cbProcessList_TextChanged(object sender, EventArgs e)
        {
            string p = cbProcessList.SelectedItem.ToString();
            pid = p.Substring(p.LastIndexOf("-")+2);
        }

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.ForeColor = Color.FromArgb(72, 163, 255);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.FromArgb(28,28,28);
        }
    }
}
