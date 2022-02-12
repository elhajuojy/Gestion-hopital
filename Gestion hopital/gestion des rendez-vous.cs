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
    public partial class gestion_des_rendez_vous : Form
    {
        public gestion_des_rendez_vous()
        {
            InitializeComponent();
        }

        Gest_RDVEntities db = new Gest_RDVEntities();

        private void gestion_des_rendez_vous_Load(object sender, EventArgs e)
        {
            textNomMedecin.Enabled = false;
            textNomPatient.Enabled = false;
            radioF.Enabled = false;
            radioM.Enabled = false;
            textspecialiteMedecin.Enabled = false;
            cbCodeMedecin.DataSource = db.medecins.Select(m => m.codemedcin).ToList();
            cbCodePatient.DataSource = db.patients.Select(p => p.codepatient).ToList();



        }

        private void cbCodePatient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            var req = from patient in db.patients
                      where patient.codepatient == cbCodePatient.SelectedItem.ToString()
                      select patient;
            foreach(var p in req)
            {
                textNomPatient.Text = p.nompatient;
                if (p.sexepatient == "M")
                {
                    radioM.Checked = true;
                }
                else
                {
                    radioF.Checked = true;
                }


            }
        }

        private void cbCodeMedecin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var req = db.medecins.Where(m => m.codemedcin == cbCodeMedecin.SelectedItem.ToString());
            foreach(var m in req)
            {
                textNomMedecin.Text = m.nommedecin;
                textspecialiteMedecin.Text = m.specialitemedecin;
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            textHeureRDV.Text = string.Empty;
            textNomMedecin.Text = string.Empty;
            textNomPatient.Text = string.Empty;
            radioF.Checked = false;
            radioM.Checked = false;
            DateRDV.Value = DateTime.Now;
            textspecialiteMedecin.Text = string.Empty;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouterRDV_Click(object sender, EventArgs e)
        {
            int max = (from n in db.RDVs
                       select n.numeroRDV).Max();


            RDV rdv = new RDV();
            rdv.numeroRDV = max+1;
            rdv.codemedcin = cbCodeMedecin.SelectedItem.ToString();
            rdv.codepatient = cbCodePatient.SelectedItem.ToString();
            rdv.dateRDV = DateRDV.Value;
            rdv.heureRDV = textHeureRDV.Text;
            db.RDVs.Add(rdv);
            db.SaveChanges();
        }
    }
}
