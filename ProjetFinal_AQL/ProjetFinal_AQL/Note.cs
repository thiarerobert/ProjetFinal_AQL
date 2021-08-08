using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal_AQL
{
    class Note
    {
        private int numeroCours;
        private int numeroEtudiant;
        private double note;

        public Note()
        {
            numeroCours = 0;
            numeroEtudiant = 0;
            note = 0.0;
        }
        public Note(int numeroCours, int numeroEtudiant, int note)
        {
            this.numeroCours = numeroCours;
            this.numeroEtudiant = numeroEtudiant;
            this.note = note;
        }

        public static void ajouter(string numeroCours, string numeroEtudiant, string note)
        {
            bool cours = Cours.Exists(numeroCours.ToString());
            bool etudiant = Etudiant.Exists(numeroEtudiant);

            if(cours && etudiant)
            {
                string c = Cours.GetCours(numeroCours.ToString());
                string valeur = c + " note : " + note;
                Sauve.file("../../../base/listeEtudiant/" + numeroEtudiant + ".txt",valeur);
                MessageBox.Show("Ca marche");

            }
            else
            {
                MessageBox.Show("Cours -> " + cours + " & Etudiant -> " + etudiant, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    }
}
