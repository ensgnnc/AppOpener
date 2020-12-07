using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOpener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            OpenApp("C:/Users/dengu/AppData/Local/Discord/app-0.0.308/Discord.exe");
        }

        private void EpicGames_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Program Files (x86)/Epic Games/Launcher/Portal/Binaries/Win32/EpicGamesLauncher.exe");
        }

        private void Mail_Click(object sender, EventArgs e)
        {
            OpenApp("https://mail.google.com");
            OpenApp("https://outlook.office365.com/mail/inbox");
        }

        private void LeagueOfLegends_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Riot Games/League of Legends/LeagueClient.exe");
        }

        private void Logitech_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Program Files/Logitech Gaming Software/LCore.exe");
        }

        private void Minecraft_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Program Files (x86)/Minecraft Launcher/MinecraftLauncher.exe");
        }

        private void OneDrive_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Users/dengu/AppData/Local/Microsoft/OneDrive/OneDrive.exe");
        }

        private void Opera_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Users/dengu/AppData/Local/Programs/Opera GX/launcher.exe");
        }

        private void Spotify_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Program Files/WindowsApps/SpotifyAB.SpotifyMusic_1.147.684.0_x86__zpdnekdrzrea0/Spotify.exe");
        }

        private void Steam_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Program Files (x86)/Steam/steam.exe");
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
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C \"C:/Riot Games/Riot Client/RiotClientServices.exe\" --launch-product=valorant --launch-patchline=live";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void VisualStudio_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Program Files (x86)/Microsoft Visual Studio/2019/Professional/Common7/IDE/devenv.exe");
        }

        private void Whatsapp_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Users/dengu/AppData/Local/WhatsApp/WhatsApp.exe");
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            OpenApp("https://twitter.com/home");
        }

        private void Zoom_Click(object sender, EventArgs e)
        {
            OpenApp("C:/Users/dengu/AppData/Roaming/Zoom/bin/Zoom.exe");
        }
    }
}
