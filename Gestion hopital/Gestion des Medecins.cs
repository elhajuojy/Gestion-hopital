using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Gestion_hopital
{
    public partial class Gestion_des_Medecins : Form
    {
        public Gestion_des_Medecins()
        {
            InitializeComponent();
        }
        
        List<string> listSpecialite = new List<string>();
        string CtnGestionFrom = ConfigurationManager.ConnectionStrings["GesHopitalCtn"].ConnectionString;
        SqlConnection ctn = new SqlConnection();
        private void Gestion_des_Medecins_Load(object sender, EventArgs e)
        {
            ctn.ConnectionString = CtnGestionFrom;
            listSpecialite.Add("Cardiologie");
            listSpecialite.Add("Chriugie");
            listSpecialite.Add("Dreamtologie");
            listSpecialite.Add("Geriatrie");
            listSpecialite.Add("Oncologie");
            listSpecialite.Add("Pediatrie");
            listSpecialite.Add("Psychiatrie");
            listSpecialite.Add("Allergologie");


            CbSpecialite.DataSource=listSpecialite;

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            textNOm.Text = string.Empty;
            textcode.Text = string.Empty;
            textTel.Text = string.Empty;
            dateEmb.Value= DateTime.Now;
            CbSpecialite.DataSource = listSpecialite;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            string codeMed = textcode.Text;
            string textTelMed = textTel.Text;
            string Nom = textNOm.Text;
            DateTime DateEmb = dateEmb.Value;
            string cbSp = CbSpecialite.SelectedItem.ToString();

            SqlCommand cmd = new SqlCommand("select * from medecin where codemedcin = @code", ctn);
            
            cmd.Parameters.AddWithValue("@code",codeMed);
            ctn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ctn.Close();

            textNOm.Text=dt.Rows[0][1].ToString();
            textTel.Text = dt.Rows[0][2].ToString();
            dateEmb.Value=DateTime.Parse( dt.Rows[0][3].ToString());
            CbSpecialite.Text = dt.Rows[0][4].ToString();






        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            string codeMed = textcode.Text;
            string TelMed = textTel.Text;
            string Nom = textNOm.Text;
            DateTime DateEmb = dateEmb.Value;
            string cbSp = CbSpecialite.SelectedItem.ToString();


            


            SqlCommand cmd = new SqlCommand("insert into medecin values(@code,@nom,@tel,@DateEmb,@specialite) ", ctn);
            cmd.Parameters.AddWithValue("@code", codeMed);
            cmd.Parameters.AddWithValue("@nom", Nom);
            cmd.Parameters.AddWithValue("@tel", TelMed);
           cmd.Parameters.AddWithValue("@DateEmb", DateEmb);
            cmd.Parameters.AddWithValue("@specialite", cbSp);

            ctn.Open();
            int rowsEffected= cmd.ExecuteNonQuery();
            ctn.Close();
            MessageBox.Show("Bien Ajouter","Done");




        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string codeMed = textcode.Text;
            string TelMed = textTel.Text;
            string Nom = textNOm.Text;
            DateTime DateEmb = dateEmb.Value;
            string cbSp = CbSpecialite.SelectedItem.ToString();



            //' "+DateEmb+"  '

            SqlCommand cmd = new SqlCommand("update medecin  set  nommedecin=@nom, telmedecin=@tel , dateEmbauche= @DateEmb, specialitemedecin=@specialite    where  codemedcin= @code", ctn);
            cmd.Parameters.AddWithValue("@code", codeMed);
            cmd.Parameters.AddWithValue("@nom", Nom);
            cmd.Parameters.AddWithValue("@tel", TelMed);
            cmd.Parameters.AddWithValue("@DateEmb", DateEmb);
            cmd.Parameters.AddWithValue("@specialite", cbSp);

            ctn.Open();
            int rowsEffected = cmd.ExecuteNonQuery();
            ctn.Close();
            MessageBox.Show("Bien Modifier "+rowsEffected, "Done");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string codeMed = textcode.Text;
            SqlCommand cmd = new SqlCommand("delete from medecin where codemedcin = @code", ctn);

            cmd.Parameters.AddWithValue("@code", codeMed);
            ctn.Open();
            int rowsEffected = cmd.ExecuteNonQuery();
            ctn.Close();
            MessageBox.Show("Bien Supprimer"); 
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
