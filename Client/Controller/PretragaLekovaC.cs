using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transfer;

namespace Client.Controller
{
    class PretragaLekovaC
    {

        private BindingList<Medicine> medicines = new BindingList<Medicine>();


        public void PretraziLekove(TextBox txtBoxSearch, DataGridView dgv)
        {
            try
            {
                string text = txtBoxSearch.Text;
                Medicine m = new Medicine()
                {
                    Doctor = MainController.Instance.Doctor
                };

                m.SearchWhere = $"where (m.MedicineName LIKE '%{text}%' OR m.MedicineCategory LIKE '%{text}%')";
                List<Medicine> medicines = (List<Medicine>)Communication.Instance.PretragaLekova(m).Object;

                this.medicines = new BindingList<Medicine>(medicines);
                dgv.DataSource = this.medicines;

                if (this.medicines.Count == 0)
                {
                    MessageBox.Show("Medicine not found!");
                } 
                else if (txtBoxSearch.Text != "")
                {
                    MessageBox.Show("Medicine list successfully loaded!");
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pretrazi lekove.");
                return;
            }
        }

        public void ObrisiLek(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Invalid data");
                return;
            }

            try
            {
                Medicine m = (Medicine)dgv.SelectedRows[0].DataBoundItem;
                Response r = Communication.Instance.BrisanjeLeka(m);
                if (r.Signal == Signal.OK)
                {
                    MessageBox.Show(r.Message);
                    this.medicines.Remove(m);
                }
                else
                {
                    MessageBox.Show(r.Message);
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da obrise lek.");
                return;
            }
        }
    }
}
