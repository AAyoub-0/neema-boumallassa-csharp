namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ListeEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeEtudiant));
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.PanelInterieur = new System.Windows.Forms.Panel();
            this.dgvEtudiants = new System.Windows.Forms.DataGridView();
            this.nomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msGlobal = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.PanelInterieur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).BeginInit();
            this.panel1.SuspendLayout();
            this.msGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogo
            // 
            this.PanelLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLogo.Controls.Add(this.pbLogo);
            this.PanelLogo.Location = new System.Drawing.Point(1, 47);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(91, 397);
            this.PanelLogo.TabIndex = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(7, 2);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(75, 73);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // PanelInterieur
            // 
            this.PanelInterieur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInterieur.Controls.Add(this.dgvEtudiants);
            this.PanelInterieur.Location = new System.Drawing.Point(94, 47);
            this.PanelInterieur.Margin = new System.Windows.Forms.Padding(2);
            this.PanelInterieur.Name = "PanelInterieur";
            this.PanelInterieur.Size = new System.Drawing.Size(747, 396);
            this.PanelInterieur.TabIndex = 12;
            // 
            // dgvEtudiants
            // 
            this.dgvEtudiants.AllowUserToAddRows = false;
            this.dgvEtudiants.AllowUserToDeleteRows = false;
            this.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomEtudiant,
            this.prenomEtudiant,
            this.Classe});
            this.dgvEtudiants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEtudiants.Location = new System.Drawing.Point(0, 0);
            this.dgvEtudiants.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEtudiants.MultiSelect = false;
            this.dgvEtudiants.Name = "dgvEtudiants";
            this.dgvEtudiants.ReadOnly = true;
            this.dgvEtudiants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvEtudiants.RowTemplate.ReadOnly = true;
            this.dgvEtudiants.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEtudiants.Size = new System.Drawing.Size(747, 396);
            this.dgvEtudiants.TabIndex = 1;
            this.dgvEtudiants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtudiants_CellDoubleClick);
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomEtudiant.FillWeight = 50F;
            this.nomEtudiant.HeaderText = "Nom";
            this.nomEtudiant.MinimumWidth = 6;
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.ReadOnly = true;
            this.nomEtudiant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prenomEtudiant
            // 
            this.prenomEtudiant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenomEtudiant.FillWeight = 50F;
            this.prenomEtudiant.HeaderText = "Prénom";
            this.prenomEtudiant.MinimumWidth = 6;
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.ReadOnly = true;
            this.prenomEtudiant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Classe
            // 
            this.Classe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Classe.FillWeight = 150F;
            this.Classe.HeaderText = "Classe";
            this.Classe.MinimumWidth = 6;
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            this.Classe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.msGlobal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 30);
            this.panel1.TabIndex = 13;
            // 
            // msGlobal
            // 
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem2,
            this.gestionEtudiantToolStripMenuItem1,
            this.gestionClasseToolStripMenuItem,
            this.toolStripMenuItem1});
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msGlobal.Size = new System.Drawing.Size(841, 28);
            this.msGlobal.TabIndex = 14;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(71, 24);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            this.accueilToolStripMenuItem2.Click += new System.EventHandler(this.accueilToolStripMenuItem2_Click_1);
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
            this.listeDesEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.listeDesEtudiantsToolStripMenuItem.Text = "Liste des étudiants";
            this.listeDesEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.listeDesEtudiantsToolStripMenuItem_Click_1);
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            this.ajouterUnEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEtudiantToolStripMenuItem_Click_1);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCoursToolStripMenuItem,
            this.ajouterCoursToolStripMenuItem,
            this.modifierCoursToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 24);
            this.toolStripMenuItem1.Text = "Gestion cours";
            // 
            // listeCoursToolStripMenuItem
            // 
            this.listeCoursToolStripMenuItem.Name = "listeCoursToolStripMenuItem";
            this.listeCoursToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.listeCoursToolStripMenuItem.Text = "Liste cours";
            this.listeCoursToolStripMenuItem.Click += new System.EventHandler(this.listeCoursToolStripMenuItem_Click);
            // 
            // ajouterCoursToolStripMenuItem
            // 
            this.ajouterCoursToolStripMenuItem.Name = "ajouterCoursToolStripMenuItem";
            this.ajouterCoursToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.ajouterCoursToolStripMenuItem.Text = "Ajouter cours";
            this.ajouterCoursToolStripMenuItem.Click += new System.EventHandler(this.ajouterCoursToolStripMenuItem_Click);
            // 
            // modifierCoursToolStripMenuItem
            // 
            this.modifierCoursToolStripMenuItem.Name = "modifierCoursToolStripMenuItem";
            this.modifierCoursToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.modifierCoursToolStripMenuItem.Text = "Modifier cours";
            this.modifierCoursToolStripMenuItem.Click += new System.EventHandler(this.modifierCoursToolStripMenuItem_Click);
            // 
            // ListeEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelInterieur);
            this.Controls.Add(this.PanelLogo);
            this.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeEtudiant";
            this.Text = "Liste des Etudiants";
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.PanelInterieur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel PanelInterieur;
        private System.Windows.Forms.DataGridView dgvEtudiants;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip msGlobal;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCoursToolStripMenuItem;
    }
}