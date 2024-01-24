
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutProduit));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPrixHTProduit = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrixTTCProduit = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dtpDerniereVente = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(5, 48);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(268, 22);
            this.txtNom.TabIndex = 0;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Items.AddRange(new object[] {
            "Accessoire",
            "Batterie",
            "Cable",
            "Composant",
            "Consommable",
            "Déplacement",
            "Entretien véhicule",
            "Consommation interne",
            "Location directe",
            "Logiciel",
            "Contrats Maintenance et télémaintenance",
            "Main d\'oeuvre",
            "Occasion",
            "Ordinateur portable",
            "Ordinateur de bureau, AIO, serveur",
            "Peripherique",
            "Reseau",
            "Sauvegarde Cloud",
            "Tablette"});
            this.cmbCategorie.Location = new System.Drawing.Point(5, 94);
            this.cmbCategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(268, 24);
            this.cmbCategorie.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Catégorie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix (HT) en € :";
            // 
            // nudPrixHTProduit
            // 
            this.nudPrixHTProduit.DecimalPlaces = 2;
            this.nudPrixHTProduit.Location = new System.Drawing.Point(5, 230);
            this.nudPrixHTProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrixHTProduit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrixHTProduit.Name = "nudPrixHTProduit";
            this.nudPrixHTProduit.Size = new System.Drawing.Size(120, 22);
            this.nudPrixHTProduit.TabIndex = 4;
            this.nudPrixHTProduit.ValueChanged += new System.EventHandler(this.nudPrixHTProduit_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prix (TTC) en €:";
            // 
            // nudPrixTTCProduit
            // 
            this.nudPrixTTCProduit.DecimalPlaces = 2;
            this.nudPrixTTCProduit.Location = new System.Drawing.Point(153, 230);
            this.nudPrixTTCProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrixTTCProduit.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudPrixTTCProduit.Name = "nudPrixTTCProduit";
            this.nudPrixTTCProduit.Size = new System.Drawing.Size(121, 22);
            this.nudPrixTTCProduit.TabIndex = 5;
            this.nudPrixTTCProduit.ValueChanged += new System.EventHandler(this.nudPrixTTCProduit_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnValider);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.dtpDerniereVente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudPrixHTProduit);
            this.groupBox1.Controls.Add(this.nudPrixTTCProduit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudQuantite);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCategorie);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(283, 337);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produit";
            // 
            // btnValider
            // 
            this.btnValider.AutoSize = true;
            this.btnValider.Location = new System.Drawing.Point(5, 258);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(120, 58);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(153, 258);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(121, 58);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // dtpDerniereVente
            // 
            this.dtpDerniereVente.Location = new System.Drawing.Point(5, 140);
            this.dtpDerniereVente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDerniereVente.Name = "dtpDerniereVente";
            this.dtpDerniereVente.Size = new System.Drawing.Size(268, 22);
            this.dtpDerniereVente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date de la dernière vente :";
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(5, 185);
            this.nudQuantite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQuantite.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(268, 22);
            this.nudQuantite.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Quantite :";
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
            this.groupBox2.Location = new System.Drawing.Point(315, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(279, 337);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fournisseur";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(5, 94);
            this.txtReference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(267, 22);
            this.txtReference.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Référence :";
            // 
            // nudPrixTTCFournisseur
            // 
            this.nudPrixTTCFournisseur.DecimalPlaces = 2;
            this.nudPrixTTCFournisseur.Location = new System.Drawing.Point(5, 230);
            this.nudPrixTTCFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrixTTCFournisseur.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPrixTTCFournisseur.Name = "nudPrixTTCFournisseur";
            this.nudPrixTTCFournisseur.Size = new System.Drawing.Size(267, 22);
            this.nudPrixTTCFournisseur.TabIndex = 12;
            this.nudPrixTTCFournisseur.ValueChanged += new System.EventHandler(this.nudPrixTTCFournisseur_ValueChanged);
            // 
            // nudPrixHTFournisseur
            // 
            this.nudPrixHTFournisseur.DecimalPlaces = 2;
            this.nudPrixHTFournisseur.Location = new System.Drawing.Point(5, 185);
            this.nudPrixHTFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrixHTFournisseur.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudPrixHTFournisseur.Name = "nudPrixHTFournisseur";
            this.nudPrixHTFournisseur.Size = new System.Drawing.Size(267, 22);
            this.nudPrixHTFournisseur.TabIndex = 11;
            this.nudPrixHTFournisseur.ValueChanged += new System.EventHandler(this.nudPrixHTFournisseur_ValueChanged);
            // 
            // txtNomFournisseur
            // 
            this.txtNomFournisseur.Location = new System.Drawing.Point(5, 48);
            this.txtNomFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomFournisseur.Name = "txtNomFournisseur";
            this.txtNomFournisseur.Size = new System.Drawing.Size(267, 22);
            this.txtNomFournisseur.TabIndex = 8;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(5, 258);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(267, 58);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dtpDateDernierAchat
            // 
            this.dtpDateDernierAchat.Location = new System.Drawing.Point(5, 140);
            this.dtpDateDernierAchat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateDernierAchat.Name = "dtpDateDernierAchat";
            this.dtpDateDernierAchat.Size = new System.Drawing.Size(267, 22);
            this.dtpDateDernierAchat.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Date du dernier achat :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Prix d\'achat (TTC) en € :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Prix d\'achat (HT) en € :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nom :";
            // 
            // frmAjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(603, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(621, 406);
            this.Name = "frmAjoutProduit";
            this.Text = "Ajout d\'un produit";
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