using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    public class Dictionnaire : Document
    {
        public string Langue { get; set; }
        public int NombreDeDefinitions { get; set; }

        public Dictionnaire(string titre, string langue, int nombreDeDefinitions)
            : base(titre)
        {
            this.Langue = langue;
            this.NombreDeDefinitions = nombreDeDefinitions;
        }

        public override string Description()
        {
            return $"[Dictionnaire] ID: {Id}, Titre: {Titre}, Langue: {Langue}, Définitions: {NombreDeDefinitions}";
        }
    }
}
