using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrintheTest.Structures;

namespace LabyrintheTest
{
    class Program
    {
        public static Personnages Joueur;
        static Personnages Ordi;
        static Dictionary<string, Noeuds> Histoire = new Dictionary<string, Noeuds>();
       
        static void Main(string[] args)
        {
            
            //Personnages Joueur = new Personnages();
            //Personnages Ordi = new Personnages();
            Combat RochePapierCiseau = new Combat(Joueur, Ordi);
            Combat PileFace = new Combat(Joueur, Ordi);
            Combat Null = new Combat();
            Null = null;
            
            string start = "Case Depart";
            string End = "GAME OVER";
            Histoire.Add("Case Depart", new Noeuds("Case Depart", null, 
                new Dictionary<int, string>() { {1,"Case 2" },{2,"Case 3" } }));
            Histoire.Add("Case 2", new Noeuds("Case 2", null, 
                new Dictionary<int, string>() { { 1, "Case 6" }, { 2, "Case 5" }, { 3, "Case 4" } }));
            Histoire.Add("Case 3", new Noeuds("Case 3", null, 
                new Dictionary<int, string>() { {0,"Case Depart" } }));
            Histoire.Add("Case 4", new Noeuds("Case 4", RochePapierCiseau, 
                new Dictionary<int, string>() { { 1, "Case 7" }, { 2, "Case 8" }, { 3, "Case 9" } }));
            Histoire.Add("Case 5",new Noeuds("Case 5", PileFace, 
                new Dictionary<int, string>() { { 1, "Case 10" }, { 2, "Case 11" } }));
            Histoire.Add("Case 6", new Noeuds("Case 6", null, 
                new Dictionary<int, string>() { { 1, "Case 12" },{2,"Case 5" } }));
            Histoire.Add("Case 7", new Noeuds("Case 7", null, 
                new Dictionary<int, string>() { { 1, "Case 14" }, { 2, "Case 13" } }));
            Histoire.Add("Case 8", new Noeuds("Case 8", null, 
                new Dictionary<int, string>() { { 1, "Case 16" }, { 2, "Case 15" } }));
            Histoire.Add("Case 9", new Noeuds("Case 9", null, 
                new Dictionary<int, string>() { { 1, "Case 17" }, { 2, "Case 10" } }));
            Histoire.Add("Case 10", new Noeuds("Case 10", null, 
                new Dictionary<int, string>() { { 1, "Case 19" }, { 2, "Case 18" } }));
            Histoire.Add("Case 11", new Noeuds("Case 11", null, 
                new Dictionary<int, string>() { { 0, "Case Depart" } }));
            Histoire.Add("Case 12", new Noeuds("Case 12", null, 
                new Dictionary<int, string>() { { 0, "Case Depart" } }));
            Histoire.Add("Case 13", new Noeuds("Case 13", null, 
                new Dictionary<int, string>() { { 0, "Case Depart" } }));
            Histoire.Add("Case 14", new Noeuds("Case 14", null, 
                new Dictionary<int, string>() { { 1, "Case 20" }, { 2, "Case 15" } }));
            Histoire.Add("Case 15", new Noeuds("Case 15", PileFace, 
                new Dictionary<int, string>() { { 1, "Case 16" }, { 2, "Case 21" } }));
            Histoire.Add("Case 16", new Noeuds("Case 16", null, 
                new Dictionary<int, string>() { { 1, "Case 21" }, { 2, "Case 17" } }));
            Histoire.Add("Case 17", new Noeuds("Case 17", null, 
                new Dictionary<int, string>() { { 0, "Case Depart" } }));
            Histoire.Add("Case 18", new Noeuds("Case 18", RochePapierCiseau, 
                new Dictionary<int, string>() { { 1, "Case 22" }, { 2, "Case 23" } }));
            Histoire.Add("Case 19", new Noeuds("Case 19", null, 
                new Dictionary<int, string>() { { 0, "Case Depart" } }));
            Histoire.Add("Case 20", new Noeuds("Case 20", null, 
                new Dictionary<int, string>() { { 0, "Case Depart" } }));
            Histoire.Add("Case 21", new Noeuds("Case 21", RochePapierCiseau, 
                new Dictionary<int, string>() { { 1, "Case 22" }, { 2, "Case 24" } }));
            Histoire.Add("Case 22", new Noeuds("Case 22", PileFace, 
                new Dictionary<int, string>() { { 1, "Case 23" }, { 2, "Case 24" } }));
            Histoire.Add("Case 23", new Noeuds("Case 23", null, 
                new Dictionary<int, string>() { { 0, "Case Depart" } }));
            Histoire.Add("Case 24", new Noeuds("Case 24", null, 
                new Dictionary<int, string>() { {00, "LABYRINTHE REUSSI" } }));
            Histoire.Add("Case 25", new Noeuds("GAME OVER", null, 
                new Dictionary<int, string>() { { 000, "GAME OVER" } }));
            Console.WriteLine();

        }
        // FAIS LE DEROULEMENT DE LA PARTIE
        public static string RouleNeud()
        {
            if()
            {
                GameOver();
            }
            else if()
            {
                LabyrintheReussi();
            }
            return RouleNeud();
        }

        public static void GameOver()
        {
            Console.WriteLine("GAME OVER !!!");
            Console.ReadLine();
            Environment.Exit(1);
        }

        public static void LabyrintheReussi()
        {
            Console.WriteLine("FÉLICITATION !!! ");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
