using Client.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forme
{
    public partial class FRMLogin : Form
    {
        LoginC loginC = new LoginC();
        public FRMLogin()
        {
            InitializeComponent();
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            if (!Communication.Instance.Connect())
            {
                MessageBox.Show("Niste povezani sa serverom.");
                Environment.Exit(0);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginC.Login(txtUsername, txtPassword, this);
        }
    }
}
