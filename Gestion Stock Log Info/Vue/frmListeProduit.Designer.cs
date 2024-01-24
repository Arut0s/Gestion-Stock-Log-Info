
namespace Gestion_Stock_Log_Info.Vue
{
    partial class frmListeProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeProduit));
            this.lstProduit = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCommande = new System.Windows.Forms.Button();
            this.btnDecoche = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProduit
            // 
            this.lstProduit.AllowColumnReorder = true;
            this.lstProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProduit.CheckBoxes = true;
            this.lstProduit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader7});
            this.lstProduit.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProduit.FullRowSelect = true;
            this.lstProduit.HideSelection = false;
            this.lstProduit.Location = new System.Drawing.Point(12, 96);
            this.lstProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProduit.MultiSelect = false;
            this.lstProduit.Name = "lstProduit";
            this.lstProduit.Size = new System.Drawing.Size(1159, 361);
            this.lstProduit.TabIndex = 9;
            this.lstProduit.UseCompatibleStateImageBehavior = false;
            this.lstProduit.View = System.Windows.Forms.View.Details;
            this.lstProduit.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Column_Click);
            this.lstProduit.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstProduit_ItemChecked);
            this.lstProduit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstProduit_KeyDown);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nom";
            this.columnHeader6.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Catégorie";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantité";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prix (HT)";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prix (TTC)";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre Fournisseurs";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date Dernière Vente";
            this.columnHeader7.Width = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recherche :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(9, 28);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(193, 22);
            this.txtRecherche.TabIndex = 0;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtre :";
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.DropDownHeight = 9999;
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.IntegralHeight = false;
            this.cmbFiltre.Items.AddRange(new object[] {
            "(aucun)",
            "Accessoire",
            "Batterie",
            "Cable",
            "Composant",
            "Consommable",
            "Consommation interne",
            "Contrats Maintenance et télémaintenance",
            "Déplacement",
            "Entretien véhicule",
            "Location directe",
            "Logiciel",
            "Main d\'oeuvre",
            "Occasion",
            "Ordinateur de bureau, AIO, serveur",
            "Ordinateur portable",
            "Peripherique",
            "Reseau",
            "Sauvegarde Cloud",
            "Tablette"});
            this.cmbFiltre.Location = new System.Drawing.Point(208, 26);
            this.cmbFiltre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(189, 24);
            this.cmbFiltre.Sorted = true;
            this.cmbFiltre.TabIndex = 1;
            this.cmbFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbFiltre_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.AutoSize = true;
            this.btnAjouter.Location = new System.Drawing.Point(488, 17);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 39);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.AutoSize = true;
            this.btnInfo.Location = new System.Drawing.Point(594, 17);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(100, 39);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(700, 17);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 39);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Location = new System.Drawing.Point(403, 18);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 38);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCommande
            // 
            this.btnCommande.Location = new System.Drawing.Point(832, 17);
            this.btnCommande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(100, 39);
            this.btnCommande.TabIndex = 6;
            this.btnCommande.Text = "Commande";
            this.btnCommande.UseVisualStyleBackColor = true;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // btnDecoche
            // 
            this.btnDecoche.Location = new System.Drawing.Point(12, 65);
            this.btnDecoche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecoche.Name = "btnDecoche";
            this.btnDecoche.Size = new System.Drawing.Size(25, 25);
            this.btnDecoche.TabIndex = 8;
            this.btnDecoche.UseVisualStyleBackColor = true;
            this.btnDecoche.Click += new System.EventHandler(this.btnDecoche_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.Location = new System.Drawing.Point(938, 17);
            this.btnRestock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(100, 39);
            this.btnRestock.TabIndex = 7;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tout décocher";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(1071, 17);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 39);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmListeProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(1181, 469);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnDecoche);
            this.Controls.Add(this.btnCommande);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProduit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1199, 516);
            this.Name = "frmListeProduit";
            this.Text = "Gestion Stock Log Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListeProduit_FormClosing);
            this.Load += new System.EventHandler(this.frmListeProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCommande;
        private System.Windows.Forms.Button btnDecoche;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}