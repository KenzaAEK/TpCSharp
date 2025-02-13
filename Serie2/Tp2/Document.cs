using System;
using System.Collections.Generic;

namespace Tp2
{
    public abstract class Document
    {
        private static int counter = 1;
        public int Id { get; }
        public string Titre { get; set; }

        public Document(string titre)
        {
            this.Id = counter++;
            this.Titre = titre;
        }

        // Méthode virtuelle pour description (sera redéfinie dans les classes dérivées)
        public abstract string Description();
    }
}