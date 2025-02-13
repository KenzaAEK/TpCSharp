using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            GestionnaireProjet gestionnaire = new GestionnaireProjet();
            Console.WriteLine("Bienvenue dans l'application de suivi de consommation de café des programmeurs !");

            while (true)
            {
                Console.WriteLine("\nMenu :");
                Console.WriteLine("1. Créer un projet");
                Console.WriteLine("2. Ajouter un programmeur à un projet");
                Console.WriteLine("3. Ajouter une consommation de café");
                Console.WriteLine("4. Afficher la consommation totale d'une semaine");
                Console.WriteLine("5. Quitter");
                Console.Write("Choisissez une option : ");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        Console.Write("Code du projet : ");
                        string code = Console.ReadLine();
                        Console.Write("Sujet du projet : ");
                        string sujet = Console.ReadLine();
                        Console.Write("Durée (en semaines) : ");
                        int duree = int.Parse(Console.ReadLine());
                        gestionnaire.CreerProjet(code, sujet, duree);
                        Console.WriteLine("Projet créé avec succès !");
                        break;
                    case "2":
                        Console.Write("Code du projet : ");
                        string codeProjet = Console.ReadLine();
                        var projet = gestionnaire.ObtenirProjet(codeProjet);
                        Console.Write("ID du programmeur : ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Nom : ");
                        string nom = Console.ReadLine();
                        Console.Write("Prénom : ");
                        string prenom = Console.ReadLine();
                        Console.Write("Bureau : ");
                        int bureau = int.Parse(Console.ReadLine());
                        projet.AjouterProgrammeur(new Programmeur(id, nom, prenom, bureau));
                        Console.WriteLine("Programmeur ajouté avec succès !");
                        break;
                    case "3":
                        Console.Write("Code du projet : ");
                        string projetCode = Console.ReadLine();
                        projet = gestionnaire.ObtenirProjet(projetCode);
                        Console.Write("ID du programmeur : ");
                        int progId = int.Parse(Console.ReadLine());
                        Console.Write("Numéro de semaine : ");
                        int semaine = int.Parse(Console.ReadLine());
                        Console.Write("Nombre de tasses : ");
                        int tasses = int.Parse(Console.ReadLine());
                        projet.AjouterConsommation(semaine, progId, tasses);
                        Console.WriteLine("Consommation enregistrée avec succès !");
                        break;
                    case "4":
                        Console.Write("Code du projet : ");
                        string codeP = Console.ReadLine();
                        projet = gestionnaire.ObtenirProjet(codeP);
                        Console.Write("Numéro de semaine : ");
                        int numSemaine = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Consommation totale : {projet.ConsommationTotaleSemaine(numSemaine)} tasses");
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Option invalide, veuillez réessayer.");
                        break;
                }
            }
        }
    }
}

}
