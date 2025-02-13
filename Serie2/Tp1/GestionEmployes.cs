using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    public class GestionEmployes
    {
        private List<Employee> employees = new List<Employee>();
        public void AjouterEmploye(Employee employe)
        {
            employees.Add(employe);
        }

        public void SupprimerEmploye(string nom)
        {
            employees.RemoveAll(employee => employee.Nom == nom);
        }
        public double CalculerSalaireTotal()
        {
            return employees.Sum(employee => employee.Salaire);
        }
        public double CalculerSalaireMoyen()
        {
            if (employees.Count > 0)
            {
                return employees.Average(employee => employee.Salaire);
            }
            return 0;
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }

    }
}