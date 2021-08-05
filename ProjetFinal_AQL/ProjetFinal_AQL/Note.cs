using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_AQL
{
    class Note
    {
       private double note;
       private int numeroEtudiant;
       private int numeroCours;
     public double getNote()
        {
            return note;
        }
        public void setNote(double note) { this.note = note; }
        public int getNumeroEtudiant() 
        {
            return numeroEtudiant;
        }
        public void setNumeroEtudiant(int numeroEtudiant) { this.numeroEtudiant= numeroEtudiant; }

        public int getNumeroCours()
        {
            return numeroCours;
        }
        public void setNumeroCours(int numeroCours) { this.numeroCours = numeroCours; }

        public Note(double note, int numeroEtudiant, int numeroCours)
        {
            this.note = note;
            this.numeroEtudiant = numeroEtudiant;
            this.numeroCours = numeroCours;
        }
    }
}
