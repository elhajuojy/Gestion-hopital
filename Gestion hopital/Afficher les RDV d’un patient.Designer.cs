
namespace Gestion_hopital
{
    partial class Afficher_les_RDV_d_un_patient
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.textcodePatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioF = new System.Windows.Forms.RadioButton();
            this.RadioM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TextAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextDateNais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cbCodeMedecin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextHeureRDv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextdateRDV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextNumeroRDV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.textcodePatient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "saisir code paitent";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(641, 60);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(129, 33);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(506, 60);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(129, 33);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textcodePatient
            // 
            this.textcodePatient.Location = new System.Drawing.Point(251, 56);
            this.textcodePatient.Name = "textcodePatient";
            this.textcodePatient.Size = new System.Drawing.Size(226, 30);
            this.textcodePatient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "code Patient";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioF);
            this.groupBox2.Controls.Add(this.RadioM);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TextAdresse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TextDateNais);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textNom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 161);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "info patient";
            // 
            // RadioF
            // 
            this.RadioF.AutoSize = true;
            this.RadioF.Location = new System.Drawing.Point(705, 88);
            this.RadioF.Name = "RadioF";
            this.RadioF.Size = new System.Drawing.Size(41, 30);
            this.RadioF.TabIndex = 8;
            this.RadioF.TabStop = true;
            this.RadioF.Text = "F";
            this.RadioF.UseVisualStyleBackColor = true;
            // 
            // RadioM
            // 
            this.RadioM.AutoSize = true;
            this.RadioM.Location = new System.Drawing.Point(572, 88);
            this.RadioM.Name = "RadioM";
            this.RadioM.Size = new System.Drawing.Size(46, 30);
            this.RadioM.TabIndex = 7;
            this.RadioM.TabStop = true;
            this.RadioM.Text = "M";
            this.RadioM.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sexe";
            // 
            // TextAdresse
            // 
            this.TextAdresse.Location = new System.Drawing.Point(572, 37);
            this.TextAdresse.Name = "TextAdresse";
            this.TextAdresse.Size = new System.Drawing.Size(226, 30);
            this.TextAdresse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse";
            // 
            // TextDateNais
            // 
            this.TextDateNais.Location = new System.Drawing.Point(165, 84);
            this.TextDateNais.Name = "TextDateNais";
            this.TextDateNais.Size = new System.Drawing.Size(226, 30);
            this.TextDateNais.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Nais";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(165, 37);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(226, 30);
            this.textNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(884, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            //this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSupprimer);
            this.groupBox3.Controls.Add(this.btnEnregistrer);
            this.groupBox3.Controls.Add(this.cbCodeMedecin);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TextHeureRDv);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TextdateRDV);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TextNumeroRDV);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 506);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(884, 161);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendez vous";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(751, 83);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(112, 37);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(751, 39);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(112, 37);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // cbCodeMedecin
            // 
            this.cbCodeMedecin.FormattingEnabled = true;
            this.cbCodeMedecin.Location = new System.Drawing.Point(483, 81);
            this.cbCodeMedecin.Name = "cbCodeMedecin";
            this.cbCodeMedecin.Size = new System.Drawing.Size(226, 34);
            this.cbCodeMedecin.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "code medecin";
            // 
            // TextHeureRDv
            // 
            this.TextHeureRDv.Location = new System.Drawing.Point(483, 37);
            this.TextHeureRDv.Name = "TextHeureRDv";
            this.TextHeureRDv.Size = new System.Drawing.Size(226, 30);
            this.TextHeureRDv.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Heure RDV";
            // 
            // TextdateRDV
            // 
            this.TextdateRDV.Location = new System.Drawing.Point(113, 85);
            this.TextdateRDV.Name = "TextdateRDV";
            this.TextdateRDV.Size = new System.Drawing.Size(226, 30);
            this.TextdateRDV.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date RDV";
            // 
            // TextNumeroRDV
            // 
            this.TextNumeroRDV.Location = new System.Drawing.Point(113, 37);
            this.TextNumeroRDV.Name = "TextNumeroRDV";
            this.TextNumeroRDV.Size = new System.Drawing.Size(226, 30);
            this.TextNumeroRDV.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Numero RDV";
            // 
            // Afficher_les_RDV_d_un_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 679);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Afficher_les_RDV_d_un_patient";
            this.Text = "Afficher_les_RDV_d_un_patient";
            this.Load += new System.EventHandler(this.Afficher_les_RDV_d_un_patient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textcodePatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadioF;
        private System.Windows.Forms.RadioButton RadioM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextDateNais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbCodeMedecin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextHeureRDv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextdateRDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextNumeroRDV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}