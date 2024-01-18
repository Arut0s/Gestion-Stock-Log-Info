using Gestion_Stock_Log_Info.Controlleur;
using Gestion_Stock_Log_Info.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stock_Log_Info.Vue
{
    public partial class frmInfoProduit : Form
    {
        private Produit produitActuel;
        private Controle controle;
        public frmInfoProduit()
        {
            InitializeComponent();
            controle = Controle.getInstance();
            this.lstFournisseurs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstFournisseurs.MeasureItem += lst_MeasureItem;
            this.lstFournisseurs.DrawItem += lst_DrawItem;


        }

        public void setTxtNom(string reference)
        {
            txtNom.Text = reference;
        }

        public void setNudQuantite(int quantite)
        {
            nudQuantite.Value = quantite;
        }

        public void setNudPrixHTProduit(decimal prix)
        {
            nudPrixHTProduit.Value = prix;
        }

        public void setCmbCategorie(string categorie)
        {
            if (string.IsNullOrEmpty(categorie))
            {
                this.cmbCategorie.SelectedIndex = -1;
            }
            this.cmbCategorie.Text = categorie;
        }

        public void setDateDerniereVente(DateTime date)
        {
            dtpDerniereVente.Value = date;
        }

        public ListBox getListBox()
        {
            return this.lstFournisseurs;
        }

        private void frmInfoProduit_Load(object sender, EventArgs e)
        {
            produitActuel = controle.getLesProduits().Single(p => p.getNom() == txtNom.Text);
            DisableProduit();
            DisableFournisseur();
            lblValeurTotalHT.Text = "Valeur Totale (HT) : " + nudQuantite.Value * nudPrixHTProduit.Value+"€";
            lblValeurTotaleTTC.Text = "Valeur Totale (TTC) : " + nudQuantite.Value * nudPrixTTCProduit.Value + "€";
            ActualiserListe();
        }

        private void DisableProduit()
        {
            btnAnnulerProduit.Enabled = false;
            txtNom.ReadOnly = true;

            nudPrixHTProduit.Controls[0].Enabled = false;
            nudPrixHTProduit.ReadOnly = true;

            nudPrixTTCProduit.Controls[0].Enabled = false;
            nudPrixTTCProduit.ReadOnly = true;

            nudQuantite.Controls[0].Enabled = false;
            nudQuantite.ReadOnly = true;

            cmbCategorie.Enabled = false;

            dtpDerniereVente.Enabled = false;
        }

        private void EnableProduit()
        {
            btnAnnulerProduit.Enabled = true;

            txtNom.ReadOnly = false;

            nudPrixHTProduit.Controls[0].Enabled = true;
            nudPrixHTProduit.ReadOnly = false;

            nudPrixTTCProduit.Controls[0].Enabled = true;
            nudPrixTTCProduit.ReadOnly = false;

            nudQuantite.Controls[0].Enabled = true;
            nudQuantite.ReadOnly = false;

            cmbCategorie.Enabled = true;

            dtpDerniereVente.Enabled = true;
        }

        private void DisableFournisseur()
        {
            btnAnnulerFournisseur.Enabled = false;

            txtReferenceFournisseur.ReadOnly = true;

            txtNomFournisseur.ReadOnly = true;

            nudPrixHTFournisseur.Controls[0].Enabled = false;
            nudPrixHTFournisseur.ReadOnly = true;

            nudPrixTTCFournisseur.Controls[0].Enabled = false;
            nudPrixTTCFournisseur.ReadOnly = true;

            dtpDateDernierAchat.Enabled = false;
        }

        private void EnableFournisseur()
        {
            btnAnnulerFournisseur.Enabled = true;

            txtReferenceFournisseur.ReadOnly = false;

            txtNomFournisseur.ReadOnly = false;

            nudPrixHTFournisseur.Controls[0].Enabled = true;
            nudPrixHTFournisseur.ReadOnly = false;

            nudPrixTTCFournisseur.Controls[0].Enabled = true;
            nudPrixTTCFournisseur.ReadOnly = false;

            dtpDateDernierAchat.Enabled = true;
        }

        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            if (btnModifierProduit.Text == "Modifier")
            {
                EnableProduit();
                btnModifierProduit.Text = "Valider";
            }
            else
            {
                if (txtNom.Text != "" && cmbCategorie.SelectedIndex != -1)
                {
                    DisableProduit();
                    btnModifierProduit.Text = "Modifier";
                    Produit newProduit = new Produit(txtNom.Text, cmbCategorie.Text, produitActuel.getFournisseurs(), Math.Round(nudPrixHTProduit.Value,2), Convert.ToInt32(nudQuantite.Value), dtpDerniereVente.Value);
                    if (controle.Modif(produitActuel, newProduit))
                    {
                        produitActuel = newProduit;
                        lblValeurTotalHT.Text = "Valeur Totale (HT) : " + nudQuantite.Value * nudPrixHTProduit.Value+"€";
                        lblValeurTotaleTTC.Text = "Valeur Totale (TTC) : " + nudQuantite.Value * nudPrixTTCProduit.Value + "€";
                        ActualiserListe();
                    }
                    else
                    {
                        txtNom.Text = produitActuel.getNom();
                        dtpDerniereVente.Value = produitActuel.getDateDerniereVente();
                        cmbCategorie.Text = produitActuel.getCategorie();
                        nudPrixHTProduit.Value = Convert.ToDecimal(produitActuel.getPrixVente());
                        nudQuantite.Value = Convert.ToDecimal(produitActuel.getQuantite());
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez renseigner tout les champs");
                }
            }
        }
        
        private void btnAnnulerProduit_Click(object sender, EventArgs e)
        {
            DisableProduit();
            btnModifierProduit.Text = "Modifier";
            txtNom.Text = produitActuel.getNom();
            nudPrixHTProduit.Value = Convert.ToDecimal(produitActuel.getPrixVente());
            nudPrixTTCProduit.Value = produitActuel.getPrixVente() * (decimal)1.2;
            nudQuantite.Value = Convert.ToDecimal(produitActuel.getQuantite());
            dtpDerniereVente.Value = produitActuel.getDateDerniereVente();
        }

        #region Fournisseur
        private void btnAjouterFournisseur_Click(object sender, EventArgs e)
        {
            if (btnAjouterFournisseur.Text == "Ajouter")
            {
                EnableFournisseur();
                btnAjouterFournisseur.Text = "Valider";
                btnModifierFournisseur.Enabled = false;
                btnSupprimerFournisseur.Enabled = false;
            }
            else
            {
                if (txtReferenceFournisseur.Text != "" && txtNomFournisseur.Text != "")
                {
                    DisableFournisseur();
                    btnAjouterFournisseur.Text = "Ajouter";
                    Fournisseur fournisseur = new Fournisseur(txtReferenceFournisseur.Text, txtNomFournisseur.Text, Math.Round(nudPrixHTFournisseur.Value,2), dtpDateDernierAchat.Value);
                    produitActuel.getFournisseurs().Add(fournisseur);
                    btnModifierFournisseur.Enabled = true;
                    btnSupprimerFournisseur.Enabled = true;
                    txtReferenceFournisseur.Text = "";
                    txtNomFournisseur.Text = "";
                    nudPrixHTFournisseur.Value = 0;
                    ActualiserListe();
                }
                else
                {
                    MessageBox.Show("Veuillez renseigner tout les champs");
                }

            }
        }

        private void ActualiserListe()
        {
            lstFournisseurs.Items.Clear();
            List<decimal> lesMarges = new List<decimal>();
            foreach (Fournisseur fournisseur in produitActuel.getFournisseurs())
            {
                decimal margeHT = produitActuel.getPrixVente() - fournisseur.getPrixAchat();
                lstFournisseurs.Items.Add(fournisseur.ToString()+" Marge (HT) : "+margeHT+ "Marge (TTC) : "+margeHT*(decimal)1.2);
                lesMarges.Add(margeHT);
            }
            if (!lesMarges.Any())
            {
                lblMargeHT.Text = "Marge (HT) : --,--€";
                lblMargeTTC.Text = "Marge (TTC) : --,--€";
            }
            else
            {
                if(lesMarges.Max() == lesMarges.Min())
                {
                    lblMargeHT.Text = "Marge (HT) : "+lesMarges.Max()+"€";
                    lblMargeTTC.Text = "Marge (TTC) : "+lesMarges.Max()*(decimal)1.2+"€";
                }
                else
                {
                    lblMargeHT.Text = "Marge (HT) : " + lesMarges.Min()+"~"+lesMarges.Max() + "€";
                    lblMargeTTC.Text = "Marge (TTC) : " + lesMarges.Min()*(decimal)1.2 + "~" + lesMarges.Max()*(decimal)1.2 + "€";
                }
            }
        }

        private void btnAnnulerFournisseur_Click(object sender, EventArgs e)
        {
            if (btnAjouterFournisseur.Text == "Valider")
            {
                DisableFournisseur();
                btnAjouterFournisseur.Text = "Ajouter";
                txtReferenceFournisseur.Text = "";
                txtNomFournisseur.Text = "";
                nudPrixHTFournisseur.Value = 0;
            }
            if (btnModifierFournisseur.Text == "Valider")
            {
                DisableFournisseur();
                btnModifierFournisseur.Text = "Modifier";
                btnAjouterFournisseur.Enabled = true;
                btnSupprimerFournisseur.Enabled = true;
                txtReferenceFournisseur.Text = "";
                txtNomFournisseur.Text = "";
                nudPrixHTFournisseur.Value = 0;
                ActualiserListe();
            }
        }

        private void btnModifierFournisseur_Click(object sender, EventArgs e)
        {
            if (lstFournisseurs.SelectedIndex != -1)
            {
                Fournisseur fournisseur = produitActuel.getFournisseurs().Single(p => lstFournisseurs.SelectedItem.ToString().Contains(p.ToString()));
                if (btnModifierFournisseur.Text == "Valider")
                {
                    if (txtReferenceFournisseur.Text != "" && txtNomFournisseur.Text != "")
                    {
                        Fournisseur newfournisseur = new Fournisseur(txtReferenceFournisseur.Text, txtNomFournisseur.Text, Math.Round(nudPrixHTFournisseur.Value,2), dtpDateDernierAchat.Value);
                        if (!controle.DejaDansLaListe(newfournisseur.getReference(), produitActuel.getFournisseurs()) || newfournisseur.getReference() == fournisseur.getReference())
                            {
                            DisableFournisseur();
                            produitActuel.getFournisseurs().Remove(fournisseur);
                            produitActuel.getFournisseurs().Add(newfournisseur);
                            btnModifierFournisseur.Text = "Modifier";
                            btnAjouterFournisseur.Enabled = true;
                            btnSupprimerFournisseur.Enabled = true;
                            txtReferenceFournisseur.Text = "";
                            txtNomFournisseur.Text = "";
                            nudPrixHTFournisseur.Value = 0;
                            ActualiserListe();
                        }
                        else
                        {
                            MessageBox.Show("Le fournisseur existe déjà","Opération impossible");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez renseigner tout les champs");
                    }
                }
                else
                {

                    EnableFournisseur();
                    btnModifierFournisseur.Text = "Valider";
                    btnAjouterFournisseur.Enabled = false;
                    btnSupprimerFournisseur.Enabled = false;
                    txtReferenceFournisseur.Text = fournisseur.getReference();
                    txtNomFournisseur.Text = fournisseur.getNom();
                    nudPrixHTFournisseur.Value = Convert.ToDecimal(fournisseur.getPrixAchat());
                }

            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne dans la liste des fournisseurs", "erreur");
            }
        }

        private void btnSupprimerFournisseur_Click(object sender, EventArgs e)
        {
            if (lstFournisseurs.SelectedIndex != -1)
            {
                Fournisseur fournisseur = produitActuel.getFournisseurs().Single(p => p.ToString() == lstFournisseurs.SelectedItem.ToString());
                if(MessageBox.Show(fournisseur.ToString(), "Confirmer la suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    produitActuel.getFournisseurs().Remove(fournisseur);
                    MessageBox.Show("Fournisseur supprimé avec succès","Succès");
                    ActualiserListe();
                }
            }
        }

        private void btnSupprimerProduit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Êtes vous sur de vouloir supprimer le produit : "+produitActuel.ToString()+" ?", "Confirmer la suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                controle.supprProduit(produitActuel);
                this.Close();
            }
        }

        private void nudPrixHTProduit_ValueChanged(object sender, EventArgs e)
        {
            nudPrixTTCProduit.ValueChanged -= new EventHandler(nudPrixTTCProduit_ValueChanged);
            nudPrixTTCProduit.Value = nudPrixHTProduit.Value * (decimal)1.2;
            nudPrixTTCProduit.ValueChanged += new EventHandler(nudPrixTTCProduit_ValueChanged);
        }

        private void nudPrixTTCProduit_ValueChanged(object sender, EventArgs e)
        {
            nudPrixHTProduit.ValueChanged -= new EventHandler(nudPrixHTProduit_ValueChanged);
            nudPrixHTProduit.Value = nudPrixTTCProduit.Value / (decimal)1.2;
            nudPrixHTProduit.ValueChanged += new EventHandler(nudPrixHTProduit_ValueChanged);
        }

        private void nudPrixTTCFournisseur_ValueChanged(object sender, EventArgs e)
        {
            nudPrixHTFournisseur.ValueChanged -= new EventHandler(nudPrixHTFournisseur_ValueChanged);
            nudPrixHTFournisseur.Value = nudPrixTTCFournisseur.Value / (decimal)1.2;
            nudPrixHTFournisseur.ValueChanged += new EventHandler(nudPrixHTFournisseur_ValueChanged);
        }

        private void nudPrixHTFournisseur_ValueChanged(object sender, EventArgs e)
        {
            nudPrixTTCFournisseur.ValueChanged -= new EventHandler(nudPrixTTCFournisseur_ValueChanged);
            nudPrixTTCFournisseur.Value = nudPrixHTFournisseur.Value * (decimal)1.2;
            nudPrixTTCFournisseur.ValueChanged += new EventHandler(nudPrixTTCFournisseur_ValueChanged);
        }
  



        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
            {
                e.ItemHeight = (int)e.Graphics.MeasureString(lstFournisseurs.Items[e.Index].ToString(), lstFournisseurs.Font, lstFournisseurs.Width).Height;
            }
            private void lst_DrawItem(object sender, DrawItemEventArgs e)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(lstFournisseurs.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
}
    #endregion Fournisseur


}
