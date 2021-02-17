using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;

namespace Client.UserControls
{
    public partial class PretragaLekova : UserControl
    {
        PretragaLekovaC pretragaLekovaC = new PretragaLekovaC();
        public PretragaLekova()
        {
            InitializeComponent();
            pretragaLekovaC.PretraziLekove(textBoxSearch, dataGridView1);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            pretragaLekovaC.PretraziLekove(textBoxSearch, dataGridView1);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            pretragaLekovaC.ObrisiLek(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDelete.Enabled = true;
        }
    }
}
