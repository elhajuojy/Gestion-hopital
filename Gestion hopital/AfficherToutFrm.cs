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
    public partial class AfficherToutFrm : Form
    {
        public AfficherToutFrm()
        {
            InitializeComponent();
        }
        Gest_RDVEntities db = new Gest_RDVEntities();

        private void RadioPatients_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.patients.Select(p => p).ToList();
        }

        private void RadioMedecins_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.medecins.Select(m => m).ToList();
        }

        private void RadioRDV_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.RDVs.Select(r => r).ToList();
        }

        private void AfficherToutFrm_Load(object sender, EventArgs e)
        {
            RadioMedecins.Checked = false;
            RadioPatients.Checked = false;
            RadioRDV.Checked = false;
        }
    }
}
