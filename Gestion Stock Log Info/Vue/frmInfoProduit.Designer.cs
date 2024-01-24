
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoProduit));
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.grpProduit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTFournisseur)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Location = new System.Drawing.Point(5, 258);
            this.btnModifierProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(111, 34);
            this.btnModifierProduit.TabIndex = 6;
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.UseVisualStyleBackColor = true;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // lstFournisseurs
            // 
            this.lstFournisseurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFournisseurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFournisseurs.FormattingEnabled = true;
            this.lstFournisseurs.ItemHeight = 20;
            this.lstFournisseurs.Location = new System.Drawing.Point(256, 346);
            this.lstFournisseurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstFournisseurs.Name = "lstFournisseurs";
            this.lstFournisseurs.Size = new System.Drawing.Size(499, 184);
            this.lstFournisseurs.Sorted = true;
            this.lstFournisseurs.TabIndex = 1;
            this.lstFournisseurs.DoubleClick += new System.EventHandler(this.lstFournisseurs_DoubleClick);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(5, 47);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(345, 22);
            this.txtNom.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom :";
            // 
            // nudPrixHTProduit
            // 
            this.nudPrixHTProduit.DecimalPlaces = 2;
            this.nudPrixHTProduit.Location = new System.Drawing.Point(5, 231);
            this.nudPrixHTProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrixHTProduit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrixHTProduit.Name = "nudPrixHTProduit";
            this.nudPrixHTProduit.Size = new System.Drawing.Size(160, 22);
            this.nudPrixHTProduit.TabIndex = 4;
            this.nudPrixHTProduit.ValueChanged += new System.EventHandler(this.nudPrixHTProduit_ValueChanged);
            // 
            // nudPrixTTCProduit
            // 
            this.nudPrixTTCProduit.DecimalPlaces = 2;
            this.nudPrixTTCProduit.Location = new System.Drawing.Point(192, 231);
            this.nudPrixTTCProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrixTTCProduit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrixTTCProduit.Name = "nudPrixTTCProduit";
            this.nudPrixTTCProduit.Size = new System.Drawing.Size(160, 22);
            this.nudPrixTTCProduit.TabIndex = 5;
            this.nudPrixTTCProduit.ValueChanged += new System.EventHandler(this.nudPrixTTCProduit_ValueChanged);
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(5, 185);
            this.nudQuantite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQuantite.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(347, 22);
            this.nudQuantite.TabIndex = 3;
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
            this.grpProduit.Controls.Add(this.nudPrixHTProduit);
            this.grpProduit.Controls.Add(this.label3);
            this.grpProduit.Controls.Add(this.btnModifierProduit);
            this.grpProduit.Controls.Add(this.nudQuantite);
            this.grpProduit.Controls.Add(this.nudPrixTTCProduit);
            this.grpProduit.Controls.Add(this.txtNom);
            this.grpProduit.Controls.Add(this.label2);
            this.grpProduit.Location = new System.Drawing.Point(16, 17);
            this.grpProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProduit.Name = "grpProduit";
            this.grpProduit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProduit.Size = new System.Drawing.Size(361, 304);
            this.grpProduit.TabIndex = 9;
            this.grpProduit.TabStop = false;
            this.grpProduit.Text = "Produit";
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.Location = new System.Drawing.Point(123, 258);
            this.btnSupprimerProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(112, 34);
            this.btnSupprimerProduit.TabIndex = 7;
            this.btnSupprimerProduit.Text = "Supprimer";
            this.btnSupprimerProduit.UseVisualStyleBackColor = true;
            this.btnSupprimerProduit.Click += new System.EventHandler(this.btnSupprimerProduit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Categorie :";
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
            this.cmbCategorie.Location = new System.Drawing.Point(5, 92);
            this.cmbCategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(345, 24);
            this.cmbCategorie.TabIndex = 1;
            // 
            // dtpDerniereVente
            // 
            this.dtpDerniereVente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDerniereVente.Location = new System.Drawing.Point(5, 139);
            this.dtpDerniereVente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDerniereVente.Name = "dtpDerniereVente";
            this.dtpDerniereVente.Size = new System.Drawing.Size(345, 22);
            this.dtpDerniereVente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date de la dernière vente :";
            // 
            // btnAnnulerProduit
            // 
            this.btnAnnulerProduit.Location = new System.Drawing.Point(241, 258);
            this.btnAnnulerProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnulerProduit.Name = "btnAnnulerProduit";
            this.btnAnnulerProduit.Size = new System.Drawing.Size(111, 34);
            this.btnAnnulerProduit.TabIndex = 8;
            this.btnAnnulerProduit.Text = "Annuler";
            this.btnAnnulerProduit.UseVisualStyleBackColor = true;
            this.btnAnnulerProduit.Click += new System.EventHandler(this.btnAnnulerProduit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantite :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prix (TTC) en € :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prix (HT) en € :";
            // 
            // btnAjouterFournisseur
            // 
            this.btnAjouterFournisseur.Location = new System.Drawing.Point(5, 258);
            this.btnAjouterFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouterFournisseur.Name = "btnAjouterFournisseur";
            this.btnAjouterFournisseur.Size = new System.Drawing.Size(83, 34);
            this.btnAjouterFournisseur.TabIndex = 14;
            this.btnAjouterFournisseur.Text = "Ajouter";
            this.btnAjouterFournisseur.UseVisualStyleBackColor = true;
            this.btnAjouterFournisseur.Click += new System.EventHandler(this.btnAjouterFournisseur_Click);
            // 
            // btnModifierFournisseur
            // 
            this.btnModifierFournisseur.Location = new System.Drawing.Point(93, 258);
            this.btnModifierFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifierFournisseur.Name = "btnModifierFournisseur";
            this.btnModifierFournisseur.Size = new System.Drawing.Size(83, 34);
            this.btnModifierFournisseur.TabIndex = 15;
            this.btnModifierFournisseur.Text = "Modifier";
            this.btnModifierFournisseur.UseVisualStyleBackColor = true;
            this.btnModifierFournisseur.Click += new System.EventHandler(this.btnModifierFournisseur_Click);
            // 
            // lblMargeHT
            // 
            this.lblMargeHT.AutoSize = true;
            this.lblMargeHT.Location = new System.Drawing.Point(5, 102);
            this.lblMargeHT.Name = "lblMargeHT";
            this.lblMargeHT.Size = new System.Drawing.Size(89, 17);
            this.lblMargeHT.TabIndex = 13;
            this.lblMargeHT.Text = "Marge (HT) :";
            // 
            // btnSupprimerFournisseur
            // 
            this.btnSupprimerFournisseur.Location = new System.Drawing.Point(181, 258);
            this.btnSupprimerFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimerFournisseur.Name = "btnSupprimerFournisseur";
            this.btnSupprimerFournisseur.Size = new System.Drawing.Size(83, 34);
            this.btnSupprimerFournisseur.TabIndex = 16;
            this.btnSupprimerFournisseur.Text = "Supprimer";
            this.btnSupprimerFournisseur.UseVisualStyleBackColor = true;
            this.btnSupprimerFournisseur.Click += new System.EventHandler(this.btnSupprimerFournisseur_Click);
            // 
            // lblValeurTotalHT
            // 
            this.lblValeurTotalHT.AutoSize = true;
            this.lblValeurTotalHT.Location = new System.Drawing.Point(5, 47);
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
            this.groupBox1.Location = new System.Drawing.Point(395, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(361, 304);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fournisseur";
            // 
            // btnAnnulerFournisseur
            // 
            this.btnAnnulerFournisseur.Location = new System.Drawing.Point(269, 258);
            this.btnAnnulerFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnulerFournisseur.Name = "btnAnnulerFournisseur";
            this.btnAnnulerFournisseur.Size = new System.Drawing.Size(83, 34);
            this.btnAnnulerFournisseur.TabIndex = 17;
            this.btnAnnulerFournisseur.Text = "Annuler";
            this.btnAnnulerFournisseur.UseVisualStyleBackColor = true;
            this.btnAnnulerFournisseur.Click += new System.EventHandler(this.btnAnnulerFournisseur_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Prix d\'achat (HT) en € :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Prix d\'achat (TTC) en € :";
            // 
            // nudPrixTTCFournisseur
            // 
            this.nudPrixTTCFournisseur.DecimalPlaces = 2;
            this.nudPrixTTCFournisseur.Location = new System.Drawing.Point(5, 231);
            this.nudPrixTTCFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrixTTCFournisseur.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrixTTCFournisseur.Name = "nudPrixTTCFournisseur";
            this.nudPrixTTCFournisseur.Size = new System.Drawing.Size(347, 22);
            this.nudPrixTTCFournisseur.TabIndex = 13;
            this.nudPrixTTCFournisseur.ValueChanged += new System.EventHandler(this.nudPrixTTCFournisseur_ValueChanged);
            // 
            // nudPrixHTFournisseur
            // 
            this.nudPrixHTFournisseur.DecimalPlaces = 2;
            this.nudPrixHTFournisseur.Location = new System.Drawing.Point(5, 182);
            this.nudPrixHTFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrixHTFournisseur.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrixHTFournisseur.Name = "nudPrixHTFournisseur";
            this.nudPrixHTFournisseur.Size = new System.Drawing.Size(347, 22);
            this.nudPrixHTFournisseur.TabIndex = 12;
            this.nudPrixHTFournisseur.ValueChanged += new System.EventHandler(this.nudPrixHTFournisseur_ValueChanged);
            // 
            // dtpDateDernierAchat
            // 
            this.dtpDateDernierAchat.Location = new System.Drawing.Point(5, 137);
            this.dtpDateDernierAchat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateDernierAchat.Name = "dtpDateDernierAchat";
            this.dtpDateDernierAchat.Size = new System.Drawing.Size(345, 22);
            this.dtpDateDernierAchat.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Date du dernier achat :";
            // 
            // txtNomFournisseur
            // 
            this.txtNomFournisseur.Location = new System.Drawing.Point(5, 47);
            this.txtNomFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomFournisseur.Name = "txtNomFournisseur";
            this.txtNomFournisseur.Size = new System.Drawing.Size(345, 22);
            this.txtNomFournisseur.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Reference :";
            // 
            // txtReferenceFournisseur
            // 
            this.txtReferenceFournisseur.Location = new System.Drawing.Point(5, 92);
            this.txtReferenceFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReferenceFournisseur.Name = "txtReferenceFournisseur";
            this.txtReferenceFournisseur.Size = new System.Drawing.Size(345, 22);
            this.txtReferenceFournisseur.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(412, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Liste des fournisseurs (Double-cliquez pour debug l\'affichage ) :";
            // 
            // lblValeurTotaleTTC
            // 
            this.lblValeurTotaleTTC.AutoSize = true;
            this.lblValeurTotaleTTC.Location = new System.Drawing.Point(5, 75);
            this.lblValeurTotaleTTC.Name = "lblValeurTotaleTTC";
            this.lblValeurTotaleTTC.Size = new System.Drawing.Size(146, 17);
            this.lblValeurTotaleTTC.TabIndex = 18;
            this.lblValeurTotaleTTC.Text = "Valeur Totale (TTC) : ";
            // 
            // lblMargeTTC
            // 
            this.lblMargeTTC.AutoSize = true;
            this.lblMargeTTC.Location = new System.Drawing.Point(5, 130);
            this.lblMargeTTC.Name = "lblMargeTTC";
            this.lblMargeTTC.Size = new System.Drawing.Size(97, 17);
            this.lblMargeTTC.TabIndex = 19;
            this.lblMargeTTC.Text = "Marge (TTC) :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMargeTTC);
            this.groupBox2.Controls.Add(this.lblValeurTotaleTTC);
            this.groupBox2.Controls.Add(this.lblValeurTotalHT);
            this.groupBox2.Controls.Add(this.lblMargeHT);
            this.groupBox2.Location = new System.Drawing.Point(16, 327);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(235, 167);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations supplémentaires";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(21, 501);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 34);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Quitter";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmInfoProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(768, 544);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpProduit);
            this.Controls.Add(this.lstFournisseurs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInfoProduit";
            this.Text = "frmInfoProduit";
            this.Load += new System.EventHandler(this.frmInfoProduit_Load);
            this.ResizeEnd += new System.EventHandler(this.frmInfoProduit_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.grpProduit.ResumeLayout(false);
            this.grpProduit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixTTCFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixHTFournisseur)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
    }
}