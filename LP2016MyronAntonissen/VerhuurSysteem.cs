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
        DBAccount dbAccount = new DBAccount();
        public VerhuurSysteem()
        {
            InitializeComponent();
            btnLogout.Enabled = false;
            DisableTabs();
            foreach (Boot boot in dbBoot.GetAllBoot())
            {
                if(boot.GetType() == typeof(Motor))
                    cbActieRadiusBoten.Items.Add(boot);
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
    }
}
