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
    public partial class UnosLeka : UserControl
    {
        UnosLekaC unosLekaC = new UnosLekaC();
        public UnosLeka()
        {
            InitializeComponent();
        }

        private void UnosLeka_Load(object sender, EventArgs e)
        {
            unosLekaC.InitForm(listBoxBolesti);
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            unosLekaC.UnesiLek(textBoxImeLeka, textBoxKategorijaLeka, listBoxBolesti);
        }
    }
}
