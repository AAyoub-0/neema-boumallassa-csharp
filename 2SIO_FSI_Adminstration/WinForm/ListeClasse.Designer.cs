
namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ListeClasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeClasse));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCLasse = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLasse)).BeginInit();
            this.panel1.SuspendLayout();
            this.msGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 519);
            this.panel3.TabIndex = 5;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(101, 90);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvCLasse);
            this.panel2.Location = new System.Drawing.Point(108, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 518);
            this.panel2.TabIndex = 4;
            // 
            // dgvCLasse
            // 
            this.dgvCLasse.AllowUserToAddRows = false;
            this.dgvCLasse.AllowUserToDeleteRows = false;
            this.dgvCLasse.AllowUserToOrderColumns = true;
            this.dgvCLasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCLasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCLasse.Location = new System.Drawing.Point(0, 0);
            this.dgvCLasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCLasse.MultiSelect = false;
            this.dgvCLasse.Name = "dgvCLasse";
            this.dgvCLasse.ReadOnly = true;
            this.dgvCLasse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCLasse.RowTemplate.ReadOnly = true;
            this.dgvCLasse.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCLasse.Size = new System.Drawing.Size(924, 518);
            this.dgvCLasse.TabIndex = 13;
            this.dgvCLasse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCLasse_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.msGlobal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 34);
            this.panel1.TabIndex = 3;
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
            this.msGlobal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msGlobal.Size = new System.Drawing.Size(1032, 28);
            this.msGlobal.TabIndex = 1;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(71, 24);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            this.accueilToolStripMenuItem2.Click += new System.EventHandler(this.accueilToolStripMenuItem2_Click);
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
            this.listeDesEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.listeDesEtudiantsToolStripMenuItem_Click);
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
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
            // ListeClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeClasse";
            this.Text = "ListeClasse";
            this.Load += new System.EventHandler(this.ListeClasse_Load_1);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLasse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCLasse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip msGlobal;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCoursToolStripMenuItem;
    }
}