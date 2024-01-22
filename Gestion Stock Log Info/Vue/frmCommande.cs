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
    public partial class frmCommande : Form
    {
        #region déclarations 

        private Controle controle;
        public List<Fournisseur> lesFournisseurs;

        #endregion
        public frmCommande()
        {
            InitializeComponent();
            controle = Controle.getInstance();
            
        }

        #region evenements boutons

        /// <summary>
        /// Bouton permettant de confirmer les informations du form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            controle.setCommandeQuantite((int)nudQuantite.Value);
            controle.setCommandeDate(dtpDate.Value);
            if(Text == "Restock")
            {
                controle.setFournisseurRestock(lesFournisseurs.Single(f => cmbFournisseur.SelectedItem.ToString().Contains(f.getNom())));
            }
            this.Close();
        }

        /// <summary>
        /// Bouton permettant d'annuler le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region getters et setters

        /// <summary>
        /// Getter sur le combobox des fournisseurs
        /// </summary>
        /// <returns></returns>
        public ComboBox getCmbFournisseur()
        {
            return cmbFournisseur;
        }

        /// <summary>
        /// Setter sur la liste des fournisseurs
        /// </summary>
        /// <param name="fournisseurs"></param>
        public void setLesFournisseurs(List<Fournisseur> fournisseurs)
        {
            this.lesFournisseurs = fournisseurs;
        }

        
        #endregion

        #region autres evenements

        /// <summary>
        /// Evenement se produisant au chargement du formulaire permettant d'initialisé ce dernier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCommande_Load(object sender, EventArgs e)
        {
            nudQuantite.Value = 1;
            dtpDate.Value = controle.GetCommandeDate();
            if (this.Text == "Commande")
            {
                lblFournisseur.Enabled = false;
                cmbFournisseur.Enabled = false;
            }
            else
            {
                foreach (Fournisseur fournisseur in lesFournisseurs)
                {
                    cmbFournisseur.Items.Add(fournisseur);
                }
                cmbFournisseur.SelectedIndex = 0;
            }
        }

        #endregion
    }
}
