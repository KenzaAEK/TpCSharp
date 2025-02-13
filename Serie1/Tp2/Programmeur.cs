using System;

namespace Tp2
{
    public class Programmeur
    {
        // Propriétés encapsulées
        public int Id { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public int Bureau { get; private set; }

        // Constructeur
        public Programmeur(int id, string nom, string prenom, int bureau)
        {
            if (id <= 0)
                throw new ArgumentException("L'ID doit être un nombre positif.");
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom))
                throw new ArgumentException("Le nom et le prénom ne peuvent pas être vides.");
            if (bureau <= 0)
                throw new ArgumentException("Le numéro du bureau doit être positif.");

            Id = id;
            Nom = nom;
            Prenom = prenom;
            Bureau = bureau;
        }

        // Méthode pour changer le bureau
        public void ChangerBureau(int nouveauBureau)
        {
            if (nouveauBureau <= 0)
                throw new ArgumentException("Le numéro du bureau doit être positif.");
            Bureau = nouveauBureau;
        }

        // Méthode d'affichage des détails du programmeur
        public override string ToString()
        {
            return $"ID: {Id}, Nom: {Nom}, Prénom: {Prenom}, Bureau: {Bureau}";
        }
    }
}
