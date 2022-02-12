using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_hopital
{
    public partial class Afficher_les_RDV_d_un_patient : Form
    {
        public Afficher_les_RDV_d_un_patient()
        {
            InitializeComponent();
        }


        Gest_RDVEntities db = new Gest_RDVEntities();
        private void Afficher_les_RDV_d_un_patient_Load(object sender, EventArgs e)
        {

        }
      

        private void btnOk_Click(object sender, EventArgs e)
        {
            var reqselect = from p in db.patients
                            where p.codepatient == textcodePatient.Text
                            select p;



            foreach(var p in reqselect)
            {
                dataGridView1.DataSource = p.RDVs.ToList();
                textNom.Text = p.nompatient;
                TextAdresse.Text = p.adressepatient;
                TextDateNais.Text = p.datenaissance.ToString();
                if (p.sexepatient == "M")
                {
                    RadioM.Checked = true;
                }
                else
                {
                    RadioF.Checked = true;
                }

            }
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.ColumnIndex==3)
            {
                string codem = dataGridView1.CurrentCell.Value.ToString();
                
                this.Close();
                Gestion_des_Medecins frmMedecins = new Gestion_des_Medecins();
                frmMedecins.MdiParent = Form1.ActiveForm;
                frmMedecins.Dock = DockStyle.Fill;
                frmMedecins.Show();
                frmMedecins.btnNouveau.PerformClick();
                frmMedecins.textcode.Text = codem;
                //frmMedecins.btnRecherche.PerformClick();
            }
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
