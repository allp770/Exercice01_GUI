using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice01_GUI
{
    public partial class FrmNombreCache : Form
    {
        private int phase, valeurAChercher, nbEssai;

        private void efface()
        {
            txtValeur.Text = "";
            txtValeur.Focus();
        }

        private void initialiser()
        {
            if (phase == 1)
            {
                grpValeur.Text ="Valeur (entre 1 et 100)";
                grpReponse.Visible = false;
            }
            else
            {
                grpValeur.Text = "Essai (entre 1 et 100)";
                grpReponse.Visible = true;
                grpReponse.Text = "";
                nbEssai = 0;
            }

            lblMessage.Text = "";
            efface();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            phase = 1;
            initialiser();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int valeur = 0;
            try
            {
                valeur = int.Parse(txtValeur.Text);   // plante si vide ou pas un entier

                if (valeur < 1 || valeur > 100)
                {
                    efface();
                    lblMessage.Text = "Veuillez saisir un entier entre 1 et 100";
                }
                else
                {
                    if (phase == 1)
                    {
                        valeurAChercher = valeur;
                        phase = 2;
                        initialiser();
                    }
                    else
                    {
                        nbEssai++;
                        grpReponse.Text = "Essai n°" + nbEssai;

                        if (valeur < valeurAChercher)
                        {
                            lblMessage.Text = valeur + " est trop petit !";
                            efface();
                        }
                        else if (valeur > valeurAChercher)
                        {
                            lblMessage.Text = valeur + " est trop grand !";
                            efface();
                        }
                        else
                        {
                            lblMessage.Text = "Bravo !!!, c'était bien " + valeurAChercher;
                            efface();
                            btnRejouer.Focus();
                        }
                    }
                }
            }
            catch
            {
                efface();
                lblMessage.Text = "Veuillez saisir un entier entre 1 et 100";
            }
        }

        private void txtValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnValider_Click(null, null);
            }
        }

        public FrmNombreCache()
        {
            InitializeComponent();
        }

        private void FrmNombreCache_Load(object sender, EventArgs e)
        {
            btnRejouer_Click(null, null);
        }
    }
}
