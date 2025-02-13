using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp1;

namespace Tp1
{
    class Repertoire
    {
        public string Nom { get; set; }
        public int Nbr_fichiers { get; private set; }
        private Fichier[] fichiers;

        public Repertoire(string nom)
        {
            Nom = nom;
            fichiers = new Fichier[30];
            Nbr_fichiers = 0;
        }

        public void Afficher()
        {
            Console.WriteLine($"Répertoire: {Nom} (Nombre de fichiers: {Nbr_fichiers})");
            for (int i = 0; i < Nbr_fichiers; i++)
            {
                fichiers[i].Afficher();
            }
        }

        public int Rechercher(string nom)
        {
            for (int i = 0; i < Nbr_fichiers; i++)
            {
                if (fichiers[i].Nom.Equals(nom, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        public void Ajouter(Fichier fichier)
        {
            if (Nbr_fichiers < 30)
            {
                fichiers[Nbr_fichiers++] = fichier;
            }
            else
            {
                Console.WriteLine("Le répertoire est plein.");
            }
        }

        public void RechercherPdf()
        {
            Console.WriteLine("Fichiers PDF :");
            for (int i = 0; i < Nbr_fichiers; i++)
            {
                if (fichiers[i].Extension.Equals("pdf", StringComparison.OrdinalIgnoreCase))
                {
                    fichiers[i].Afficher();
                }
            }
        }

        public void Supprimer(string nom)
        {
            int index = Rechercher(nom);
            if (index != -1)
            {
                for (int i = index; i < Nbr_fichiers - 1; i++)
                {
                    fichiers[i] = fichiers[i + 1];
                }
                fichiers[--Nbr_fichiers] = null;
                Console.WriteLine("Fichier supprimé avec succès.");
            }
            else
            {
                Console.WriteLine("Fichier introuvable.");
            }
        }

        public void Renommer(string ancienNom, string nouveauNom)
        {
            int index = Rechercher(ancienNom);
            if (index != -1)
            {
                fichiers[index].Nom = nouveauNom;
                Console.WriteLine("Fichier renommé avec succès.");
            }
            else
            {
                Console.WriteLine("Fichier introuvable.");
            }
        }

        public void Modifier(string nom, float nouvelleTaille)
        {
            int index = Rechercher(nom);
            if (index != -1)
            {
                fichiers[index].Taille = nouvelleTaille;
                Console.WriteLine("Taille du fichier modifiée avec succès.");
            }
            else
            {
                Console.WriteLine("Fichier introuvable.");
            }
        }

        public float GetTaille()
        {
            float totalTaille = 0;
            for (int i = 0; i < Nbr_fichiers; i++)
            {
                totalTaille += fichiers[i].Taille;
            }
            return totalTaille / 1024; // Convertir KO en MO
        }
    }
}
