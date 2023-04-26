
namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjoutClasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutClasse));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbAnnuleAjout = new System.Windows.Forms.LinkLabel();
            this.actionMessage = new System.Windows.Forms.Label();
            this.bouton3 = new System.Windows.Forms.Button();
            this.bouton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAjoutClasse = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.lbAnnuleAjout);
            this.panel4.Controls.Add(this.actionMessage);
            this.panel4.Controls.Add(this.bouton3);
            this.panel4.Controls.Add(this.bouton2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tbAjoutClasse);
            this.panel4.Location = new System.Drawing.Point(0, 81);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 287);
            this.panel4.TabIndex = 3;
            // 
            // lbAnnuleAjout
            // 
            this.lbAnnuleAjout.AutoSize = true;
            this.lbAnnuleAjout.Location = new System.Drawing.Point(28, 141);
            this.lbAnnuleAjout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAnnuleAjout.Name = "lbAnnuleAjout";
            this.lbAnnuleAjout.Size = new System.Drawing.Size(73, 13);
            this.lbAnnuleAjout.TabIndex = 19;
            this.lbAnnuleAjout.TabStop = true;
            this.lbAnnuleAjout.Text = "Annuler l\'ajout";
            this.lbAnnuleAjout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbAnnuleAjout_LinkClicked);
            // 
            // actionMessage
            // 
            this.actionMessage.AutoSize = true;
            this.actionMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.actionMessage.Location = new System.Drawing.Point(28, 117);
            this.actionMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actionMessage.Name = "actionMessage";
            this.actionMessage.Size = new System.Drawing.Size(0, 13);
            this.actionMessage.TabIndex = 18;
            // 
            // bouton3
            // 
            this.bouton3.BackColor = System.Drawing.Color.Honeydew;
            this.bouton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton3.Location = new System.Drawing.Point(56, 217);
            this.bouton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton3.Name = "bouton3";
            this.bouton3.Size = new System.Drawing.Size(142, 34);
            this.bouton3.TabIndex = 17;
            this.bouton3.Text = "RETOUR";
            this.bouton3.UseVisualStyleBackColor = false;
            this.bouton3.Click += new System.EventHandler(this.bouton3_Click);
            // 
            // bouton2
            // 
            this.bouton2.BackColor = System.Drawing.Color.Honeydew;
            this.bouton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton2.Location = new System.Drawing.Point(56, 176);
            this.bouton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bouton2.Name = "bouton2";
            this.bouton2.Size = new System.Drawing.Size(142, 34);
            this.bouton2.TabIndex = 16;
            this.bouton2.Text = "ENREGISTRER";
            this.bouton2.UseVisualStyleBackColor = false;
            this.bouton2.Click += new System.EventHandler(this.bouton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libellé de la classe";
            // 
            // tbAjoutClasse
            // 
            this.tbAjoutClasse.Location = new System.Drawing.Point(31, 48);
            this.tbAjoutClasse.Margin = new System.Windows.Forms.Padding(2);
            this.tbAjoutClasse.Name = "tbAjoutClasse";
            this.tbAjoutClasse.Size = new System.Drawing.Size(197, 20);
            this.tbAjoutClasse.TabIndex = 0;
            this.tbAjoutClasse.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 76);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(67, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 52);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une classe";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 52);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AjoutClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 368);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "AjoutClasse";
            this.Text = "                                   ";
            this.Load += new System.EventHandler(this.AjoutClasse_Load_1);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel lbAnnuleAjout;
        private System.Windows.Forms.Label actionMessage;
        private System.Windows.Forms.Button bouton3;
        private System.Windows.Forms.Button bouton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAjoutClasse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}