﻿namespace LP2016MyronAntonissen
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tcLogin = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblActieRadiusBoten = new System.Windows.Forms.Label();
            this.gbActieRadius = new System.Windows.Forms.GroupBox();
            this.lblActieRadiusResult = new System.Windows.Forms.Label();
            this.lbHuurcontracten = new System.Windows.Forms.ListBox();
            this.gbBudget = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBudgetBerekenen = new System.Windows.Forms.Button();
            this.lblBudgetBerekenen = new System.Windows.Forms.Label();
            this.tbBudgetBerekenen = new System.Windows.Forms.TextBox();
            this.lbBudgetBoten = new System.Windows.Forms.ListBox();
            this.lbBudgetArtikelen = new System.Windows.Forms.ListBox();
            this.lbBudgetBotenHuur = new System.Windows.Forms.ListBox();
            this.lbBudgetArtikelenHuur = new System.Windows.Forms.ListBox();
            this.lbBudgetTehuren = new System.Windows.Forms.Label();
            this.lbBudgetHuur = new System.Windows.Forms.Label();
            this.btnBudgetBootBij = new System.Windows.Forms.Button();
            this.btnBudgetBootAf = new System.Windows.Forms.Button();
            this.btnBudgetArtikelAf = new System.Windows.Forms.Button();
            this.btnBudgetArtikelBij = new System.Windows.Forms.Button();
            this.gbNieuweKlant = new System.Windows.Forms.GroupBox();
            this.gbHuurcontract = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tcLogin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbActieRadius.SuspendLayout();
            this.gbBudget.SuspendLayout();
            this.gbHuurcontract.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tcLogin);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1160, 637);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbBudget);
            this.tabPage1.Controls.Add(this.gbActieRadius);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1152, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tcLogin
            // 
            this.tcLogin.Controls.Add(this.btnLogout);
            this.tcLogin.Controls.Add(this.btnLogin);
            this.tcLogin.Controls.Add(this.tbPassword);
            this.tcLogin.Controls.Add(this.tbUsername);
            this.tcLogin.Location = new System.Drawing.Point(4, 22);
            this.tcLogin.Name = "tcLogin";
            this.tcLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tcLogin.Size = new System.Drawing.Size(1152, 611);
            this.tcLogin.TabIndex = 1;
            this.tcLogin.Text = "Login";
            this.tcLogin.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbHuurcontract);
            this.tabPage2.Controls.Add(this.gbNieuweKlant);
            this.tabPage2.Controls.Add(this.lbHuurcontracten);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1152, 611);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(31, 6);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(156, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(31, 32);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(156, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(31, 58);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(112, 58);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // gbActieRadius
            // 
            this.gbActieRadius.Controls.Add(this.lblActieRadiusResult);
            this.gbActieRadius.Controls.Add(this.button1);
            this.gbActieRadius.Controls.Add(this.lblActieRadiusBoten);
            this.gbActieRadius.Controls.Add(this.comboBox1);
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
            // lbHuurcontracten
            // 
            this.lbHuurcontracten.FormattingEnabled = true;
            this.lbHuurcontracten.Location = new System.Drawing.Point(6, 6);
            this.lbHuurcontracten.Name = "lbHuurcontracten";
            this.lbHuurcontracten.Size = new System.Drawing.Size(223, 602);
            this.lbHuurcontracten.TabIndex = 0;
            // 
            // gbBudget
            // 
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
            // tbBudgetBerekenen
            // 
            this.tbBudgetBerekenen.Location = new System.Drawing.Point(53, 19);
            this.tbBudgetBerekenen.Name = "tbBudgetBerekenen";
            this.tbBudgetBerekenen.Size = new System.Drawing.Size(71, 20);
            this.tbBudgetBerekenen.TabIndex = 5;
            // 
            // lbBudgetBoten
            // 
            this.lbBudgetBoten.FormattingEnabled = true;
            this.lbBudgetBoten.Location = new System.Drawing.Point(9, 65);
            this.lbBudgetBoten.Name = "lbBudgetBoten";
            this.lbBudgetBoten.Size = new System.Drawing.Size(115, 95);
            this.lbBudgetBoten.TabIndex = 6;
            // 
            // lbBudgetArtikelen
            // 
            this.lbBudgetArtikelen.FormattingEnabled = true;
            this.lbBudgetArtikelen.Location = new System.Drawing.Point(9, 166);
            this.lbBudgetArtikelen.Name = "lbBudgetArtikelen";
            this.lbBudgetArtikelen.Size = new System.Drawing.Size(115, 95);
            this.lbBudgetArtikelen.TabIndex = 7;
            // 
            // lbBudgetBotenHuur
            // 
            this.lbBudgetBotenHuur.FormattingEnabled = true;
            this.lbBudgetBotenHuur.Location = new System.Drawing.Point(162, 65);
            this.lbBudgetBotenHuur.Name = "lbBudgetBotenHuur";
            this.lbBudgetBotenHuur.Size = new System.Drawing.Size(115, 95);
            this.lbBudgetBotenHuur.TabIndex = 8;
            // 
            // lbBudgetArtikelenHuur
            // 
            this.lbBudgetArtikelenHuur.FormattingEnabled = true;
            this.lbBudgetArtikelenHuur.Location = new System.Drawing.Point(162, 166);
            this.lbBudgetArtikelenHuur.Name = "lbBudgetArtikelenHuur";
            this.lbBudgetArtikelenHuur.Size = new System.Drawing.Size(115, 95);
            this.lbBudgetArtikelenHuur.TabIndex = 9;
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
            // lbBudgetHuur
            // 
            this.lbBudgetHuur.AutoSize = true;
            this.lbBudgetHuur.Location = new System.Drawing.Point(159, 49);
            this.lbBudgetHuur.Name = "lbBudgetHuur";
            this.lbBudgetHuur.Size = new System.Drawing.Size(30, 13);
            this.lbBudgetHuur.TabIndex = 11;
            this.lbBudgetHuur.Text = "Huur";
            // 
            // btnBudgetBootBij
            // 
            this.btnBudgetBootBij.Location = new System.Drawing.Point(130, 87);
            this.btnBudgetBootBij.Name = "btnBudgetBootBij";
            this.btnBudgetBootBij.Size = new System.Drawing.Size(26, 23);
            this.btnBudgetBootBij.TabIndex = 12;
            this.btnBudgetBootBij.Text = ">";
            this.btnBudgetBootBij.UseVisualStyleBackColor = true;
            // 
            // btnBudgetBootAf
            // 
            this.btnBudgetBootAf.Location = new System.Drawing.Point(130, 116);
            this.btnBudgetBootAf.Name = "btnBudgetBootAf";
            this.btnBudgetBootAf.Size = new System.Drawing.Size(26, 23);
            this.btnBudgetBootAf.TabIndex = 13;
            this.btnBudgetBootAf.Text = "<";
            this.btnBudgetBootAf.UseVisualStyleBackColor = true;
            // 
            // btnBudgetArtikelAf
            // 
            this.btnBudgetArtikelAf.Location = new System.Drawing.Point(130, 219);
            this.btnBudgetArtikelAf.Name = "btnBudgetArtikelAf";
            this.btnBudgetArtikelAf.Size = new System.Drawing.Size(26, 23);
            this.btnBudgetArtikelAf.TabIndex = 15;
            this.btnBudgetArtikelAf.Text = "<";
            this.btnBudgetArtikelAf.UseVisualStyleBackColor = true;
            // 
            // btnBudgetArtikelBij
            // 
            this.btnBudgetArtikelBij.Location = new System.Drawing.Point(130, 190);
            this.btnBudgetArtikelBij.Name = "btnBudgetArtikelBij";
            this.btnBudgetArtikelBij.Size = new System.Drawing.Size(26, 23);
            this.btnBudgetArtikelBij.TabIndex = 14;
            this.btnBudgetArtikelBij.Text = ">";
            this.btnBudgetArtikelBij.UseVisualStyleBackColor = true;
            // 
            // gbNieuweKlant
            // 
            this.gbNieuweKlant.Location = new System.Drawing.Point(235, 6);
            this.gbNieuweKlant.Name = "gbNieuweKlant";
            this.gbNieuweKlant.Size = new System.Drawing.Size(417, 166);
            this.gbNieuweKlant.TabIndex = 1;
            this.gbNieuweKlant.TabStop = false;
            this.gbNieuweKlant.Text = "Nieuwe Klant";
            // 
            // gbHuurcontract
            // 
            this.gbHuurcontract.Controls.Add(this.button2);
            this.gbHuurcontract.Controls.Add(this.button3);
            this.gbHuurcontract.Controls.Add(this.button4);
            this.gbHuurcontract.Controls.Add(this.button5);
            this.gbHuurcontract.Controls.Add(this.listBox1);
            this.gbHuurcontract.Controls.Add(this.listBox2);
            this.gbHuurcontract.Controls.Add(this.listBox3);
            this.gbHuurcontract.Controls.Add(this.listBox4);
            this.gbHuurcontract.Controls.Add(this.comboBox2);
            this.gbHuurcontract.Location = new System.Drawing.Point(235, 178);
            this.gbHuurcontract.Name = "gbHuurcontract";
            this.gbHuurcontract.Size = new System.Drawing.Size(417, 430);
            this.gbHuurcontract.TabIndex = 2;
            this.gbHuurcontract.TabStop = false;
            this.gbHuurcontract.Text = "Nieuw Huurcontract";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(127, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(127, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(159, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(115, 95);
            this.listBox1.TabIndex = 19;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(159, 62);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(115, 95);
            this.listBox2.TabIndex = 18;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(6, 163);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(115, 95);
            this.listBox3.TabIndex = 17;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(6, 62);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(115, 95);
            this.listBox4.TabIndex = 16;
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
            this.tabPage1.ResumeLayout(false);
            this.tcLogin.ResumeLayout(false);
            this.tcLogin.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbActieRadius.ResumeLayout(false);
            this.gbActieRadius.PerformLayout();
            this.gbBudget.ResumeLayout(false);
            this.gbBudget.PerformLayout();
            this.gbHuurcontract.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tcLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblActieRadiusBoten;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lbHuurcontracten;
        private System.Windows.Forms.GroupBox gbNieuweKlant;
        private System.Windows.Forms.GroupBox gbHuurcontract;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
    }
}
