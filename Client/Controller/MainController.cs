using Client.UserControls;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    class MainController
    {
        private static MainController instance;
        public Doctor Doctor { get; set; }
        FRMClient forma;
        public Patient Patient { get; set; }
        public static MainController Instance
        {
            get
            {
                if (instance == null) instance = new MainController();
                return instance;
            }
        }

        internal void PostaviFormu(FRMClient f)
        {
            forma = f;
        }

        internal void UnosPacijentaForma()
        {
            forma.SetPanel(new UnosPacijenta());
        }

        public void UnesiBolestForma()
        {
            forma.SetPanel(new UnosBolesti());
        }

        public void UnosLekaForma()
        {
            forma.SetPanel(new UnosLeka());
        }

        public void UnosDijagnozeForma()
        {
            forma.SetPanel(new UnosDijagnoze());
        }

        public void PretragaPacijentaForma()
        {
            forma.SetPanel(new PretragaPacijenta());
        }

        public void PretragaLekova()
        {
            forma.SetPanel(new PretragaLekova());
        }

        public void IzmenaPacijentaForma()
        {
            forma.SetPanel(new IzmenaPacijenta());
        }
    }
}
