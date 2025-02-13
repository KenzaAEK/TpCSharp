using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tp1
{
    public class Program
    {
        static void Main()
        {
            GestionEmployes gestionEmployes = new GestionEmployes();
            gestionEmployes.AjouterEmploye(new Employee("ALIA", 15000, "Informatique", new DateTime(2020, 4, 14)));
            gestionEmployes.AjouterEmploye(new Employee("KENZA", 25000, "Logistique", new DateTime(2021, 6, 6)));
            gestionEmployes.AjouterEmploye(new Employee("ZAHRAE", 75000, "Finance", new DateTime(2023, 2, 6)));

            Directeur directeur = Directeur.GetInstance();
            directeur.SetGestionEmployes(gestionEmployes);
            Console.WriteLine($"Salaire total de l'entreprise: {directeur.ObtenirSalaireTotal()} $");
            Console.WriteLine($"Salaire moyen de l'entreprise: {directeur.ObtenirSalaireMoyen()} $");
        }
    }
}