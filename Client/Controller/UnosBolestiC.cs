using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transfer;

namespace Client.Controller
{
    class UnosBolestiC
    {
        internal void SacuvajBolest(TextBox txtImeBolesti, TextBox txtKategorijaBolesti)
        {
            if (txtImeBolesti.Text == "" || txtKategorijaBolesti.Text == "")
            {
                MessageBox.Show("Pogresan unos.");
                return;
            }

            Illness i = new Illness() 
            {
                IllnessName = txtImeBolesti.Text,
                IllnessCategory = txtKategorijaBolesti.Text,
                Doctor = MainController.Instance.Doctor
            };

            try
            {
                Response r = Communication.Instance.SacuvajBolest(i);
                txtImeBolesti.Clear();
                txtKategorijaBolesti.Clear();
                MessageBox.Show("Illness saved!");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Illness not saved.");
                return;
            }
        }
    }
}
