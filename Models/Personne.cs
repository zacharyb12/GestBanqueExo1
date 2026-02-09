using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Personne
    {
        //Créer une classe « Personne » 
        //qui devra implémenter
        //Les propriétés publiques: 

        // Nom(string) 
        // Prenom(string) 
        // DateNaiss(DateTime) - date de naissance

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
    }
}
