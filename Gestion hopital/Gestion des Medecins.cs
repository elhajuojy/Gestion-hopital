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
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder builder;
        BindingSource bs =new BindingSource();


        private int Find(string code)
        {
            int index = -1;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i][0].ToString() == code)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private void Fill(int index)
        {
            textcode.Text= dt.Rows[index][0].ToString();
            textNOm.Text = dt.Rows[index][1].ToString();
            textTel.Text = dt.Rows[index][2].ToString();
            dateEmb.Value = DateTime.Parse(dt.Rows[index][3].ToString());
            CbSpecialite.Text = dt.Rows[index][4].ToString();
        }


        private void bindingThings()
        {
            textcode.DataBindings.Add("Text", bs, "codemedcin");
            textNOm.DataBindings.Add("Text", bs, "nommedecin");
            textTel.DataBindings.Add("Text", bs, "telmedecin");
            dateEmb.DataBindings.Add("Value", bs, "dateEmbauche");
            CbSpecialite.DataSource = bs;
            CbSpecialite.DisplayMember = "specialitemedecin";
        }
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

             cmd = new SqlCommand("select * from medecin", ctn);

            CbSpecialite.DataSource=listSpecialite;

            adapter.SelectCommand=cmd;
            adapter.Fill(dt);
            bs.DataSource = dt;
            //dt = ds.Tables[0];
            bindingThings();
            CbSpecialite.DataSource = listSpecialite;
           
            
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

            dt.DefaultView.Sort="codemedcin ASC";

            int index = dt.DefaultView.Find(textcode.Text);
            if (index == -1)
            {
                MessageBox.Show("no one has been find ");
            }
            else
            {
                textNOm.Text=dt.Rows[index][1].ToString();
                textTel.Text=dt.Rows[index][2].ToString();
                dateEmb.Value = DateTime.Parse(dt.Rows[index][3].ToString());
                CbSpecialite.Text=dt.Rows[index][4].ToString();
            }































            //string codeMed = textcode.Text;
            //string textTelMed = textTel.Text;
            //string Nom = textNOm.Text;
            //DateTime DateEmb = dateEmb.Value;
            //string cbSp = CbSpecialite.SelectedItem.ToString();

            //SqlCommand cmd = new SqlCommand("select * from medecin where codemedcin = @code", ctn);
            
            //cmd.Parameters.AddWithValue("@code",codeMed);
            //ctn.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            //ctn.Close();

            //textNOm.Text=dt.Rows[0][1].ToString();
            //textTel.Text = dt.Rows[0][2].ToString();
            //dateEmb.Value=DateTime.Parse( dt.Rows[0][3].ToString());
            //CbSpecialite.Text = dt.Rows[0][4].ToString();






        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            string codeMed = textcode.Text;
            string TelMed = textTel.Text;
            string Nom = textNOm.Text;
            DateTime DateEmb = dateEmb.Value;
            string cbSp = CbSpecialite.SelectedItem.ToString();


            DataRow newrow = dt.NewRow();
            newrow[0] = codeMed;
            newrow[1] = Nom;
            newrow[2] = TelMed;
            newrow[3] = DateEmb;
            newrow[4] = cbSp;
            dt.Rows.Add(newrow);
            
            




            MessageBox.Show("bien Ajouter");
            //builder = new SqlCommandBuilder(adapter);
            //adapter.Update(dt);




           // SqlCommand cmd = new SqlCommand("insert into medecin values(@code,@nom,@tel,@DateEmb,@specialite) ", ctn);
           // cmd.Parameters.AddWithValue("@code", codeMed);
           // cmd.Parameters.AddWithValue("@nom", Nom);
           // cmd.Parameters.AddWithValue("@tel", TelMed);
           //cmd.Parameters.AddWithValue("@DateEmb", DateEmb);
           // cmd.Parameters.AddWithValue("@specialite", cbSp);

           // ctn.Open();
           // int rowsEffected= cmd.ExecuteNonQuery();
           // ctn.Close();
           // MessageBox.Show("Bien Ajouter","Done");




        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string codeMed = textcode.Text;
            string TelMed = textTel.Text;
            string Nom = textNOm.Text;
            DateTime DateEmb = dateEmb.Value;
            string cbSp = CbSpecialite.SelectedItem.ToString();



            //' "+DateEmb+"  '
            dt.DefaultView.Sort = "codemedcin ASC";
            int theone = dt.DefaultView.Find(codeMed);
            dt.DefaultView.AllowEdit = true;
            dt.Rows[theone][1] = Nom;
            dt.Rows[theone][2] = TelMed;
            dt.Rows[theone][3] = DateEmb;
            dt.Rows[theone][4] = cbSp;
            
            //dt.AcceptChanges();
            MessageBox.Show("bien Modifier");


            //builder = new SqlCommandBuilder(adapter);
            //builder.GetUpdateCommand();
            //adapter.Update(dt);













            //SqlCommand cmd = new SqlCommand("update medecin  set  nommedecin=@nom, telmedecin=@tel , dateEmbauche= @DateEmb, specialitemedecin=@specialite    where  codemedcin= @code", ctn);
            //cmd.Parameters.AddWithValue("@code", codeMed);
            //cmd.Parameters.AddWithValue("@nom", Nom);
            //cmd.Parameters.AddWithValue("@tel", TelMed);
            //cmd.Parameters.AddWithValue("@DateEmb", DateEmb);
            //cmd.Parameters.AddWithValue("@specialite", cbSp);

            //ctn.Open();
            //int rowsEffected = cmd.ExecuteNonQuery();
            //ctn.Close();
            //MessageBox.Show("Bien Modifier "+rowsEffected, "Done");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            dt.DefaultView.Sort = "codemedcin ASC";

            int index = dt.DefaultView.Find(textcode.Text);

            dt.Rows[index].Delete();
            //dt.AcceptChanges();

            MessageBox.Show("bien Supprimer");

            

















            //string codeMed = textcode.Text;
            //SqlCommand cmd = new SqlCommand("delete from medecin where codemedcin = @code", ctn);

            //cmd.Parameters.AddWithValue("@code", codeMed);
            //ctn.Open();
            //int rowsEffected = cmd.ExecuteNonQuery();
            //ctn.Close();
            //MessageBox.Show("Bien Supprimer"); 
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateDataBase_Click(object sender, EventArgs e)
        {
            builder = new SqlCommandBuilder(adapter);
            
            adapter.Update(dt);

            MessageBox.Show(" bien Modifer on datatable");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            
            bs.MoveFirst();
        }

        private void btnPreviows_Click(object sender, EventArgs e)
        {
           
            bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
            bs.MoveNext();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
           
            bs.MoveLast();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
