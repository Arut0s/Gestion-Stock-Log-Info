using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_Log_Info.Modele
{
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

        public string getNom()
        {
            return this.nom;
        }

        public decimal getPrixAchat()
        {
            return this.prixachat;
        }

        public override string ToString()
        {
            return "Reference : "+reference+", Nom : " + nom + " (" + prixachat + "€ (HT) et " + Math.Round(prixachat * (decimal)1.2,2) + "€ (TTC)) Date dernier achat : "+datedernierachat.ToShortDateString();
        }

        public void setReference(string reference)
        {
            this.reference = reference;
        }

        public string getReference()
        {
            return this.reference;
        }

        public void setDateDernierAchat(DateTime date)
        {
            this.datedernierachat = date;
        }
    }
}
