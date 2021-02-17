using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transfer;

namespace Client.Controller
{
    class UnosPacijentaC
    {

        internal void init_cmbBolesti(ComboBox cmbBolesti)
        {
            cmbBolesti.DataSource = Communication.Instance.UcitajBolesti();
        }
        internal void init_lbLekovi(ListBox lbLekovi)
        {
            lbLekovi.DataSource = Communication.Instance.UcitajLekove();
        }

        internal void SacuvajPacijenta(TextBox txtJMBG, TextBox txtIme, TextBox txtPrezime, ComboBox cmbBolest, ListBox lbLek)
        {
            try
            {
                if (!Regex.IsMatch(txtIme.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(txtPrezime.Text, @"^[a-zA-Z]+$")
                       || !Regex.IsMatch(txtJMBG.Text, @"^\d{15}$"))
                {
                    MessageBox.Show("Sva polja moraju biti popunjena i u adekvatnom formatu!");
                    return;
                }
                Patient pacijent = new Patient
                {
                    PatientJMBG = txtJMBG.Text,
                    PatientName = txtIme.Text,
                    PatientSurname = txtPrezime.Text,
                    Doctor = MainController.Instance.Doctor
                };
                Diagnosis dijagnoza = new Diagnosis
                {
                    Patient = pacijent,
                    Illness = cmbBolest.SelectedItem as Illness,
                    Medicines = lbLek.SelectedItems.OfType<Medicine>().ToList(),
                    Doctor = MainController.Instance.Doctor,
                    Date = DateTime.Now
                };
                Response r = Communication.Instance.SacuvajPacijenta(dijagnoza);
                if (r.Signal == Signal.OK)
                {
                    MessageBox.Show(r.Message);
                    txtJMBG.Clear();
                    txtIme.Clear();
                    txtPrezime.Clear();
                }
                else
                {
                    MessageBox.Show(r.Message);
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Sistem ne moze da unese pacijenta i dijagnozu.");
                return;
            }
        }
    }
}
