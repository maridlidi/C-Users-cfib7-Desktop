using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrintheTest.Structures;
namespace LabyrintheTest.Structures
{
    public class Noeuds
    {
        public string Intitule;
        public Combat Combat;
        public int compteur;
        public Dictionary<int, string> LienReponseEmfant;

        public Noeuds(string _intitule, Combat _combat, Dictionary<int, string> _reponse)
        {
            Intitule = _intitule;
            Combat = _combat;
            LienReponseEmfant = _reponse;
        }
        public Noeuds() { }
        
        public string AfficherChoix()
        {
            foreach (var choix in LienReponseEmfant)
            {
                Console.WriteLine($"{choix.Key} : {choix.Value}");
                Console.WriteLine("Faite votre choix!");
            }
            return AfficherChoix();
        }

        public string choixReponse()
        {
            
            string reponse = null;
            foreach (var choix in LienReponseEmfant)
            {
                Console.WriteLine($"{choix.Key} : {choix.Value}");
                Console.WriteLine("Faite votre choix!");
            }
            int x = int.Parse(Console.ReadLine());
            foreach(var Reponse in LienReponseEmfant)
            {
                
                if (x== Reponse.Key)
                {
                    
                    reponse = Reponse.Value;
                    break;
                }
                compteur++;
            }
            return reponse;
        }

        public int AfficherNombreCoup(ref Personnages Joueur)
        {
            return compteur;
        }

        // DETERMINE QUEL ACTION A FAIRE
        public void LancerCombat(ref Personnages Joueur)
        {
            object JeuRochePapierCiseau = null;
            if (Combat == JeuRochePapierCiseau)
            {
               Combat.Equals(JeuRochePapierCiseau) ;
            }
            else if(Combat==JeuPileOuFace)
            {
                Combat.Equals(JeuPileOuFace)
            }
            else
            {

            }

        }


    }
}
