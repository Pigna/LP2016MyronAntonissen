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

            foreach (Boot boot in dbBoot.GetAllBoot())
            {
                cbActieRadiusBoten.Items.Add(boot);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            if (username != "" && password != "") //velden niet leeg
            {
                if (dbAccount.LoginCheck(username, password))
                {
                    //put loggedin user into variable
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
    }
}
