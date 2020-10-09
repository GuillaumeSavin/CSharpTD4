using System;

namespace Exo1
{
    public abstract class Collaborateur
    {
        private String nom;
        private DateTime dateDeNaissance;

        public Collaborateur(String mNom, String mDate)
        {
            this.nom = mNom;
            this.dateDeNaissance = DateTime.ParseExact(mDate, "ddMMyyyy", null);
        }

        public string Nom => nom;

        public DateTime DateDeNaissance => dateDeNaissance;

        public abstract Double CalculSalaire();

        public override string ToString()
        {
            String str = "";

            str += this.GetType().Name + " : \n\tNom: " + this.Nom + "\n\tDate de Naissance: " +
                   this.DateDeNaissance.ToShortDateString();
        
            return str;
        }
    }
}