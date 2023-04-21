
namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class Modifier_Cours
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier_Cours));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msGlobal = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCours = new System.Windows.Forms.ComboBox();
            this.tbAENom = new System.Windows.Forms.TextBox();
            this.tbAEPrenom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bouton1 = new System.Windows.Forms.Button();
            this.bouton2 = new System.Windows.Forms.Button();
            this.bouton3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.msGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // msGlobal
            // 
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem2,
            this.gestionEtudiantToolStripMenuItem1,
            this.gestionClasseToolStripMenuItem});
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(800, 24);
            this.msGlobal.TabIndex = 11;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            // 
            // gestionEtudiantToolStripMenuItem1
            // 
            this.gestionEtudiantToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesEtudiantsToolStripMenuItem,
            this.ajouterUnEtudiantToolStripMenuItem});
            this.gestionEtudiantToolStripMenuItem1.Name = "gestionEtudiantToolStripMenuItem1";
            this.gestionEtudiantToolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.gestionEtudiantToolStripMenuItem1.Text = "Gestion Etudiant";
            // 
            // listeDesEtudiantsToolStripMenuItem
            // 
            this.listeDesEtudiantsToolStripMenuItem.Name = "listeDesEtudiantsToolStripMenuItem";
            this.listeDesEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listeDesEtudiantsToolStripMenuItem.Text = "Liste des étudiants";
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            // 
            // gestionClasseToolStripMenuItem
            // 
            this.gestionClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesClassesToolStripMenuItem,
            this.ajouterUneClasseToolStripMenuItem});
            this.gestionClasseToolStripMenuItem.Name = "gestionClasseToolStripMenuItem";
            this.gestionClasseToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.gestionClasseToolStripMenuItem.Text = "Gestion classe";
            // 
            // listeDesClassesToolStripMenuItem
            // 
            this.listeDesClassesToolStripMenuItem.Name = "listeDesClassesToolStripMenuItem";
            this.listeDesClassesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listeDesClassesToolStripMenuItem.Text = "Liste des classes";
            // 
            // ajouterUneClasseToolStripMenuItem
            // 
            this.ajouterUneClasseToolStripMenuItem.Name = "ajouterUneClasseToolStripMenuItem";
            this.ajouterUneClasseToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ajouterUneClasseToolStripMenuItem.Text = "Ajouter une classe";
            // 
            // cbCours
            // 
            this.cbCours.FormattingEnabled = true;
            this.cbCours.Location = new System.Drawing.Point(223, 49);
            this.cbCours.Name = "cbCours";
            this.cbCours.Size = new System.Drawing.Size(272, 21);
            this.cbCours.TabIndex = 12;
            this.cbCours.SelectedIndexChanged += new System.EventHandler(this.cbCours_SelectedIndexChanged);
            // 
            // tbAENom
            // 
            this.tbAENom.Location = new System.Drawing.Point(250, 94);
            this.tbAENom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(221, 20);
            this.tbAENom.TabIndex = 13;
            this.tbAENom.TextChanged += new System.EventHandler(this.Modifier_Cours_Load);
            // 
            // tbAEPrenom
            // 
            this.tbAEPrenom.Location = new System.Drawing.Point(250, 140);
            this.tbAEPrenom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAEPrenom.Multiline = true;
            this.tbAEPrenom.Name = "tbAEPrenom";
            this.tbAEPrenom.Size = new System.Drawing.Size(221, 109);
            this.tbAEPrenom.TabIndex = 14;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(171, 97);
            this.lNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(34, 13);
            this.lNom.TabIndex = 15;
            this.lNom.Text = "Cours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(171, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "description";
            // 
            // bouton1
            // 
            this.bouton1.BackColor = System.Drawing.Color.Honeydew;
            this.bouton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton1.Location = new System.Drawing.Point(160, 272);
            this.bouton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton1.Name = "bouton1";
            this.bouton1.Size = new System.Drawing.Size(138, 34);
            this.bouton1.TabIndex = 17;
            this.bouton1.Text = "EFFACER";
            this.bouton1.UseVisualStyleBackColor = false;
            // 
            // bouton2
            // 
            this.bouton2.BackColor = System.Drawing.Color.Honeydew;
            this.bouton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton2.Location = new System.Drawing.Point(329, 272);
            this.bouton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton2.Name = "bouton2";
            this.bouton2.Size = new System.Drawing.Size(142, 34);
            this.bouton2.TabIndex = 18;
            this.bouton2.Text = "ENREGISTRER";
            this.bouton2.UseVisualStyleBackColor = false;
            this.bouton2.Click += new System.EventHandler(this.bouton2_Click);
            // 
            // bouton3
            // 
            this.bouton3.BackColor = System.Drawing.Color.Honeydew;
            this.bouton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton3.Location = new System.Drawing.Point(250, 323);
            this.bouton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton3.Name = "bouton3";
            this.bouton3.Size = new System.Drawing.Size(138, 34);
            this.bouton3.TabIndex = 19;
            this.bouton3.Text = "RETOUR";
            this.bouton3.UseVisualStyleBackColor = false;
            // 
            // Modifier_Cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCours);
            this.Controls.Add(this.bouton3);
            this.Controls.Add(this.bouton2);
            this.Controls.Add(this.bouton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.tbAEPrenom);
            this.Controls.Add(this.tbAENom);
            this.Controls.Add(this.msGlobal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Modifier_Cours";
            this.Text = "Modifier_Cours";
            this.Load += new System.EventHandler(this.Modifier_Cours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip msGlobal;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneClasseToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbCours;
        private System.Windows.Forms.TextBox tbAENom;
        private System.Windows.Forms.TextBox tbAEPrenom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bouton1;
        private System.Windows.Forms.Button bouton2;
        private System.Windows.Forms.Button bouton3;
    }
}