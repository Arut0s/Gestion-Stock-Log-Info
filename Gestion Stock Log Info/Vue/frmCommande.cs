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
        private Controle controle;
        public List<Fournisseur> lesFournisseurs;
        public frmCommande()
        {
            InitializeComponent();
            controle = Controle.getInstance();
            
        }

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

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setLesFournisseurs(List<Fournisseur> fournisseurs)
        {
            this.lesFournisseurs = fournisseurs;
        }

        public ComboBox getCmbFournisseur()
        {
            return cmbFournisseur;
        }

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
    }
}
