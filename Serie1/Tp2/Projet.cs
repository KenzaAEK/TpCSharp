using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    public class Projet
    {
        // Propriétés
        public string Code { get; private set; }
        public string Sujet { get; private set; }
        public int DureeSemaines { get; private set; }
        private List<Programmeur> programmeurs;
        private List<ConsommationCafe> consommations;

        // Constructeur
        public Projet(string code, string sujet, int dureeSemaines)
        {
            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(sujet))
                throw new ArgumentException("Le code et le sujet ne peuvent pas être vides.");
            if (dureeSemaines <= 0)
                throw new ArgumentException("La durée doit être positive.");

            Code = code;
            Sujet = sujet;
            DureeSemaines = dureeSemaines;
            programmeurs = new List<Programmeur>();
            consommations = new List<ConsommationCafe>();
        }

        // Ajouter un programmeur
        public void AjouterProgrammeur(Programmeur programmeur)
        {
            if (programmeurs.Any(p => p.Id == programmeur.Id))
                throw new ArgumentException("Ce programmeur existe déjà dans le projet.");
            programmeurs.Add(programmeur);
        }

        // Supprimer un programmeur
        public void SupprimerProgrammeur(int id)
        {
            var programmeur = programmeurs.FirstOrDefault(p => p.Id == id);
            if (programmeur == null)
                throw new ArgumentException("Programmeur introuvable.");
            programmeurs.Remove(programmeur);
        }

        // Ajouter une consommation de café
        public void AjouterConsommation(int numeroSemaine, int programmeurId, int nombreTasses)
        {
            var programmeur = programmeurs.FirstOrDefault(p => p.Id == programmeurId);
            if (programmeur == null)
                throw new ArgumentException("Programmeur introuvable.");

            consommations.Add(new ConsommationCafe(numeroSemaine, programmeur, nombreTasses));
        }

        // Calculer la consommation totale d'une semaine
        public int ConsommationTotaleSemaine(int numeroSemaine)
        {
            return consommations.Where(c => c.NumeroSemaine == numeroSemaine).Sum(c => c.NombreTasses);
        }
    }
}
