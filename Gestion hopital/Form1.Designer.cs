namespace Gestion_hopital
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesMedcinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPatinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesRDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherTouotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheRDVParDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesRDVDunPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.conToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesMedcinesToolStripMenuItem,
            this.gestionDesPatinToolStripMenuItem,
            this.gestionDesRDVToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(84, 30);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // gestionDesMedcinesToolStripMenuItem
            // 
            this.gestionDesMedcinesToolStripMenuItem.Name = "gestionDesMedcinesToolStripMenuItem";
            this.gestionDesMedcinesToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.gestionDesMedcinesToolStripMenuItem.Text = "Gestion des medecins";
            this.gestionDesMedcinesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesMedcinesToolStripMenuItem_Click_1);
            // 
            // gestionDesPatinToolStripMenuItem
            // 
            this.gestionDesPatinToolStripMenuItem.Name = "gestionDesPatinToolStripMenuItem";
            this.gestionDesPatinToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.gestionDesPatinToolStripMenuItem.Text = "Gestion des patients";
            this.gestionDesPatinToolStripMenuItem.Click += new System.EventHandler(this.gestionDesPatinToolStripMenuItem_Click);
            // 
            // gestionDesRDVToolStripMenuItem
            // 
            this.gestionDesRDVToolStripMenuItem.Name = "gestionDesRDVToolStripMenuItem";
            this.gestionDesRDVToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.gestionDesRDVToolStripMenuItem.Text = "Gestion Des RDV";
            this.gestionDesRDVToolStripMenuItem.Click += new System.EventHandler(this.gestionDesRDVToolStripMenuItem_Click);
            // 
            // conToolStripMenuItem
            // 
            this.conToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherTouotToolStripMenuItem,
            this.rechercheRDVParDateToolStripMenuItem,
            this.afficherLesRDVDunPatientToolStripMenuItem});
            this.conToolStripMenuItem.Name = "conToolStripMenuItem";
            this.conToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.conToolStripMenuItem.Text = "Consutation";
            this.conToolStripMenuItem.Click += new System.EventHandler(this.conToolStripMenuItem_Click);
            // 
            // afficherTouotToolStripMenuItem
            // 
            this.afficherTouotToolStripMenuItem.Name = "afficherTouotToolStripMenuItem";
            this.afficherTouotToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.afficherTouotToolStripMenuItem.Text = "Afficher tout";
            this.afficherTouotToolStripMenuItem.Click += new System.EventHandler(this.afficherTouotToolStripMenuItem_Click);
            // 
            // rechercheRDVParDateToolStripMenuItem
            // 
            this.rechercheRDVParDateToolStripMenuItem.Name = "rechercheRDVParDateToolStripMenuItem";
            this.rechercheRDVParDateToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.rechercheRDVParDateToolStripMenuItem.Text = "Recherche RDV par date";
            this.rechercheRDVParDateToolStripMenuItem.Click += new System.EventHandler(this.rechercheRDVParDateToolStripMenuItem_Click);
            // 
            // afficherLesRDVDunPatientToolStripMenuItem
            // 
            this.afficherLesRDVDunPatientToolStripMenuItem.Name = "afficherLesRDVDunPatientToolStripMenuItem";
            this.afficherLesRDVDunPatientToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.afficherLesRDVDunPatientToolStripMenuItem.Text = "Afficher les RDV d\'un patient";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(77, 30);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 600);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Formulaire Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMedcinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPatinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesRDVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherTouotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheRDVParDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesRDVDunPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

