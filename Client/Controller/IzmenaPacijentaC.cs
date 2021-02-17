using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transfer;

namespace Client.Controller
{
    class IzmenaPacijentaC
    {
        internal void InitData(TextBox txtJMBG, TextBox txtIme, TextBox txtPrezime)
        {
            txtJMBG.Text = MainController.Instance.Patient.PatientJMBG;
            txtIme.Text = MainController.Instance.Patient.PatientName;
            txtPrezime.Text = MainController.Instance.Patient.PatientSurname;
        }

        internal void IzmeniPacijenta(TextBox txtJMBG, TextBox txtIme, TextBox txtPrezime)
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

                Response r = Communication.Instance.IzmeniPacijenta(pacijent);
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
            catch (Exception)
            {

                throw;
            }
        }
    }
}
