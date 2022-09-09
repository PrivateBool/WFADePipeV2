using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADePipeV2
{
    public class DePipe : De
    {
        public DePipe() : base("Dé pipé")
        {
        }
        public override void Brasser()
        {
            int resultatDe = (int)(Math.Ceiling((hasard.NextDouble()) * (this.NombreDeFace * 1.5)));
            if (resultatDe > 6)
            {
                this.Valeur = resultatDe - 3;
            }
            else
            {
                this.Valeur = resultatDe;
            }
        }
    }
}
