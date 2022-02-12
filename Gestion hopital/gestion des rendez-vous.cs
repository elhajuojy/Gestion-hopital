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
    }
}
