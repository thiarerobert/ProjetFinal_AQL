using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal_AQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Les actions
            Etudiant etudiant = new Etudiant(nomBox.Text, prenomBox.Text);
            etudiant.enregistrerEtudiant(nomBox, prenomBox);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Etudiant.recherche(search.Text, print);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cours cours = new Cours(titre.Text, code.Text);
            cours.sauvegardeCours();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cours.afficher(print);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Note.ajouter(numeroCoursN.Text, numeroEtudiantN.Text, noteN.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
