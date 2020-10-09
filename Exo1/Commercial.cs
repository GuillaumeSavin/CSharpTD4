using System;

namespace Exo1
{
    public class Commercial : Collaborateur
    {
        private int sommeFixe;
        private int chiffreAffaire;
        private Double t2 = 0.01;

        public Commercial(string mNom, String mDate, int mSommeFixe, int mChiffreAffaire) : base(mNom, mDate)
        {
            this.sommeFixe = mSommeFixe;
            this.chiffreAffaire = mChiffreAffaire;
        }
        
        public override double CalculSalaire()
        {
            return this.sommeFixe + this.chiffreAffaire * t2;
        }

        public override String ToString()
        {
            String str = "";

            str = base.ToString();
            str += "\n\tSomme fixe: " + this.sommeFixe + "\n\tChiffre d'Affaire: " +
                   this.chiffreAffaire;
            return str;
        }
    }
}