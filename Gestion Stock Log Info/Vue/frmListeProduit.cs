using Gestion_Stock_Log_Info.Controlleur;
using Gestion_Stock_Log_Info.Modele;
using GestionStockLogInfo.outils;
using GestionStockLogInfo.Outils;
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
    public partial class frmListeProduit : Form
    {

        #region déclarations

        private Controle controle;
        private List<Produit> Commande = new List<Produit>();
        private List<int> lesQuantites = new List<int>();
        private List<DateTime> lesDates = new List<DateTime>();
        private List<Fournisseur> lesFournisseursRestock = new List<Fournisseur>();
        private string fichier = "ListeProduit.txt";

        #endregion

        public frmListeProduit()
        {
            InitializeComponent();
            Init();
        }

        #region méthodes et fonctions
        
        /// <summary>
        /// Méthode permettant l'initialisation du formulaire
        /// </summary>
        private void Init()
        {
            controle = Controle.getInstance();
            this.lstProduit.ListViewItemSorter = new ListViewItemComparer();
            cmbFiltre.SelectedIndex = 0;
        }

        /// <summary>
        /// Méthode permettant d'actualiser la liste des produits
        /// </summary>
        private void ActualiserListe()
        {
            lstProduit.Items.Clear();
            List<Produit> lesProduits = controle.getLesProduits();
            for (int k = 0; k < lesProduits.Count; k++)
            {
                if (FiltreRecherche(k))
                {
                    ListViewItem item = new ListViewItem(lesProduits[k].getNom(), 0);
                    item.SubItems.Add(lesProduits[k].getCategorie());
                    if (lesProduits[k].getQuantite() == 0)
                    {
                        item.ForeColor = Color.Red;
                        item.SubItems.Add("Out of stock");
                    }
                    else
                    {
                        item.SubItems.Add(lesProduits[k].getQuantite().ToString());
                    }
                    item.SubItems.Add(lesProduits[k].getPrixVente().ToString("N2") + "€");
                    item.SubItems.Add(Math.Round((lesProduits[k].getPrixVente() * (decimal)1.2), 2).ToString("N2") + "€");
                    item.SubItems.Add(lesProduits[k].getDateDerniereVente().ToShortDateString());
                    if (lesProduits[k].isChecked())
                    {
                        item.Checked = true;
                    }
                    lstProduit.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Fonction permettant de filtrer/rechercher dans la liste produit
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        private bool FiltreRecherche(int k)
        {

            List<Produit> lesProduits = controle.getLesProduits();
            List<Fournisseur> lesFournisseurs = lesProduits[k].getFournisseurs();
            if (lesProduits[k].getNom().ToLower().Contains(txtRecherche.Text.ToLower()))
            {
                if (cmbFiltre.SelectedItem.ToString().Equals(lesProduits[k].getCategorie()))
                {
                    return true;
                }
                else
                {
                    if (cmbFiltre.SelectedItem.ToString().Equals("(aucun)"))
                    {
                        return true;
                    }
                }
            }
            foreach (Fournisseur fournisseur in lesFournisseurs)
            {
                if (fournisseur.getReference().ToLower().Contains(txtRecherche.Text.ToLower()))
                {
                    if (cmbFiltre.SelectedItem.ToString().Equals(lesProduits[k].getCategorie()))
                    {
                        return true;
                    }
                    else
                    {
                        if (cmbFiltre.SelectedItem.ToString().Equals("(aucun)"))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Fonction permettant de changer l'ordre de tri des colonnes lors du click
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private SortOrder Swap(SortOrder a)
        {
            if (a == SortOrder.Ascending)
                return SortOrder.Descending;
            else if (a == SortOrder.Descending)
                return SortOrder.Ascending;
            else return SortOrder.Ascending;
        }

        #endregion

        #region événements boutons

        /// <summary>
        /// Evenement permettant d'ajouter un produit a la liste des produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            controle.AfficheFrm(null, "ajouter");
            ActualiserListe();
        }

        /// <summary>
        /// Evenement permettant d'obtenir les informations du produit sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (lstProduit.SelectedIndices.Count == 1)
            {
                Produit produit = controle.getLesProduits().Single(p => p.getNom() == lstProduit.SelectedItems[0].SubItems[0].Text);
                controle.AfficheFrm(produit, "info");
            }
            else if (lstProduit.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne", "erreur");
            }
            else
            {
                MessageBox.Show("Veuillez ne sélectionner qu'une seule ligne", "erreur");
            }
            ActualiserListe();
        }

        /// <summary>
        /// Evenement permettant de supprimer un ou plusieurs produits de la liste des produits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            List<Produit> supprList = new List<Produit>();
            for (int k = 0; k < lstProduit.SelectedItems.Count; k++)
            {
                Produit produit = controle.getLesProduits().Single(p => p.getNom() == lstProduit.SelectedItems[k].SubItems[0].Text);
                supprList.Add(produit);
            }
            for (int k = 0; k < lstProduit.Items.Count; k++)
            {
                if (lstProduit.Items[k].Checked)
                {
                    supprList.Add(controle.getLesProduits().Single(p => p.getNom() == lstProduit.Items[k].SubItems[0].Text));
                }
            }
            controle.supprProduit(supprList.Distinct().ToList());
            ActualiserListe();
        }

        /// <summary>
        /// Evenement permettant de déclencher le mode "commande" puis de valider la sélection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommande_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Enabled == false)
            {
                btnDecoche_Click(null, null);
                btnAjouter.Enabled = true;
                btnInfo.Enabled = true;
                btnSupprimer.Enabled = true;
                btnRestock.Enabled = true;
                btnCommande.Text = "Commande";
                lstProduit.ItemChecked -= new ItemCheckedEventHandler(Item_Checked_Commande);
                if (Commande.Any())
                {
                    List<string> info = new List<string>();
                    decimal totalHT = 0;
                    for (int k = 0; k < Commande.Count; k++)
                    {
                        info.Add(Commande[k].getNom() + " x " + lesQuantites[k].ToString() + " = " + (Commande[k].getPrixVente() * lesQuantites[k]).ToString("N2") + "€ (HT) et " + Math.Round(Commande[k].getPrixVente() * (decimal)1.2 * lesQuantites[k], 2).ToString("N2") + "€ (TTC)");
                        totalHT += Commande[k].getPrixVente() * lesQuantites[k];
                    }
                    if (MessageBox.Show(string.Join("\r", info) + "\r" + "Total : " + totalHT.ToString("N2") + "€ (HT) et " + Math.Round(totalHT * (decimal)1.2, 2).ToString("N2") + "€ (TTC)", "Valider la commande", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        for (int k = 0; k < Commande.Count; k++)
                        {
                            Produit produit = controle.getLesProduits().Single(p => p.getNom() == Commande[k].getNom());
                            produit.setQuantite(produit.getQuantite() - lesQuantites[k]);
                            produit.setDateDerniereVente(lesDates[k]);
                        }
                    }
                    ActualiserListe();
                }

            }
            else
            {
                Commande.Clear();
                lesQuantites.Clear();
                lesDates.Clear();
                controle.setCommandeDate(DateTime.Today);
                btnCommande.Text = "Valider";
                btnAjouter.Enabled = false;
                btnInfo.Enabled = false;
                btnRestock.Enabled = false;
                btnSupprimer.Enabled = false;
                btnDecoche_Click(null, null);
                lstProduit.ItemChecked += new ItemCheckedEventHandler(Item_Checked_Commande);
            }
        }

        /// <summary>
        /// Evenement permettant de déclencher le mode "restock" puis de valider la sélection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Enabled == false)
            {
                btnDecoche_Click(null, null);
                btnAjouter.Enabled = true;
                btnInfo.Enabled = true;
                btnSupprimer.Enabled = true;
                btnCommande.Enabled = true;
                btnRestock.Text = "Restock";
                lstProduit.ItemChecked -= new ItemCheckedEventHandler(Item_Checked_Restock);
                if (Commande.Any())
                {
                    List<string> info = new List<string>();
                    decimal totalHT = 0;
                    for (int k = 0; k < Commande.Count; k++)
                    {
                        info.Add(Commande[k].getNom() + " x " + lesQuantites[k].ToString() + " = " + (lesFournisseursRestock[k].getPrixAchat() * lesQuantites[k]).ToString("N2") + "€ (HT) et " + Math.Round(lesFournisseursRestock[k].getPrixAchat() * (decimal)1.2 * lesQuantites[k], 2).ToString("N2") + "€ (TTC)");
                        totalHT += lesFournisseursRestock[k].getPrixAchat() * lesQuantites[k];
                    }
                    if (MessageBox.Show(string.Join("\r", info) + "\r" + "Total : " + totalHT.ToString("N2") + "€ (HT) et " + Math.Round(totalHT * (decimal)1.2, 2).ToString("N2") + "€ (TTC)", "Valider la commande", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        for (int k = 0; k < Commande.Count; k++)
                        {
                            Produit produit = controle.getLesProduits().Single(p => p.getNom() == Commande[k].getNom());
                            produit.setQuantite(produit.getQuantite() + lesQuantites[k]);
                            produit.getFournisseurs().Single(f => f.getReference() == lesFournisseursRestock[k].getReference()).setDateDernierAchat(controle.GetCommandeDate());
                        }
                    }
                    ActualiserListe();
                }

            }
            else
            {
                Commande.Clear();
                lesQuantites.Clear();
                lesFournisseursRestock.Clear();
                lesDates.Clear();
                controle.setCommandeDate(DateTime.Today);
                btnRestock.Text = "Valider";
                btnAjouter.Enabled = false;
                btnInfo.Enabled = false;
                btnCommande.Enabled = false;
                btnSupprimer.Enabled = false;
                btnDecoche_Click(null, null);
                lstProduit.ItemChecked += new ItemCheckedEventHandler(Item_Checked_Restock);
            }
        }

        /// <summary>
        /// Evenement permettant de reset les filtres de recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            cmbFiltre.SelectedItem = "(aucun)";
        }

        /// <summary>
        /// Evenement permettant de décocher tout les produits coché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecoche_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < lstProduit.Items.Count; k++)
            {
                controle.getLesProduits()[k].setChecked(false);
            }
            ActualiserListe();
        }

        /// <summary>
        /// Evenement de test permettant de rapidement ajouter des produits (a supprimer)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            List<Fournisseur> lesFournisseurs = new List<Fournisseur>();
            lesFournisseurs.Add(new Fournisseur("NV-2738", "Nvidia", 25, DateTime.Today));
            lesFournisseurs.Add(new Fournisseur("ZV-2738", "Intel", 30, DateTime.Today));
            Produit produit = new Produit("RTX 4080", "Composant", lesFournisseurs, 40, 4, DateTime.Today);
            Produit produit1 = new Produit("Intel I9", "Cable", new List<Fournisseur>(), 65, 2, DateTime.Today);
            controle.Ajout(produit);
            controle.Ajout(produit1);
            ActualiserListe();
        }

        #endregion

        #region autres événements

        /// <summary>
        /// Evenement permettant de récupérer la liste des produits par sérialisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmListeProduit_Load(object sender, EventArgs e)
        {
            List<Produit> recup = new List<Produit>();
            recup = (List<Produit>)Serialise.Recup(fichier);
            if (recup != null)
            {
                controle.setLesProduits(recup);
            }
            ActualiserListe();
        }

        /// <summary>
        /// Evenement permettant de trier les colonnes du tableau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Column_Click(object sender, ColumnClickEventArgs e)
        {
            //tri de la liste grace aux outils du listviewver :
            ListViewItemComparer comparer = (ListViewItemComparer)lstProduit.ListViewItemSorter;

            if (e.Column == comparer.Column)
            {
                comparer.Order = Swap(comparer.Order);
            }
            else
            {
                comparer.Order = SortOrder.Ascending;
            }
            comparer.Column = e.Column;
            lstProduit.Sort();
        }

        /// <summary>
        /// Evenement permettant l'actualisation de la liste lors d'un changement de filtrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        /// <summary>
        /// Evenement permettant l'actualisation de la liste lors d'un changement de recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text != "")
            {
                btnClear.Enabled = true;
            }
            else
            {
                btnClear.Enabled = false;
            }
            ActualiserListe();
        }

        /// <summary>
        /// Evenement permettant d'enregistrer l'état (coché ou décoché) d'un produit lors de la modification de celui ci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstProduit_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked == true)
            {
                controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text).setChecked(true);
            }
            else
            {
                controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text).setChecked(false);
            }
        }

        private void lstProduit_DoubleClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evenement permettant d'enregistrer l'état (coché ou décoché) d'un produit lors de la modification de celui ci en mode commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Item_Checked_Commande(object sender, ItemCheckedEventArgs e)
        {
            if (!e.Item.Focused)
            {
                return;
            }
            e.Item.Focused = true;
            if (e.Item.Checked == true && !controle.DejaDansLaListe(e.Item.SubItems[0].Text, Commande))
            {
                if (e.Item.SubItems[2].Text == "Out of stock")
                {
                    MessageBox.Show("Ce produit est en rupture de stock");
                    e.Item.Checked = false;
                    controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text).setChecked(false);
                    ActualiserListe();
                }
                else
                {
                    controle.AfficheFrm(null, "commande");
                    int limite = int.Parse(e.Item.SubItems[2].Text);
                    if (controle.getCommandeQuantite() == 0)
                    {
                        e.Item.Checked = false;
                        controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text).setChecked(false);
                    }
                    else if (controle.getCommandeQuantite() > limite)
                    {
                        MessageBox.Show("Il n'y a pas assez de quantite de ce produit");
                        e.Item.Checked = false;
                        controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text).setChecked(false);
                    }
                    else if (controle.getCommandeQuantite() <= limite)
                    {
                        Commande.Add(controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text));
                        lesQuantites.Add(controle.getCommandeQuantite());
                        lesDates.Add(controle.GetCommandeDate());
                        controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text).setChecked(true);
                    }
                }
            }
            else if (e.Item.Checked == false)
            {
                if (controle.DejaDansLaListe(e.Item.SubItems[0].Text, Commande))
                {
                    lesQuantites.RemoveAt(Commande.IndexOf(controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text)));
                    lesDates.RemoveAt(Commande.IndexOf(controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text)));
                    Commande.Remove(controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text));
                    controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text).setChecked(false);
                    ActualiserListe();
                }
            }
        }

        /// <summary>
        /// Evenement permettant d'enregistrer l'état (coché ou décoché) d'un produit lors de la modification de celui ci en mode restock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Item_Checked_Restock(object sender, ItemCheckedEventArgs e)
        {
            if (!e.Item.Focused)
            {
                return;
            }
            e.Item.Focused = true;
            if (e.Item.Checked == true && !controle.DejaDansLaListe(e.Item.SubItems[0].Text, Commande))
            {
                Produit produit = controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text);
                if (!produit.getFournisseurs().Any())
                {
                    MessageBox.Show("Ce produit ne possède pas de fournisseur", "Opération Impossible");
                    controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text).setChecked(false);
                    ActualiserListe();
                }
                else
                {
                    controle.AfficheFrm(produit, "restock");
                    Commande.Add(controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text));
                    lesQuantites.Add(controle.getCommandeQuantite());
                    lesDates.Add(controle.GetCommandeDate());
                    lesFournisseursRestock.Add(controle.getFournisseurRestock());
                    controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text).setChecked(true);
                }
            }
            else if (e.Item.Checked == false)
            {
                if (controle.DejaDansLaListe(e.Item.SubItems[0].Text, Commande))
                {
                    lesQuantites.RemoveAt(Commande.IndexOf(controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text)));
                    lesDates.RemoveAt(Commande.IndexOf(controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text)));
                    lesFournisseursRestock.RemoveAt(Commande.IndexOf(controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text)));
                    Commande.Remove(controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text));
                    controle.getLesProduits().Single(p => p.getNom() == e.Item.SubItems[0].Text).setChecked(false);
                    ActualiserListe();
                }
            }

        }

        #endregion    
    }
}

