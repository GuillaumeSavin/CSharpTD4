using System;

namespace Exo1
{
    class Prog
    {
        static void Main(string[] args)
        {
            TabCollaborateur tab = new TabCollaborateur();
            Employe e1 = new Employe("Lejaune", "13051956", 20, 30);
            Employe e2 = new Employe("LeBlanc", "20051970", 15, 100);
            Manager m1 = new Manager("LeRouge", "14011998", 2500, 150);
            Manager m2 = new Manager("LeVert", "29101987", 3000, 200);
            Commercial c1 = new Commercial("LeNoir", "29011987", 4000, 30000);
            Commercial c2 = new Commercial("LeViolet", "29011987", 3000, 30000);

            tab.Add(c1);
            tab.Add(e1);
            tab.Add(m1);
            tab.Add(e2);
            tab.Add(m2);
            tab.Add(c2);
            
            Console.WriteLine("COLLABORATEUR AYANT PLUS HAUT SALAIRE");
            Console.WriteLine(tab.PlusHautSal());
            Console.WriteLine("EMPLOYE AYANT PLUS HAUT SALAIRE");
            Console.WriteLine(tab.PlusHautSal("Employe"));
            Console.WriteLine("MANAGER AYANT PLUS HAUT SALAIRE");
            Console.WriteLine(tab.PlusHautSal("Manager"));
            Console.WriteLine("COMMERCIAL AYANT PLUS HAUT SALAIRE");
            Console.WriteLine(tab.PlusHautSal("Commercial"));

            Console.WriteLine("TRI SUR AGE ");
            tab.Sort();
            Console.WriteLine(tab.ToString());
            Console.WriteLine("TRI SUR SALAIRE ");
            tab.Sort("TriSalaire");
            Console.WriteLine(tab.ToString());

        }
    }
}