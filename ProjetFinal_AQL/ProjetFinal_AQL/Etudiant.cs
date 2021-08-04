using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            public Etudiant(int numeroEtudiant, string nom, string prenom)
            {
                this.numeroEtudiant = numeroEtudiant;
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

            public void affiche()
            {
                Console.WriteLine("Numero Etudiant : " + numeroEtudiant + " Nom : " + nom + " Prenom : " + prenom);
            }

            public void enregistrerEtudiant()
            {
                //fichier
            }

        }
    }


