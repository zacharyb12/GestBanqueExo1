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

        protected override double CalculInteret()
        {
            //tandis que pour le compte courant

            //si ( le solde est positif )
            //le taux sera de 3%
            //sinon
            //le taux sera de 9.75%.
            if(Solde > 0)
            {
                return Solde * 0.03;
            }else
            {
                return Solde * 0.0975;
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
