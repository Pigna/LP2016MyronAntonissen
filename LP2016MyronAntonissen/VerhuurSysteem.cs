using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2016MyronAntonissen.Database;

namespace LP2016MyronAntonissen
{
    public partial class VerhuurSysteem : Form
    {
        private Account LoggedInUser;
        DBBoot dbBoot = new DBBoot();
        DBArtikel dbArtikel = new DBArtikel();
        DBAccount dbAccount = new DBAccount();
        public VerhuurSysteem()
        {
            InitializeComponent();
            btnLogout.Enabled = false;
            DisableTabs();
            //Fills interface with data
            foreach (Boot boot in dbBoot.GetAllBoot())
            {
                lbBudgetBoten.Items.Add(boot);
                if(boot.GetType() == typeof(Motor))
                    cbActieRadiusBoten.Items.Add(boot);
            }
            foreach (Artikel artikel in dbArtikel.GetAllArtikel())
            {
                lbBudgetArtikelen.Items.Add(artikel);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            if (username != "" && password != "") //velden niet leeg
            {
                int accountid = dbAccount.LoginCheck(username, password);
                if (accountid > 0)
                {
                    LoggedInUser = dbAccount.GetAccountById(accountid);
                    //enable tabs
                    EnableTabs();
                    btnLogin.Enabled = false;
                    btnLogout.Enabled = true;
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Gebruikersnaam en Wachtwoord combinatie is niet correct.");
                }
            }
            else
            {
                MessageBox.Show("Vul een gebruikersnaam en wachtwoord in.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoggedInUser = null;
            //disable tabs
            DisableTabs();
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
        }

        private void DisableTabs()
        {
            tabControl.TabPages.Remove(tpMedewerker);
        }

        private void EnableTabs()
        {
            tabControl.TabPages.Add(tpMedewerker);
        }

        private void btnGetRadius_Click(object sender, EventArgs e)
        {
            Motor boot = (Motor)cbActieRadiusBoten.SelectedItem;
            lblActieRadiusResult.Text = boot.ActieRadius.ToString() + " km";
        }

        private void btnBudgetBootBij_Click(object sender, EventArgs e)
        {
            if (lbBudgetBoten.SelectedItem != null)
            {
                Boot selectedBoot = (Boot) lbBudgetBoten.SelectedItem;
                lbBudgetBotenHuur.Items.Add(selectedBoot);
                lbBudgetBoten.Items.Remove(selectedBoot);
            }
        }

        private void btnBudgetBootAf_Click(object sender, EventArgs e)
        {
            if (lbBudgetBotenHuur.SelectedItem != null)
            {
                Boot selectedBoot = (Boot)lbBudgetBotenHuur.SelectedItem;
                lbBudgetBoten.Items.Add(selectedBoot);
                lbBudgetBotenHuur.Items.Remove(selectedBoot);
            }
        }

        private void btnBudgetArtikelBij_Click(object sender, EventArgs e)
        {
            if (lbBudgetArtikelen.SelectedItem != null)
            {
                Artikel selectedArtikel = (Artikel)lbBudgetArtikelen.SelectedItem;
                lbBudgetArtikelenHuur.Items.Add(selectedArtikel);
                lbBudgetArtikelen.Items.Remove(selectedArtikel);
            }
        }

        private void btnBudgetArtikelAf_Click(object sender, EventArgs e)
        {
            if(lbBudgetArtikelenHuur.SelectedItem != null)
            {
                Artikel selectedArtikel = (Artikel)lbBudgetArtikelenHuur.SelectedItem;
                lbBudgetArtikelen.Items.Add(selectedArtikel);
                lbBudgetArtikelenHuur.Items.Remove(selectedArtikel);
            }
        }

        private void btnBudgetBerekenen_Click(object sender, EventArgs e)
        {
            BudgetController Budget = new BudgetController();

            double budget = 0.0;
            double.TryParse(tbBudgetBerekenen.Text.Trim(), out budget);
            if (budget > 0)
            {
                List<Boot> bootHuurLijst = new List<Boot>();
                foreach (var boot in lbBudgetBotenHuur.Items)
                {
                    bootHuurLijst.Add((Boot) boot);
                }
                List<Artikel> artikelHuurLijst = new List<Artikel>();
                foreach (var artikel in lbBudgetArtikelenHuur.Items)
                {
                    artikelHuurLijst.Add((Artikel) artikel);
                }
                Budget.BerekenAantalMeren(budget, bootHuurLijst, artikelHuurLijst, )
            }
            else
            {
                MessageBox.Show("Vul een waarde in die voldoet aan [nn.nn]");
            }

        }
    }
}
