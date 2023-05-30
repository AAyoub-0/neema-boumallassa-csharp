
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
            this.cbCours = new System.Windows.Forms.ComboBox();
            this.tbAENom = new System.Windows.Forms.TextBox();
            this.tbAEPrenom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bouton1 = new System.Windows.Forms.Button();
            this.bouton2 = new System.Windows.Forms.Button();
            this.bouton3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cbCours
            // 
            this.cbCours.FormattingEnabled = true;
            this.cbCours.Location = new System.Drawing.Point(124, 12);
            this.cbCours.Margin = new System.Windows.Forms.Padding(4);
            this.cbCours.Name = "cbCours";
            this.cbCours.Size = new System.Drawing.Size(293, 24);
            this.cbCours.TabIndex = 12;
            this.cbCours.SelectedIndexChanged += new System.EventHandler(this.cbCours_SelectedIndexChanged);
            // 
            // tbAENom
            // 
            this.tbAENom.Location = new System.Drawing.Point(124, 75);
            this.tbAENom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(293, 22);
            this.tbAENom.TabIndex = 13;
            // 
            // tbAEPrenom
            // 
            this.tbAEPrenom.Location = new System.Drawing.Point(124, 131);
            this.tbAEPrenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAEPrenom.Multiline = true;
            this.tbAEPrenom.Name = "tbAEPrenom";
            this.tbAEPrenom.Size = new System.Drawing.Size(293, 133);
            this.tbAEPrenom.TabIndex = 14;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(19, 78);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(47, 16);
            this.lNom.TabIndex = 15;
            this.lNom.Text = "Libellé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(19, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Description";
            // 
            // bouton1
            // 
            this.bouton1.BackColor = System.Drawing.Color.Honeydew;
            this.bouton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton1.Location = new System.Drawing.Point(22, 361);
            this.bouton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bouton1.Name = "bouton1";
            this.bouton1.Size = new System.Drawing.Size(184, 42);
            this.bouton1.TabIndex = 17;
            this.bouton1.Text = "EFFACER";
            this.bouton1.UseVisualStyleBackColor = false;
            this.bouton1.Click += new System.EventHandler(this.bouton1_Click);
            // 
            // bouton2
            // 
            this.bouton2.BackColor = System.Drawing.Color.Honeydew;
            this.bouton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton2.Location = new System.Drawing.Point(228, 361);
            this.bouton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bouton2.Name = "bouton2";
            this.bouton2.Size = new System.Drawing.Size(189, 42);
            this.bouton2.TabIndex = 18;
            this.bouton2.Text = "ENREGISTRER";
            this.bouton2.UseVisualStyleBackColor = false;
            this.bouton2.Click += new System.EventHandler(this.bouton2_Click);
            // 
            // bouton3
            // 
            this.bouton3.BackColor = System.Drawing.Color.Honeydew;
            this.bouton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton3.Location = new System.Drawing.Point(124, 411);
            this.bouton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bouton3.Name = "bouton3";
            this.bouton3.Size = new System.Drawing.Size(184, 42);
            this.bouton3.TabIndex = 19;
            this.bouton3.Text = "RETOUR";
            this.bouton3.UseVisualStyleBackColor = false;
            this.bouton3.Click += new System.EventHandler(this.bouton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(19, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Classe";
            // 
            // cbClasse
            // 
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(124, 283);
            this.cbClasse.Margin = new System.Windows.Forms.Padding(4);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(293, 24);
            this.cbClasse.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cours";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 79);
            this.panel1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modifier un cours";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbAEPrenom);
            this.panel2.Controls.Add(this.tbAENom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lNom);
            this.panel2.Controls.Add(this.cbClasse);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bouton1);
            this.panel2.Controls.Add(this.cbCours);
            this.panel2.Controls.Add(this.bouton2);
            this.panel2.Controls.Add(this.bouton3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 475);
            this.panel2.TabIndex = 24;
            // 
            // Modifier_Cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Modifier_Cours";
            this.Text = "Modifier_Cours";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbCours;
        private System.Windows.Forms.TextBox tbAENom;
        private System.Windows.Forms.TextBox tbAEPrenom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bouton1;
        private System.Windows.Forms.Button bouton2;
        private System.Windows.Forms.Button bouton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}