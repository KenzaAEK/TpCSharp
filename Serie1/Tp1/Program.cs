using System;
using Tp1;

namespace Tp1
{
    class Program
    {
        static void Main()
        {
            Repertoire rep = new Repertoire("MonDossier");
            rep.Ajouter(new Fichier("document", "pdf", 500));
            rep.Ajouter(new Fichier("image", "jpg", 1200));
            rep.Ajouter(new Fichier("rapport", "pdf", 300));

            rep.Afficher();
            rep.RechercherPdf();
            Console.WriteLine($"Taille totale du répertoire: {rep.GetTaille()} MO");

            rep.Supprimer("image");
            rep.Renommer("document", "new_doc");
            rep.Modifier("new_doc", 700);
            rep.Afficher();
        }
    }
}
