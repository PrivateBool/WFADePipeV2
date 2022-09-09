using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADePipeV2
{
    public class Controleur
    {
        private int totalObtenu = 0;
        private DeOrdinaire deOrdinaire;
        private DePipe dePipe;
        private int hasard;
        public Controleur()
        {
            this.totalObtenu = 0;
            this.deOrdinaire = new DeOrdinaire();
            this.dePipe = new DePipe();
        }

        public int TotalObtenu { get => totalObtenu; set => totalObtenu = value; }
        public DeOrdinaire DeOrdinaire { get => deOrdinaire; set => deOrdinaire = value; }
        public DePipe DePipe { get => dePipe; set => dePipe = value; }
        public int Hasard { get => hasard; set => hasard = value; }

        public void GenererDe()
        {
            Random r = new Random();
            hasard = r.Next(0, 2);
            if (hasard == 0)
            {
                DeOrdinaire = new DeOrdinaire();                
            }
            else
            {
                DePipe = new DePipe();
            }
        }
        public int Brasser(int hasard) 
        {
            if (hasard == 0)
            {
                deOrdinaire.Brasser();
                totalObtenu += DeOrdinaire.Valeur;
                return deOrdinaire.Valeur;
            }
            else
            {
                dePipe.Brasser();
                totalObtenu += DePipe.Valeur;
                return dePipe.Valeur;
            }           
        }
        public string TrouverTypeDeDe(int hasard)
        {
            if (hasard == 0)
            {
                return deOrdinaire.TypeDeDe;
            }
            else
            {
                return dePipe.TypeDeDe;
            }
        }
    }
}
