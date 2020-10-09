using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Exo1
{
    public class TabCollaborateur
    {
        private List<Collaborateur> tab = new List<Collaborateur>();

        public void Add(Collaborateur c)
        {
            this.tab.Add(c);
        }

        public Double PlusHautSal(String genre = "")
        {
            Double max = -1;

            switch (genre)
            {
                case "":
                    foreach (var collaborateur in tab)
                    {
                        Double salaireCollaborateur = collaborateur.CalculSalaire();
                        
                        if (max < salaireCollaborateur)
                        {
                            max = salaireCollaborateur;
                        }
                    }
                    break;
                
                case "Employe":
                    foreach (var collaborateur in tab)
                    {
                        Double salaireCollaborateur = collaborateur.CalculSalaire();
                        String typeCollaborateur = collaborateur.GetType().Name;
                        
                        if (max < salaireCollaborateur && typeCollaborateur == "Employe")
                        {
                            max = collaborateur.CalculSalaire();
                        }
                    }
                    break;
                
                case "Manager":
                    foreach (var collaborateur in tab)
                    {
                        Double salaireCollaborateur = collaborateur.CalculSalaire();
                        String typeCollaborateur = collaborateur.GetType().Name;
                        
                        if (max < salaireCollaborateur && typeCollaborateur == "Manager")
                        {
                            max = collaborateur.CalculSalaire();
                        }
                    }
                    break;
                
                case "Commercial":
                    foreach (var collaborateur in tab)
                    {
                        Double salaireCollaborateur = collaborateur.CalculSalaire();
                        String typeCollaborateur = collaborateur.GetType().Name;
                        
                        if (max < salaireCollaborateur && typeCollaborateur == "Commercial")
                        {
                            max = collaborateur.CalculSalaire();
                        }
                    }
                    break;
                
                default:
                    max = 0;
                    break;
            }
            
            return max;
        }
        public override string ToString()
        {
            String str = "";

            str += "Liste des Collaborateurs :\n\n";

            foreach (var collaborateur in tab)
            {
                str += collaborateur.ToString() + "\n";
            }
            
            return str;
        }
    }
}