
namespace Gestion_Stock_Log_Info.Vue
{
    partial class frmInfoProduit
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
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.lstFournisseurs = new System.Windows.Forms.ListBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPrixHTProduit = new System.Windows.Forms.NumericUpDown();
            this.nudPrixTTCProduit = new System.Windows.Forms.NumericUpDown();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.grpProduit = new System.Windows.Forms.GroupBox();
            this.btnSupprimerProduit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.dtpDerniereVente = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnulerProduit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjouterFournisseur = new System.Windows.Forms.Button();
            this.btnModifierFournisseur = new System.Windows.Forms.Button();
            this.lblMargeHT = new System.Windows.Forms.Label();
            this.btnSupprimerFournisseur = new System.Windows.Forms.Button();
            this.lblValeurTotalHT = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnulerFournisseur = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudPrixTTCFournisseur = new System.Windows.Forms.NumericUpDown();
            this.nudPrixHTFournisseur = new System.Windows.Forms.NumericUpDown();
            this.dtpDateDernierAchat = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomFournisseur = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReferenceFournisseur = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblValeurTotaleTTC = new System.Windows.Forms.Label();
            this.lblMargeTTC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.grpProduit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Location = new System.Drawing.Point(8, 228);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(124, 58);
            this.btnModifierProduit.TabIndex = 0;
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.UseVisualStyleBackColor = true;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // lstFournisseurs
            // 
            this.lstFournisseurs.FormattingEnabled = true;
            this.lstFournisseurs.ItemHeight = 16;
            this.lstFournisseurs.Location = new System.Drawing.Point(225, 361);
            this.lstFournisseurs.Name = "lstFournisseurs";
            this.lstFournisseurs.Size = new System.Drawing.Size(630, 132);
            this.lstFournisseurs.Sorted = true;
            this.lstFournisseurs.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(13, 47);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(256, 22);
            this.txtNom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // nudPrixHTProduit
            // 
            this.nudPrixHTProduit.DecimalPlaces = 2;
            this.nudPrixHTProduit.Location = new System.Drawing.Point(8, 181);
            this.nudPrixHTProduit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrixHTProduit.Name = "nudPrixHTProduit";
            this.nudPrixHTProduit.Size = new System.Drawing.Size(120, 22);
            this.nudPrixHTProduit.TabIndex = 6;
            this.nudPrixHTProduit.ValueChanged += new System.EventHandler(this.nudPrixHTProduit_ValueChanged);
            // 
            // nudPrixTTCProduit
            // 
            this.nudPrixTTCProduit.DecimalPlaces = 2;
            this.nudPrixTTCProduit.Location = new System.Drawing.Point(134, 181);
            this.nudPrixTTCProduit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrixTTCProduit.Name = "nudPrixTTCProduit";
            this.nudPrixTTCProduit.Size = new System.Drawing.Size(120, 22);
            this.nudPrixTTCProduit.TabIndex = 7;
            this.nudPrixTTCProduit.ValueChanged += new System.EventHandler(this.nudPrixTTCProduit_ValueChanged);
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(260, 181);
            this.nudQuantite.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(120, 22);
            this.nudQuantite.TabIndex = 8;
            // 
            // grpProduit
            // 
            this.grpProduit.Controls.Add(this.btnSupprimerProduit);
            this.grpProduit.Controls.Add(this.label8);
            this.grpProduit.Controls.Add(this.cmbCategorie);
            this.grpProduit.Controls.Add(this.dtpDerniereVente);
            this.grpProduit.Controls.Add(this.label1);
            this.grpProduit.Controls.Add(this.btnAnnulerProduit);
            this.grpProduit.Controls.Add(this.label5);
            this.grpProduit.Controls.Add(this.label4);
            this.grpProduit.Controls.Add(this.label3);
            this.grpProduit.Controls.Add(this.btnModifierProduit);
            this.grpProduit.Controls.Add(this.nudQuantite);
            this.grpProduit.Controls.Add(this.nudPrixTTCProduit);
            this.grpProduit.Controls.Add(this.nudPrixHTProduit);
            this.grpProduit.Controls.Add(this.txtNom);
            this.grpProduit.Controls.Add(this.label2);
            this.grpProduit.Location = new System.Drawing.Point(16, 17);
            this.grpProduit.Name = "grpProduit";
            this.grpProduit.Size = new System.Drawing.Size(387, 310);
            this.grpProduit.TabIndex = 9;
            this.grpProduit.TabStop = false;
            this.grpProduit.Text = "Produit :";
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.Location = new System.Drawing.Point(138, 227);
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(99, 61);
            this.btnSupprimerProduit.TabIndex = 19;
            this.btnSupprimerProduit.Text = "supprimer";
            this.btnSupprimerProduit.UseVisualStyleBackColor = true;
            this.btnSupprimerProduit.Click += new System.EventHandler(this.btnSupprimerProduit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Categorie :";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Items.AddRange(new object[] {
            "CPU",
            "GPU"});
            this.cmbCategorie.Location = new System.Drawing.Point(209, 113);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(121, 24);
            this.cmbCategorie.TabIndex = 17;
            // 
            // dtpDerniereVente
            // 
            this.dtpDerniereVente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDerniereVente.Location = new System.Drawing.Point(9, 123);
            this.dtpDerniereVente.Name = "dtpDerniereVente";
            this.dtpDerniereVente.Size = new System.Drawing.Size(119, 22);
            this.dtpDerniereVente.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date dernière vente";
            // 
            // btnAnnulerProduit
            // 
            this.btnAnnulerProduit.Location = new System.Drawing.Point(244, 228);
            this.btnAnnulerProduit.Name = "btnAnnulerProduit";
            this.btnAnnulerProduit.Size = new System.Drawing.Size(122, 58);
            this.btnAnnulerProduit.TabIndex = 12;
            this.btnAnnulerProduit.Text = "Annuler";
            this.btnAnnulerProduit.UseVisualStyleBackColor = true;
            this.btnAnnulerProduit.Click += new System.EventHandler(this.btnAnnulerProduit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prix TTC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prix HT";
            // 
            // btnAjouterFournisseur
            // 
            this.btnAjouterFournisseur.Location = new System.Drawing.Point(18, 239);
            this.btnAjouterFournisseur.Name = "btnAjouterFournisseur";
            this.btnAjouterFournisseur.Size = new System.Drawing.Size(75, 34);
            this.btnAjouterFournisseur.TabIndex = 11;
            this.btnAjouterFournisseur.Text = "Ajouter";
            this.btnAjouterFournisseur.UseVisualStyleBackColor = true;
            this.btnAjouterFournisseur.Click += new System.EventHandler(this.btnAjouterFournisseur_Click);
            // 
            // btnModifierFournisseur
            // 
            this.btnModifierFournisseur.Location = new System.Drawing.Point(99, 230);
            this.btnModifierFournisseur.Name = "btnModifierFournisseur";
            this.btnModifierFournisseur.Size = new System.Drawing.Size(75, 50);
            this.btnModifierFournisseur.TabIndex = 12;
            this.btnModifierFournisseur.Text = "Modifier";
            this.btnModifierFournisseur.UseVisualStyleBackColor = true;
            this.btnModifierFournisseur.Click += new System.EventHandler(this.btnModifierFournisseur_Click);
            // 
            // lblMargeHT
            // 
            this.lblMargeHT.AutoSize = true;
            this.lblMargeHT.Location = new System.Drawing.Point(13, 407);
            this.lblMargeHT.Name = "lblMargeHT";
            this.lblMargeHT.Size = new System.Drawing.Size(56, 17);
            this.lblMargeHT.TabIndex = 13;
            this.lblMargeHT.Text = "Marge :";
            // 
            // btnSupprimerFournisseur
            // 
            this.btnSupprimerFournisseur.Location = new System.Drawing.Point(180, 239);
            this.btnSupprimerFournisseur.Name = "btnSupprimerFournisseur";
            this.btnSupprimerFournisseur.Size = new System.Drawing.Size(68, 38);
            this.btnSupprimerFournisseur.TabIndex = 14;
            this.btnSupprimerFournisseur.Text = "Supprimer";
            this.btnSupprimerFournisseur.UseVisualStyleBackColor = true;
            this.btnSupprimerFournisseur.Click += new System.EventHandler(this.btnSupprimerFournisseur_Click);
            // 
            // lblValeurTotalHT
            // 
            this.lblValeurTotalHT.AutoSize = true;
            this.lblValeurTotalHT.Location = new System.Drawing.Point(12, 361);
            this.lblValeurTotalHT.Name = "lblValeurTotalHT";
            this.lblValeurTotalHT.Size = new System.Drawing.Size(138, 17);
            this.lblValeurTotalHT.TabIndex = 15;
            this.lblValeurTotalHT.Text = "Valeur Totale (HT) : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnnulerFournisseur);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nudPrixTTCFournisseur);
            this.groupBox1.Controls.Add(this.nudPrixHTFournisseur);
            this.groupBox1.Controls.Add(this.dtpDateDernierAchat);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNomFournisseur);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtReferenceFournisseur);
            this.groupBox1.Controls.Add(this.btnSupprimerFournisseur);
            this.groupBox1.Controls.Add(this.btnModifierFournisseur);
            this.groupBox1.Controls.Add(this.btnAjouterFournisseur);
            this.groupBox1.Location = new System.Drawing.Point(420, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 304);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fournisseur(s)";
            // 
            // btnAnnulerFournisseur
            // 
            this.btnAnnulerFournisseur.Location = new System.Drawing.Point(271, 239);
            this.btnAnnulerFournisseur.Name = "btnAnnulerFournisseur";
            this.btnAnnulerFournisseur.Size = new System.Drawing.Size(104, 43);
            this.btnAnnulerFournisseur.TabIndex = 25;
            this.btnAnnulerFournisseur.Text = "Annuler";
            this.btnAnnulerFournisseur.UseVisualStyleBackColor = true;
            this.btnAnnulerFournisseur.Click += new System.EventHandler(this.btnAnnulerFournisseur_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(200, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Prix HT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Prix TTC";
            // 
            // nudPrixTTCFournisseur
            // 
            this.nudPrixTTCFournisseur.DecimalPlaces = 2;
            this.nudPrixTTCFournisseur.Location = new System.Drawing.Point(289, 149);
            this.nudPrixTTCFournisseur.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrixTTCFournisseur.Name = "nudPrixTTCFournisseur";
            this.nudPrixTTCFournisseur.Size = new System.Drawing.Size(120, 22);
            this.nudPrixTTCFournisseur.TabIndex = 22;
            this.nudPrixTTCFournisseur.ValueChanged += new System.EventHandler(this.nudPrixTTCFournisseur_ValueChanged);
            // 
            // nudPrixHTFournisseur
            // 
            this.nudPrixHTFournisseur.DecimalPlaces = 2;
            this.nudPrixHTFournisseur.Location = new System.Drawing.Point(195, 185);
            this.nudPrixHTFournisseur.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrixHTFournisseur.Name = "nudPrixHTFournisseur";
            this.nudPrixHTFournisseur.Size = new System.Drawing.Size(120, 22);
            this.nudPrixHTFournisseur.TabIndex = 21;
            this.nudPrixHTFournisseur.ValueChanged += new System.EventHandler(this.nudPrixHTFournisseur_ValueChanged);
            // 
            // dtpDateDernierAchat
            // 
            this.dtpDateDernierAchat.Location = new System.Drawing.Point(21, 185);
            this.dtpDateDernierAchat.Name = "dtpDateDernierAchat";
            this.dtpDateDernierAchat.Size = new System.Drawing.Size(168, 22);
            this.dtpDateDernierAchat.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Date dernier achat";
            // 
            // txtNomFournisseur
            // 
            this.txtNomFournisseur.Location = new System.Drawing.Point(18, 109);
            this.txtNomFournisseur.Name = "txtNomFournisseur";
            this.txtNomFournisseur.Size = new System.Drawing.Size(256, 22);
            this.txtNomFournisseur.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Reference";
            // 
            // txtReferenceFournisseur
            // 
            this.txtReferenceFournisseur.Location = new System.Drawing.Point(18, 52);
            this.txtReferenceFournisseur.Name = "txtReferenceFournisseur";
            this.txtReferenceFournisseur.Size = new System.Drawing.Size(256, 22);
            this.txtReferenceFournisseur.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(222, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Liste des fournisseurs :";
            // 
            // lblValeurTotaleTTC
            // 
            this.lblValeurTotaleTTC.AutoSize = true;
            this.lblValeurTotaleTTC.Location = new System.Drawing.Point(13, 390);
            this.lblValeurTotaleTTC.Name = "lblValeurTotaleTTC";
            this.lblValeurTotaleTTC.Size = new System.Drawing.Size(146, 17);
            this.lblValeurTotaleTTC.TabIndex = 18;
            this.lblValeurTotaleTTC.Text = "Valeur Totale (TTC) : ";
            // 
            // lblMargeTTC
            // 
            this.lblMargeTTC.AutoSize = true;
            this.lblMargeTTC.Location = new System.Drawing.Point(12, 438);
            this.lblMargeTTC.Name = "lblMargeTTC";
            this.lblMargeTTC.Size = new System.Drawing.Size(56, 17);
            this.lblMargeTTC.TabIndex = 19;
            this.lblMargeTTC.Text = "Marge :";
            // 
            // frmInfoProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 509);
            this.Controls.Add(this.lblMargeTTC);
            this.Controls.Add(this.lblValeurTotaleTTC);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblValeurTotalHT);
            this.Controls.Add(this.lblMargeHT);
            this.Controls.Add(this.grpProduit);
            this.Controls.Add(this.lstFournisseurs);
            this.Name = "frmInfoProduit";
            this.Text = "frmInfoProduit";
            this.Load += new System.EventHandler(this.frmInfoProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.grpProduit.ResumeLayout(false);
            this.grpProduit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTFournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifierProduit;
        private System.Windows.Forms.ListBox lstFournisseurs;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrixHTProduit;
        private System.Windows.Forms.NumericUpDown nudPrixTTCProduit;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.GroupBox grpProduit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjouterFournisseur;
        private System.Windows.Forms.Button btnModifierFournisseur;
        private System.Windows.Forms.Label lblMargeHT;
        private System.Windows.Forms.Button btnSupprimerFournisseur;
        private System.Windows.Forms.Button btnAnnulerProduit;
        private System.Windows.Forms.DateTimePicker dtpDerniereVente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label lblValeurTotalHT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReferenceFournisseur;
        private System.Windows.Forms.DateTimePicker dtpDateDernierAchat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomFournisseur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudPrixTTCFournisseur;
        private System.Windows.Forms.NumericUpDown nudPrixHTFournisseur;
        private System.Windows.Forms.Button btnSupprimerProduit;
        private System.Windows.Forms.Button btnAnnulerFournisseur;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblValeurTotaleTTC;
        private System.Windows.Forms.Label lblMargeTTC;
    }
}