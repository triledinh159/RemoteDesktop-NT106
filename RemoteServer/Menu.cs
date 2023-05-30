

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;
using System.Diagnostics;

namespace RemoteServer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        public void printDebug(string Msg,bool Force)
        {//This will be called on this forms thread
            if (Settings.Debug || Force)
            {
                textDebug.Text = Msg + Environment.NewLine + textDebug.Text;
                if (textDebug.Text.Length > 20000) textDebug.Text = textDebug.Text.Substring(10000);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = Settings.MainProgramName;
            bool B=Control.IsKeyLocked(Keys.CapsLock);
            this.WindowState = FormWindowState.Normal;
            Server.ImgWinbackground = ImgWinbackground.Image;
            Wallpaper.SaveWallpaper();
            Settings.LoadSettings();
            Settings.FormService = this;
            if (!Helper.IsUserAdministrator())
                printDebug("This program should be started with administrator rights to allow control of windows system forms and settings." + Environment.NewLine , true);
            if (Settings.FirstTime)
            {
                ShowSettings(true);
                passwordBox.Text = Settings.Password;
                portBox.Text = Settings.Port.ToString();
            }
            else
                Server.ListenStart();
            //this.Hide();
        }

       

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.SaveSettings();
            Server.ListenStop(true);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textDebug.Text = string.Empty;
        }

        private void buttonClear_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.SizeAll;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           // this.textDebug.Text = Cursor.Current.ToString() + " " + System.Windows.Forms.Cursor.Position.X;
          
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (Server.IsClientsConnected())
            {
               DialogResult  Answer= MessageBox.Show("Remote connections will all be closed before any settings can be changed", "Change Settings", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               if (Answer == DialogResult.Cancel) return;
            }
         
            Server.ListenStop(false);
            ShowSettings(true);
            passwordBox.Text  = Settings.Password;
            portBox.Text = Settings.Port.ToString();
        }

        private void buttonCancelSettings_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCancelSettings_MouseDown(object sender, MouseEventArgs e)
        {
            ShowSettings(false);
            if (!Settings.FirstTime)
                Server.ListenStart();
            else
                printDebug("Service not started",true);
        }

        private void ShowSettings(bool Vis)
        {
            if (Settings.FirstTime)
                buttonSaveSettings.Text = "Allow connections";
            else
                buttonSaveSettings.Text = "Save setting";
            buttonCancelSettings.Visible = Vis;
            buttonSaveSettings.Visible = Vis;
            buttonFirewall.Visible = Vis;
            buttonTask.Visible = Vis;
            portBox.Visible = Vis;
            passwordBox.Visible = Vis;
            textDebug.Visible = !Vis;
            buttonClear.Visible = !Vis;
            buttonSettings.Visible = !Vis;
            buttonHide.Visible = !Vis;
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            //Settings.Password = passwordBox.Text.Trim();
            //try { Settings.Port = int.Parse(portBox.Text.Trim()); } catch { ;}
            //Settings.FirstTime = false;
            //Settings.SaveSettings();
            //ShowSettings(false);
            //Server.ListenStart();
            //textDebug.Visible = true;
            //printDebug("Settings saved", true);
            //textDebug.Focus();
        }

       

        private void buttonFirewall_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {

        }


        private void buttonFirewall_MouseClick(object sender, MouseEventArgs e)
        {
            if (Helper.IsUserAdministrator())
            {
                FireWall.ProgramName = Settings.MainProgramName;
                if (FireWall.AllowThisProgram("TCP", Settings.Port.ToString(), string.Empty, "IN"))
                {
                    MessageBox.Show("New firewall rule added for TCP port " + Settings.Port, Settings.MainProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowSettings(false); Server.ListenStart(); return;
                }
            }
            MessageBox.Show("Sorry but you need to run this program as an administrator to add new firewall rules", Settings.MainProgramName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            ShowSettings(false); Server.ListenStart();
        }

        private void buttonTask_MouseClick(object sender, MouseEventArgs e)
        {
            if (Helper.IsUserAdministrator())
            {
                if (ScheduleTask.AddNewTask(Settings.MainProgramName, "Service for remote desktop"))
                {
                    MessageBox.Show("Schedule task added for " + Settings.MainProgramName, Settings.MainProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowSettings(false); Server.ListenStart(); return;
                }
            }
            MessageBox.Show("Sorry but you need to run this program as an administrator to add the Schedule task to auto start the program", Settings.MainProgramName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            ShowSettings(false); Server.ListenStart();
        }

        private void buttonSaveSettings_MouseClick(object sender, MouseEventArgs e)
        {
            Settings.Password = passwordBox.Text.Trim();
            try { 
                Settings.Port = int.Parse(portBox.Text.Trim()); 
            }
            catch { ;}
            Settings.FirstTime = false;
            Settings.SaveSettings();
            ShowSettings(false);
            Server.ListenStart();
            textDebug.Visible = true;
            printDebug("Settings saved", true);
            textDebug.Focus();
        }
    }     
}