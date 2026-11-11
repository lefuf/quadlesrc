using System;
using System.Diagnostics;
using System.IO;

namespace quadlesrc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // mapinp.Text = AppDomain.CurrentDomain.BaseDirectory + "maps\\Baseplate.rbxl";
        }

        string client = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "client",
            "QuadleApp.exe"
        );

        private void studioBtn_Click(object sender, EventArgs e)
        {
            string args = string.Join(" ", new[]
            {
                "-script",
                "\"p=Instance.new('Part', game.Workspace);",
                "p.Name='Baseplate';",
                "p.Size=Vector3.new(256, 16, 256);",
                "p.Anchored=true\""
            });

            Process.Start(new ProcessStartInfo
            {
                FileName = client,
                Arguments = args,
                UseShellExecute = false
            });
        }

        private void hostBtn_Click_1(object sender, EventArgs e)
        {
            string map = mapinp.Text;
            string port = sportinp.Text;

            string args = string.Join(" ", new[]
            {
                "-script",
                "\"port=" + port + "; map='" + map + "'; dofile('rbxasset://../../scripts/host.lua')\""
            });

            Process.Start(new ProcessStartInfo
            {
                FileName = client,
                Arguments = args,
                UseShellExecute = false
            });
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            string port = jport.Text;
            string ip = jip.Text;
            string name = jname.Text;

            string args = string.Join(" ", new[]
            {
                "-script",
                "\"ip='" + ip + "'; port=" + port + "; name='" + name + "'; dofile('rbxasset://../../scripts/join.lua')\""
            });

            Process.Start(new ProcessStartInfo
            {
                FileName = client,
                Arguments = args,
                UseShellExecute = false
            });
        }
    }
}
