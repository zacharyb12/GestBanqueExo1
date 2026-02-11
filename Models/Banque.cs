using System.Collections.Generic;
using System.Security.Cryptography;

namespace Models
{
    public class Banque
    {
        // Champs
        //private Dictionary<string, Courant> _comptes = new Dictionary<string,Courant>();
        // 👇🏼 écriture raccourcie de la ligne du dessus
        private Dictionary<string, Courant> _comptes = [];

        // Props
        public string Nom { get; set; }

        // Indexeur
        public Courant this[string numero]
        {
            get
            {
                Courant c;
                bool compteTrouve = _comptes.TryGetValue(numero, out c);
                if (!compteTrouve)
                {
                    Console.WriteLine("Désolés, il n'y a aucun compte avec ce numéro chez nous.");
                }
                return c; 
                // null si aucun compte trouvé, rempli avec le compte si trouvé
            }
            
        }

        public void Ajouter(Courant compte)
        {
            //V1 : Minimum syndical
            //_comptes.Add(compte.Numero, compte);

            //V2 : Si on fait un minimum attention aux détails
            bool etreDejaPresent = _comptes.ContainsKey(compte.Numero);
            if (etreDejaPresent) 
            {
                Console.WriteLine("Un compte avec ce numéro est déjà présent dans notre système");
            } else
            {
                _comptes.Add(compte.Numero, compte);
                Console.WriteLine("Compte ajouté avec succès !");
            }
        }

        public void Supprimer(string numero)
        {
            //V1 : Minimum syndical
            //_comptes.Remove(numero);

            //V2 : Minimum détails
            bool etrePresent = _comptes.ContainsKey(numero);
            if(!etrePresent)
            {
                Console.WriteLine("Vous essayez de supprimer un compte qui n'est pas présent dans notre système");
            }
            else
            {
                _comptes.Remove(numero);
                Console.WriteLine("Compte supprimé avec succès");
            }
        }
    }
}
