namespace Models
{
    public class Courant: Compte
    {
      
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

        public override void Retrait(double montant)
        {
            if(montant <= ( Solde + _ligneDeCredit) )
            {
                base.Retrait(montant);
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
