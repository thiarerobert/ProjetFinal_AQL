using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetFinal_AQL
{
    
    
        class Etudiant
        {
            private int numeroEtudiant;
            private String nom;
            private String prenom;

            public Etudiant()
            {

            }

            public Etudiant( string nom, string prenom)
            {
                this.numeroEtudiant = this.creationNumero() ;
                this.nom = nom;
                this.prenom = prenom;
            }

            public int getNumeroEtudiant()
            {
                return numeroEtudiant;
            }

            public void setNumeroEtudiant(int numeroEtudiant)
            {
                this.numeroEtudiant = numeroEtudiant;
            }

            public String getNom()
            {
                return nom;
            }

            public void setNom(String nom)
            {
                this.nom = nom;
            }

            public String getPrenom()
            {
                return prenom;
            }

            public void setPrenom(String prenom)
            {
                this.prenom = prenom;
            }
           private int creationNumero()
           {
            Random rand = new Random();
            return rand.Next(1000000, 9999999);
           }

        public static void recherche(string numero, TextBox imprime)
            {
            string path = "../../../base/listeEtudiant/" + numero + ".txt";

            if (File.Exists(path))
            {
                imprime.Text = System.IO.File.ReadAllText(path);
            }
            else
            {
                MessageBox.Show("Etudiant < " + numero + " > introvable","", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            }

        public void enregistrerEtudiant(TextBox nomBox, TextBox prenomBox)
        {
            string text = "CREATION ETUDIANT\n\n" +
                      this.getNumeroEtudiant() + " " + this.getPrenom() + " " + this.getNom();

            string student = this.getNumeroEtudiant() + " " + this.getPrenom() + " " + this.getNom();
            DialogResult resutat = MessageBox.Show(text, "Titre", MessageBoxButtons.YesNo);
            string verif = resutat.ToString();

            if (verif == "Yes")
            {
                nomBox.Text = "";
                prenomBox.Text = "";
                Sauve.file("../../../base/listeEtudiant/" + this.getNumeroEtudiant() + ".txt", student);
                Sauve.file("../../../base/doc/lesEtudiants.txt", student);
                Sauve.file("../../../base/doc/lesNumeros.txt", this.getNumeroEtudiant().ToString());
                MessageBox.Show("Etudiant Enregistre");
            }
            else
            {
                nomBox.Text = this.nom ;
                prenomBox.Text = this.prenom;

            }
        }
        }
    }


