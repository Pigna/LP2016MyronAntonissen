namespace LP2016MyronAntonissen
{
    partial class VerhuurSysteem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.gbBudget = new System.Windows.Forms.GroupBox();
            this.btnBudgetArtikelAf = new System.Windows.Forms.Button();
            this.btnBudgetArtikelBij = new System.Windows.Forms.Button();
            this.btnBudgetBootAf = new System.Windows.Forms.Button();
            this.btnBudgetBootBij = new System.Windows.Forms.Button();
            this.lbBudgetHuur = new System.Windows.Forms.Label();
            this.lbBudgetTehuren = new System.Windows.Forms.Label();
            this.lbBudgetArtikelenHuur = new System.Windows.Forms.ListBox();
            this.lbBudgetBotenHuur = new System.Windows.Forms.ListBox();
            this.lbBudgetArtikelen = new System.Windows.Forms.ListBox();
            this.lbBudgetBoten = new System.Windows.Forms.ListBox();
            this.tbBudgetBerekenen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBudgetBerekenen = new System.Windows.Forms.Button();
            this.lblBudgetBerekenen = new System.Windows.Forms.Label();
            this.gbActieRadius = new System.Windows.Forms.GroupBox();
            this.lblActieRadiusResult = new System.Windows.Forms.Label();
            this.btnGetRadius = new System.Windows.Forms.Button();
            this.lblActieRadiusBoten = new System.Windows.Forms.Label();
            this.cbActieRadiusBoten = new System.Windows.Forms.ComboBox();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tpMedewerker = new System.Windows.Forms.TabPage();
            this.gbHuurcontract = new System.Windows.Forms.GroupBox();
            this.btnContractArtikelAf = new System.Windows.Forms.Button();
            this.btnContractArtikelBij = new System.Windows.Forms.Button();
            this.btnContractBootAf = new System.Windows.Forms.Button();
            this.btnContractBootBij = new System.Windows.Forms.Button();
            this.lbContractArtikelHuur = new System.Windows.Forms.ListBox();
            this.lbContractBootHuur = new System.Windows.Forms.ListBox();
            this.lbContractArtikel = new System.Windows.Forms.ListBox();
            this.lbContractBoot = new System.Windows.Forms.ListBox();
            this.cbHuurContractKlant = new System.Windows.Forms.ComboBox();
            this.gbNieuweKlant = new System.Windows.Forms.GroupBox();
            this.lbHuurcontracten = new System.Windows.Forms.ListBox();
            this.cbBudgetWater = new System.Windows.Forms.ComboBox();
            this.tbNKlantNaam = new System.Windows.Forms.TextBox();
            this.tbNKlantEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNieuweKlant = new System.Windows.Forms.Button();
            this.btnHuurContractNew = new System.Windows.Forms.Button();
            this.dtpVan = new System.Windows.Forms.DateTimePicker();
            this.dtpTot = new System.Windows.Forms.DateTimePicker();
            this.btnExporteer = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.gbBudget.SuspendLayout();
            this.gbActieRadius.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.tpMedewerker.SuspendLayout();
            this.gbHuurcontract.SuspendLayout();
            this.gbNieuweKlant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpHome);
            this.tabControl.Controls.Add(this.tpLogin);
            this.tabControl.Controls.Add(this.tpMedewerker);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1160, 637);
            this.tabControl.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.gbBudget);
            this.tpHome.Controls.Add(this.gbActieRadius);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(1152, 611);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // gbBudget
            // 
            this.gbBudget.Controls.Add(this.cbBudgetWater);
            this.gbBudget.Controls.Add(this.btnBudgetArtikelAf);
            this.gbBudget.Controls.Add(this.btnBudgetArtikelBij);
            this.gbBudget.Controls.Add(this.btnBudgetBootAf);
            this.gbBudget.Controls.Add(this.btnBudgetBootBij);
            this.gbBudget.Controls.Add(this.lbBudgetHuur);
            this.gbBudget.Controls.Add(this.lbBudgetTehuren);
            this.gbBudget.Controls.Add(this.lbBudgetArtikelenHuur);
            this.gbBudget.Controls.Add(this.lbBudgetBotenHuur);
            this.gbBudget.Controls.Add(this.lbBudgetArtikelen);
            this.gbBudget.Controls.Add(this.lbBudgetBoten);
            this.gbBudget.Controls.Add(this.tbBudgetBerekenen);
            this.gbBudget.Controls.Add(this.label1);
            this.gbBudget.Controls.Add(this.btnBudgetBerekenen);
            this.gbBudget.Controls.Add(this.lblBudgetBerekenen);
            this.gbBudget.Location = new System.Drawing.Point(190, 6);
            this.gbBudget.Name = "gbBudget";
            this.gbBudget.Size = new System.Drawing.Size(285, 306);
            this.gbBudget.TabIndex = 5;
            this.gbBudget.TabStop = false;
            this.gbBudget.Text = "Budget Berekenen";
            // 
            // btnBudgetArtikelAf
            // 
            this.btnBudgetArtikelAf.Location = new System.Drawing.Point(130, 219);
            this.btnBudgetArtikelAf.Name = "btnBudgetArtikelAf";
            this.btnBudgetArtikelAf.Size = new System.Drawing.Size(26, 23);
            this.btnBudgetArtikelAf.TabIndex = 15;
            this.btnBudgetArtikelAf.Text = "<";
            this.btnBudgetArtikelAf.UseVisualStyleBackColor = true;
            this.btnBudgetArtikelAf.Click += new System.EventHandler(this.btnBudgetArtikelAf_Click);
            // 
            // btnBudgetArtikelBij
            // 
            this.btnBudgetArtikelBij.Location = new System.Drawing.Point(130, 190);
            this.btnBudgetArtikelBij.Name = "btnBudgetArtikelBij";
            this.btnBudgetArtikelBij.Size = new System.Drawing.Size(26, 23);
            this.btnBudgetArtikelBij.TabIndex = 14;
            this.btnBudgetArtikelBij.Text = ">";
            this.btnBudgetArtikelBij.UseVisualStyleBackColor = true;
            this.btnBudgetArtikelBij.Click += new System.EventHandler(this.btnBudgetArtikelBij_Click);
            // 
            // btnBudgetBootAf
            // 
            this.btnBudgetBootAf.Location = new System.Drawing.Point(130, 116);
            this.btnBudgetBootAf.Name = "btnBudgetBootAf";
            this.btnBudgetBootAf.Size = new System.Drawing.Size(26, 23);
            this.btnBudgetBootAf.TabIndex = 13;
            this.btnBudgetBootAf.Text = "<";
            this.btnBudgetBootAf.UseVisualStyleBackColor = true;
            this.btnBudgetBootAf.Click += new System.EventHandler(this.btnBudgetBootAf_Click);
            // 
            // btnBudgetBootBij
            // 
            this.btnBudgetBootBij.Location = new System.Drawing.Point(130, 87);
            this.btnBudgetBootBij.Name = "btnBudgetBootBij";
            this.btnBudgetBootBij.Size = new System.Drawing.Size(26, 23);
            this.btnBudgetBootBij.TabIndex = 12;
            this.btnBudgetBootBij.Text = ">";
            this.btnBudgetBootBij.UseVisualStyleBackColor = true;
            this.btnBudgetBootBij.Click += new System.EventHandler(this.btnBudgetBootBij_Click);
            // 
            // lbBudgetHuur
            // 
            this.lbBudgetHuur.AutoSize = true;
            this.lbBudgetHuur.Location = new System.Drawing.Point(159, 49);
            this.lbBudgetHuur.Name = "lbBudgetHuur";
            this.lbBudgetHuur.Size = new System.Drawing.Size(30, 13);
            this.lbBudgetHuur.TabIndex = 11;
            this.lbBudgetHuur.Text = "Huur";
            // 
            // lbBudgetTehuren
            // 
            this.lbBudgetTehuren.AutoSize = true;
            this.lbBudgetTehuren.Location = new System.Drawing.Point(74, 49);
            this.lbBudgetTehuren.Name = "lbBudgetTehuren";
            this.lbBudgetTehuren.Size = new System.Drawing.Size(50, 13);
            this.lbBudgetTehuren.TabIndex = 10;
            this.lbBudgetTehuren.Text = "Te huren";
            // 
            // lbBudgetArtikelenHuur
            // 
            this.lbBudgetArtikelenHuur.FormattingEnabled = true;
            this.lbBudgetArtikelenHuur.Location = new System.Drawing.Point(162, 166);
            this.lbBudgetArtikelenHuur.Name = "lbBudgetArtikelenHuur";
            this.lbBudgetArtikelenHuur.Size = new System.Drawing.Size(115, 95);
            this.lbBudgetArtikelenHuur.TabIndex = 9;
            // 
            // lbBudgetBotenHuur
            // 
            this.lbBudgetBotenHuur.FormattingEnabled = true;
            this.lbBudgetBotenHuur.Location = new System.Drawing.Point(162, 65);
            this.lbBudgetBotenHuur.Name = "lbBudgetBotenHuur";
            this.lbBudgetBotenHuur.Size = new System.Drawing.Size(115, 95);
            this.lbBudgetBotenHuur.TabIndex = 8;
            // 
            // lbBudgetArtikelen
            // 
            this.lbBudgetArtikelen.FormattingEnabled = true;
            this.lbBudgetArtikelen.Location = new System.Drawing.Point(9, 166);
            this.lbBudgetArtikelen.Name = "lbBudgetArtikelen";
            this.lbBudgetArtikelen.Size = new System.Drawing.Size(115, 95);
            this.lbBudgetArtikelen.TabIndex = 7;
            // 
            // lbBudgetBoten
            // 
            this.lbBudgetBoten.FormattingEnabled = true;
            this.lbBudgetBoten.Location = new System.Drawing.Point(9, 65);
            this.lbBudgetBoten.Name = "lbBudgetBoten";
            this.lbBudgetBoten.Size = new System.Drawing.Size(115, 95);
            this.lbBudgetBoten.TabIndex = 6;
            // 
            // tbBudgetBerekenen
            // 
            this.tbBudgetBerekenen.Location = new System.Drawing.Point(53, 19);
            this.tbBudgetBerekenen.Name = "tbBudgetBerekenen";
            this.tbBudgetBerekenen.Size = new System.Drawing.Size(71, 20);
            this.tbBudgetBerekenen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // btnBudgetBerekenen
            // 
            this.btnBudgetBerekenen.Location = new System.Drawing.Point(202, 267);
            this.btnBudgetBerekenen.Name = "btnBudgetBerekenen";
            this.btnBudgetBerekenen.Size = new System.Drawing.Size(75, 23);
            this.btnBudgetBerekenen.TabIndex = 1;
            this.btnBudgetBerekenen.Text = "Bereken";
            this.btnBudgetBerekenen.UseVisualStyleBackColor = true;
            this.btnBudgetBerekenen.Click += new System.EventHandler(this.btnBudgetBerekenen_Click);
            // 
            // lblBudgetBerekenen
            // 
            this.lblBudgetBerekenen.AutoSize = true;
            this.lblBudgetBerekenen.Location = new System.Drawing.Point(6, 22);
            this.lblBudgetBerekenen.Name = "lblBudgetBerekenen";
            this.lblBudgetBerekenen.Size = new System.Drawing.Size(41, 13);
            this.lblBudgetBerekenen.TabIndex = 2;
            this.lblBudgetBerekenen.Text = "Budget";
            // 
            // gbActieRadius
            // 
            this.gbActieRadius.Controls.Add(this.lblActieRadiusResult);
            this.gbActieRadius.Controls.Add(this.btnGetRadius);
            this.gbActieRadius.Controls.Add(this.lblActieRadiusBoten);
            this.gbActieRadius.Controls.Add(this.cbActieRadiusBoten);
            this.gbActieRadius.Location = new System.Drawing.Point(6, 6);
            this.gbActieRadius.Name = "gbActieRadius";
            this.gbActieRadius.Size = new System.Drawing.Size(178, 85);
            this.gbActieRadius.TabIndex = 3;
            this.gbActieRadius.TabStop = false;
            this.gbActieRadius.Text = "ActieRadius";
            // 
            // lblActieRadiusResult
            // 
            this.lblActieRadiusResult.AutoSize = true;
            this.lblActieRadiusResult.Location = new System.Drawing.Point(6, 48);
            this.lblActieRadiusResult.Name = "lblActieRadiusResult";
            this.lblActieRadiusResult.Size = new System.Drawing.Size(0, 13);
            this.lblActieRadiusResult.TabIndex = 4;
            // 
            // btnGetRadius
            // 
            this.btnGetRadius.Location = new System.Drawing.Point(93, 43);
            this.btnGetRadius.Name = "btnGetRadius";
            this.btnGetRadius.Size = new System.Drawing.Size(75, 23);
            this.btnGetRadius.TabIndex = 1;
            this.btnGetRadius.Text = "ActieRadius";
            this.btnGetRadius.UseVisualStyleBackColor = true;
            this.btnGetRadius.Click += new System.EventHandler(this.btnGetRadius_Click);
            // 
            // lblActieRadiusBoten
            // 
            this.lblActieRadiusBoten.AutoSize = true;
            this.lblActieRadiusBoten.Location = new System.Drawing.Point(6, 19);
            this.lblActieRadiusBoten.Name = "lblActieRadiusBoten";
            this.lblActieRadiusBoten.Size = new System.Drawing.Size(35, 13);
            this.lblActieRadiusBoten.TabIndex = 2;
            this.lblActieRadiusBoten.Text = "Boten";
            // 
            // cbActieRadiusBoten
            // 
            this.cbActieRadiusBoten.FormattingEnabled = true;
            this.cbActieRadiusBoten.Location = new System.Drawing.Point(47, 16);
            this.cbActieRadiusBoten.Name = "cbActieRadiusBoten";
            this.cbActieRadiusBoten.Size = new System.Drawing.Size(121, 21);
            this.cbActieRadiusBoten.TabIndex = 0;
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.btnLogout);
            this.tpLogin.Controls.Add(this.btnLogin);
            this.tpLogin.Controls.Add(this.tbPassword);
            this.tpLogin.Controls.Add(this.tbUsername);
            this.tpLogin.Location = new System.Drawing.Point(4, 22);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(1152, 611);
            this.tpLogin.TabIndex = 1;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(112, 58);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(31, 58);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(31, 32);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(156, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(31, 6);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(156, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // tpMedewerker
            // 
            this.tpMedewerker.Controls.Add(this.btnExporteer);
            this.tpMedewerker.Controls.Add(this.gbHuurcontract);
            this.tpMedewerker.Controls.Add(this.gbNieuweKlant);
            this.tpMedewerker.Controls.Add(this.lbHuurcontracten);
            this.tpMedewerker.Location = new System.Drawing.Point(4, 22);
            this.tpMedewerker.Name = "tpMedewerker";
            this.tpMedewerker.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedewerker.Size = new System.Drawing.Size(1152, 611);
            this.tpMedewerker.TabIndex = 2;
            this.tpMedewerker.Text = "Medewerker";
            this.tpMedewerker.UseVisualStyleBackColor = true;
            this.tpMedewerker.Enter += new System.EventHandler(this.tpMedewerker_Enter);
            // 
            // gbHuurcontract
            // 
            this.gbHuurcontract.Controls.Add(this.dtpTot);
            this.gbHuurcontract.Controls.Add(this.dtpVan);
            this.gbHuurcontract.Controls.Add(this.btnHuurContractNew);
            this.gbHuurcontract.Controls.Add(this.btnContractArtikelAf);
            this.gbHuurcontract.Controls.Add(this.btnContractArtikelBij);
            this.gbHuurcontract.Controls.Add(this.btnContractBootAf);
            this.gbHuurcontract.Controls.Add(this.btnContractBootBij);
            this.gbHuurcontract.Controls.Add(this.lbContractArtikelHuur);
            this.gbHuurcontract.Controls.Add(this.lbContractBootHuur);
            this.gbHuurcontract.Controls.Add(this.lbContractArtikel);
            this.gbHuurcontract.Controls.Add(this.lbContractBoot);
            this.gbHuurcontract.Controls.Add(this.cbHuurContractKlant);
            this.gbHuurcontract.Location = new System.Drawing.Point(235, 178);
            this.gbHuurcontract.Name = "gbHuurcontract";
            this.gbHuurcontract.Size = new System.Drawing.Size(417, 430);
            this.gbHuurcontract.TabIndex = 2;
            this.gbHuurcontract.TabStop = false;
            this.gbHuurcontract.Text = "Nieuw Huurcontract";
            // 
            // btnContractArtikelAf
            // 
            this.btnContractArtikelAf.Location = new System.Drawing.Point(129, 249);
            this.btnContractArtikelAf.Name = "btnContractArtikelAf";
            this.btnContractArtikelAf.Size = new System.Drawing.Size(26, 23);
            this.btnContractArtikelAf.TabIndex = 23;
            this.btnContractArtikelAf.Text = "<";
            this.btnContractArtikelAf.UseVisualStyleBackColor = true;
            this.btnContractArtikelAf.Click += new System.EventHandler(this.btnContractArtikelAf_Click);
            // 
            // btnContractArtikelBij
            // 
            this.btnContractArtikelBij.Location = new System.Drawing.Point(129, 220);
            this.btnContractArtikelBij.Name = "btnContractArtikelBij";
            this.btnContractArtikelBij.Size = new System.Drawing.Size(26, 23);
            this.btnContractArtikelBij.TabIndex = 22;
            this.btnContractArtikelBij.Text = ">";
            this.btnContractArtikelBij.UseVisualStyleBackColor = true;
            this.btnContractArtikelBij.Click += new System.EventHandler(this.btnContractArtikelBij_Click);
            // 
            // btnContractBootAf
            // 
            this.btnContractBootAf.Location = new System.Drawing.Point(129, 146);
            this.btnContractBootAf.Name = "btnContractBootAf";
            this.btnContractBootAf.Size = new System.Drawing.Size(26, 23);
            this.btnContractBootAf.TabIndex = 21;
            this.btnContractBootAf.Text = "<";
            this.btnContractBootAf.UseVisualStyleBackColor = true;
            this.btnContractBootAf.Click += new System.EventHandler(this.btnContractBootAf_Click);
            // 
            // btnContractBootBij
            // 
            this.btnContractBootBij.Location = new System.Drawing.Point(129, 117);
            this.btnContractBootBij.Name = "btnContractBootBij";
            this.btnContractBootBij.Size = new System.Drawing.Size(26, 23);
            this.btnContractBootBij.TabIndex = 20;
            this.btnContractBootBij.Text = ">";
            this.btnContractBootBij.UseVisualStyleBackColor = true;
            this.btnContractBootBij.Click += new System.EventHandler(this.btnContractBootBij_Click);
            // 
            // lbContractArtikelHuur
            // 
            this.lbContractArtikelHuur.FormattingEnabled = true;
            this.lbContractArtikelHuur.Location = new System.Drawing.Point(161, 196);
            this.lbContractArtikelHuur.Name = "lbContractArtikelHuur";
            this.lbContractArtikelHuur.Size = new System.Drawing.Size(115, 95);
            this.lbContractArtikelHuur.TabIndex = 19;
            // 
            // lbContractBootHuur
            // 
            this.lbContractBootHuur.FormattingEnabled = true;
            this.lbContractBootHuur.Location = new System.Drawing.Point(161, 95);
            this.lbContractBootHuur.Name = "lbContractBootHuur";
            this.lbContractBootHuur.Size = new System.Drawing.Size(115, 95);
            this.lbContractBootHuur.TabIndex = 18;
            // 
            // lbContractArtikel
            // 
            this.lbContractArtikel.FormattingEnabled = true;
            this.lbContractArtikel.Location = new System.Drawing.Point(8, 196);
            this.lbContractArtikel.Name = "lbContractArtikel";
            this.lbContractArtikel.Size = new System.Drawing.Size(115, 95);
            this.lbContractArtikel.TabIndex = 17;
            // 
            // lbContractBoot
            // 
            this.lbContractBoot.FormattingEnabled = true;
            this.lbContractBoot.Location = new System.Drawing.Point(8, 95);
            this.lbContractBoot.Name = "lbContractBoot";
            this.lbContractBoot.Size = new System.Drawing.Size(115, 95);
            this.lbContractBoot.TabIndex = 16;
            // 
            // cbHuurContractKlant
            // 
            this.cbHuurContractKlant.FormattingEnabled = true;
            this.cbHuurContractKlant.Location = new System.Drawing.Point(6, 19);
            this.cbHuurContractKlant.Name = "cbHuurContractKlant";
            this.cbHuurContractKlant.Size = new System.Drawing.Size(115, 21);
            this.cbHuurContractKlant.TabIndex = 1;
            // 
            // gbNieuweKlant
            // 
            this.gbNieuweKlant.Controls.Add(this.btnNieuweKlant);
            this.gbNieuweKlant.Controls.Add(this.label3);
            this.gbNieuweKlant.Controls.Add(this.label2);
            this.gbNieuweKlant.Controls.Add(this.tbNKlantEmail);
            this.gbNieuweKlant.Controls.Add(this.tbNKlantNaam);
            this.gbNieuweKlant.Location = new System.Drawing.Point(235, 6);
            this.gbNieuweKlant.Name = "gbNieuweKlant";
            this.gbNieuweKlant.Size = new System.Drawing.Size(417, 166);
            this.gbNieuweKlant.TabIndex = 1;
            this.gbNieuweKlant.TabStop = false;
            this.gbNieuweKlant.Text = "Nieuwe Klant";
            // 
            // lbHuurcontracten
            // 
            this.lbHuurcontracten.FormattingEnabled = true;
            this.lbHuurcontracten.Location = new System.Drawing.Point(6, 6);
            this.lbHuurcontracten.Name = "lbHuurcontracten";
            this.lbHuurcontracten.Size = new System.Drawing.Size(223, 563);
            this.lbHuurcontracten.TabIndex = 0;
            // 
            // cbBudgetWater
            // 
            this.cbBudgetWater.FormattingEnabled = true;
            this.cbBudgetWater.Items.AddRange(new object[] {
            "Noordzee",
            "IJsselmeer"});
            this.cbBudgetWater.Location = new System.Drawing.Point(162, 19);
            this.cbBudgetWater.Name = "cbBudgetWater";
            this.cbBudgetWater.Size = new System.Drawing.Size(115, 21);
            this.cbBudgetWater.TabIndex = 16;
            // 
            // tbNKlantNaam
            // 
            this.tbNKlantNaam.Location = new System.Drawing.Point(88, 19);
            this.tbNKlantNaam.Name = "tbNKlantNaam";
            this.tbNKlantNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNKlantNaam.TabIndex = 0;
            // 
            // tbNKlantEmail
            // 
            this.tbNKlantEmail.Location = new System.Drawing.Point(88, 45);
            this.tbNKlantEmail.Name = "tbNKlantEmail";
            this.tbNKlantEmail.Size = new System.Drawing.Size(100, 20);
            this.tbNKlantEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naam:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNieuweKlant
            // 
            this.btnNieuweKlant.Location = new System.Drawing.Point(113, 71);
            this.btnNieuweKlant.Name = "btnNieuweKlant";
            this.btnNieuweKlant.Size = new System.Drawing.Size(75, 23);
            this.btnNieuweKlant.TabIndex = 4;
            this.btnNieuweKlant.Text = "Aanmaken";
            this.btnNieuweKlant.UseVisualStyleBackColor = true;
            this.btnNieuweKlant.Click += new System.EventHandler(this.btnNieuweKlant_Click);
            // 
            // btnHuurContractNew
            // 
            this.btnHuurContractNew.Location = new System.Drawing.Point(201, 297);
            this.btnHuurContractNew.Name = "btnHuurContractNew";
            this.btnHuurContractNew.Size = new System.Drawing.Size(75, 23);
            this.btnHuurContractNew.TabIndex = 24;
            this.btnHuurContractNew.Text = "Aanmaken";
            this.btnHuurContractNew.UseVisualStyleBackColor = true;
            this.btnHuurContractNew.Click += new System.EventHandler(this.btnHuurContractNew_Click);
            // 
            // dtpVan
            // 
            this.dtpVan.Location = new System.Drawing.Point(6, 58);
            this.dtpVan.Name = "dtpVan";
            this.dtpVan.Size = new System.Drawing.Size(115, 20);
            this.dtpVan.TabIndex = 25;
            // 
            // dtpTot
            // 
            this.dtpTot.Location = new System.Drawing.Point(161, 58);
            this.dtpTot.Name = "dtpTot";
            this.dtpTot.Size = new System.Drawing.Size(115, 20);
            this.dtpTot.TabIndex = 26;
            // 
            // btnExporteer
            // 
            this.btnExporteer.Location = new System.Drawing.Point(154, 575);
            this.btnExporteer.Name = "btnExporteer";
            this.btnExporteer.Size = new System.Drawing.Size(75, 23);
            this.btnExporteer.TabIndex = 27;
            this.btnExporteer.Text = "Exporteer";
            this.btnExporteer.UseVisualStyleBackColor = true;
            this.btnExporteer.Click += new System.EventHandler(this.btnExporteer_Click);
            // 
            // VerhuurSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tabControl);
            this.Name = "VerhuurSysteem";
            this.Text = "VerhuurSysteem | t Sloepke";
            this.tabControl.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.gbBudget.ResumeLayout(false);
            this.gbBudget.PerformLayout();
            this.gbActieRadius.ResumeLayout(false);
            this.gbActieRadius.PerformLayout();
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.tpMedewerker.ResumeLayout(false);
            this.gbHuurcontract.ResumeLayout(false);
            this.gbNieuweKlant.ResumeLayout(false);
            this.gbNieuweKlant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TabPage tpMedewerker;
        private System.Windows.Forms.GroupBox gbBudget;
        private System.Windows.Forms.Button btnBudgetArtikelAf;
        private System.Windows.Forms.Button btnBudgetArtikelBij;
        private System.Windows.Forms.Button btnBudgetBootAf;
        private System.Windows.Forms.Button btnBudgetBootBij;
        private System.Windows.Forms.Label lbBudgetHuur;
        private System.Windows.Forms.Label lbBudgetTehuren;
        private System.Windows.Forms.ListBox lbBudgetArtikelenHuur;
        private System.Windows.Forms.ListBox lbBudgetBotenHuur;
        private System.Windows.Forms.ListBox lbBudgetArtikelen;
        private System.Windows.Forms.ListBox lbBudgetBoten;
        private System.Windows.Forms.TextBox tbBudgetBerekenen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBudgetBerekenen;
        private System.Windows.Forms.Label lblBudgetBerekenen;
        private System.Windows.Forms.GroupBox gbActieRadius;
        private System.Windows.Forms.Label lblActieRadiusResult;
        private System.Windows.Forms.Button btnGetRadius;
        private System.Windows.Forms.Label lblActieRadiusBoten;
        private System.Windows.Forms.ComboBox cbActieRadiusBoten;
        private System.Windows.Forms.ListBox lbHuurcontracten;
        private System.Windows.Forms.GroupBox gbNieuweKlant;
        private System.Windows.Forms.GroupBox gbHuurcontract;
        private System.Windows.Forms.ComboBox cbHuurContractKlant;
        private System.Windows.Forms.Button btnContractArtikelAf;
        private System.Windows.Forms.Button btnContractArtikelBij;
        private System.Windows.Forms.Button btnContractBootAf;
        private System.Windows.Forms.Button btnContractBootBij;
        private System.Windows.Forms.ListBox lbContractArtikelHuur;
        private System.Windows.Forms.ListBox lbContractBootHuur;
        private System.Windows.Forms.ListBox lbContractArtikel;
        private System.Windows.Forms.ListBox lbContractBoot;
        private System.Windows.Forms.ComboBox cbBudgetWater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNKlantEmail;
        private System.Windows.Forms.TextBox tbNKlantNaam;
        private System.Windows.Forms.Button btnNieuweKlant;
        private System.Windows.Forms.Button btnHuurContractNew;
        private System.Windows.Forms.DateTimePicker dtpTot;
        private System.Windows.Forms.DateTimePicker dtpVan;
        private System.Windows.Forms.Button btnExporteer;
    }
}

