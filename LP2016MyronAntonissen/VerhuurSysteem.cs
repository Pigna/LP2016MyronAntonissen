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
        DBContract dbContract = new DBContract();

        public VerhuurSysteem()
        {
            InitializeComponent();
            btnLogout.Enabled = false;
            DisableTabs();
            //Fills interface with data
            foreach (Boot boot in dbBoot.GetAllBoot())
            {
                lbBudgetBoten.Items.Add(boot);
                lbContractBoot.Items.Add(boot);
                if (boot.GetType() == typeof(Motor))
                    cbActieRadiusBoten.Items.Add(boot);
            }
            foreach (Artikel artikel in dbArtikel.GetAllArtikel())
            {
                lbBudgetArtikelen.Items.Add(artikel);
                lbContractArtikel.Items.Add(artikel);
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
            Motor boot = (Motor) cbActieRadiusBoten.SelectedItem;
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
                Boot selectedBoot = (Boot) lbBudgetBotenHuur.SelectedItem;
                lbBudgetBoten.Items.Add(selectedBoot);
                lbBudgetBotenHuur.Items.Remove(selectedBoot);
            }
        }

        private void btnBudgetArtikelBij_Click(object sender, EventArgs e)
        {
            if (lbBudgetArtikelen.SelectedItem != null)
            {
                Artikel selectedArtikel = (Artikel) lbBudgetArtikelen.SelectedItem;
                lbBudgetArtikelenHuur.Items.Add(selectedArtikel);
                lbBudgetArtikelen.Items.Remove(selectedArtikel);
            }
        }

        private void btnBudgetArtikelAf_Click(object sender, EventArgs e)
        {
            if (lbBudgetArtikelenHuur.SelectedItem != null)
            {
                Artikel selectedArtikel = (Artikel) lbBudgetArtikelenHuur.SelectedItem;
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
                string water = cbBudgetWater.Text;
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
                int aantalmeren = Budget.BerekenAantalMeren(budget, bootHuurLijst, artikelHuurLijst, water);
                lbBudgetTehuren.Text = aantalmeren.ToString();
            }
            else
            {
                MessageBox.Show("Vul een waarde in die voldoet aan [nn.nn]");
            }

        }

        private void tpMedewerker_Enter(object sender, EventArgs e)
        {
            if (LoggedInUser.GetType() == typeof(Verhuurder))
            {
                foreach (Huurcontract contract in ((Verhuurder) LoggedInUser).AlleContracten())
                {
                    lbHuurcontracten.Items.Add(contract);
                }
                foreach (Klant klant in ((Verhuurder) LoggedInUser).AlleKlanten())
                {
                    cbHuurContractKlant.Items.Add(klant);
                }
            }
        }

        private void btnNieuweKlant_Click(object sender, EventArgs e)
        {
            string naam = tbNKlantNaam.Text;
            string email = tbNKlantEmail.Text;
            if (naam.Trim() != "" && email.Trim() != "")
            {
                if (LoggedInUser.GetType() == typeof(Verhuurder))
                {
                    Klant klant = ((Verhuurder) LoggedInUser).NieuweKlant(naam, email);
                    if (klant != null)
                    {
                        cbHuurContractKlant.Items.Add(klant);
                        tbNKlantNaam.Clear();
                        tbNKlantEmail.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Fout bij toevoegen.");
                    }
                }
            }
        }

        private void btnContractBootBij_Click(object sender, EventArgs e)
        {
            if (lbContractBoot.SelectedItem != null)
            {
                Boot selectedBoot = (Boot) lbContractBoot.SelectedItem;
                lbContractBootHuur.Items.Add(selectedBoot);
                lbContractBoot.Items.Remove(selectedBoot);
            }
        }

        private void btnContractBootAf_Click(object sender, EventArgs e)
        {
            if (lbContractBootHuur.SelectedItem != null)
            {
                Boot selectedBoot = (Boot) lbContractBootHuur.SelectedItem;
                lbContractBoot.Items.Add(selectedBoot);
                lbContractBootHuur.Items.Remove(selectedBoot);
            }
        }

        private void btnContractArtikelBij_Click(object sender, EventArgs e)
        {
            if (lbContractArtikel.SelectedItem != null)
            {
                Artikel selectedArtikel = (Artikel) lbContractArtikel.SelectedItem;
                lbContractArtikelHuur.Items.Add(selectedArtikel);
                lbContractArtikel.Items.Remove(selectedArtikel);
            }
        }

        private void btnContractArtikelAf_Click(object sender, EventArgs e)
        {
            if (lbContractArtikelHuur.SelectedItem != null)
            {
                Artikel selectedArtikel = (Artikel) lbContractArtikelHuur.SelectedItem;
                lbContractArtikel.Items.Add(selectedArtikel);
                lbContractArtikelHuur.Items.Remove(selectedArtikel);
            }
        }

        private void btnHuurContractNew_Click(object sender, EventArgs e)
        {
            if (cbHuurContractKlant.Text != "" && dtpVan.Value < dtpTot.Value)
            {
                if (LoggedInUser.GetType() == typeof(Verhuurder))
                {
                    List<Boot> boten = lbContractBootHuur.SelectedItems.Cast<Boot>().ToList();
                    List<Artikel> artikels = lbContractArtikelHuur.SelectedItems.Cast<Artikel>().ToList();
                    Huurcontract contract = ((Verhuurder) LoggedInUser).NieuwContract(dtpVan.Value, dtpTot.Value,
                        (Klant) cbHuurContractKlant.SelectedItem, boten, artikels);
                    lbHuurcontracten.Items.Add(contract);
                }
            }
        }

        private void btnExporteer_Click(object sender, EventArgs e)
        {
            ((Huurcontract) lbHuurcontracten.SelectedItem).ExportContract();
        }
    }
}
