using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_Log_Info.Modele
{
    [SerializableAttribute]
    public class Fournisseur
    {
        private string nom;
        private decimal prixachat;
        private DateTime datedernierachat;
        private string reference;

        public Fournisseur(string reference, string nom, decimal prixachat, DateTime datedernierachat)
        {
            this.nom = nom;
            this.prixachat = prixachat;
            this.datedernierachat = datedernierachat;
            this.reference = reference;
        }

        /// <summary>
        /// Getter sur le nom d'un fournisseur
        /// </summary>
        /// <returns>string nom</returns>
        public string getNom()
        {
            return this.nom;
        }

        /// <summary>
        /// Getter sur le prix d'achat d'un produit chez un fournisseur
        /// </summary>
        /// <returns>deciaml prixachat</returns>
        public decimal getPrixAchat()
        {
            return this.prixachat;
        }

        /// <summary>
        /// Getter sur la référence du produit associée au fournisseur
        /// </summary>
        /// <returns>string reference</returns>
        public string getReference()
        {
            return this.reference;
        }

        /// <summary>
        /// setter sur la date du dernier achat chez le fournisseur
        /// </summary>
        /// <param name="date"></param>
        public void setDateDernierAchat(DateTime date)
        {
            this.datedernierachat = date;
        }

        /// <summary>
        /// Permet d'obtenir une chaine string contenant les informations du fournisseur
        /// </summary>
        /// <returns>string fournisseur</returns>
        public override string ToString()
        {
            return "Reference : " + reference + ", Nom : " + nom + " (" + prixachat.ToString("N2") + "€ (HT) et " + Math.Round(prixachat * (decimal)1.2, 2).ToString("N2") + "€ (TTC)) Date dernier achat : " + datedernierachat.ToShortDateString();
        }

    }
}
