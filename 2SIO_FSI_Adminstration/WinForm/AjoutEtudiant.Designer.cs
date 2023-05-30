namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjoutEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutEtudiant));
            this.lNom = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAENom = new System.Windows.Forms.TextBox();
            this.tbAEPrenom = new System.Windows.Forms.TextBox();
            this.bouton1 = new System.Windows.Forms.Button();
            this.bouton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bouton3 = new System.Windows.Forms.Button();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(46, 19);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(52, 22);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lPrenom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lPrenom.Location = new System.Drawing.Point(20, 73);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(83, 22);
            this.lPrenom.TabIndex = 1;
            this.lPrenom.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(25, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classe";
            // 
            // tbAENom
            // 
            this.tbAENom.Location = new System.Drawing.Point(107, 11);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(165, 35);
            this.tbAENom.TabIndex = 3;
            // 
            // tbAEPrenom
            // 
            this.tbAEPrenom.Location = new System.Drawing.Point(107, 65);
            this.tbAEPrenom.Name = "tbAEPrenom";
            this.tbAEPrenom.Size = new System.Drawing.Size(165, 35);
            this.tbAEPrenom.TabIndex = 4;
            // 
            // bouton1
            // 
            this.bouton1.BackColor = System.Drawing.Color.Honeydew;
            this.bouton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.bouton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton1.Location = new System.Drawing.Point(16, 276);
            this.bouton1.Name = "bouton1";
            this.bouton1.Size = new System.Drawing.Size(145, 36);
            this.bouton1.TabIndex = 6;
            this.bouton1.Text = "EFFACER";
            this.bouton1.UseVisualStyleBackColor = false;
            this.bouton1.Click += new System.EventHandler(this.bouton1_Click);
            // 
            // bouton2
            // 
            this.bouton2.BackColor = System.Drawing.Color.Honeydew;
            this.bouton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.bouton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton2.Location = new System.Drawing.Point(175, 276);
            this.bouton2.Name = "bouton2";
            this.bouton2.Size = new System.Drawing.Size(151, 36);
            this.bouton2.TabIndex = 7;
            this.bouton2.Text = "ENREGISTRER";
            this.bouton2.UseVisualStyleBackColor = false;
            this.bouton2.Click += new System.EventHandler(this.bouton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bouton3
            // 
            this.bouton3.BackColor = System.Drawing.Color.Honeydew;
            this.bouton3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.bouton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton3.Location = new System.Drawing.Point(107, 318);
            this.bouton3.Name = "bouton3";
            this.bouton3.Size = new System.Drawing.Size(123, 37);
            this.bouton3.TabIndex = 9;
            this.bouton3.Text = "RETOUR";
            this.bouton3.UseVisualStyleBackColor = false;
            this.bouton3.Click += new System.EventHandler(this.bouton2_Click);
            // 
            // cbClasse
            // 
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(107, 225);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(165, 36);
            this.cbClasse.TabIndex = 10;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(107, 114);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(165, 35);
            this.tbMail.TabIndex = 11;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(107, 169);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(165, 35);
            this.tbTel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(46, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(62, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tél";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 82);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(84, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ajouter un etudiant";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tbTel);
            this.panel2.Controls.Add(this.lNom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lPrenom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbAENom);
            this.panel2.Controls.Add(this.tbMail);
            this.panel2.Controls.Add(this.tbAEPrenom);
            this.panel2.Controls.Add(this.cbClasse);
            this.panel2.Controls.Add(this.bouton1);
            this.panel2.Controls.Add(this.bouton3);
            this.panel2.Controls.Add(this.bouton2);
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 366);
            this.panel2.TabIndex = 16;
            // 
            // AjoutEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AjoutEtudiant";
            this.Text = "AjouterEtudiant";
            this.Load += new System.EventHandler(this.AjoutEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAENom;
        private System.Windows.Forms.TextBox tbAEPrenom;
        private System.Windows.Forms.Button bouton1;
        private System.Windows.Forms.Button bouton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bouton3;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        //    private P2022_Appli_AdministrationDataSet1TableAdapters.classeTableAdapter classeTableAdapter;
    }
}