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
        }

        public void setTxtNom(string reference)
        {
            txtNom.Text = reference;
        }

        public void setNudQuantite(int quantite)
        {
            nudQuantite.Value = quantite;
        }

        public void setNudPrixHTProduit(double prix)
        {
            nudPrixHTProduit.Value = Convert.ToDecimal(prix);
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
                    Produit newProduit = new Produit(txtNom.Text, cmbCategorie.Text, produitActuel.getFournisseurs(), Convert.ToDouble(nudPrixHTProduit.Value), Convert.ToInt32(nudQuantite.Value), dtpDerniereVente.Value);
                    if (controle.Modif(produitActuel, newProduit))
                    {
                        produitActuel = newProduit;
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
            nudPrixTTCProduit.Value = Convert.ToDecimal(produitActuel.getPrixVente() * 1.2);
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
                    Fournisseur fournisseur = new Fournisseur(txtReferenceFournisseur.Text, txtNomFournisseur.Text, Convert.ToDouble(nudPrixHTFournisseur.Value), dtpDateDernierAchat.Value);
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
            foreach (Fournisseur fournisseur in produitActuel.getFournisseurs())
            {
                lstFournisseurs.Items.Add(fournisseur.ToString());
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
                Fournisseur fournisseur = produitActuel.getFournisseurs().Single(p => p.ToString() == lstFournisseurs.SelectedItem.ToString());
                if (btnModifierFournisseur.Text == "Valider")
                {
                    if (txtReferenceFournisseur.Text != "" && txtNomFournisseur.Text != "")
                    {
                        Fournisseur newfournisseur = new Fournisseur(txtReferenceFournisseur.Text, txtNomFournisseur.Text, Convert.ToDouble(nudPrixHTFournisseur.Value), dtpDateDernierAchat.Value);
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

    }
    #endregion Fournisseur
}
