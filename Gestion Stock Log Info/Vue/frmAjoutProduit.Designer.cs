
namespace Gestion_Stock_Log_Info.Vue
{
    partial class frmAjoutProduit
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPrixHTProduit = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrixTTCProduit = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDerniereVente = new System.Windows.Forms.DateTimePicker();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudPrixTTCFournisseur = new System.Windows.Forms.NumericUpDown();
            this.nudPrixHTFournisseur = new System.Windows.Forms.NumericUpDown();
            this.txtNomFournisseur = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dtpDateDernierAchat = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCProduit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(6, 73);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(268, 22);
            this.txtNom.TabIndex = 3;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Items.AddRange(new object[] {
            "CPU",
            "GPU"});
            this.cmbCategorie.Location = new System.Drawing.Point(10, 174);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(121, 24);
            this.cmbCategorie.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Catégorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix (HT)";
            // 
            // nudPrixHTProduit
            // 
            this.nudPrixHTProduit.DecimalPlaces = 2;
            this.nudPrixHTProduit.Location = new System.Drawing.Point(10, 253);
            this.nudPrixHTProduit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrixHTProduit.Name = "nudPrixHTProduit";
            this.nudPrixHTProduit.Size = new System.Drawing.Size(120, 22);
            this.nudPrixHTProduit.TabIndex = 7;
            this.nudPrixHTProduit.ValueChanged += new System.EventHandler(this.nudPrixHTProduit_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prix (TTC)";
            // 
            // nudPrixTTCProduit
            // 
            this.nudPrixTTCProduit.DecimalPlaces = 2;
            this.nudPrixTTCProduit.Location = new System.Drawing.Point(205, 253);
            this.nudPrixTTCProduit.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudPrixTTCProduit.Name = "nudPrixTTCProduit";
            this.nudPrixTTCProduit.Size = new System.Drawing.Size(120, 22);
            this.nudPrixTTCProduit.TabIndex = 9;
            this.nudPrixTTCProduit.ValueChanged += new System.EventHandler(this.nudPrixTTCProduit_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDerniereVente);
            this.groupBox1.Controls.Add(this.nudQuantite);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nudPrixTTCProduit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudPrixHTProduit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCategorie);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 296);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date Derniere Vente";
            // 
            // dtpDerniereVente
            // 
            this.dtpDerniereVente.Location = new System.Drawing.Point(6, 120);
            this.dtpDerniereVente.Name = "dtpDerniereVente";
            this.dtpDerniereVente.Size = new System.Drawing.Size(242, 22);
            this.dtpDerniereVente.TabIndex = 12;
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(189, 191);
            this.nudQuantite.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(120, 22);
            this.nudQuantite.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Quantite";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.txtReference);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nudPrixTTCFournisseur);
            this.groupBox2.Controls.Add(this.nudPrixHTFournisseur);
            this.groupBox2.Controls.Add(this.txtNomFournisseur);
            this.groupBox2.Controls.Add(this.btnAjouter);
            this.groupBox2.Controls.Add(this.dtpDateDernierAchat);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(423, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 390);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fournisseur";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(6, 115);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(100, 22);
            this.txtReference.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Reference";
            // 
            // nudPrixTTCFournisseur
            // 
            this.nudPrixTTCFournisseur.DecimalPlaces = 2;
            this.nudPrixTTCFournisseur.Location = new System.Drawing.Point(20, 216);
            this.nudPrixTTCFournisseur.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPrixTTCFournisseur.Name = "nudPrixTTCFournisseur";
            this.nudPrixTTCFournisseur.Size = new System.Drawing.Size(120, 22);
            this.nudPrixTTCFournisseur.TabIndex = 8;
            this.nudPrixTTCFournisseur.ValueChanged += new System.EventHandler(this.nudPrixTTCFournisseur_ValueChanged);
            // 
            // nudPrixHTFournisseur
            // 
            this.nudPrixHTFournisseur.DecimalPlaces = 2;
            this.nudPrixHTFournisseur.Location = new System.Drawing.Point(19, 163);
            this.nudPrixHTFournisseur.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudPrixHTFournisseur.Name = "nudPrixHTFournisseur";
            this.nudPrixHTFournisseur.Size = new System.Drawing.Size(120, 22);
            this.nudPrixHTFournisseur.TabIndex = 7;
            this.nudPrixHTFournisseur.ValueChanged += new System.EventHandler(this.nudPrixHTFournisseur_ValueChanged);
            // 
            // txtNomFournisseur
            // 
            this.txtNomFournisseur.Location = new System.Drawing.Point(6, 68);
            this.txtNomFournisseur.Name = "txtNomFournisseur";
            this.txtNomFournisseur.Size = new System.Drawing.Size(100, 22);
            this.txtNomFournisseur.TabIndex = 6;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(20, 311);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(162, 58);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dtpDateDernierAchat
            // 
            this.dtpDateDernierAchat.Location = new System.Drawing.Point(20, 269);
            this.dtpDateDernierAchat.Name = "dtpDateDernierAchat";
            this.dtpDateDernierAchat.Size = new System.Drawing.Size(242, 22);
            this.dtpDateDernierAchat.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "date dernier achat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Prix d\'achat (TTC)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Prix d\'achat (HT)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "nom";
            // 
            // btnValider
            // 
            this.btnValider.AutoSize = true;
            this.btnValider.Location = new System.Drawing.Point(31, 341);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(124, 71);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(201, 341);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(124, 71);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmAjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAjoutProduit";
            this.Text = "frmAjoutProduit";
            this.Load += new System.EventHandler(this.frmAjoutProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCProduit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTFournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPrixHTProduit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrixTTCProduit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DateTimePicker dtpDateDernierAchat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrixTTCFournisseur;
        private System.Windows.Forms.NumericUpDown nudPrixHTFournisseur;
        private System.Windows.Forms.TextBox txtNomFournisseur;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDerniereVente;
    }
}