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
            c1.Numero = "BE45 4545 4545 4545";
            c1.LigneDeCredit = 1000;

            Courant c2 = new Courant();
            c2.Titulaire = p1;
            c2.Numero = "CH65 6565 6565 6565";
            c2.LigneDeCredit = 0;
            c2.Depot(2_500_000);

            // -------- Recap infos compte

            Console.WriteLine($"Compte {c1.Numero} :\n".ToUpper());
            Console.WriteLine($"Titulaire : {c1.Titulaire.Prenom} {c1.Titulaire.Nom}");
            Console.WriteLine($"Solde actuel : {c1.Solde} €");
            // Le :0.00 après un nombre indique qu'à l'affichage, il faudra toujours afficher deux chiffres après la virgule. Si c'est un compte rond, va afficher 2 fois 00
            // ex : 999 -> 999,00
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

            Banque b1 = new Banque();
            b1.Nom = "MaSuperBanque";

            b1.Ajouter(c1);
            b1.Ajouter(c1);

            Courant compteRecherche = b1["BE45 4545 4545 4545"];
            // Si on a trouvé un compte
            if(compteRecherche != null)
            {
                Console.WriteLine("Compte trouvé");
                Console.WriteLine($"Le compte appartient à {compteRecherche.Titulaire.Prenom} {compteRecherche.Titulaire.Nom}");
            }
            else //sinon, on n'a pas trouvé de compte
            {
                Console.WriteLine("Compte introuvable");
            }

            Console.WriteLine("Notre petit chanceux vient d'hériter d'un compte d'un viel oncle suisse");
            b1.Ajouter(c2);
            Console.WriteLine("🚨 Wihou wihou. La banque est suspicieuse envers ce compte et ne veut plus nous garder chez eux");
            b1.Supprimer("CH65 6565 6565 6565");

            Console.ReadKey();

        }
    }
}
