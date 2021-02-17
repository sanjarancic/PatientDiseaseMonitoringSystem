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
    public partial class UnosBolesti : UserControl
    {
        UnosBolestiC unosBolestiC = new UnosBolestiC();
        public UnosBolesti()
        {
            InitializeComponent();
        }

        private void buttonSacuvajBolest_Click(object sender, EventArgs e)
        {
            unosBolestiC.SacuvajBolest(textBoxNazivBolesti, textBoxKategorijaBolesti);
        }       
    }
}
