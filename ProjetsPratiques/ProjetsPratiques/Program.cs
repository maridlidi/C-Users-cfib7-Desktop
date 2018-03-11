using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetsPratiques;

namespace ProjetsPratiques
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            string[] jeu = new string[] { "ROCHE", "PAPIER", "CISEAU" };
            Random r = new Random();
             var hasard= r.Next(0,jeu.Length);
            //Console.WriteLine(jeu[hasard]);
            string choixordi = jeu[hasard];
            Console.WriteLine(choixordi);
            string reponseJoueur = Console.ReadLine();
            string partienull = null;
            void jeuRochePapierCiseau(string X, string Y)
            {
                if (reponseJoueur == choixordi)
                {
                   return partienull ;
                }
                else if (reponseJoueur.ToUpper() == "ROCHE" && choixordi == "CISEAU" ||
                    reponseJoueur.ToUpper() == "PAPIER" && choixordi == "ROCHE" ||
                    reponseJoueur.ToUpper() == "CISEAU" && choixordi == "PAPIER")
                {

                }
                else
                {

                }
            }
        }
    }
}
    

