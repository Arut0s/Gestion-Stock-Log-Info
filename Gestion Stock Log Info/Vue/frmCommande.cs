using Gestion_Stock_Log_Info.Controlleur;
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
        public frmCommande()
        {
            InitializeComponent();
            controle = Controle.getInstance();
            nudQuantite.Value = 1;
            dtpDate.Value = controle.GetCommandeDate();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            controle.setCommandeQuantite((int)nudQuantite.Value);
            controle.setCommandeDate(dtpDate.Value);
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
