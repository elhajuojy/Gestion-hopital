
namespace Gestion_hopital
{
    partial class AfficherToutFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioMedecins = new System.Windows.Forms.RadioButton();
            this.RadioPatients = new System.Windows.Forms.RadioButton();
            this.RadioRDV = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioRDV);
            this.groupBox1.Controls.Add(this.RadioPatients);
            this.groupBox1.Controls.Add(this.RadioMedecins);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 8.8F);
            this.groupBox1.Location = new System.Drawing.Point(32, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix";
            // 
            // RadioMedecins
            // 
            this.RadioMedecins.AutoSize = true;
            this.RadioMedecins.Location = new System.Drawing.Point(51, 31);
            this.RadioMedecins.Name = "RadioMedecins";
            this.RadioMedecins.Size = new System.Drawing.Size(170, 30);
            this.RadioMedecins.TabIndex = 0;
            this.RadioMedecins.TabStop = true;
            this.RadioMedecins.Text = "Tous les Medecins";
            this.RadioMedecins.UseVisualStyleBackColor = true;
            this.RadioMedecins.CheckedChanged += new System.EventHandler(this.RadioMedecins_CheckedChanged);
            // 
            // RadioPatients
            // 
            this.RadioPatients.AutoSize = true;
            this.RadioPatients.Location = new System.Drawing.Point(363, 30);
            this.RadioPatients.Name = "RadioPatients";
            this.RadioPatients.Size = new System.Drawing.Size(159, 30);
            this.RadioPatients.TabIndex = 1;
            this.RadioPatients.TabStop = true;
            this.RadioPatients.Text = "Tous les patients";
            this.RadioPatients.UseVisualStyleBackColor = true;
            this.RadioPatients.CheckedChanged += new System.EventHandler(this.RadioPatients_CheckedChanged);
            // 
            // RadioRDV
            // 
            this.RadioRDV.AutoSize = true;
            this.RadioRDV.Location = new System.Drawing.Point(645, 31);
            this.RadioRDV.Name = "RadioRDV";
            this.RadioRDV.Size = new System.Drawing.Size(126, 30);
            this.RadioRDV.TabIndex = 2;
            this.RadioRDV.TabStop = true;
            this.RadioRDV.Text = "Tous les RDv";
            this.RadioRDV.UseVisualStyleBackColor = true;
            this.RadioRDV.CheckedChanged += new System.EventHandler(this.RadioRDV_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(857, 280);
            this.dataGridView1.TabIndex = 3;
            // 
            // AfficherToutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfficherToutFrm";
            this.Text = "AfficherToutFrm";
            this.Load += new System.EventHandler(this.AfficherToutFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioRDV;
        private System.Windows.Forms.RadioButton RadioPatients;
        private System.Windows.Forms.RadioButton RadioMedecins;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}