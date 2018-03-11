using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrintheTest.Structures;

namespace LabyrintheTest.Structures
{
    public class Combat
    {
        public Personnages Joueur;
        public Personnages Adverse;
        public Combat() { }
        public static Random hasard = new Random();
        public Combat(Personnages joueur, Personnages adverse)
        {
            Joueur = joueur;
            Adverse = adverse;
        }
        
        

            
            /* public bool AttaquePremier(Personnages hero, Personnages adverse)
             {
                 if(Joueur.Age > Adverse.Age)
                 {
                     return true;
                 }return false;
             }*/

            /*    public bool FrapperAdversaire(Personnages adverse)
                {
                    if()
                    {
                        return true;
                    }return false;
                }*/










        }
}
