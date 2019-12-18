using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWindowsFormsApp
{
    class Personne
    {
        //Attributs
        string nom, prenom, naissance;
        int age;

        //constructeur
        public Personne(string _nom, string _prenom, string _naissance, int _age)
        {
            nom = _nom;
            prenom = _prenom;
            age = _age;
            naissance = _naissance;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Naissance { get => naissance; set => naissance = value; }
        public int Age { get => age; set => age = value; }

        //méthode






    }
}
