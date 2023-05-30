namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.lMDP = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.bConnexion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(102, 39);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(111, 103);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogin.ForeColor = System.Drawing.Color.Black;
            this.lLogin.Location = new System.Drawing.Point(102, 178);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(57, 23);
            this.lLogin.TabIndex = 1;
            this.lLogin.Text = "Login";
            // 
            // lMDP
            // 
            this.lMDP.AutoSize = true;
            this.lMDP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMDP.ForeColor = System.Drawing.Color.Black;
            this.lMDP.Location = new System.Drawing.Point(102, 287);
            this.lMDP.Name = "lMDP";
            this.lMDP.Size = new System.Drawing.Size(131, 23);
            this.lMDP.TabIndex = 2;
            this.lMDP.Text = "Mot de passe";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(102, 209);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(257, 35);
            this.tbLogin.TabIndex = 3;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(102, 317);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.PasswordChar = '*';
            this.tbMdp.Size = new System.Drawing.Size(257, 35);
            this.tbMdp.TabIndex = 4;
            // 
            // bConnexion
            // 
            this.bConnexion.AutoSize = true;
            this.bConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(112)))));
            this.bConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConnexion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConnexion.ForeColor = System.Drawing.Color.White;
            this.bConnexion.Location = new System.Drawing.Point(102, 395);
            this.bConnexion.Name = "bConnexion";
            this.bConnexion.Padding = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.bConnexion.Size = new System.Drawing.Size(261, 47);
            this.bConnexion.TabIndex = 5;
            this.bConnexion.Text = "Valider";
            this.bConnexion.UseVisualStyleBackColor = false;
            this.bConnexion.Click += new System.EventHandler(this.bConnexion_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(484, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 593);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 66);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenu sur FSI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 591);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bConnexion);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lMDP);
            this.Controls.Add(this.lLogin);
            this.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Connexion";
            this.Text = "CONNEXION";
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lMDP;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button bConnexion;
 
    }
}