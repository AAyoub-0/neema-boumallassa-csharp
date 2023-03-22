using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
        
        private void Connexion_Load(object sender, EventArgs e)
        {
          
        }

        private void AddFontFromMemory()
        {
            PrivateFontCollection myFont = new PrivateFontCollection();

            Stream fontStream = GetType().Assembly.GetManifestResourceStream("Poppins-Regular.ttf");
            IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
          
            byte[] fontdata = new byte[fontStream.Length];
            
            fontStream.Read(fontdata,0,(int)fontStream.Length);
            Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
            
            myFont.AddMemoryFont(data, (int)fontStream.Length);
            fontStream.Close();
            
            Marshal.FreeCoTaskMem(data);

            foreach (Control control in Controls)
            {
                control.Font = new Font(myFont.Families[0], 15, FontStyle.Regular);
            }
        }
        
        private void bConnexion_Click(object sender, EventArgs e)
        {
            string loginUti = tbLogin.Text;
            string mdpUti = tbMdp.Text;
            //Contrôle de la connexion
            string Conx = "Server=localhost;Port=5432;Database=2SIO_Appli_Administration;User Id=postgres;Password=Y@utub32112;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            string select = "SELECT * FROM utilisateur where loginutilisateur = :login;";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            MyCmd.Parameters.Add(new NpgsqlParameter("login", NpgsqlDbType.Varchar)).Value = loginUti;

            NpgsqlDataReader dr = MyCmd.ExecuteReader();

            if (dr.Read())
            {
                // Création de l'objet utilisateur
                Utilisateur uti = new Utilisateur(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
                if(uti.MdpUtilisateur == mdpUti)
                {
                    //Ouverture du formulaire d'accueil si la connexion est ok
                    this.Hide();
                    Form formAccueil = new Accueil(uti);
                    formAccueil.Show();
                }
                else
                {
                    MessageBox.Show($"Erreur d'authentification mot de passe incorrect");
                    tbMdp.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show($"Erreur d'authentification login : {loginUti} innexistant");
                tbLogin.Text = "";
                tbMdp.Text = "";
            }

            MyCnx.Close();

        }

        
    }
}
