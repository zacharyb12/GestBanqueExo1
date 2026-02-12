namespace Models
{
    public class Courant
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }
      

        private double _ligneDeCredit;

        public double LigneDeCredit 
        { 
            get
            {
                return _ligneDeCredit;
            }
            set
            {
                if(value >= 0)
                {
                    _ligneDeCredit = value;
                }
            }
        }

        public void Retrait(double montant)
        {
            // Ligne de credit : 1000
            // Solde           : 500
            if(montant <= ( Solde + _ligneDeCredit) )
            {
                Solde -= montant;
            }
        }

        public void Depot(double montant)
        {
            if(montant > 0)
            {
                Solde += montant;
            }
        }

        public static double operator + (double montant, Courant c)
        {
            if (c.Solde < 0)
            {
                Console.WriteLine("Hop hop les soldes négatifs, c'est non !");
                return montant;
            }

            return c.Solde + montant;
        }
    }
}
