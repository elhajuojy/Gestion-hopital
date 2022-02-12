
namespace Gestion_hopital
{
    partial class gestion_des_rendez_vous
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCodePatient = new System.Windows.Forms.ComboBox();
            this.textNomPatient = new System.Windows.Forms.TextBox();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textNomMedecin = new System.Windows.Forms.TextBox();
            this.cbCodeMedecin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textspecialiteMedecin = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DateRDV = new System.Windows.Forms.DateTimePicker();
            this.textHeureRDV = new System.Windows.Forms.MaskedTextBox();
            this.btnAjouterRDV = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.btnNouveau);
            this.groupBox1.Controls.Add(this.btnAjouterRDV);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "s";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioF);
            this.groupBox2.Controls.Add(this.radioM);
            this.groupBox2.Controls.Add(this.textNomPatient);
            this.groupBox2.Controls.Add(this.cbCodePatient);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 8.8F);
            this.groupBox2.Location = new System.Drawing.Point(40, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 183);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexe Patient";
            // 
            // cbCodePatient
            // 
            this.cbCodePatient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbCodePatient.FormattingEnabled = true;
            this.cbCodePatient.Location = new System.Drawing.Point(125, 17);
            this.cbCodePatient.Name = "cbCodePatient";
            this.cbCodePatient.Size = new System.Drawing.Size(190, 34);
            this.cbCodePatient.TabIndex = 3;
            this.cbCodePatient.SelectionChangeCommitted += new System.EventHandler(this.cbCodePatient_SelectionChangeCommitted);
            // 
            // textNomPatient
            // 
            this.textNomPatient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textNomPatient.Location = new System.Drawing.Point(125, 68);
            this.textNomPatient.Name = "textNomPatient";
            this.textNomPatient.Size = new System.Drawing.Size(190, 29);
            this.textNomPatient.TabIndex = 4;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioM.Location = new System.Drawing.Point(125, 124);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(46, 30);
            this.radioM.TabIndex = 5;
            this.radioM.TabStop = true;
            this.radioM.Text = "M";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioF.Location = new System.Drawing.Point(216, 124);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(41, 30);
            this.radioF.TabIndex = 6;
            this.radioF.TabStop = true;
            this.radioF.Text = "F";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textspecialiteMedecin);
            this.groupBox3.Controls.Add(this.textNomMedecin);
            this.groupBox3.Controls.Add(this.cbCodeMedecin);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Poppins", 8.8F);
            this.groupBox3.Location = new System.Drawing.Point(425, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 183);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // textNomMedecin
            // 
            this.textNomMedecin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textNomMedecin.Location = new System.Drawing.Point(177, 68);
            this.textNomMedecin.Name = "textNomMedecin";
            this.textNomMedecin.Size = new System.Drawing.Size(190, 29);
            this.textNomMedecin.TabIndex = 4;
            // 
            // cbCodeMedecin
            // 
            this.cbCodeMedecin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbCodeMedecin.FormattingEnabled = true;
            this.cbCodeMedecin.Location = new System.Drawing.Point(177, 17);
            this.cbCodeMedecin.Name = "cbCodeMedecin";
            this.cbCodeMedecin.Size = new System.Drawing.Size(190, 34);
            this.cbCodeMedecin.TabIndex = 3;
            this.cbCodeMedecin.SelectionChangeCommitted += new System.EventHandler(this.cbCodeMedecin_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Specialite medecin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nom Medecin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Code Medecin";
            // 
            // textspecialiteMedecin
            // 
            this.textspecialiteMedecin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textspecialiteMedecin.Location = new System.Drawing.Point(177, 121);
            this.textspecialiteMedecin.Name = "textspecialiteMedecin";
            this.textspecialiteMedecin.Size = new System.Drawing.Size(190, 29);
            this.textspecialiteMedecin.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textHeureRDV);
            this.groupBox4.Controls.Add(this.DateRDV);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Poppins", 8.8F);
            this.groupBox4.Location = new System.Drawing.Point(40, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 183);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Heure RDV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date RDV";
            // 
            // DateRDV
            // 
            this.DateRDV.Location = new System.Drawing.Point(106, 58);
            this.DateRDV.Name = "DateRDV";
            this.DateRDV.Size = new System.Drawing.Size(200, 29);
            this.DateRDV.TabIndex = 2;
            // 
            // textHeureRDV
            // 
            this.textHeureRDV.Location = new System.Drawing.Point(102, 98);
            this.textHeureRDV.Mask = "90:00";
            this.textHeureRDV.Name = "textHeureRDV";
            this.textHeureRDV.Size = new System.Drawing.Size(204, 29);
            this.textHeureRDV.TabIndex = 3;
            this.textHeureRDV.ValidatingType = typeof(System.DateTime);
            // 
            // btnAjouterRDV
            // 
            this.btnAjouterRDV.Location = new System.Drawing.Point(464, 277);
            this.btnAjouterRDV.Name = "btnAjouterRDV";
            this.btnAjouterRDV.Size = new System.Drawing.Size(317, 49);
            this.btnAjouterRDV.TabIndex = 8;
            this.btnAjouterRDV.Text = "Ajouter RDV";
            this.btnAjouterRDV.UseVisualStyleBackColor = true;
            this.btnAjouterRDV.Click += new System.EventHandler(this.btnAjouterRDV_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(464, 340);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(156, 49);
            this.btnNouveau.TabIndex = 9;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(625, 340);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(156, 49);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // gestion_des_rendez_vous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 512);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestion_des_rendez_vous";
            this.Text = "gestion_des_rendez_vous";
            this.Load += new System.EventHandler(this.gestion_des_rendez_vous_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textspecialiteMedecin;
        private System.Windows.Forms.TextBox textNomMedecin;
        private System.Windows.Forms.ComboBox cbCodeMedecin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.TextBox textNomPatient;
        private System.Windows.Forms.ComboBox cbCodePatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox textHeureRDV;
        private System.Windows.Forms.DateTimePicker DateRDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnAjouterRDV;
    }
}