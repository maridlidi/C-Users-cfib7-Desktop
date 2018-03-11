using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrintheTest.Structures;

namespace LabyrintheTest.Structures
{
    public class PileOuFace
    {
        public Personnages Joueur;
      //  public Personnages Ordi;
        public PileOuFace() { }
        public PileOuFace(Personnages joueur/*, Personnages ordi*/)
        {
            Joueur = joueur;
            //Ordi = ordi;
        }

        

        public bool JeuPileOuFace()
        {

            string[] PileFace = new string[] { "PILE", "FACE" };
            Random rand = new Random();
            var PF = rand.Next(0, PileFace.Length);
            string PileFaceOrdi = PileFace[PF];
            Console.WriteLine(" PILE ou FACE ? ");
            string ChoixReponse = Console.ReadLine();
            
            {
                if (ChoixReponse == PileFaceOrdi)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            return JeuPileOuFace();
        }
    }
}
