using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProjetFinal_AQL

{
    class Sauve
    {

        private string chemin;

        public string Chemin
        {
            get { return chemin; }
            set { chemin = value; }
        }

        public Sauve(string chemin)
        {
            this.chemin = chemin;
        }

        public static void  file(string chemin, string valeur)
        {

            if(!Sauve.checkFile(chemin))
            {
                Sauve.CreateFile(chemin);
            }

            String ancienTexte = GetOld(chemin);

            string txt = ancienTexte + valeur;

            Sauve.Reading(chemin,txt);

           

        }

        public static bool checkFile(string chemin)
        {
            return File.Exists(chemin);
        }

        public static void CreateFile(string chemin)
        {
            try
            {
                StreamWriter fichier = new StreamWriter(chemin);
                fichier.WriteLine("");
                fichier.Close();
            }catch(Exception e)
            {
                Console.WriteLine("erreur " + e.Message);
            }
        }

        public static string GetOld(String chemin)
        {
            int index = Sauve.countLine(chemin);
            String line; 
            string chaine = "";
            try
            {
                
                StreamReader sr = new StreamReader(chemin);
               
                
                line = sr.ReadLine();
               
                while (line != null)
                {
                    if(index == 0)
                    {
                        chaine += line ;
                    }
                    else
                    {
                        chaine += line + "\n";
                    }
                   

                   
                    
                    line = sr.ReadLine();
                }
               
                sr.Close();
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
           

            return chaine;
        }


        public static void Reading(string chemin, string valeur)
        {
            try
            {
                StreamWriter fichier = new StreamWriter(chemin);
                fichier.WriteLine(valeur);
                fichier.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("erreur " + e.Message);
            }
        }

        public static int countLine(string chemin)
        {

            int index = 0;
            String line;
            
            try
            {

                StreamReader sr = new StreamReader(chemin);


                line = sr.ReadLine();

                while (line != null)
                {
                   


                    index++;

                    line = sr.ReadLine();
                }

                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }


            return index;
        }



    }
}
