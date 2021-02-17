using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transfer;

namespace Client.Controller
{
    class UnosDijagnozeC
    {

        internal void init_cmbBolesti(ComboBox cmbBolesti)
        {
            cmbBolesti.DataSource = Communication.Instance.UcitajBolesti();
        }
        internal void init_lbLekovi(ListBox lbLekovi)
        {
            lbLekovi.DataSource = Communication.Instance.UcitajLekove();
        }

        internal void SacuvajDijagnozu(ComboBox cmbBolest, ListBox lbLek)
        {
            try
            {
                Diagnosis d = new Diagnosis
                {
                    Date = DateTime.Now,
                    Doctor = MainController.Instance.Doctor,
                    Patient = MainController.Instance.Patient,
                    Illness = cmbBolest.SelectedItem as Illness,
                    Medicines = lbLek.SelectedItems.OfType<Medicine>().ToList()
                };

                Response r = Communication.Instance.UnosDijagnoze(d);

                if (r.Signal == Signal.OK)
                {
                    MessageBox.Show(r.Message);

                } 
                else
                {
                    MessageBox.Show(r.Message);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Sistem ne moze da sacuva dijagnozu.");
                return;
            }
        }
    }
}
