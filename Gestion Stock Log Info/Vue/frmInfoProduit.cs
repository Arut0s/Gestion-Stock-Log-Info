﻿using Gestion_Stock_Log_Info.Controlleur;
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
        #region déclarations

        private Produit produitActuel;
        private Controle controle;

        #endregion

        public frmInfoProduit()
        {
            InitializeComponent();
            controle = Controle.getInstance();
            this.lstFournisseurs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstFournisseurs.MeasureItem += lst_MeasureItem;
            this.lstFournisseurs.DrawItem += lst_DrawItem;


        }

        #region produit

        /// <summary>
        /// Evenement permettant de modifier un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            if (btnModifierProduit.Text == "Modifier")
            {
                EnableProduit();
                txtNom.Focus();
                btnModifierProduit.Text = "Valider";
            }
            else
            {
                if (txtNom.Text != "" && cmbCategorie.SelectedIndex != -1)
                {
                    DisableProduit();
                    btnModifierProduit.Text = "Modifier";
                    Produit newProduit = new Produit(txtNom.Text, cmbCategorie.Text, produitActuel.getFournisseurs(), Math.Round(nudPrixHTProduit.Value, 2), Convert.ToInt32(nudQuantite.Value), dtpDerniereVente.Value);
                    if (controle.Modif(produitActuel, newProduit))
                    {
                        produitActuel = newProduit;
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
                    MessageBox.Show("Veuillez renseigner tout les champs", "Opération Impossible");
                }
            }
        }

        /// <summary>
        /// Evenement permettant de supprimer un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerProduit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sur de vouloir supprimer le produit : " + produitActuel.ToString() + " ?", "Confirmer la suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                controle.supprProduit(produitActuel);
                this.Close();
            }
        }

        /// <summary>
        /// Evenement permettant d'annuler la modification d'un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Méthode permettant de désactiver la zone de saisie du produit
        /// </summary>
        private void DisableProduit()
        {
            btnAnnulerProduit.Enabled = false;
            txtNom.Enabled = false;
            nudPrixHTProduit.Enabled = false;
            nudPrixTTCProduit.Enabled = false;
            nudQuantite.Enabled = false;
            cmbCategorie.Enabled = false;
            dtpDerniereVente.Enabled = false;
        }

        /// <summary>
        /// Méthode permettant d'activer la zone de saisie du produit
        /// </summary>
        private void EnableProduit()
        {
            btnAnnulerProduit.Enabled = true;
            txtNom.Enabled = true;
            nudPrixHTProduit.Enabled = true;
            nudPrixTTCProduit.Enabled = true;
            nudQuantite.Enabled = true;
            cmbCategorie.Enabled = true;
            dtpDerniereVente.Enabled = true;
        }

        /// <summary>
        /// Evenement permettant d'actualiser le nudTTC en fonction du nudHT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudPrixHTProduit_ValueChanged(object sender, EventArgs e)
        {
            nudPrixTTCProduit.ValueChanged -= new EventHandler(nudPrixTTCProduit_ValueChanged);
            nudPrixTTCProduit.Value = nudPrixHTProduit.Value * (decimal)1.2;
            nudPrixTTCProduit.ValueChanged += new EventHandler(nudPrixTTCProduit_ValueChanged);
        }

        /// <summary>
        /// Evenement permettant d'actualiser le nudHT en fonction du nudTTC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudPrixTTCProduit_ValueChanged(object sender, EventArgs e)
        {
            nudPrixHTProduit.ValueChanged -= new EventHandler(nudPrixHTProduit_ValueChanged);
            nudPrixHTProduit.Value = nudPrixTTCProduit.Value / (decimal)1.2;
            nudPrixHTProduit.ValueChanged += new EventHandler(nudPrixHTProduit_ValueChanged);
        }
        #endregion

        #region fournisseur

        /// <summary>
        /// Evenement permettant d'ajouter un fournisseur a la liste des fournisseur du produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterFournisseur_Click(object sender, EventArgs e)
        {
            if (btnAjouterFournisseur.Text == "Ajouter")
            {

                EnableFournisseur();
                btnAjouterFournisseur.Text = "Valider";
                btnModifierFournisseur.Enabled = false;
                btnSupprimerFournisseur.Enabled = false;
                txtNomFournisseur.Focus();
            }
            else
            {
                if (txtReferenceFournisseur.Text != "" && txtNomFournisseur.Text != "")
                {
                    Fournisseur fournisseur = new Fournisseur(txtReferenceFournisseur.Text, txtNomFournisseur.Text, Math.Round(nudPrixHTFournisseur.Value, 2), dtpDateDernierAchat.Value);
                    if (controle.DejaDansLaListe(fournisseur.getReference(), produitActuel.getFournisseurs()) || produitActuel.getFournisseurs().Any(f => f.getNom() == fournisseur.getNom()))
                    {
                        MessageBox.Show("Ce founisseur existe déjà", "Opération Impossible");
                    }
                    else
                    {
                        bool ok = true;
                        for (int k = 0; k < controle.getLesProduits().Count; k++)
                        {
                            if (controle.getLesProduits()[k].getFournisseurs().Any(f => f.getReference() == fournisseur.getReference()))
                            {

                                ok = false;
                            }
                        }
                        if (ok)
                        {
                            DisableFournisseur();
                            btnAjouterFournisseur.Text = "Ajouter";
                            produitActuel.getFournisseurs().Add(fournisseur);
                            btnModifierFournisseur.Enabled = true;
                            btnSupprimerFournisseur.Enabled = true;
                            txtReferenceFournisseur.Text = "";
                            txtNomFournisseur.Text = "";
                            nudPrixHTFournisseur.Value = 0;
                            ActualiserListe();
                            controle.Serialisation();
                        }
                        else
                        {
                            MessageBox.Show("Il y a déjà un couple produit/fournisseur ayant cette référence", "Opération Impossible");
                        }
                      
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez renseigner tout les champs", "Opération Impossible");
                }

            }
        }

        /// <summary>
        /// Evenement permettant de modifier un fournisseur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierFournisseur_Click(object sender, EventArgs e)
        {
            if (lstFournisseurs.SelectedIndex != -1)
            {
                Fournisseur fournisseur = produitActuel.getFournisseurs().Single(p => lstFournisseurs.SelectedItem.ToString().Contains(p.ToString()));
                if (btnModifierFournisseur.Text == "Valider")
                {
                    if (txtReferenceFournisseur.Text != "" && txtNomFournisseur.Text != "")
                    {
                        Fournisseur newfournisseur = new Fournisseur(txtReferenceFournisseur.Text, txtNomFournisseur.Text, Math.Round(nudPrixHTFournisseur.Value, 2), dtpDateDernierAchat.Value);
                        bool ok = true;
                        for (int k = 0; k < controle.getLesProduits().Count; k++)
                        {
                            if (controle.getLesProduits()[k].getFournisseurs().Any(f => f.getReference() == newfournisseur.getReference()))
                            {
                                if(!(newfournisseur.getReference() == fournisseur.getReference()))
                                {
                                    ok = false;
                                }   
                            }
                        }
                        if (AllowModifFournisseur(fournisseur, newfournisseur) && ok == true)
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
                            controle.Serialisation();
                        }
                        else
                        {
                            MessageBox.Show("Il y a déjà un couple produit/fournisseur ayant cette référence", "Opération Impossible");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez renseigner tout les champs", "Opération Impossible");
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
                    txtNomFournisseur.Focus();
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne dans la liste des fournisseurs", "Opération Impossible");
            }
        }

        /// <summary>
        /// Evenement permettant de supprimer un fournisseur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerFournisseur_Click(object sender, EventArgs e)
        {
            if (lstFournisseurs.SelectedIndex != -1)
            {
                Fournisseur fournisseur = produitActuel.getFournisseurs().Single(p => lstFournisseurs.SelectedItem.ToString().Contains(p.ToString()));
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer le fournisseur : " + fournisseur.ToString(), "Confirmer la suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    produitActuel.getFournisseurs().Remove(fournisseur);
                    MessageBox.Show("Fournisseur supprimé avec succès", "Succès");
                    ActualiserListe();
                    controle.Serialisation();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne", "Opération Impossible");
            }
        }

        /// <summary>
        /// Evenement permettant d'annuler la modifcation ou l'ajout d'un fournisseur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerFournisseur_Click(object sender, EventArgs e)
        {
            if (btnAjouterFournisseur.Text == "Valider")
            {
                DisableFournisseur();
                btnAjouterFournisseur.Text = "Ajouter";
                btnModifierFournisseur.Enabled = true;
                btnSupprimerFournisseur.Enabled = true;
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

        /// <summary>
        /// Fonction permettant d'empêcher l'ajout ou la modification d'un fournisseur en un fournisseur déjà existant
        /// </summary>
        /// <param name="fournisseur"></param>
        /// <param name="newfournisseur"></param>
        /// <returns></returns>
        private bool AllowModifFournisseur(Fournisseur fournisseur, Fournisseur newfournisseur)
        {
            int k = 0;
            if (!produitActuel.getFournisseurs().Any(f => f.getNom() == newfournisseur.getNom()))
            {
                k++;
            }
            else
            {
                if (fournisseur.getNom() == newfournisseur.getNom())
                {
                    k++;
                }
            }

            if (!produitActuel.getFournisseurs().Any(f => f.getReference() == newfournisseur.getReference()))
            {
                k++;
            }
            else
            {
                if (fournisseur.getReference() == newfournisseur.getReference())
                {
                    k++;
                }
            }

            return k == 2;      
        }

        /// <summary>
        /// Méthode permettant de désactiver la zone de saisie du fournisseur
        /// </summary>
        private void DisableFournisseur()
        {
            btnAnnulerFournisseur.Enabled = false;
            txtReferenceFournisseur.Enabled = false;
            txtNomFournisseur.Enabled = false;
            nudPrixHTFournisseur.Enabled = false;
            nudPrixTTCFournisseur.Enabled = false;
            dtpDateDernierAchat.Enabled = false;
        }

        /// <summary>
        /// Méthode permettant d'activer la zone de saisie du fournisseur
        /// </summary>
        private void EnableFournisseur()
        {
            btnAnnulerFournisseur.Enabled = true;
            txtReferenceFournisseur.Enabled = true;
            txtNomFournisseur.Enabled = true;
            nudPrixHTFournisseur.Enabled = true;
            nudPrixTTCFournisseur.Enabled = true;
            dtpDateDernierAchat.Enabled = true;
        }

        /// Evenement permettant d'actualiser le nudHT en fonction du nudTTC
        private void nudPrixTTCFournisseur_ValueChanged(object sender, EventArgs e)
        {
            nudPrixHTFournisseur.ValueChanged -= new EventHandler(nudPrixHTFournisseur_ValueChanged);
            nudPrixHTFournisseur.Value = nudPrixTTCFournisseur.Value / (decimal)1.2;
            nudPrixHTFournisseur.ValueChanged += new EventHandler(nudPrixHTFournisseur_ValueChanged);
        }

        /// <summary>
        /// Evenement permettant d'actualiser le nudTTC en fonction du nudHT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudPrixHTFournisseur_ValueChanged(object sender, EventArgs e)
        {
            nudPrixTTCFournisseur.ValueChanged -= new EventHandler(nudPrixTTCFournisseur_ValueChanged);
            nudPrixTTCFournisseur.Value = nudPrixHTFournisseur.Value * (decimal)1.2;
            nudPrixTTCFournisseur.ValueChanged += new EventHandler(nudPrixTTCFournisseur_ValueChanged);
        }

        /// <summary>
        /// Evenement permettant d'actualiser la liste avec un double click (la liste s'affiche mal lors du fullscreen)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstFournisseurs_DoubleClick(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        #endregion

        #region autre

        /// <summary>
        /// Methode permettant l'actualisation des informations du produit
        /// </summary>
        private void ActualiserListe()
        {
            lstFournisseurs.Items.Clear();
            List<decimal> lesMarges = new List<decimal>();
            lblValeurTotalHT.Text = "Valeur Totale (HT) : " + (nudQuantite.Value * nudPrixHTProduit.Value).ToString("N2") + "€";
            lblValeurTotaleTTC.Text = "Valeur Totale (TTC) : " + (nudQuantite.Value * nudPrixTTCProduit.Value).ToString("N2") + "€";
            Text = produitActuel.getNom();
            foreach (Fournisseur fournisseur in produitActuel.getFournisseurs())
            {
                decimal margeHT = produitActuel.getPrixVente() - fournisseur.getPrixAchat();
                lstFournisseurs.Items.Add(fournisseur.ToString() + ". Marge (HT) : " + margeHT.ToString("N2") + "€, " + "marge (TTC) : " + (margeHT * (decimal)1.2).ToString("N2") + "€");
                lesMarges.Add(margeHT);
            }
            if (!lesMarges.Any())
            {
                lblMargeHT.Text = "Marge (HT) : --,--€";
                lblMargeTTC.Text = "Marge (TTC) : --,--€";
            }
            else
            {
                if (lesMarges.Max() == lesMarges.Min())
                {
                    lblMargeHT.Text = "Marge (HT) : " + lesMarges.Max().ToString("N2") + "€";
                    lblMargeTTC.Text = "Marge (TTC) : " + (lesMarges.Max() * (decimal)1.2).ToString("N2") + "€";
                }
                else
                {
                    lblMargeHT.Text = "Marge (HT) : " + lesMarges.Min().ToString("N2") + "~" + lesMarges.Max().ToString("N2") + "€";
                    lblMargeTTC.Text = "Marge (TTC) : " + (lesMarges.Min() * (decimal)1.2).ToString("N2") + "~" + (lesMarges.Max() * (decimal)1.2).ToString("N2") + "€";
                }
            }
        }

        /// <summary>
        /// Evenement permettant l'affichage d'un fournisseur sur plusieurs lignes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(lstFournisseurs.Items[e.Index].ToString(), lstFournisseurs.Font, lstFournisseurs.Width).Height;
        }

        /// <summary>
        /// Evenement permettant l'affichage d'un fournisseur sur plusieurs lignes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (produitActuel.getFournisseurs().Any())
                {
                    e.DrawBackground();
                    e.DrawFocusRectangle();
                    e.Graphics.DrawString(lstFournisseurs.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Evenement permettant l'initialisation du formulaire lors de son ouverture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInfoProduit_Load(object sender, EventArgs e)
        {
            produitActuel = controle.getLesProduits().Single(p => p.getNom() == txtNom.Text);
            DisableProduit();
            DisableFournisseur();

            ActualiserListe();
        }

        /// <summary>
        /// Evenement permettant de rafraichir la liste lors du changemenet de taille de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInfoProduit_ResizeEnd(object sender, EventArgs e)
        {
            if (produitActuel != null)
            {
                ActualiserListe();
            }
        }

        /// <summary>
        /// Evenement permettant de fermer le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region getters et setters

        /// <summary>
        /// Getter sur la listbox des fournisseurs
        /// </summary>
        /// <returns></returns>
        public ListBox getListBox()
        {
            return this.lstFournisseurs;
        }

        /// <summary>
        /// Setter sur le texte de la textbox du nom
        /// </summary>
        /// <param name="reference"></param>
        public void setTxtNom(string reference)
        {
            txtNom.Text = reference;
        }

        /// <summary>
        /// Setter sur la valeur du nud de la quantite
        /// </summary>
        /// <param name="quantite"></param>
        public void setNudQuantite(int quantite)
        {
            nudQuantite.Value = quantite;
        }

        /// <summary>
        /// Setter sur la value du nud du prix de vente du produit
        /// </summary>
        /// <param name="prix"></param>
        public void setNudPrixHTProduit(decimal prix)
        {
            nudPrixHTProduit.Value = prix;
        }

        /// <summary>
        /// Setter sur le combobox categorie
        /// </summary>
        /// <param name="categorie"></param>
        public void setCmbCategorie(string categorie)
        {
            if (string.IsNullOrEmpty(categorie))
            {
                this.cmbCategorie.SelectedIndex = -1;
            }
            this.cmbCategorie.Text = categorie;
        }

        /// <summary>
        /// Setter sur le datetimepicker
        /// </summary>
        /// <param name="date"></param>
        public void setDateDerniereVente(DateTime date)
        {
            dtpDerniereVente.Value = date;
        }


        #endregion
    }
}
