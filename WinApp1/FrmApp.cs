using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp1
{
    public partial class FrmApp : Form
    {
        public FrmApp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string msg, nom, annee;
            nom = txtNom.Text;
            msg = "Bonjour " + nom.ToUpper()+ Environment.NewLine; 
            annee = txtAnnee.Text;
            //annee = DateTime.Now.Year - annee.ToUpper();
            annee = "Vous avez " + annee.ToUpper() + " ans";
            txtMessage.Text = msg+annee;
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtMessage.Clear();
            txtAnnee.Clear();
            // txtAnnee.focus();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnnee_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
