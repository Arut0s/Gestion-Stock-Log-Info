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
    public partial class frmAjoutProduit : Form
    {
        private Controle controle;
        private List<Fournisseur> lesFournisseurs = new List<Fournisseur>();
        public frmAjoutProduit()
        {
            InitializeComponent();
        }

        private void frmAjoutProduit_Load(object sender, EventArgs e)
        {
            controle = Controle.getInstance();
            if(controle.getOrdre() == "modifier")
            {

            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNomFournisseur.Text != "")
            {
                Fournisseur fournisseur = new Fournisseur(txtReference.Text, txtNomFournisseur.Text, Convert.ToDouble(nudPrixHTFournisseur.Value), dtpDateDernierAchat.Value);
                lesFournisseurs.Add(fournisseur);
                MessageBox.Show(fournisseur.ToString() + " a bien été ajouté");
                txtNomFournisseur.Text = "";
            }
            else
            {
                MessageBox.Show("Le nom doit être rempli", "erreur");
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(txtNom.Text != "" && cmbCategorie.SelectedIndex != -1)
            {
                if (controle.DejaDansLaListe(txtNom.Text, controle.getLesProduits()))
                {
                    MessageBox.Show("Ce produit existe déjà : " + controle.getLesProduits().Single(p => p.getNom() == txtNom.Text).ToString());
                }
                else
                {
                    Produit produit = new Produit(txtNom.Text, cmbCategorie.Text, lesFournisseurs, Convert.ToDouble(nudPrixHTProduit.Value), Convert.ToInt32(nudQuantite.Value), dtpDerniereVente.Value);
                    controle.Ajout(produit);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tout les champs");
            }
        }
    }
}
