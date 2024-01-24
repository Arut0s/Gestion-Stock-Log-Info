
namespace Gestion_Stock_Log_Info.Vue
{
    partial class frmCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommande));
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFournisseur = new System.Windows.Forms.ComboBox();
            this.lblFournisseur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantite :";
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(12, 30);
            this.nudQuantite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQuantite.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(245, 22);
            this.nudQuantite.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 149);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(117, 39);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(139, 149);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(117, 39);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 74);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(245, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date derniere vente :";
            // 
            // cmbFournisseur
            // 
            this.cmbFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFournisseur.FormattingEnabled = true;
            this.cmbFournisseur.Location = new System.Drawing.Point(12, 119);
            this.cmbFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFournisseur.Name = "cmbFournisseur";
            this.cmbFournisseur.Size = new System.Drawing.Size(245, 24);
            this.cmbFournisseur.TabIndex = 2;
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Location = new System.Drawing.Point(12, 98);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(83, 17);
            this.lblFournisseur.TabIndex = 7;
            this.lblFournisseur.Text = "Fournisseur";
            // 
            // frmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(264, 197);
            this.Controls.Add(this.lblFournisseur);
            this.Controls.Add(this.cmbFournisseur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmCommande";
            this.Text = "frmCommande";
            this.Load += new System.EventHandler(this.frmCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFournisseur;
        private System.Windows.Forms.Label lblFournisseur;
    }
}