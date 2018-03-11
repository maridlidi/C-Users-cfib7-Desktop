using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrintheTest.Structures;

namespace LabyrintheTest.Structures
{
    public class RochePapierCiseau
    {
        public Personnages Joueur;
        public Personnages Ordi;
        public RochePapierCiseau() { }
        public RochePapierCiseau(Personnages joueur)
        {
            Joueur = joueur;
           
        }
        public bool JeuRochePapierCiseau()
        {
            
            string[] jeu = new string[] { "ROCHE", "PAPIER", "CISEAU" };
            Random r = new Random();
            var hasard = r.Next(0, jeu.Length);
            //Console.WriteLine(jeu[hasard]);
            string choixordi = jeu[hasard];
            Console.WriteLine(choixordi);
            string reponseJoueur = Console.ReadLine();
            {
                if (reponseJoueur == choixordi)
                {
                    return false;
                }
                else if (reponseJoueur.ToUpper() == "ROCHE" && choixordi == "CISEAU" ||
                    reponseJoueur.ToUpper() == "PAPIER" && choixordi == "ROCHE" ||
                    reponseJoueur.ToUpper() == "CISEAU" && choixordi == "PAPIER")
                {
                    return true;
                }
                else
                {
                    Joueur.Vie--;
                }

             //   return RochePapierCiseau();
            }
            return JeuRochePapierCiseau();
        }
    }
}



