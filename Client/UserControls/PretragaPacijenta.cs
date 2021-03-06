﻿using System;
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
    public partial class PretragaPacijenta : UserControl
    {
        PretragaPacijentaC ppc = new PretragaPacijentaC();
        public PretragaPacijenta()
        {
            InitializeComponent();
            ppc.PretraziPacijente(textBoxSearch, dataGridView1);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ppc.PretraziPacijente(textBoxSearch, dataGridView1);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ppc.OtvoriDijagnozu(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            ppc.IzmeniPacijenta(dataGridView1);
        }
    }
}
