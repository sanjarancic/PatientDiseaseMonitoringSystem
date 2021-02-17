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

namespace Client
{
    public partial class FRMClient : Form
    {
        public FRMClient()
        {
            InitializeComponent();
            MainController.Instance.PostaviFormu(this);
        }

        private void noviPacijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.Instance.UnosPacijentaForma();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.Instance.PretragaPacijentaForma();
        }

        public void SetPanel(UserControl userControl)
        {
            pnlMainContainer.Controls.Clear();
            userControl.Parent = pnlMainContainer;
            userControl.Dock = DockStyle.Fill;
        }

        private void unesiBolestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.Instance.UnesiBolestForma();
        }

        private void unesiLekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.Instance.UnosLekaForma();
        }

        private void pretraziLekoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.Instance.PretragaLekova();
        }
    }
}
