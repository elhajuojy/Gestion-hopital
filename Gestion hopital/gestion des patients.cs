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
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            textNOm.Text = string.Empty;
            textcode.Text = string.Empty;
            textAdresse.Text = string.Empty;
            dateNais.Value = DateTime.Now;
            radioF.Checked = false;
            radioM.Checked = false;

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            string codepa = textcode.Text;
            

            SqlCommand cmd = new SqlCommand("select * from patient where codepatient = @code", ctn);

            cmd.Parameters.AddWithValue("@code", codepa);


            ctn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ctn.Close();

            textNOm.Text = dt.Rows[0][1].ToString();
            textAdresse.Text = dt.Rows[0][2].ToString();
            dateNais.Value = DateTime.Parse(dt.Rows[0][3].ToString());
            //if(dt.Rows[0][4].ToString() == "M")
            //{
            //    radioM.Checked = true;
            //}
            //else
            //{
            //    radioF.Checked = true;
            //}
            
        }
    }
}
