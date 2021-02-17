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
    public partial class IzmenaPacijenta : UserControl
    {
        IzmenaPacijentaC izmenaPacijenta = new IzmenaPacijentaC();
        public IzmenaPacijenta()
        {
            InitializeComponent();
            izmenaPacijenta.InitData(txtJMBG, txtIme, txtPrezime);
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            izmenaPacijenta.IzmeniPacijenta(txtJMBG, txtIme, txtPrezime);
        }
    }
}
