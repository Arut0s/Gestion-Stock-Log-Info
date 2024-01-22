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

  
        public string getNom()
        {
            return this.nom;
        }

        public string getCategorie()
        {
            return this.categorie;
        }

        public int getQuantite()
        {
            return this.quantite;
        }
        public bool isChecked()
        {
            return this.ischecked;
        }

        public decimal getPrixVente()
        {
            return this.prixvente;
        }

        public List<Fournisseur> getFournisseurs()
        {
            return fournisseurs;
        }

        public DateTime getDateDerniereVente()
        {
            return this.datedernierevente;
        }

        public void setDateDerniereVente(DateTime datedernierevente)
        {
            this.datedernierevente = datedernierevente;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setCategorie(string categorie)
        {
            this.categorie = categorie;
        }

        public void setFournisseurs(List<Fournisseur> fournisseurs)
        {
            this.fournisseurs = fournisseurs;
        }

        public void setQuantite(int quantite)
        {
            this.quantite = quantite;
        }

        public void setPrixVente(decimal prixvente)
        {
            this.prixvente = prixvente;
        }
        public override string ToString()
        {
            return   "Nom : " + nom + ", Catégorie : " + categorie;
        }

        public void setChecked(bool ischecked)
        {
            this.ischecked = ischecked;
        }
    }
}
