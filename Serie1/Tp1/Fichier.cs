using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp1;

namespace Tp1
{
    class Fichier
    {
        public string Nom { get; set; }
        public string Extension { get; set; }
        public float Taille { get; set; } // en KO

        public Fichier(string nom, string extension, float taille)
        {
            Nom = nom;
            Extension = extension;
            Taille = taille;
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}.{Extension}, Taille: {Taille} KO");
        }
    }
}