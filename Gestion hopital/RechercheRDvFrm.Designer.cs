
namespace Gestion_hopital
{
    partial class RechercheRDvFrm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.textNomPatient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textspecialiteMedecin = new System.Windows.Forms.TextBox();
            this.textNomMedecin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textpatientDateNais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textdate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.textdate);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisir la date";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(432, 63);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 40);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(579, 63);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(115, 40);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Anuuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // dgv
            // 
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(24, 175);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(872, 171);
            this.dgv.TabIndex = 3;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textpatientDateNais);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radioF);
            this.groupBox2.Controls.Add(this.radioM);
            this.groupBox2.Controls.Add(this.textNomPatient);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 8.8F);
            this.groupBox2.Location = new System.Drawing.Point(517, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 206);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioF.Location = new System.Drawing.Point(243, 146);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(41, 30);
            this.radioF.TabIndex = 6;
            this.radioF.TabStop = true;
            this.radioF.Text = "F";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioM.Location = new System.Drawing.Point(158, 146);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(46, 30);
            this.radioM.TabIndex = 5;
            this.radioM.TabStop = true;
            this.radioM.Text = "M";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // textNomPatient
            // 
            this.textNomPatient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textNomPatient.Location = new System.Drawing.Point(158, 40);
            this.textNomPatient.Name = "textNomPatient";
            this.textNomPatient.Size = new System.Drawing.Size(190, 29);
            this.textNomPatient.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexe Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Patient";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textspecialiteMedecin);
            this.groupBox3.Controls.Add(this.textNomMedecin);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Poppins", 8.8F);
            this.groupBox3.Location = new System.Drawing.Point(24, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 206);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // textspecialiteMedecin
            // 
            this.textspecialiteMedecin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textspecialiteMedecin.Location = new System.Drawing.Point(182, 92);
            this.textspecialiteMedecin.Name = "textspecialiteMedecin";
            this.textspecialiteMedecin.Size = new System.Drawing.Size(190, 29);
            this.textspecialiteMedecin.TabIndex = 5;
            // 
            // textNomMedecin
            // 
            this.textNomMedecin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textNomMedecin.Location = new System.Drawing.Point(182, 39);
            this.textNomMedecin.Name = "textNomMedecin";
            this.textNomMedecin.Size = new System.Drawing.Size(190, 29);
            this.textNomMedecin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Specialite medecin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nom Medecin";
            // 
            // textpatientDateNais
            // 
            this.textpatientDateNais.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textpatientDateNais.Location = new System.Drawing.Point(158, 92);
            this.textpatientDateNais.Name = "textpatientDateNais";
            this.textpatientDateNais.Size = new System.Drawing.Size(190, 29);
            this.textpatientDateNais.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "date Nais Patient";
            // 
            // textdate
            // 
            this.textdate.Location = new System.Drawing.Point(141, 67);
            this.textdate.Multiline = true;
            this.textdate.Name = "textdate";
            this.textdate.Size = new System.Drawing.Size(208, 36);
            this.textdate.TabIndex = 1;
            this.textdate.TextChanged += new System.EventHandler(this.textdate_TextChanged);
            // 
            // RechercheRDvFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RechercheRDvFrm";
            this.Text = "RechercheRDvFrm";
            this.Load += new System.EventHandler(this.RechercheRDvFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.TextBox textNomPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textspecialiteMedecin;
        private System.Windows.Forms.TextBox textNomMedecin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textpatientDateNais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textdate;
    }
}