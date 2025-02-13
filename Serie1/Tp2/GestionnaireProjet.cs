using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{   
    public class GestionnaireProjet
    {
        private List<Projet> projets;

        public GestionnaireProjet()
        {
            projets = new List<Projet>();
        }

        public void CreerProjet(string code, string sujet, int dureeSemaines)
        {
            projets.Add(new Projet(code, sujet, dureeSemaines));
        }

        public Projet ObtenirProjet(string code)
        {
            return projets.FirstOrDefault(p => p.Code == code) ?? throw new ArgumentException("Projet introuvable.");
        }
    }
}
