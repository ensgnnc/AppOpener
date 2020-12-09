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


//TO-DO: Add special app 
namespace AppOpener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * INI
         * FILE
         * REGISTERATION
        */

        public string ReadConfig(string section, string key)
        {
            string retVal = string.Empty;
            string bankname = string.Empty;
            string basePath = System.Environment.CurrentDirectory + "\\" + "Settings";
            INIFile ini = new INIFile(Path.Combine(basePath, "ConfigFile.ini"));
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
                ini.IniWriteValue("Discord", "Discord Path", "C:/Users/Enis/AppData/Local/Discord/app-0.0.308/Discord.exe");
                ini.IniWriteValue("Epic Games", "Epic Games Path", "C:/Program Files (x86)/Epic Games/Launcher/Portal/Binaries/Win32/EpicGamesLauncher.exe");
                ini.IniWriteValue("League Of Legends", "League Of Legends Path", "C:/Riot Games/League of Legends/LeagueClient.exe");
                ini.IniWriteValue("Logitech", "Logitech Path", "C:/Program Files/Logitech Gaming Software/LCore.exe");
                ini.IniWriteValue("Minecraft", "Minecraft Path", "C:/Program Files(x86)/Minecraft Launcher/MinecraftLauncher.exe");
                ini.IniWriteValue("OneDrive", "OneDrive Path", "C:/Users/Enis/AppData/Local/Microsoft/OneDrive/OneDrive.exe");
                ini.IniWriteValue("Opera WebBrowser", "Opera WebBrowser Path", "C:/Users/Enis/AppData/Local/Programs/Opera GX/launcher.exe");
                ini.IniWriteValue("Spotify", "Spotify Path", "C:/Users/Enis/AppData/Roaming/Spotify/Spotify.exe");
                ini.IniWriteValue("Steam", "Steam Path", "C:/Program Files (x86)/Steam/steam.exe");
                ini.IniWriteValue("Valorant", "Valorant Path", "C:/Riot Games/Riot Client/RiotClientServices.exe");//Valorant
                ini.IniWriteValue("Visual Studio", "Visual Studio Path", "C:/Program Files (x86)/Microsoft Visual Studio/2019/Professional/Common7/IDE/devenv.exe");
                ini.IniWriteValue("Whatsapp", "Whatsapp Path", "C:/Users/Enis/AppData/Local/WhatsApp/WhatsApp.exe");
                ini.IniWriteValue("Zoom", "Zoom Path", "C:/Users/Enis/AppData/Roaming/Zoom/bin/Zoom.exe");
            }
            retVal = ini.IniReadValue(section, key);
            return retVal;
        }

        /*
         * END
         * OF
         * INI
         * FILE
         * REGISTERATION
        */

        ///
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        ///

        public static void OpenApp(string apppath)
        {
            System.Diagnostics.Process.Start(apppath);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Calculator_Click(object sender, EventArgs e)
        {
            OpenApp("calc.exe");
        }

        private void Cmd_Click(object sender, EventArgs e)
        {
            OpenApp("cmd.exe");
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            string discordpath = ReadConfig("Discord", "Discord Path");
            MessageBox.Show(discordpath);
            Console.WriteLine(discordpath);
            OpenApp(discordpath);
        }

        private void EpicGames_Click(object sender, EventArgs e)
        {
            string epic = ReadConfig("Epic Games", "Epic Games Path");
            MessageBox.Show(epic);
            Console.WriteLine(epic);
            OpenApp(epic);
        }

        private void Mail_Click(object sender, EventArgs e)
        {
            OpenApp("https://mail.google.com");
            OpenApp("https://outlook.office365.com/mail/inbox");
        }

        private void LeagueOfLegends_Click(object sender, EventArgs e)
        {
            string lol = ReadConfig("League Of Legends", "League Of Legends Path");
            MessageBox.Show(lol);
            Console.WriteLine(lol);
            OpenApp(lol);
        }

        private void Logitech_Click(object sender, EventArgs e)
        {
            string logitech = ReadConfig("Logitech", "Logitech Path");
            MessageBox.Show(logitech);
            Console.WriteLine(logitech);
            OpenApp(logitech);
        }

        private void Minecraft_Click(object sender, EventArgs e)
        {
            string mc = ReadConfig("Minecraft", "Minecraft Path");
            MessageBox.Show(mc);
            Console.WriteLine(mc);
            OpenApp(mc);
        }

        private void OneDrive_Click(object sender, EventArgs e)
        {
            string onedrive = ReadConfig("OneDrive", "OneDrive Path");
            MessageBox.Show(onedrive);
            Console.WriteLine(onedrive);
            OpenApp(onedrive);
        }

        private void Opera_Click(object sender, EventArgs e)
        {
            string opera = ReadConfig("Opera WebBrowser", "Opera WebBrowser Path");
            MessageBox.Show(opera);
            Console.WriteLine(opera);
            OpenApp(opera);
        }

        private void Spotify_Click(object sender, EventArgs e)
        {
            string spotify = ReadConfig("Spotify", "Spotify Path");
            MessageBox.Show(spotify);
            Console.WriteLine(spotify);
            OpenApp(spotify);
        }

        private void Steam_Click(object sender, EventArgs e)
        {
            string steam = ReadConfig("Steam", "Steam Path");
            MessageBox.Show(steam);
            Console.WriteLine(steam);
            OpenApp(steam);
        }

        private void Youtube_Click(object sender, EventArgs e)
        {
            OpenApp("https://www.youtube.com");
        }

        private void Twitch_Click(object sender, EventArgs e)
        {
            OpenApp("https://www.twitch.tv");
        }

        private void Valorant_Click(object sender, EventArgs e)
        {
            var decision = MessageBox.Show("Valorant is so difficult to open so it can crash App Launcher! Do you want continue?", "Valorant", MessageBoxButtons.YesNo);

            if (decision == DialogResult.Yes) {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C \"C:/Riot Games/Riot Client/RiotClientServices.exe\" --launch-product=valorant --launch-patchline=live";
                process.StartInfo = startInfo;
                process.Start(); 
            }
            else
            {
                MessageBox.Show("Valorant launching cancelled.","Cancelled");
            }
        }

        private void VisualStudio_Click(object sender, EventArgs e)
        {
            string vs = ReadConfig("Visual Studio", "Visual Studio Path");
            MessageBox.Show(vs);
            Console.WriteLine(vs);
            OpenApp(vs);
        }

        private void Whatsapp_Click(object sender, EventArgs e)
        {
            string wp = ReadConfig("Whatsapp", "Whatsapp Path");
            MessageBox.Show(wp);
            Console.WriteLine(wp);
            OpenApp(wp);
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            OpenApp("https://twitter.com/home");
        }

        private void Zoom_Click(object sender, EventArgs e)
        {
            string zoom = ReadConfig("Zoom", "Zoom Path");
            MessageBox.Show(zoom);
            Console.WriteLine(zoom);
            OpenApp(zoom);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
//By Erynial