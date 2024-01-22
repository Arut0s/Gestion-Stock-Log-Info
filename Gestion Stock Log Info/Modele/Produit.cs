using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_Log_Info.Modele
{
    [SerializableAttribute]
    public class Produit
    {
        private string nom;
        private string categorie;
        private List<Fournisseur> fournisseurs;
        private decimal prixvente;
        private int quantite;
        private bool ischecked = false;
        private DateTime datedernierevente;

        
        public Produit(string nom, string categorie, List<Fournisseur> fournisseurs, decimal prixvente, int quantite, DateTime datedernierevente)
        {
            this.nom = nom;
            this.categorie = categorie;
            this.fournisseurs = fournisseurs;
            this.prixvente = prixvente;
            this.quantite = quantite;
            this.datedernierevente = datedernierevente;
        }

        /// <summary>
        /// Getter sur le nom d'un produit
        /// </summary>
        /// <returns>string nom</returns>
        public string getNom()
        {
            return this.nom;
        }

        /// <summary>
        /// Getter sur la catégorie d'un produit
        /// </summary>
        /// <returns>string categorie</returns>
        public string getCategorie()
        {
            return this.categorie;
        }

        /// <summary>
        /// Getter sur la quantité disponible d'un produit
        /// </summary>
        /// <returns>int quantite</returns>
        public int getQuantite()
        {
            return this.quantite;
        }

        /// <summary>
        /// Getter surla liste des fournisseurs d'un produit
        /// </summary>
        /// <returns>List fournisseur</returns>
        public List<Fournisseur> getFournisseurs()
        {
            return fournisseurs;
        }

        /// <summary>
        /// Getter sur le prix de vente d'un produit
        /// </summary>
        /// <returns></returns>
        public decimal getPrixVente()
        {
            return this.prixvente;
        }

        /// <summary>
        /// Getter sur la date de la dernière vente d'un produit
        /// </summary>
        /// <returns>Date date dernière vente</returns>
        public DateTime getDateDerniereVente()
        {
            return this.datedernierevente;
        }

        /// <summary>
        /// Permet d'obtenir l'état de la case "check" d'un produit
        /// </summary>
        /// <returns>bool ischecked</returns>
        public bool isChecked()
        {
            return this.ischecked;
        }

        /// <summary>
        /// Setter sur la quantite d'un produit
        /// </summary>
        /// <param name="quantite"></param>

        public void setQuantite(int quantite)
        {
            this.quantite = quantite;
        }

        /// <summary>
        /// Setter sur la date de dernière vente d'un produit
        /// </summary>
        /// <param name="datedernierevente"></param>
        public void setDateDerniereVente(DateTime datedernierevente)
        {
            this.datedernierevente = datedernierevente;
        }

        /// <summary>
        /// Permet de changer l'état de la case "check" d'un produit
        /// </summary>
        /// <param name="ischecked"></param>
        public void setChecked(bool ischecked)
        {
            this.ischecked = ischecked;
        }

        /// <summary>
        /// Permet d'obtenir une chaine string contenant les informations du produit
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Nom : " + nom + ", Catégorie : " + categorie;
        }
    }
}
