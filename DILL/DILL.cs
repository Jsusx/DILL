using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DILL
{
    public partial class DILL : Form
    {
        public static List<int> games = new List<int>(); 
        private PrivateFontCollection f = new PrivateFontCollection();

        public DILL()
        {
            InitializeComponent();
            Setup();
        }


        public void LoadProcess()
        {
            try
            {
                Process[] process = Process.GetProcesses();
                cbProcesos.Items.Clear();
                games.Add(EditProcess.processadded);
                foreach (Process p in process)
                {
                    foreach (int j in games)
                    {
                        if (p.Id == j)
                        {
                            cbProcesos.Items.Add(p.ProcessName);
                        }
                        else
                        {
                            ;
                        }
                    }
                }
                MessageBox.Show("   Process Reloaded   ","DILL - Alert");
            }
            catch (Exception e)
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


        }

        private void Resources()
        {
            this.Icon = Icon.ExtractAssociatedIcon("C:\\Windows\\Temp\\DILL\\Images\\Icon\\jsusx.ico");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Setup()
        {
            CenterToScreen();
            BackColor = Color.White;
            f.AddFontFile("C:/Users/jesus/Desktop/C#/DILL/DILL/Resources/Fonts/Comfortaa-Light.ttf");
            LabelDill1.BackColor = Color.FromArgb(28, 28, 28);
            LabelDill1.ForeColor = Color.FromArgb(255, 255, 255);
            LabelDill1.Font = new Font(f.Families[0], 20);
            btnEdit.Font = new Font(f.Families[0], 10);
            btnRecargar.Font = new Font(f.Families[0], 12);
            LabelSelectDLL.Font = new Font(f.Families[0], 14);
            LabelSelectProcess.Font = new Font(f.Families[0], 14);
            btnAceptar.Font = new Font(f.Families[0],12);
            btnRecargar.BackColor = Color.White;
            btnAceptar.BackColor = Color.White;
            btnEdit.BackColor = Color.White;
            btnEdit.Select();
            Resources();
            txtDLL.Enabled = false;
        }

        private void LoadProcessIcon()
        {
            try
            {
                Process[] p = Process.GetProcesses();
                foreach (Process j in p)
                {

                    if (j.ProcessName == cbProcesos.SelectedItem.ToString())
                    {
                        Icon pico = Icon.ExtractAssociatedIcon(j.MainModule.FileName);
                        this.Icon = pico;
                        /*
                        Image img = pico.ToBitmap();
                        LabelProcessIcon.Size = new Size(img.Width, img.Height);
                        LabelProcessIcon.Image = img;
                        */
                        break;
                    }
                    else
                    {
                        ;
                    }
                }
            }catch (Exception e)
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
        }


        private void btnRecargar_Click(object sender, EventArgs e)
        {
            LoadProcess();
        }


        private void cbProcesos_TextChanged(object sender, EventArgs e)
        {
            LoadProcessIcon();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProcess ep = new EditProcess();
            ep.ShowDialog();
        }

        private void btnEdit_MouseMove(object sender, MouseEventArgs e)
        {
            btnEdit.ForeColor = Color.White;
            btnEdit.BackColor = Color.FromArgb(28,28,28);
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.Black;
            btnEdit.BackColor = Color.FromArgb(255,255,255);
        }

        private void btnRecargar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRecargar.ForeColor = Color.FromArgb(72, 163, 255);
        }

        private void btnRecargar_MouseLeave(object sender, EventArgs e)
        {
            btnRecargar.ForeColor = Color.FromArgb(28,28,28);
        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAceptar.ForeColor = Color.FromArgb(72, 163, 255);
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.ForeColor = Color.FromArgb(28,28,28);
        }

        private void btnEdit_MouseMove_1(object sender, MouseEventArgs e)
        {
            btnEdit.ForeColor = Color.FromArgb(72, 163, 255);
        }

        private void btnEdit_MouseLeave_1(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.FromArgb(28, 28, 28);
        }

        private void btnSelectDLL_Click(object sender, EventArgs e)
        {
            OpenFileDialog fb = new OpenFileDialog();
            fb.Title = $"{this.Text} - Select your DLL";
            fb.Filter = "DLL files (*.dll) | *.dll";
            fb.ShowDialog();
            txtDLL.Text = fb.FileName;
            if (String.IsNullOrEmpty(txtDLL.Text))
            {
                this.Text = "DILL";
            }
            else
            {
                this.Text = $"Selected DLL: {txtDLL.Text.Substring(txtDLL.Text.LastIndexOf("\\") + 1)}";
            }
            
        }

        private void checkEDP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEDP.Checked)
            {
                txtDLL.Enabled = true;
            }
            else
            {
                txtDLL.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDLL.Text))
            {
                try
                {
                    InjectorClass.DllInjector.injectar(cbProcesos.SelectedItem.ToString(), txtDLL.Text);
                    MessageBox.Show("Injected!");
                }
                catch (Exception error)
                {
                    DialogResult dr = MessageBox.Show($"Oops: \nAn error has occurred, Check Logs in C:/Windows/Temp\n\nDo you want to see the eror log?", $"{this.Text} Error", MessageBoxButtons.YesNo);
                    if (Directory.Exists("C://Windows//Temp//DILL//Logs"))
                    {
                        StreamWriter sw = new StreamWriter("C://Windows//Temp//DILL//Logs//Errors.txt");
                        sw.Write($"====================== ERRORS ========================\n-\n{error}\n-");
                        sw.Close();
                    }
                    else
                    {
                        Directory.CreateDirectory("C://Windows//Temp//DILL//Logs");
                        StreamWriter sw = new StreamWriter("C://Windows//Temp//DILL//Logs//Errors.txt");
                        sw.Write($"====================== ERRORS ========================\n-\n{error}\n-");
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
            }
            else if (cbProcesos.SelectedIndex == -1)
            {
                DialogResult dg = MessageBox.Show("You have not selected a process, do you want to add it?", $"{this.Text} - Error", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    btnEdit.PerformClick();
                }
            }
            else 
            {
                DialogResult dg = MessageBox.Show("you have not selected a dll file, do you want to add it?", $"{this.Text} - Error",MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    btnSelectDLL.PerformClick();
                }
            }
        }
    }
}
