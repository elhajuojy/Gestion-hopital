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
    public partial class gestion_des_patients : Form
    {
        public gestion_des_patients()
        {
            InitializeComponent();
        }
        string CtnGestionFrom = ConfigurationManager.ConnectionStrings["GesHopitalCtn"].ConnectionString;
        SqlConnection ctn = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapter ;
        DataTable dt = new DataTable();

        SqlCommandBuilder bldr ;
        BindingSource bs = new BindingSource();
        
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            textNOm.Text = string.Empty;
            textcode.Text = string.Empty;
            textAdresse.Text = string.Empty;
            dateNais.Value = DateTime.Now;
            radioF.Checked = false;
            radioM.Checked = false;

        }

        private int find(string code)
        {
            int index = -1;

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == code)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private void fill(int index)
        {
            textcode.Text = dt.Rows[index][0].ToString();
            textNOm.Text = dt.Rows[index][1].ToString();
            textAdresse.Text= dt.Rows[index][2].ToString();
            dateNais.Value = DateTime.Parse(dt.Rows[index][3].ToString());

            if(dt.Rows[index][4].ToString() == "M")
            {
                radioM.Checked=true;
            }
            else
            {
                radioF.Checked=true;
            }

        }



        private void btnRecherche_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from patient where codepatient = '" + textcode.Text + "'", ctn);

            ctn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textNOm.Text = reader[1].ToString();
                textAdresse.Text = reader[2].ToString();
                dateNais.Value = DateTime.Parse(reader[3].ToString());
                if (reader[4].ToString() == "M")
                {
                    radioM.Checked = true;
                }
                else
                {
                    radioF.Checked = true;
                }
            }
            ctn.Close();





































            //string code = textcode.Text;

            //int index = find(code);

            //if(index == -1)
            //{
            //    MessageBox.Show(" non !!");
            //}
            //else
            //{
            //    fill(index);
            //}





















            //string codepa = textcode.Text;


            //SqlCommand cmd = new SqlCommand("select * from patient where codepatient = @code", ctn);

            //cmd.Parameters.AddWithValue("@code", codepa);


            //ctn.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            //ctn.Close();

            //textNOm.Text = dt.Rows[0][1].ToString();
            //textAdresse.Text = dt.Rows[0][2].ToString();
            //dateNais.Value = DateTime.Parse(dt.Rows[0][3].ToString());
            //if (dt.Rows[0][4].ToString() == "M")
            //{
            //    radioM.Checked = true;
            //}
            //else
            //{
            //    radioF.Checked = true;
            //}

        }

        private void gestion_des_patients_Load(object sender, EventArgs e)
        {
            ctn.ConnectionString = CtnGestionFrom;
            cmd = new SqlCommand("select * from patient", ctn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            bs.DataSource = dt;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string sexe;

            if (radioF.Checked == true)
            {
                sexe = "F";
            }
            else
            {
                sexe = "M";
            }

            DataRow newRow = dt.NewRow();
            newRow[0] = textcode.Text;
            newRow[1] = textNOm.Text;
            newRow[2]= textAdresse.Text;
            newRow[3]= dateNais.Value;
            newRow[4] = sexe;

            dt.Rows.Add(newRow);




            bldr = new SqlCommandBuilder(adapter);
            adapter.Update(dt);























































            //string codepa = textcode.Text;
            //string adresse = textAdresse.Text;
            //string Nom = textNOm.Text;
            //DateTime datenais = dateNais.Value;
            //string sexe;

            //if (radioF.Checked==true)
            //{
            //    sexe = "F";
            //}
            //else
            //{
            //    sexe = "M";
            //}





            //SqlCommand cmd = new SqlCommand("insert into patient values(@code,@nom,@Adresse,@DateNias,@sexe) ", ctn);
            //cmd.Parameters.AddWithValue("@code", codepa);
            //cmd.Parameters.AddWithValue("@nom", Nom);
            //cmd.Parameters.AddWithValue("@Adresse", adresse);
            //cmd.Parameters.AddWithValue("@DateNias", datenais);
            //cmd.Parameters.AddWithValue("@sexe",sexe);  
            

            //ctn.Open();
            //int rowsEffected = cmd.ExecuteNonQuery();
            //ctn.Close();
            //MessageBox.Show("Bien Ajouter", "Done");


        }
    }
}
