using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transfer;

namespace Client.Controller
{
    class PretragaPacijentaC
    {
        private BindingList<Patient> pacijenti = new BindingList<Patient>();


        internal void PretraziPacijente(TextBox textBoxSearch, DataGridView dataGridView1)
        {
            try
            {
                Patient p = new Patient
                {
                    Doctor = MainController.Instance.Doctor
                };
                p.SearchWhere = $"where p.PatientJMBG = '{textBoxSearch.Text}' or p.PatientName like '%{textBoxSearch.Text}%' or p.PatientSurname like '%{textBoxSearch.Text}%'";
                List<Patient> patients = (List<Patient>)Communication.Instance.PretragaPacijenata(p).Object;

                this.pacijenti = new BindingList<Patient>(patients);
                dataGridView1.DataSource = this.pacijenti;

                if (this.pacijenti.Count == 0)
                {
                    MessageBox.Show("Patient not found!");
                }
                else if (textBoxSearch.Text != "")
                {
                    MessageBox.Show("Patient list successfully loaded!");
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Sistem ne moze da pretrazi pacijente.");
                return;
            }
        }

        internal void IzmeniPacijenta(DataGridView dataGridView1)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                MainController.Instance.Patient = (Patient)dataGridView1.SelectedRows[0].DataBoundItem;
                MainController.Instance.IzmenaPacijentaForma();
            }
        }

        internal void OtvoriDijagnozu(DataGridView dataGridView1)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                MainController.Instance.Patient = (Patient)dataGridView1.SelectedRows[0].DataBoundItem;
                MainController.Instance.UnosDijagnozeForma();
            }
        }
    }
}
