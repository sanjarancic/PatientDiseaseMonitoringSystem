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
    public partial class UnosDijagnoze : UserControl
    {
        UnosDijagnozeC unosDijagnozeC = new UnosDijagnozeC();
        public UnosDijagnoze()
        {
            InitializeComponent();
            labelPatientName.Text = MainController.Instance.Patient.ToString();
            unosDijagnozeC.init_cmbBolesti(cmbBolest);
            unosDijagnozeC.init_lbLekovi(lbLek);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unosDijagnozeC.SacuvajDijagnozu(cmbBolest, lbLek);
        }
    }
}
