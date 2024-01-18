using Gestion_Stock_Log_Info.Modele;
using Gestion_Stock_Log_Info.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stock_Log_Info.Controlleur
{
    class Controle
    {
        private static Controle instance = null;
        private List<Produit> lesProduits = new List<Produit>();
        private string ordre = "";
        private int quantite;
        private DateTime date = DateTime.Today;

        public Controle()
        {
            
        }
        public static Controle getInstance()
        {
            if (instance == null)
            {
                instance = new Controle();
            }
            return instance;
        }

        public int getCommandeQuantite()
        {
            return this.quantite;
        }

        public void setCommandeQuantite(int quantite)
        {
            this.quantite = quantite;
        }

        public DateTime GetCommandeDate()
        {
            return this.date;
        }

        public void setCommandeDate(DateTime date)
        {
            this.date = date;
        }

        public void Ajout(Produit produit)
        {
            if (!DejaDansLaListe(produit.getNom(), lesProduits))
            {
                lesProduits.Add(produit);
            }
            else
            {
                MessageBox.Show("Le produit existe déjà "+lesProduits.Single(p => p.getNom() == produit.getNom())+ " (pour le modifier, ouvrez d'abord ses informations)", "Erreur");
            }
        }

        public bool Modif(Produit produit, Produit newProduit)
        {
            if (!DejaDansLaListe(newProduit.getNom(), lesProduits) || newProduit.getNom() == produit.getNom())
            {
                lesProduits.Remove(lesProduits.Single(p => p.getNom() == produit.getNom()));
                lesProduits.Add(newProduit);
                return true;
            }
            else
            {
                MessageBox.Show("Le produit existe déjà " + lesProduits.Single(p => p.getNom() == produit.getNom()), "Erreur");
                return false;
            }
        }
        public void supprProduit(Produit produit)
        {
            lesProduits.Remove(produit);
        }
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
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné", "erreur");
            }
        }

        public List<Produit> getLesProduits()
        {
            return this.lesProduits;
        }

        public string getOrdre()
        {
            return this.ordre;
        }

        public void setOrdre(string ordre)
        {
            this.ordre = ordre;
        }

        public void AfficheFrm(Produit produit, string ordre)
        {
            setOrdre(ordre);
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
                    foreach(Fournisseur fournisseur in produit.getFournisseurs())
                    {
                        frmInfo.getListBox().Items.Add(fournisseur.ToString());
                    }
                    frmInfo.ShowDialog();
                    break;
                case "commande":
                    frmCommande frmCommande = new frmCommande();
                    frmCommande.ShowDialog(); 
                    break;
                    
            }
           
        }       



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
    }
}
