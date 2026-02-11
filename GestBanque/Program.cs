using Models;

namespace GestBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Personne p1 = new Personne();

            // ici tout est publique
            p1.Nom = "Doe";
            p1.Prenom = "John";
            p1.DateDeNaissance = new DateTime(1988-12-15);

            Courant c1 = new Courant();

            c1.Titulaire = p1;
            c1.Numero = "be1412";
            c1.LigneDeCredit = 1000;

            // -------- Recap infos compte

            Console.WriteLine($"Compte {c1.Numero} :\n".ToUpper());
            Console.WriteLine($"Titulaire : {c1.Titulaire.Prenom} {c1.Titulaire.Nom}");
            Console.WriteLine($"Solde actuel : {c1.Solde} €");
            Console.WriteLine($"Crédit autorisé : {c1.LigneDeCredit:0.00} €");
            Console.WriteLine(new String('-', 40));

            // ------- Test retrait

            Console.WriteLine("\nTentative de retrait : 999,00 €");
            c1.Retrait(999);
            Console.WriteLine($"Le solde est maintenant de {c1.Solde:0.00} €");

            // ------- Test dépôt

            Console.WriteLine("\nTentative de dépôt : 1500,00 €");
            c1.Depot(1500);
            Console.WriteLine($"Le solde est maintenant de {c1.Solde:0.00} €");

            Console.WriteLine(new String('-', 40));

            // -------- Banque
            Console.WriteLine("\nCréation d'une banque :\n".ToUpper());

            Console.ReadKey();

        }
    }
}
