using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Compte
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

        //Ajouter une méthode abstraite « protected » à la classe « Compte »
        //appelée « CalculInteret » ayant pour prototype « double CalculInteret() »
        protected abstract double CalculInteret();

        //Ajouter une méthode « public » à la classe « Compte » appelée « AppliquerInteret »
        //qui additionnera le solde avec le retour de la méthode « CalculInteret ».
        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

    }
}
