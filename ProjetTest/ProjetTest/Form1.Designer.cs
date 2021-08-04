
namespace ProjetTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNonEtudiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenomEtudiant = new System.Windows.Forms.TextBox();
            this.ajoutEtudiant = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.ajoutCours = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAffEtud = new System.Windows.Forms.TextBox();
            this.txtAffCours = new System.Windows.Forms.TextBox();
            this.txtAffNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.afficherBulletin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de l\'étudiant :";
            // 
            // txtNonEtudiant
            // 
            this.txtNonEtudiant.Location = new System.Drawing.Point(204, 32);
            this.txtNonEtudiant.Name = "txtNonEtudiant";
            this.txtNonEtudiant.Size = new System.Drawing.Size(165, 22);
            this.txtNonEtudiant.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Préom de l\'étudiant :";
            // 
            // txtPrenomEtudiant
            // 
            this.txtPrenomEtudiant.Location = new System.Drawing.Point(205, 86);
            this.txtPrenomEtudiant.Name = "txtPrenomEtudiant";
            this.txtPrenomEtudiant.Size = new System.Drawing.Size(165, 22);
            this.txtPrenomEtudiant.TabIndex = 3;
            // 
            // ajoutEtudiant
            // 
            this.ajoutEtudiant.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutEtudiant.Location = new System.Drawing.Point(205, 196);
            this.ajoutEtudiant.Name = "ajoutEtudiant";
            this.ajoutEtudiant.Size = new System.Drawing.Size(92, 31);
            this.ajoutEtudiant.TabIndex = 4;
            this.ajoutEtudiant.Text = "Ajouter";
            this.ajoutEtudiant.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(475, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code cours :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(475, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titre :";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(596, 33);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(165, 22);
            this.txtCode.TabIndex = 7;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(596, 86);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(165, 22);
            this.txtTitre.TabIndex = 8;
            // 
            // ajoutCours
            // 
            this.ajoutCours.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutCours.Location = new System.Drawing.Point(596, 196);
            this.ajoutCours.Name = "ajoutCours";
            this.ajoutCours.Size = new System.Drawing.Size(92, 31);
            this.ajoutCours.TabIndex = 9;
            this.ajoutCours.Text = "Ajouter";
            this.ajoutCours.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(824, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numéro étudiant :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(824, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numéro cours :";
            // 
            // txtAffEtud
            // 
            this.txtAffEtud.Location = new System.Drawing.Point(993, 35);
            this.txtAffEtud.Name = "txtAffEtud";
            this.txtAffEtud.Size = new System.Drawing.Size(165, 22);
            this.txtAffEtud.TabIndex = 12;
            // 
            // txtAffCours
            // 
            this.txtAffCours.Location = new System.Drawing.Point(993, 89);
            this.txtAffCours.Name = "txtAffCours";
            this.txtAffCours.Size = new System.Drawing.Size(165, 22);
            this.txtAffCours.TabIndex = 13;
            // 
            // txtAffNote
            // 
            this.txtAffNote.Location = new System.Drawing.Point(993, 144);
            this.txtAffNote.Name = "txtAffNote";
            this.txtAffNote.Size = new System.Drawing.Size(165, 22);
            this.txtAffNote.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(824, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Note :";
            // 
            // afficherBulletin
            // 
            this.afficherBulletin.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficherBulletin.Location = new System.Drawing.Point(993, 196);
            this.afficherBulletin.Name = "afficherBulletin";
            this.afficherBulletin.Size = new System.Drawing.Size(101, 31);
            this.afficherBulletin.TabIndex = 16;
            this.afficherBulletin.Text = "Afficher";
            this.afficherBulletin.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(994, 306);
            this.dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1198, 624);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.afficherBulletin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAffNote);
            this.Controls.Add(this.txtAffCours);
            this.Controls.Add(this.txtAffEtud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ajoutCours);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ajoutEtudiant);
            this.Controls.Add(this.txtPrenomEtudiant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNonEtudiant);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Application de Gestion des notes des étudiants";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNonEtudiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenomEtudiant;
        private System.Windows.Forms.Button ajoutEtudiant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Button ajoutCours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAffEtud;
        private System.Windows.Forms.TextBox txtAffCours;
        private System.Windows.Forms.TextBox txtAffNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button afficherBulletin;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

