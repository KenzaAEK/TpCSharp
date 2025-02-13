using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Biblio
    {
        private List<Document> documents = new List<Document>();

        // Ajouter un document à la bibliothèque
        public void AjouterDocument(Document doc)
        {
            documents.Add(doc);
            Console.WriteLine($"Document ajouté : {doc.Description()}");
        }

        // Calculer le nombre de livres
        public int NombreDeLivres()
        {
            int count = 0;
            foreach (var doc in documents)
            {
                if (doc is Livre)
                    count++;
            }
            return count;
        }

        // Afficher la liste des dictionnaires
        public void AfficherDictionnaires()
        {
            Console.WriteLine("\n Liste des Dictionnaires :");
            foreach (var doc in documents)
            {
                if (doc is Dictionnaire)
                    Console.WriteLine(doc.Description());
            }
        }

        // Afficher la liste des auteurs des livres
        public void TousLesAuteurs()
        {
            Console.WriteLine("\n Liste des Auteurs :");
            foreach (var doc in documents)
            {
                if (doc is Livre livre)
                    Console.WriteLine($"ID: {livre.Id}, Auteur: {livre.Auteur}");
            }
        }

        // Afficher toutes les descriptions des documents
        public void ToutesLesDescriptions()
        {
            Console.WriteLine("\n Descriptions de tous les documents :");
            foreach (var doc in documents)
            {
                Console.WriteLine(doc.Description());
            }
        }
    }
}
