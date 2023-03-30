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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(37, 45);
            this.lNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(60, 26);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lPrenom.Location = new System.Drawing.Point(11, 95);
            this.lPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(91, 26);
            this.lPrenom.TabIndex = 1;
            this.lPrenom.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(26, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classe";
            // 
            // tbAENom
            // 
            this.tbAENom.Location = new System.Drawing.Point(106, 35);
            this.tbAENom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(165, 34);
            this.tbAENom.TabIndex = 3;
            // 
            // tbAEPrenom
            // 
            this.tbAEPrenom.Location = new System.Drawing.Point(106, 85);
            this.tbAEPrenom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAEPrenom.Name = "tbAEPrenom";
            this.tbAEPrenom.Size = new System.Drawing.Size(165, 34);
            this.tbAEPrenom.TabIndex = 4;
            // 
            // bouton1
            // 
            this.bouton1.BackColor = System.Drawing.Color.Honeydew;
            this.bouton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton1.Location = new System.Drawing.Point(2, 199);
            this.bouton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton1.Name = "bouton1";
            this.bouton1.Size = new System.Drawing.Size(138, 34);
            this.bouton1.TabIndex = 6;
            this.bouton1.Text = "EFFACER";
            this.bouton1.UseVisualStyleBackColor = false;
            this.bouton1.Click += new System.EventHandler(this.bouton1_Click);
            // 
            // bouton2
            // 
            this.bouton2.BackColor = System.Drawing.Color.Honeydew;
            this.bouton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton2.Location = new System.Drawing.Point(145, 199);
            this.bouton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton2.Name = "bouton2";
            this.bouton2.Size = new System.Drawing.Size(142, 34);
            this.bouton2.TabIndex = 7;
            this.bouton2.Text = "ENREGISTRER";
            this.bouton2.UseVisualStyleBackColor = false;
            this.bouton2.Click += new System.EventHandler(this.bouton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bouton3
            // 
            this.bouton3.BackColor = System.Drawing.Color.Honeydew;
            this.bouton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton3.Location = new System.Drawing.Point(76, 238);
            this.bouton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton3.Name = "bouton3";
            this.bouton3.Size = new System.Drawing.Size(138, 34);
            this.bouton3.TabIndex = 9;
            this.bouton3.Text = "RETOUR";
            this.bouton3.UseVisualStyleBackColor = false;
            this.bouton3.Click += new System.EventHandler(this.bouton2_Click);
            // 
            // cbClasse
            // 
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(106, 145);
            this.cbClasse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(165, 34);
            this.cbClasse.TabIndex = 10;
            // 
            // AjoutEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 329);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.bouton3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bouton2);
            this.Controls.Add(this.bouton1);
            this.Controls.Add(this.tbAEPrenom);
            this.Controls.Add(this.tbAENom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPrenom);
            this.Controls.Add(this.lNom);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AjoutEtudiant";
            this.Text = "AjouterEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    //    private P2022_Appli_AdministrationDataSet1TableAdapters.classeTableAdapter classeTableAdapter;
    }
}