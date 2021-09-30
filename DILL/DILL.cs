using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DILL
{
    public partial class DILL : Form
    {
        public static List<int> games = new List<int>();
        private string cdn;
        private PrivateFontCollection f = new PrivateFontCollection();
        private string fav_path = "C:/Windows/Temp/DILL/Favorites.json";
        string root_dir = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().LastIndexOf("\\")).Substring(0, Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().LastIndexOf("\\")).LastIndexOf("\\")).Substring(0, Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().LastIndexOf("\\")).Substring(0, Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().LastIndexOf("\\")).LastIndexOf("\\")).LastIndexOf("\\"));


        class Favorite
        {
            public string name { get; set; }
            public string path { get; set; }
            public string process { get; set; }
        }


        public DILL()
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
                SaveError(e.ToString());
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
            catch(Exception e)
            {
                SaveError(e.ToString());
            }
        }

        private void Setup()
        {
            CenterToScreen();
            BackColor = Color.White;
            f.AddFontFile(root_dir + "/Resources/Fonts/Comfortaa-Light.ttf");
            LabelDill1.BackColor = Color.FromArgb(28, 28, 28);
            LabelDill1.ForeColor = Color.FromArgb(255, 255, 255);
            LabelDill1.Font = new Font(f.Families[0], 20);
            btnEdit.Font = new Font(f.Families[0], 10);
            btnRecargar.Font = new Font(f.Families[0], 12);
            LabelSelectDLL.Font = new Font(f.Families[0], 12);
            LabelSelectProcess.Font = new Font(f.Families[0], 12);
            btnAceptar.Font = new Font(f.Families[0],12);
            btnRecargar.BackColor = Color.White;
            btnAceptar.BackColor = Color.White;
            btnEdit.BackColor = Color.White;
            btnEdit.Select();
            cmsFavorites.Image = Bitmap.FromFile(root_dir + "/Resources/star.png");
            Resources();
            loadFavorites();
            txtDLL.Enabled = false;
        }

        private void LoadProcessIcon()
        {
            try
            {
                Process[] p = Process.GetProcesses();

                List<Process> processes = new List<Process>();

                foreach (Process j in p)
                {
                    processes.Add(j);
                }

                Process ps = processes.Find(m => m.ProcessName == cbProcesos.SelectedItem.ToString() && Icon.ExtractAssociatedIcon(m.MainModule.FileName) != null);

                if (ps != null)
                {
                    Icon pico = Icon.ExtractAssociatedIcon(ps.MainModule.FileName);
                    this.Icon = pico;
                }
                else
                {
                    MessageBox.Show("This process is not open!", "DILL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception e)
            {
                SaveError(e.ToString());
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
            cdn = fb.SafeFileName;
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

        public void addToFavorites(string name, string dir, string process)
        {
            try
            {
                if (File.Exists(fav_path))
                {
                    string favs = File.ReadAllText(fav_path);
                    List<Favorite> l;

                    if (!String.IsNullOrWhiteSpace(favs))
                    {
                        l = JsonConvert.DeserializeObject<List<Favorite>>(favs);
                        
                    }
                    else
                    {
                        l = new List<Favorite>();
                    }

                    l.Add(new Favorite { name = name, path = dir, process = process });
                    string data = JsonConvert.SerializeObject(l);
                    StreamWriter sw = new StreamWriter(fav_path);
                    sw.Write(data);
                    sw.Close();
                }
                else
                {
                    FileStream fs = File.Create(fav_path);
                    fs.Close();

                    MessageBox.Show(name + " - " + dir);
                }
            }
            catch(Exception ex)
            {
                SaveError(ex.ToString());
            }
        }


        public void loadFavorites()
        {
            try
            {
                if (File.Exists(fav_path))
                {
                    cmsFavorites.DropDownItems.Clear();

                    string data = File.ReadAllText(fav_path);
                    if (!String.IsNullOrWhiteSpace(data))
                    {
                        List<Favorite> favs = JsonConvert.DeserializeObject<List<Favorite>>(data);

                        foreach (Favorite f in favs)
                        {
                            cmsFavorites.DropDownItems.Add(f.process + " - " + f.name).Click += new EventHandler((s, e) => {
                                txtDLL.Text = "";
                                txtDLL.Text = f.path; 
                                cbProcesos.Items.Add(f.process); 
                                cbProcesos.SelectedIndex = cbProcesos.Items.IndexOf(f.process);
                            });
                        }
                    }

                }
                else
                {
                    FileStream fs = File.Create(fav_path);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                SaveError(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDLL.Text))
            {
                try
                {
                    InjectorClass.DllInjector.injectar(cbProcesos.SelectedItem.ToString(), txtDLL.Text);
                    MessageBox.Show("Injected!", "DILL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    string data = File.ReadAllText(fav_path);

                    loadFavorites();

                    DialogResult dr = MessageBox.Show("Do you want to add this file to favorites?, you can see it after, by left clicking.", "Favorites", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        if (!String.IsNullOrWhiteSpace(data))
                        {
                            List<Favorite> favs = JsonConvert.DeserializeObject<List<Favorite>>(data);
                            Favorite f = favs.Find(m => m.name == cdn && m.process == cbProcesos.Text);

                            if (f != null)
                            {
                                MessageBox.Show("This file is already in favorites!", "Favorites", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                addToFavorites(cdn, txtDLL.Text, cbProcesos.Text);
                                MessageBox.Show("Added to favorites!", "Favorites", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            addToFavorites(cdn, txtDLL.Text, cbProcesos.Text);
                        }
                    }
                    else
                    {
                        ;
                    }

                    loadFavorites();
                }
                catch (Exception error)
                {
                    SaveError(e.ToString());
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

        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFavorites();

            if (cmsFavorites.DropDownItems.Count <= 0)
            {
                MessageBox.Show("You have no files in favorites!");
            }
        }
    }
}
