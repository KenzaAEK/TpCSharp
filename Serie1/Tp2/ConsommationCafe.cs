using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    public class ConsommationCafe
    {
        // Propriétés
        public int NumeroSemaine { get; private set; }
        public Programmeur Programmeur { get; private set; }
        public int NombreTasses { get; private set; }

        // Constructeur
        public ConsommationCafe(int numeroSemaine, Programmeur programmeur, int nombreTasses)
        {
            if (numeroSemaine <= 0)
                throw new ArgumentException("Le numéro de semaine doit être un entier positif.");
            if (programmeur == null)
                throw new ArgumentNullException("Le programmeur ne peut pas être null.");
            if (nombreTasses < 0)
                throw new ArgumentException("Le nombre de tasses ne peut pas être négatif.");

            NumeroSemaine = numeroSemaine;
            Programmeur = programmeur;
            NombreTasses = nombreTasses;
        }

        // Méthode pour ajouter des tasses de café
        public void AjouterTasses(int tasses)
        {
            if (tasses <= 0)
                throw new ArgumentException("Le nombre de tasses ajouté doit être positif.");
            NombreTasses += tasses;
        }

        // Méthode d'affichage des consommations
        public override string ToString()
        {
            return $"Semaine: {NumeroSemaine}, Programmeur: {Programmeur.Nom} {Programmeur.Prenom}, Tasses: {NombreTasses}";
        }
    }

}
