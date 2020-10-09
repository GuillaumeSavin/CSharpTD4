using System;

namespace Exo1
{
    public class Manager : Collaborateur
    {
        private int salaireBase;
        private int prime;

        public Manager(string mNom, String mDate, int mSalaireBase, int mPrime) : base(mNom, mDate)
        {
            this.salaireBase = mSalaireBase;
            this.prime = mPrime;
        }
        
        public override double CalculSalaire()
        {
            return this.salaireBase + this.prime;
        }

        public override String ToString()
        {
            String str = "";

            str = base.ToString();
            str += "\n\tSalaire de base: " + this.salaireBase + "\n\tPrime: " +
                   this.prime;
            return str;
        }
    }
}