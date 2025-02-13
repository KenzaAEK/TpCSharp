using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    public class Livre : Document
    {
        public string Auteur { get; set; }
        public int NombreDePages { get; set; }

        public Livre(string titre, string auteur, int nombreDePages)
            : base(titre)
        {
            this.Auteur = auteur;
            this.NombreDePages = nombreDePages;
        }

        public override string Description()
        {
            return $"[Livre] ID: {Id}, Titre: {Titre}, Auteur: {Auteur}, Pages: {NombreDePages}";
        }
    }

}
