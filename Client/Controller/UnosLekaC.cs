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
    class UnosLekaC
    {
        internal void InitForm(ListBox lboxBolesti)
        {
            lboxBolesti.DataSource = Communication.Instance.UcitajBolesti();
        }

        internal void UnesiLek(TextBox txtImeLeka, TextBox txtKategorijaLeka, ListBox lboxBolesti)
        {
            if (txtKategorijaLeka.Text == "" || txtImeLeka.Text == "" || lboxBolesti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Invalid input");
                return;
            }

            Medicine m = new Medicine()
            {
                Doctor = MainController.Instance.Doctor,
                MedicineCategory = txtKategorijaLeka.Text,
                MedicineName = txtImeLeka.Text,
                Illnesses = lboxBolesti.SelectedItems.OfType<Illness>().ToList()
            };

            try
            {
                Response r = Communication.Instance.UnosLeka(m);
                txtImeLeka.Clear();
                txtKategorijaLeka.Clear();
                lboxBolesti.ClearSelected();
                MessageBox.Show("Medicine saved!");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Medicine not saved!");
                return;
            }
        }
    }
}
