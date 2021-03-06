using System;
using System.Collections;
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
        
        public void Sort()
        {
            for (int i = 0; i < tab.Count; i++)
            {
                int min = tab[i].CalculAge();;
                int indice = -1;
                bool trouve = false;
                
                for (int j = i + 1; j < tab.Count; j++)
                {
                    int ageJ = tab[j].CalculAge();
                    
                    if (min > ageJ)
                    {
                        trouve = true;
                        min = ageJ;
                        indice = j;
                    }
                }

                if (trouve)
                {
                    Collaborateur tmp = tab[indice];
                    tab[indice] = tab[i];
                    tab[i] = tmp;
                }
            }
        }

        public void Sort(String str)
        {
            for (int i = 0; i < tab.Count; i++)
            {
                double min = tab[i].CalculSalaire();;
                int indice = -1;
                bool trouve = false;
                
                for (int j = i + 1; j < tab.Count; j++)
                {
                    double salaireJ = tab[j].CalculSalaire();
                    
                    if (min > salaireJ)
                    {
                        trouve = true;
                        min = salaireJ;
                        indice = j;
                    }
                }

                if (trouve)
                {
                    Collaborateur tmp = tab[indice];
                    tab[indice] = tab[i];
                    tab[i] = tmp;
                }
            }
        }

        public List<Collaborateur> Tab => tab;

        public override string ToString()
        {
            String str = "";

            str += "Liste des Collaborateurs :\n\n\t";

            foreach (var collaborateur in tab)
            {
                str += collaborateur.ToString() + "\n\n\t";
            }
            
            return str;
        }
    }
}