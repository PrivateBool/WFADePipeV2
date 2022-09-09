using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADePipeV2
{
    public class DeOrdinaire : De
    {
        public DeOrdinaire() : base("Dé ordinaire")
        {
        }

        public override void Brasser()
        {
            this.Valeur = (int)(Math.Ceiling((hasard.NextDouble()) * this.NombreDeFace));
        }
    }
}
