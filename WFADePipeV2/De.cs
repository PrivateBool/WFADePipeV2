using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADePipeV2
{
    public abstract class De
    {
        private int valeur;
        private int nombreDeFace = 6;
        private string typeDeDe;
        public Random hasard = new Random();
        public int Valeur { get => valeur; set => valeur = value; }
        public int NombreDeFace { get => nombreDeFace;}
        public string TypeDeDe { get => typeDeDe; set => typeDeDe = value; }

        public De(string typeDeDe)
        {
            this.TypeDeDe = typeDeDe;
        }
        public abstract void Brasser();
    }
}
