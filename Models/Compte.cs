using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Compte
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }

        public virtual void Retrait(double montant)
        {
            if (montant <= Solde)
            {
                Solde -= montant;
            }
        }

        public void Depot(double montant)
        {
            if (montant > 0)
            {
                Solde += montant;
            }
        }
    }
}
