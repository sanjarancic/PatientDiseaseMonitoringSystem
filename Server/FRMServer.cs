using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FRMServer : Form
    {
        Server s;
        Thread serverThread;
        public FRMServer()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.RunServer())
            {
                serverThread = new Thread(s.Listen);
                serverThread.IsBackground = true;
                serverThread.Start();
                lblStanjeServera.Text = "Server je pokrenut!";
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            else
            {
                lblStanjeServera.Text = "Server nije pokrenut!";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (Server.connectedClients.Count > 0)
            {
                lblStanjeServera.Text = "Postoji još ulogovanih klijenata!";
                return;
            }
            if (s.StopServer())
            {
                lblStanjeServera.Text = "Server je zaustavljen!";
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }
    }
}
