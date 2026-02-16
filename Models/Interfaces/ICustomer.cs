using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    //Définir l’interface « ICustomer »,
    //afin de limiter l’accès à consulter la propriété « Solde » et
    //d’utiliser les méthodes « Depot » et « Retrait ».
    public interface ICustomer
    {
        double Solde { get; }

        void Depot(double montant);
        void Retrait(double montant);

    }
}
