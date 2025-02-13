using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2 { 
// Programme principal
public class Program
{
    static void Main()
    {
        Biblio bibliotheque = new Biblio();

        // Ajout de quelques livres et dictionnaires
        bibliotheque.AjouterDocument(new Livre("The picture of Dorian Gray", "Oscar Wild", 196));
        bibliotheque.AjouterDocument(new Livre("1984", "George Orwell", 328));
        bibliotheque.AjouterDocument(new Dictionnaire("Larousse Français", "Français", 50000));
        bibliotheque.AjouterDocument(new Dictionnaire("Oxford English Dictionary", "Anglais", 60000));

        // Affichage des informations
        Console.WriteLine($"\n Nombre total de livres : {bibliotheque.NombreDeLivres()}");
        bibliotheque.AfficherDictionnaires();
        bibliotheque.TousLesAuteurs();
        bibliotheque.ToutesLesDescriptions();
    }
}
}
