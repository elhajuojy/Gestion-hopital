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

namespace Gestion_hopital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void gestionDesMedcinesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Gestion_des_Medecins GestionMedForm = new Gestion_des_Medecins();
            GestionMedForm.MdiParent= this;
            GestionMedForm.Dock = DockStyle.Fill;
            GestionMedForm.Show();
        }


        private void conToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDesPatinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestion_des_patients formGesPa = new gestion_des_patients();
            formGesPa.MdiParent = this;
            formGesPa.Dock = DockStyle.Fill;
            formGesPa.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gestionDesRDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestion_des_rendez_vous formGest_RDV = new gestion_des_rendez_vous();
            formGest_RDV.MdiParent = this;
            formGest_RDV.Dock = DockStyle.Fill;
            formGest_RDV.Show();
        }
    }
}
