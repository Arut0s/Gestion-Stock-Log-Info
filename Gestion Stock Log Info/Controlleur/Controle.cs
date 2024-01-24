using Gestion_Stock_Log_Info.Modele;
using Gestion_Stock_Log_Info.Vue;
using GestionStockLogInfo.Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stock_Log_Info.Controlleur
{
    /// <summary>
    /// Classe controlleur permet aux forms de communiquer entre-eux
    /// </summary>
    class Controle
    {
        #region déclarations

        private static Controle instance = null;
        private List<Produit> lesProduits = new List<Produit>();
        private string ordre = "";
        private int quantite;
        private Fournisseur fournisseurRestock;
        private DateTime date = DateTime.Today;
        private string fichier = "ListeProduit.txt";

        #endregion

        #region fonctions et méthodes

        /// <summary>
        /// Permet d'obtenir l'instance du controlleur
        /// </summary>
        /// <returns>Controle instance</returns>
        public static Controle getInstance()
        {
            if (instance == null)
            {
                instance = new Controle();
            }
            return instance;
        }

        /// <summary>
        /// Permet d'ajouter un produit dans la liste des produits
        /// </summary>
        /// <param name="produit"></param>
        public void Ajout(Produit produit)
        {
            if (!DejaDansLaListe(produit.getNom(), lesProduits))
            {
                lesProduits.Add(produit);
                Serialise.Sauve(fichier, lesProduits);
            }
            else
            {
                MessageBox.Show("Le produit existe déjà "+lesProduits.Single(p => p.getNom() == produit.getNom())+ " (pour le modifier, ouvrez d'abord ses informations)", "Opération Impossible");
            }
;
        }

        /// <summary>
        /// Permet de modifier un produit de la liste des produit
        /// </summary>
        /// <param name="produit"></param>
        /// <param name="newProduit"></param>
        /// <returns></returns>
        public bool Modif(Produit produit, Produit newProduit)
        {
            if (!DejaDansLaListe(newProduit.getNom(), lesProduits) || newProduit.getNom() == produit.getNom())
            {
                lesProduits.Remove(lesProduits.Single(p => p.getNom() == produit.getNom()));
                lesProduits.Add(newProduit);
                Serialise.Sauve(fichier, lesProduits);
                return true;
            }
            else
            {
                MessageBox.Show("Le produit existe déjà " + lesProduits.Single(p => p.getNom() == produit.getNom()), "Opération Impossible");
                return false;
            }
        }

        /// <summary>
        /// Permet de supprimer un produit de la liste des produits
        /// </summary>
        /// <param name="produit"></param>
        public void supprProduit(Produit produit)
        {
            lesProduits.Remove(produit);
            Serialise.Sauve(fichier, lesProduits);
        }

        /// <summary>
        /// Permet de supprimer un ou plusieurs produit(s) de la liste des produits
        /// </summary>
        /// <param name="supprList"></param>
        public void supprProduit(List<Produit> supprList)
        {
            if (supprList.Any())
            {
                List<String> info = new List<string>();
                foreach (Produit produit in supprList)
                {
                    info.Add(produit.ToString());
                    info.Sort();
                }
                if (MessageBox.Show(String.Join("\r", info), "Confirmer la suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    for (int k = 0; k < supprList.Count; k++)
                    {
                        lesProduits.Remove(supprList[k]);
                        Serialise.Sauve(fichier, lesProduits);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné", "Opération Impossible");
            }
        }

        /// <summary>
        /// Permet de savoir si un produit existe déjà dans la liste des produit grâce a son nom
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="liste"></param>
        /// <returns></returns>
        public bool DejaDansLaListe(string nom, List<Produit> liste)
        {
            foreach (Produit p in liste)
            {
                if (p.getNom() == nom)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Permet de savoir si un fournisseur existe déjà dans la liste des fournisseurs grâce a sa référence
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="liste"></param>
        /// <returns></returns>
        public bool DejaDansLaListe(string reference, List<Fournisseur> liste)
        {
            foreach (Fournisseur f in liste)
            {
                if (f.getReference() == reference)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Permet d'afficher les différents formulaire en fonction de l'ordre donné
        /// </summary>
        /// <param name="produit"></param>
        /// <param name="ordre"></param>
        public void AfficheFrm(Produit produit, string ordre)
        {
            string temp = getOrdre();
            setOrdre(ordre);
            if(temp != getOrdre())
            {
                setCommandeDate(DateTime.Today); 
            }
            switch (ordre)
            {
                case "modifier":
                    break;
                case "ajouter":
                    frmAjoutProduit frmAjout = new frmAjoutProduit();
                    frmAjout.Text = "Ajout";
                    frmAjout.ShowDialog();
                    break;
                case "info":
                    frmInfoProduit frmInfo = new frmInfoProduit();
                    frmInfo.setTxtNom(produit.getNom());
                    frmInfo.setNudQuantite(produit.getQuantite());
                    frmInfo.setCmbCategorie(produit.getCategorie());
                    frmInfo.setNudPrixHTProduit(produit.getPrixVente());
                    frmInfo.setDateDerniereVente(produit.getDateDerniereVente());
                    frmInfo.Text = produit.getNom();
                    foreach (Fournisseur fournisseur in produit.getFournisseurs())
                    {
                        frmInfo.getListBox().Items.Add(fournisseur.ToString());
                    }
                    frmInfo.ShowDialog();
                    break;
                case "commande":
                    frmCommande frmCommande = new frmCommande();
                    frmCommande.Text = "Commande";
                    frmCommande.ShowDialog();
                    break;
                case "restock":
                    frmCommande frmRestock = new frmCommande();
                    frmRestock.Text = "Restock";
                    frmRestock.setLesFournisseurs(produit.getFournisseurs());
                    frmRestock.ShowDialog();
                    break;
            }

        }

        /// <summary>
        /// Permet de sérialiser la liste des produits
        /// </summary>
        public void Serialisation()
        {
            Serialise.Sauve(fichier, this.lesProduits);
        }

        #endregion

        #region setters et getters

        /// <summary>
        /// Getter sur la liste des produits
        /// </summary>
        /// <returns>List lesProduits</returns>
        public List<Produit> getLesProduits()
        {
            return this.lesProduits;
        }

        /// <summary>
        /// Getter sur l'ordre en cours (Ajouter, Supprimer...)
        /// </summary>
        /// <returns></returns>
        public string getOrdre()
        {
            return this.ordre;
        }

        /// <summary>
        /// Getter sur la quantite d'un produit sélectionné lors d'une commande ou d'un restock
        /// </summary>
        /// <returns></returns>
        public int getCommandeQuantite()
        {
            return this.quantite;
        }

        /// <summary>
        /// Getter sur la date sélectionnée lors d'une commande ou d'un restock qui deviendra la date de derniere vente ou de dernier achat
        /// </summary>
        /// <returns></returns>
        public DateTime GetCommandeDate()
        {
            return this.date;
        }

        /// <summary>
        /// Getter sur le fournisseur sélectionné lors d'un restock
        /// </summary>
        /// <returns></returns>
        public Fournisseur getFournisseurRestock()
        {
            return this.fournisseurRestock;
        }

        /// <summary>
        /// Setter sur la liste des produits
        /// </summary>
        /// <param name="lesProduits"></param>
        public void setLesProduits(List<Produit> lesProduits)
        {
            this.lesProduits = lesProduits;
        }

        /// <summary>
        /// Setter sur l'ordre en cours (Ajouter, Supprimer...)
        /// </summary>
        /// <param name="ordre"></param>
        public void setOrdre(string ordre)
        {
            this.ordre = ordre;
        }

        /// <summary>
        /// Setter sur la quantite d'un produit lors d'une commande ou d'un restock
        /// </summary>
        /// <param name="quantite"></param>
        public void setCommandeQuantite(int quantite)
        {
            this.quantite = quantite;
        }

        /// <summary>
        /// Setter sur la date sélectionnée lors d'une commande ou d'un restock qui deviendra la date de derniere vente ou de dernier achat
        /// </summary>
        /// <param name="date"></param>
        public void setCommandeDate(DateTime date)
        {
            this.date = date;
        }

        /// <summary>
        /// Setter sur le fournisseur sélectionné lors d'un restock
        /// </summary>
        /// <param name="fournisseur"></param>
        public void setFournisseurRestock(Fournisseur fournisseur)
        {
            this.fournisseurRestock = fournisseur;
        }

        #endregion
    }
}
