﻿
namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjoutCours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutCours));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbAENom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.tbAEPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bouton1 = new System.Windows.Forms.Button();
            this.bouton2 = new System.Windows.Forms.Button();
            this.bouton3 = new System.Windows.Forms.Button();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tbAENom
            // 
            this.tbAENom.Location = new System.Drawing.Point(72, 99);
            this.tbAENom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(221, 20);
            this.tbAENom.TabIndex = 10;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(17, 106);
            this.lNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(34, 13);
            this.lNom.TabIndex = 11;
            this.lNom.Text = "Cours";
            // 
            // tbAEPrenom
            // 
            this.tbAEPrenom.Location = new System.Drawing.Point(72, 132);
            this.tbAEPrenom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAEPrenom.Multiline = true;
            this.tbAEPrenom.Name = "tbAEPrenom";
            this.tbAEPrenom.Size = new System.Drawing.Size(221, 109);
            this.tbAEPrenom.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(11, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "description";
            // 
            // bouton1
            // 
            this.bouton1.BackColor = System.Drawing.Color.Honeydew;
            this.bouton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton1.Location = new System.Drawing.Point(11, 247);
            this.bouton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton1.Name = "bouton1";
            this.bouton1.Size = new System.Drawing.Size(138, 34);
            this.bouton1.TabIndex = 14;
            this.bouton1.Text = "EFFACER";
            this.bouton1.UseVisualStyleBackColor = false;
            this.bouton1.Click += new System.EventHandler(this.bouton1_Click);
            // 
            // bouton2
            // 
            this.bouton2.BackColor = System.Drawing.Color.Honeydew;
            this.bouton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton2.Location = new System.Drawing.Point(153, 247);
            this.bouton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton2.Name = "bouton2";
            this.bouton2.Size = new System.Drawing.Size(142, 34);
            this.bouton2.TabIndex = 15;
            this.bouton2.Text = "ENREGISTRER";
            this.bouton2.UseVisualStyleBackColor = false;
            this.bouton2.Click += new System.EventHandler(this.bouton2_Click);
            // 
            // bouton3
            // 
            this.bouton3.BackColor = System.Drawing.Color.Honeydew;
            this.bouton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton3.Location = new System.Drawing.Point(81, 287);
            this.bouton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton3.Name = "bouton3";
            this.bouton3.Size = new System.Drawing.Size(138, 34);
            this.bouton3.TabIndex = 16;
            this.bouton3.Text = "RETOUR";
            this.bouton3.UseVisualStyleBackColor = false;
            this.bouton3.Click += new System.EventHandler(this.bouton3_Click);
            // 
            // cbClasse
            // 
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(72, 67);
            this.cbClasse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(221, 21);
            this.cbClasse.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "classe";
            // 
            // AjoutCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.bouton3);
            this.Controls.Add(this.bouton2);
            this.Controls.Add(this.bouton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAEPrenom);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.tbAENom);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AjoutCours";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AjoutCours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbAENom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.TextBox tbAEPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bouton1;
        private System.Windows.Forms.Button bouton2;
        private System.Windows.Forms.Button bouton3;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.Label label2;
    }
}