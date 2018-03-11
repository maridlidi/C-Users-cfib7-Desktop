using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrintheTest.Structures;

namespace LabyrintheTest.Structures
{
   
    public class Personnages
    {
        public string Nom;
        public int Age;// SIMILAIRE A POINT DE VITESSE, +AGE ATTAQUE EN PREMIER
        public int Vie;// A TOUT LES RETOURS A LA CASE DEPART, ENLEVE UNE VIE
        public int VieMax;
        public double Argent;// CHAQUE STEP COUTE DE L'ARGENT, SI 0......
        //public double Confiance;/// SI ON GAGNE UN COMBAT, ON HERITE DE SA CONFIANCE
        //public Objets Objet;
         
        public Personnages(string _nom, int _age, double _argent, int vie/*, double _confiance, Objets _objet*/)
        {
            Nom = _nom;
            Age = _age;
            Vie = VieMax;
            VieMax = 10;
            Argent = _argent;
          //  Confiance = _confiance;
           // Objet = _objet;
        }
        public Personnages() { }

        // RETOURNE VRAI SI ARGENT, VIE ET/OU CONFIANCE A 0
        public bool Dead()
        {
            if(Argent==0 || Vie==0 /*|| Confiance==0*/)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // METHODE POUR ENLEVER UNE VIE
        public int MoinUneVie()
        {
            Vie--;
            return MoinUneVie();
        }

        // METHODE QUI VERIFIE S'IL RESTE DE L'ARGENT
        public Personnages PasseAuCash()
        {
            foreach(var choix in )
        }
        // METHODE VIE VERIFIE S'IL RESTE DES VIES

    }
}
