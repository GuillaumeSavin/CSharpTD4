using System;

namespace Exo1
{
    public class Employe : Collaborateur
    {
        private int tauxHoraire;
        private int nbrHeure;
        private const Double t1 = 0.42;
        
        public Employe(string mNom, String mDate, int mTauxHoraire, int mNbrHeure) : base(mNom, mDate)
        {
            this.tauxHoraire = mTauxHoraire;
            this.nbrHeure = mNbrHeure;
        }

        public override double CalculSalaire()
        {
            if (this.nbrHeure > 35)
            {
                return this.tauxHoraire * 35 + (this.tauxHoraire * (1 + t1))  * (this.nbrHeure - 35);
            }
            else
            {
                return this.tauxHoraire * this.nbrHeure;
            }
        }
        
        public override String ToString()
        {
            String str = "";

            str = base.ToString();
            str += "\n\tTaux Horaire : " + this.tauxHoraire + "\n\tNombre d'heure travaillé dans la semaine: " +
                   this.nbrHeure;
        
            return str;
        }
    }
}