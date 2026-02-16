using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
//Définir l’interface « IBanker » ayant les mêmes fonctionnalités que « ICustomer ».
//Elle lui permettra, en plus,
//d’invoquer la méthode du « AppliquerInteret » et
//offrira un accès en lecture au « Titulaire » et au « Numero ».
    public interface IBanker : ICustomer
    {
        public string Numero { get; }
        public Personne Titulaire { get; }

        void AppliquerInteret();
    }
}
