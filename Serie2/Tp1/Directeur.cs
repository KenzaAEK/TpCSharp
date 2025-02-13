using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Tp1
{
        public class Directeur
        {
            private static Directeur instance;
            private GestionEmployes gestionEmployes;
            private Directeur()
            {
                gestionEmployes = new GestionEmployes();
            }
            public static Directeur GetInstance()
            {
                if (instance == null)
                {
                    instance = new Directeur();
                }
                return instance;
            }
            public double ObtenirSalaireTotal()
            {
                return gestionEmployes.CalculerSalaireTotal();
            }
            public double ObtenirSalaireMoyen()
            {
                return gestionEmployes.CalculerSalaireMoyen();
            }
            public void SetGestionEmployes(GestionEmployes gestionEmployes)
            {
                this.gestionEmployes = gestionEmployes;
            }

        }
    }