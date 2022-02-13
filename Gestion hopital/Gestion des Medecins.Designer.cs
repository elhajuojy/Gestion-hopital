namespace Gestion_hopital
{
    partial class Gestion_des_Medecins
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
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPreviows = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.CbSpecialite = new System.Windows.Forms.ComboBox();
            this.dateEmb = new System.Windows.Forms.DateTimePicker();
            this.textTel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNOm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateDataBase = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPreviows);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.btnUpdateDataBase);
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.btnRecherche);
            this.groupBox1.Controls.Add(this.btnNouveau);
            this.groupBox1.Controls.Add(this.CbSpecialite);
            this.groupBox1.Controls.Add(this.dateEmb);
            this.groupBox1.Controls.Add(this.textTel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNOm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textcode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des medecins";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(559, 374);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(85, 33);
            this.btnLast.TabIndex = 23;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(414, 374);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 33);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPreviows
            // 
            this.btnPreviows.Location = new System.Drawing.Point(269, 374);
            this.btnPreviows.Name = "btnPreviows";
            this.btnPreviows.Size = new System.Drawing.Size(100, 33);
            this.btnPreviows.TabIndex = 21;
            this.btnPreviows.Text = "Previows";
            this.btnPreviows.UseVisualStyleBackColor = true;
            this.btnPreviows.Click += new System.EventHandler(this.btnPreviows_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(124, 374);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(85, 33);
            this.btnFirst.TabIndex = 20;
            this.btnFirst.Text = "first";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(615, 280);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(139, 33);
            this.btnQuitter.TabIndex = 18;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(615, 241);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(139, 33);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(615, 196);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(139, 33);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(615, 157);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(139, 33);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(615, 118);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(139, 33);
            this.btnRecherche.TabIndex = 14;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(615, 73);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(139, 33);
            this.btnNouveau.TabIndex = 13;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // CbSpecialite
            // 
            this.CbSpecialite.FormattingEnabled = true;
            this.CbSpecialite.Location = new System.Drawing.Point(221, 303);
            this.CbSpecialite.Name = "CbSpecialite";
            this.CbSpecialite.Size = new System.Drawing.Size(225, 38);
            this.CbSpecialite.TabIndex = 12;
            // 
            // dateEmb
            // 
            this.dateEmb.Location = new System.Drawing.Point(221, 239);
            this.dateEmb.Name = "dateEmb";
            this.dateEmb.Size = new System.Drawing.Size(225, 33);
            this.dateEmb.TabIndex = 11;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(221, 180);
            this.textTel.Mask = "0000000000";
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(225, 33);
            this.textTel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Specialite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date Embauche";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tel";
            // 
            // textNOm
            // 
            this.textNOm.Location = new System.Drawing.Point(221, 115);
            this.textNOm.Name = "textNOm";
            this.textNOm.Size = new System.Drawing.Size(225, 33);
            this.textNOm.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(221, 50);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(225, 33);
            this.textcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // btnUpdateDataBase
            // 
            this.btnUpdateDataBase.Location = new System.Drawing.Point(615, 319);
            this.btnUpdateDataBase.Name = "btnUpdateDataBase";
            this.btnUpdateDataBase.Size = new System.Drawing.Size(139, 33);
            this.btnUpdateDataBase.TabIndex = 19;
            this.btnUpdateDataBase.Text = "Save to Db";
            this.btnUpdateDataBase.UseVisualStyleBackColor = true;
            this.btnUpdateDataBase.Click += new System.EventHandler(this.btnUpdateDataBase_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save to Db";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestion_des_Medecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(917, 512);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestion_des_Medecins";
            this.Text = "Gestion_des_Medecins";
            this.Load += new System.EventHandler(this.Gestion_des_Medecins_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox CbSpecialite;
        private System.Windows.Forms.DateTimePicker dateEmb;
        private System.Windows.Forms.MaskedTextBox textTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNOm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreviows;
        private System.Windows.Forms.Button btnFirst;
        public System.Windows.Forms.Button btnRecherche;
        public System.Windows.Forms.TextBox textcode;
        public System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateDataBase;
    }
}