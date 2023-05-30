namespace _2SIO_FSI_Adminstration
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.msGlobal = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.PanelQuitter = new System.Windows.Forms.Panel();
            this.bQuitter = new System.Windows.Forms.Button();
            this.PanelInterieur = new System.Windows.Forms.Panel();
            this.tbUserConnecte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lBien = new System.Windows.Forms.Label();
            this.msGlobal.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.PanelQuitter.SuspendLayout();
            this.PanelInterieur.SuspendLayout();
            this.SuspendLayout();
            // 
            // msGlobal
            // 
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem2,
            this.gestionEtudiantToolStripMenuItem1,
            this.gestionClasseToolStripMenuItem,
            this.gestionCoursToolStripMenuItem});
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(1024, 28);
            this.msGlobal.TabIndex = 0;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(71, 24);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            // 
            // gestionEtudiantToolStripMenuItem1
            // 
            this.gestionEtudiantToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesEtudiantsToolStripMenuItem,
            this.ajouterUnEtudiantToolStripMenuItem});
            this.gestionEtudiantToolStripMenuItem1.Name = "gestionEtudiantToolStripMenuItem1";
            this.gestionEtudiantToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.gestionEtudiantToolStripMenuItem1.Text = "Gestion Etudiant";
            // 
            // listeDesEtudiantsToolStripMenuItem
            // 
            this.listeDesEtudiantsToolStripMenuItem.Name = "listeDesEtudiantsToolStripMenuItem";
            this.listeDesEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listeDesEtudiantsToolStripMenuItem.Text = "Liste des étudiants";
            this.listeDesEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.listeDesEtudiantsToolStripMenuItem_Click);
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            this.ajouterUnEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEtudiantToolStripMenuItem_Click);
            // 
            // gestionClasseToolStripMenuItem
            // 
            this.gestionClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesClassesToolStripMenuItem,
            this.ajouterUneClasseToolStripMenuItem});
            this.gestionClasseToolStripMenuItem.Name = "gestionClasseToolStripMenuItem";
            this.gestionClasseToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.gestionClasseToolStripMenuItem.Text = "Gestion classe";
            // 
            // listeDesClassesToolStripMenuItem
            // 
            this.listeDesClassesToolStripMenuItem.Name = "listeDesClassesToolStripMenuItem";
            this.listeDesClassesToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.listeDesClassesToolStripMenuItem.Text = "Liste des classes";
            this.listeDesClassesToolStripMenuItem.Click += new System.EventHandler(this.listeDesClassesToolStripMenuItem_Click);
            // 
            // ajouterUneClasseToolStripMenuItem
            // 
            this.ajouterUneClasseToolStripMenuItem.Name = "ajouterUneClasseToolStripMenuItem";
            this.ajouterUneClasseToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.ajouterUneClasseToolStripMenuItem.Text = "Ajouter une classe";
            this.ajouterUneClasseToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneClasseToolStripMenuItem_Click);
            // 
            // gestionCoursToolStripMenuItem
            // 
            this.gestionCoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lToolStripMenuItem,
            this.ajouterUnCoursToolStripMenuItem,
            this.modifierCoursToolStripMenuItem});
            this.gestionCoursToolStripMenuItem.Name = "gestionCoursToolStripMenuItem";
            this.gestionCoursToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.gestionCoursToolStripMenuItem.Text = "Gestion cours";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.lToolStripMenuItem.Text = "Liste des cours";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // ajouterUnCoursToolStripMenuItem
            // 
            this.ajouterUnCoursToolStripMenuItem.Name = "ajouterUnCoursToolStripMenuItem";
            this.ajouterUnCoursToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.ajouterUnCoursToolStripMenuItem.Text = "Ajouter un cours";
            this.ajouterUnCoursToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnCoursToolStripMenuItem_Click);
            // 
            // modifierCoursToolStripMenuItem
            // 
            this.modifierCoursToolStripMenuItem.Name = "modifierCoursToolStripMenuItem";
            this.modifierCoursToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.modifierCoursToolStripMenuItem.Text = "Modifier cours";
            this.modifierCoursToolStripMenuItem.Click += new System.EventHandler(this.modifierCoursToolStripMenuItem_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.msGlobal);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(1024, 34);
            this.PanelLogo.TabIndex = 9;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(87, 79);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // PanelQuitter
            // 
            this.PanelQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelQuitter.Controls.Add(this.pbLogo);
            this.PanelQuitter.Location = new System.Drawing.Point(0, 40);
            this.PanelQuitter.Name = "PanelQuitter";
            this.PanelQuitter.Size = new System.Drawing.Size(95, 437);
            this.PanelQuitter.TabIndex = 10;
            // 
            // bQuitter
            // 
            this.bQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bQuitter.AutoSize = true;
            this.bQuitter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bQuitter.BackColor = System.Drawing.Color.ForestGreen;
            this.bQuitter.ForeColor = System.Drawing.Color.Transparent;
            this.bQuitter.Location = new System.Drawing.Point(790, 12);
            this.bQuitter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(127, 38);
            this.bQuitter.TabIndex = 7;
            this.bQuitter.Text = "QUITTER";
            this.bQuitter.UseVisualStyleBackColor = false;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // PanelInterieur
            // 
            this.PanelInterieur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInterieur.Controls.Add(this.tbUserConnecte);
            this.PanelInterieur.Controls.Add(this.label1);
            this.PanelInterieur.Controls.Add(this.bQuitter);
            this.PanelInterieur.Controls.Add(this.lBien);
            this.PanelInterieur.Location = new System.Drawing.Point(96, 40);
            this.PanelInterieur.Name = "PanelInterieur";
            this.PanelInterieur.Size = new System.Drawing.Size(928, 437);
            this.PanelInterieur.TabIndex = 11;
            // 
            // tbUserConnecte
            // 
            this.tbUserConnecte.AutoSize = true;
            this.tbUserConnecte.Location = new System.Drawing.Point(245, 22);
            this.tbUserConnecte.Name = "tbUserConnecte";
            this.tbUserConnecte.Size = new System.Drawing.Size(0, 28);
            this.tbUserConnecte.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Application de gestion administration de l\'école FSI";
            // 
            // lBien
            // 
            this.lBien.AutoSize = true;
            this.lBien.ForeColor = System.Drawing.Color.DarkGreen;
            this.lBien.Location = new System.Drawing.Point(48, 22);
            this.lBien.Name = "lBien";
            this.lBien.Size = new System.Drawing.Size(149, 28);
            this.lBien.TabIndex = 13;
            this.lBien.Text = "BIENVENUE";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 478);
            this.Controls.Add(this.PanelInterieur);
            this.Controls.Add(this.PanelQuitter);
            this.Controls.Add(this.PanelLogo);
            this.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Accueil";
            this.Text = "ACCUEIL";
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.PanelQuitter.ResumeLayout(false);
            this.PanelInterieur.ResumeLayout(false);
            this.PanelInterieur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip msGlobal;
  //      private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel PanelQuitter;
   //     private System.Windows.Forms.Button bDeConnexion;
        private System.Windows.Forms.Panel PanelInterieur;
    //    private System.Windows.Forms.Label lTexteBienvenue;
   //     private System.Windows.Forms.Label lBienvenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lBien;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.ToolStripMenuItem gestionClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCoursToolStripMenuItem;
        private System.Windows.Forms.Label tbUserConnecte;
    }
}

