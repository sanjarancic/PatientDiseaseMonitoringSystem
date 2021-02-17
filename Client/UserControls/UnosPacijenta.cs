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
    public partial class UnosPacijenta : UserControl
    {
        UnosPacijentaC upc = new UnosPacijentaC();

        public UnosPacijenta()
        {
            InitializeComponent();
            upc.init_cmbBolesti(cmbBolest);
            upc.init_lbLekovi(lbLek);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            upc.SacuvajPacijenta(txtJMBG, txtIme, txtPrezime, cmbBolest, lbLek);
        }
    }
}
