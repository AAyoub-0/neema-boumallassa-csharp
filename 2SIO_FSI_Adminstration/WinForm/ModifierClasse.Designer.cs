
namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ModifierClasse
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
            System.Windows.Forms.Button buttonSave;
            System.Windows.Forms.Button boutonDelete;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierClasse));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbAnnuleAjout = new System.Windows.Forms.LinkLabel();
            this.actionMessage = new System.Windows.Forms.Label();
            this.boutonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModifClasse = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            buttonSave = new System.Windows.Forms.Button();
            boutonDelete = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = System.Drawing.Color.Green;
            buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSave.ForeColor = System.Drawing.Color.White;
            buttonSave.Image = global::_2SIO_FSI_Adminstration.Properties.Resources.download_arrowA;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(75, 217);
            buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            buttonSave.Size = new System.Drawing.Size(141, 42);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Enregistrer";
            buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // boutonDelete
            // 
            boutonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(29)))), ((int)(((byte)(7)))));
            boutonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            boutonDelete.ForeColor = System.Drawing.Color.White;
            boutonDelete.Image = global::_2SIO_FSI_Adminstration.Properties.Resources.deleteA;
            boutonDelete.Location = new System.Drawing.Point(217, 217);
            boutonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            boutonDelete.Name = "boutonDelete";
            boutonDelete.Size = new System.Drawing.Size(45, 42);
            boutonDelete.TabIndex = 16;
            boutonDelete.UseVisualStyleBackColor = false;
            boutonDelete.Click += new System.EventHandler(this.boutonDelete_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(buttonSave);
            this.panel4.Controls.Add(this.lbAnnuleAjout);
            this.panel4.Controls.Add(this.actionMessage);
            this.panel4.Controls.Add(this.boutonBack);
            this.panel4.Controls.Add(boutonDelete);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tbModifClasse);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 353);
            this.panel4.TabIndex = 4;
            // 
            // lbAnnuleAjout
            // 
            this.lbAnnuleAjout.AutoSize = true;
            this.lbAnnuleAjout.Location = new System.Drawing.Point(37, 174);
            this.lbAnnuleAjout.Name = "lbAnnuleAjout";
            this.lbAnnuleAjout.Size = new System.Drawing.Size(0, 16);
            this.lbAnnuleAjout.TabIndex = 19;
            this.lbAnnuleAjout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbAnnuleAjout_LinkClicked);
            // 
            // actionMessage
            // 
            this.actionMessage.AutoSize = true;
            this.actionMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.actionMessage.Location = new System.Drawing.Point(37, 144);
            this.actionMessage.Name = "actionMessage";
            this.actionMessage.Size = new System.Drawing.Size(0, 16);
            this.actionMessage.TabIndex = 18;
            // 
            // boutonBack
            // 
            this.boutonBack.BackColor = System.Drawing.Color.Honeydew;
            this.boutonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonBack.ForeColor = System.Drawing.Color.DarkGreen;
            this.boutonBack.Location = new System.Drawing.Point(75, 267);
            this.boutonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boutonBack.Name = "boutonBack";
            this.boutonBack.Size = new System.Drawing.Size(189, 42);
            this.boutonBack.TabIndex = 17;
            this.boutonBack.Text = "RETOUR";
            this.boutonBack.UseVisualStyleBackColor = false;
            this.boutonBack.Click += new System.EventHandler(this.boutonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libellé de la classe";
            // 
            // tbModifClasse
            // 
            this.tbModifClasse.Location = new System.Drawing.Point(41, 59);
            this.tbModifClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModifClasse.Name = "tbModifClasse";
            this.tbModifClasse.Size = new System.Drawing.Size(261, 22);
            this.tbModifClasse.TabIndex = 0;
            this.tbModifClasse.TextChanged += new System.EventHandler(this.tbModifClasse_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 94);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(89, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 64);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier une classe";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 64);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ModifierClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 453);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifierClasse";
            this.Text = "ModifierClasse";
            this.Load += new System.EventHandler(this.ModifierClasse_Load_1);
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
        private System.Windows.Forms.Button boutonBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModifClasse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}