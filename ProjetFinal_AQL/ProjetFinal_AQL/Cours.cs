using System;
using System.IO;
using System.Windows.Forms;

namespace ProjetFinal_AQL
{

    public class Cours

    {
        private int numero;
        private string titre;
        private string code;

        public int Numero{

            set{
                this.numero = value;
            }
            get {
                return this.numero;
            }

        }

        public string Titre
        {
            set
            {
                this.titre = value;

            }
            get
            {
                return this.titre;
            }
        }

        public string Code
        {
            set {
                this.code = value;

            }
            get
            {
                return this.code;
            }

        }

        public Cours()
        {
            numero = 1111;
            code = "###" ;
            titre = "INCONNU";

        }

        public Cours(string titre, string code)
        {
            this.titre = titre;
            this.code = code;
            this.numero = this.creationNumero();
        }

        private int creationNumero() {
            Random rand = new Random();
            return rand.Next(1000, 9999);
        }

        public void sauvegardeCours()
        {
            string valeur = this.code + "-" + this.numero + " " + this.titre;
            DialogResult resutat = MessageBox.Show(valeur, "Titre", MessageBoxButtons.YesNo);
            string verif = resutat.ToString();



            if (verif == "Yes")
            {
                Sauve.file("../../../base/cours/listeCours.txt", valeur);
                Sauve.file("../../../base/cours/listeNumero.txt", this.numero.ToString());
            }
            else
            {
                
            }
                
          

        }

        public static void afficher(TextBox imprime)
        {
            imprime.Text = "";
            string path = "../../../base/cours/listeCours.txt";

            if (File.Exists(path))
            {
              //  imprime.Text = System.IO.File.ReadAllText(path);
                StreamReader reader = new StreamReader(path);
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    imprime.Text += line + Environment.NewLine;
                }

            }
            else
            {
                MessageBox.Show("Pas des cours existants", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static bool Exists(string numero)
        {
           
            string path = "../../../base/cours/listeNumero.txt";
            bool v = false;

            if (File.Exists(path))
            {
                //  imprime.Text = System.IO.File.ReadAllText(path);
                StreamReader reader = new StreamReader(path);
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                   if(line == numero)
                    {
                        v = true;
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Pas des cours existants", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return v;
        }


        public static string GetCours(string numero)
        {

            string path = "../../../base/cours/listeCours.txt";
            int numeroLine = 0;
            string chaine = "";
            if (File.Exists(path))
            {
                //  imprime.Text = System.IO.File.ReadAllText(path);
                StreamReader reader = new StreamReader(path);
                string line = null;
                while ((line = reader.ReadLine()) != null)
                { 
                    numeroLine++;
                    if (line == numero)
                    {
                        
                        break;
                    }

                   
                }

                line = null;
                int nL = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    nL++;
                    if (nL == numeroLine-1)
                    {
                        chaine = line;
                        break;
                    }


                }

               

            }
            else
            {
                MessageBox.Show("Pas des cours existants", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return chaine;
        }


    }
}
