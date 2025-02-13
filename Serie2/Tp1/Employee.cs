using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    public class Employee
    {
        private string nom;
        private double salaire; 
        private string poste;
        private DateTime dateEmbauche;

        public Employee(string nom, double salaire, string poste, DateTime dateEmbauche)
        {
            this.nom = nom;
            this.salaire = salaire;
            this.poste = poste;
            this.dateEmbauche = dateEmbauche;
        }

        public string Nom { get => nom; set => nom = value; }
        public double Salaire { get => salaire; set => salaire = value; }
        public string Poste { get => poste; set => poste = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
    }
}
