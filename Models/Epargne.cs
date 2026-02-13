using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Epargne: Compte
    {
        public DateTime DateDernierRetrait { get; set; }

        public override void Retrait(double montant)
        {
            base.Retrait(montant);
            DateDernierRetrait = DateTime.Now;
        }

        protected override double CalculInteret()
        {
            //en sachant que pour un livret d’épargne le taux est toujours de 4.5%
            return Solde * 0.045;

            //double result = (Solde / 100) * 4.5;
            //return result;

        }
    }
}
