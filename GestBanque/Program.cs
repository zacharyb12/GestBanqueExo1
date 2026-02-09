using Models;
using System.Data;
using System.Runtime.ConstrainedExecution;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();

            // ici tout est publique
            p1.Nom = "Doe";
            p1.Prenom = "John";
            p1.DateDeNaissance = new DateTime(1988-12-15);

            Courant c1 = new Courant();

            c1.Titulaire = p1;
            c1.Numero = "be1412";
            c1.LigneDeCredit = 1000;

            c1.Retrait(999);
            Console.WriteLine("Retrait 999");
            Console.WriteLine($"Le solde est de {c1.Solde}");

            c1.Depot(1500);
            Console.WriteLine("Depot 1500");
            Console.WriteLine($"Le solde est de {c1.Solde}");


        }
    }
}
