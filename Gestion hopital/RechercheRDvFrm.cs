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
    public partial class RechercheRDvFrm : Form
    {
        public RechercheRDvFrm()
        {
            InitializeComponent();
        }
        Gest_RDVEntities db = new Gest_RDVEntities();
        private void RechercheRDvFrm_Load(object sender, EventArgs e)
        {
            textNomMedecin.Enabled = false;
            textNomPatient.Enabled = false;
            radioF.Enabled = false;
            radioM.Enabled = false;
            textspecialiteMedecin.Enabled = false;
            textpatientDateNais.Enabled = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgv.DataSource = db.RDVs.Select(r => r).ToList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var req = from rdv in db.RDVs
                      where rdv.dateRDV.Equals(textdate.Text)
                      select rdv;
            dgv.DataSource = null;
            dgv.DataSource = req.ToList();

        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            int code =int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
            var selectedOne = from rdv in db.RDVs
                              where rdv.numeroRDV == code
                              select rdv;

            foreach(var r in selectedOne)
            {
                textNomMedecin.Text = r.medecin.nommedecin;
                textspecialiteMedecin.Text = r.medecin.specialitemedecin;
                textNomPatient.Text = r.patient.nompatient;
                textpatientDateNais.Text = r.patient.datenaissance.ToString();
                if (r.patient.sexepatient == "M")
                {
                    radioM.Checked = true;
                }
                else
                {
                    radioF.Checked = true;
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            
            textNomMedecin.Text = string.Empty;
            textNomPatient.Text = string.Empty;
            radioF.Checked = false;
            radioM.Checked = false;
            textspecialiteMedecin.Text = string.Empty;
            textpatientDateNais.Text = string.Empty;
            dgv.DataSource = db.RDVs.Select(r => r).ToList();
            textdate.Text = string.Empty;
        }

        private void textdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
