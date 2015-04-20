﻿namespace ICT4Events
{
    partial class ReserveringSysteem
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
            this.pbCampingPlaces = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAankomst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.dtpAankomst = new System.Windows.Forms.DateTimePicker();
            this.dtpVertrek = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPlaces = new System.Windows.Forms.ComboBox();
            this.gb_gebruikercreatie = new System.Windows.Forms.GroupBox();
            this.cB_Reservation_ID_User = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_achternaam_user = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_password_gebruiker = new System.Windows.Forms.TextBox();
            this.btn_Confirm_user = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_loginname_gebruiker = new System.Windows.Forms.TextBox();
            this.tb_username_gebruiker = new System.Windows.Forms.TextBox();
            this.lb_Username_gebruiker = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_telnr_gebruiker = new System.Windows.Forms.TextBox();
            this.lb_addres_stad_gebruiker = new System.Windows.Forms.Label();
            this.tb_stad_user = new System.Windows.Forms.TextBox();
            this.tb_number_user = new System.Windows.Forms.TextBox();
            this.lb_addres_nummer_gebruiker = new System.Windows.Forms.Label();
            this.lb_addres_straat_gebruiker = new System.Windows.Forms.Label();
            this.tb_straat_user = new System.Windows.Forms.TextBox();
            this.cb_land_gebruiker = new System.Windows.Forms.ComboBox();
            this.lb_land_gebruiker = new System.Windows.Forms.Label();
            this.tb_email_gebruiker = new System.Windows.Forms.TextBox();
            this.lb_email_gebruiker = new System.Windows.Forms.Label();
            this.dtp_geboortedatum_gebruiker = new System.Windows.Forms.DateTimePicker();
            this.lb_geboortedatum_gebruiker = new System.Windows.Forms.Label();
            this.lb_naam_gebruiker = new System.Windows.Forms.Label();
            this.tb_voornaam_gebruiker = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPersonsAmount = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCampingPlaces)).BeginInit();
            this.gb_gebruikercreatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCampingPlaces
            // 
            this.pbCampingPlaces.Image = global::ICT4Events.Properties.Resources.Camping_ReeënDal;
            this.pbCampingPlaces.Location = new System.Drawing.Point(447, 79);
            this.pbCampingPlaces.Name = "pbCampingPlaces";
            this.pbCampingPlaces.Size = new System.Drawing.Size(938, 862);
            this.pbCampingPlaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCampingPlaces.TabIndex = 0;
            this.pbCampingPlaces.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kies een event:";
            // 
            // lblAankomst
            // 
            this.lblAankomst.AutoSize = true;
            this.lblAankomst.Location = new System.Drawing.Point(12, 53);
            this.lblAankomst.Name = "lblAankomst";
            this.lblAankomst.Size = new System.Drawing.Size(57, 13);
            this.lblAankomst.TabIndex = 2;
            this.lblAankomst.Text = "Aankomst:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vertrek:";
            // 
            // cbEvents
            // 
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(113, 29);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(200, 21);
            this.cbEvents.TabIndex = 4;
            this.cbEvents.SelectedValueChanged += new System.EventHandler(this.cbEvents_SelectedValueChanged);
            // 
            // dtpAankomst
            // 
            this.dtpAankomst.Location = new System.Drawing.Point(113, 53);
            this.dtpAankomst.Name = "dtpAankomst";
            this.dtpAankomst.Size = new System.Drawing.Size(200, 20);
            this.dtpAankomst.TabIndex = 5;
            // 
            // dtpVertrek
            // 
            this.dtpVertrek.Location = new System.Drawing.Point(113, 79);
            this.dtpVertrek.Name = "dtpVertrek";
            this.dtpVertrek.Size = new System.Drawing.Size(200, 20);
            this.dtpVertrek.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kies een plaats:";
            // 
            // cbPlaces
            // 
            this.cbPlaces.FormattingEnabled = true;
            this.cbPlaces.Location = new System.Drawing.Point(113, 116);
            this.cbPlaces.Name = "cbPlaces";
            this.cbPlaces.Size = new System.Drawing.Size(200, 21);
            this.cbPlaces.TabIndex = 8;
            // 
            // gb_gebruikercreatie
            // 
            this.gb_gebruikercreatie.Controls.Add(this.cB_Reservation_ID_User);
            this.gb_gebruikercreatie.Controls.Add(this.label12);
            this.gb_gebruikercreatie.Controls.Add(this.tb_achternaam_user);
            this.gb_gebruikercreatie.Controls.Add(this.label9);
            this.gb_gebruikercreatie.Controls.Add(this.tb_password_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.btn_Confirm_user);
            this.gb_gebruikercreatie.Controls.Add(this.label4);
            this.gb_gebruikercreatie.Controls.Add(this.label5);
            this.gb_gebruikercreatie.Controls.Add(this.tb_loginname_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.tb_username_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.lb_Username_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.label6);
            this.gb_gebruikercreatie.Controls.Add(this.tb_telnr_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.lb_addres_stad_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.tb_stad_user);
            this.gb_gebruikercreatie.Controls.Add(this.tb_number_user);
            this.gb_gebruikercreatie.Controls.Add(this.lb_addres_nummer_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.lb_addres_straat_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.tb_straat_user);
            this.gb_gebruikercreatie.Controls.Add(this.cb_land_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.lb_land_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.tb_email_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.lb_email_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.dtp_geboortedatum_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.lb_geboortedatum_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.lb_naam_gebruiker);
            this.gb_gebruikercreatie.Controls.Add(this.tb_voornaam_gebruiker);
            this.gb_gebruikercreatie.Enabled = false;
            this.gb_gebruikercreatie.Location = new System.Drawing.Point(15, 223);
            this.gb_gebruikercreatie.Name = "gb_gebruikercreatie";
            this.gb_gebruikercreatie.Size = new System.Drawing.Size(426, 332);
            this.gb_gebruikercreatie.TabIndex = 9;
            this.gb_gebruikercreatie.TabStop = false;
            this.gb_gebruikercreatie.Text = "User Create / Change";
            // 
            // cB_Reservation_ID_User
            // 
            this.cB_Reservation_ID_User.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cB_Reservation_ID_User.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cB_Reservation_ID_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Reservation_ID_User.FormattingEnabled = true;
            this.cB_Reservation_ID_User.Location = new System.Drawing.Point(96, 19);
            this.cB_Reservation_ID_User.Name = "cB_Reservation_ID_User";
            this.cB_Reservation_ID_User.Size = new System.Drawing.Size(141, 21);
            this.cB_Reservation_ID_User.Sorted = true;
            this.cB_Reservation_ID_User.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Reservation_ID";
            // 
            // tb_achternaam_user
            // 
            this.tb_achternaam_user.Location = new System.Drawing.Point(275, 44);
            this.tb_achternaam_user.Name = "tb_achternaam_user";
            this.tb_achternaam_user.Size = new System.Drawing.Size(145, 20);
            this.tb_achternaam_user.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Last Name:";
            // 
            // tb_password_gebruiker
            // 
            this.tb_password_gebruiker.Location = new System.Drawing.Point(95, 272);
            this.tb_password_gebruiker.MaxLength = 255;
            this.tb_password_gebruiker.Name = "tb_password_gebruiker";
            this.tb_password_gebruiker.ShortcutsEnabled = false;
            this.tb_password_gebruiker.Size = new System.Drawing.Size(325, 20);
            this.tb_password_gebruiker.TabIndex = 19;
            this.tb_password_gebruiker.UseSystemPasswordChar = true;
            // 
            // btn_Confirm_user
            // 
            this.btn_Confirm_user.Location = new System.Drawing.Point(345, 298);
            this.btn_Confirm_user.Name = "btn_Confirm_user";
            this.btn_Confirm_user.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm_user.TabIndex = 4;
            this.btn_Confirm_user.Text = "Confirm";
            this.btn_Confirm_user.UseVisualStyleBackColor = true;
            this.btn_Confirm_user.Click += new System.EventHandler(this.btn_Confirm_user_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Loginname:";
            // 
            // tb_loginname_gebruiker
            // 
            this.tb_loginname_gebruiker.Location = new System.Drawing.Point(96, 220);
            this.tb_loginname_gebruiker.MaxLength = 17;
            this.tb_loginname_gebruiker.Name = "tb_loginname_gebruiker";
            this.tb_loginname_gebruiker.Size = new System.Drawing.Size(324, 20);
            this.tb_loginname_gebruiker.TabIndex = 17;
            // 
            // tb_username_gebruiker
            // 
            this.tb_username_gebruiker.Location = new System.Drawing.Point(95, 246);
            this.tb_username_gebruiker.MaxLength = 255;
            this.tb_username_gebruiker.Name = "tb_username_gebruiker";
            this.tb_username_gebruiker.Size = new System.Drawing.Size(325, 20);
            this.tb_username_gebruiker.TabIndex = 18;
            // 
            // lb_Username_gebruiker
            // 
            this.lb_Username_gebruiker.AutoSize = true;
            this.lb_Username_gebruiker.Location = new System.Drawing.Point(7, 249);
            this.lb_Username_gebruiker.Name = "lb_Username_gebruiker";
            this.lb_Username_gebruiker.Size = new System.Drawing.Size(58, 13);
            this.lb_Username_gebruiker.TabIndex = 18;
            this.lb_Username_gebruiker.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tel.Nr:";
            // 
            // tb_telnr_gebruiker
            // 
            this.tb_telnr_gebruiker.Location = new System.Drawing.Point(95, 194);
            this.tb_telnr_gebruiker.MaxLength = 20;
            this.tb_telnr_gebruiker.Name = "tb_telnr_gebruiker";
            this.tb_telnr_gebruiker.Size = new System.Drawing.Size(325, 20);
            this.tb_telnr_gebruiker.TabIndex = 16;
            // 
            // lb_addres_stad_gebruiker
            // 
            this.lb_addres_stad_gebruiker.AutoSize = true;
            this.lb_addres_stad_gebruiker.Location = new System.Drawing.Point(46, 171);
            this.lb_addres_stad_gebruiker.Name = "lb_addres_stad_gebruiker";
            this.lb_addres_stad_gebruiker.Size = new System.Drawing.Size(29, 13);
            this.lb_addres_stad_gebruiker.TabIndex = 13;
            this.lb_addres_stad_gebruiker.Text = "Stad";
            // 
            // tb_stad_user
            // 
            this.tb_stad_user.Location = new System.Drawing.Point(95, 168);
            this.tb_stad_user.MaxLength = 255;
            this.tb_stad_user.Name = "tb_stad_user";
            this.tb_stad_user.Size = new System.Drawing.Size(178, 20);
            this.tb_stad_user.TabIndex = 12;
            // 
            // tb_number_user
            // 
            this.tb_number_user.Location = new System.Drawing.Point(332, 146);
            this.tb_number_user.MaxLength = 10;
            this.tb_number_user.Name = "tb_number_user";
            this.tb_number_user.Size = new System.Drawing.Size(88, 20);
            this.tb_number_user.TabIndex = 11;
            // 
            // lb_addres_nummer_gebruiker
            // 
            this.lb_addres_nummer_gebruiker.AutoSize = true;
            this.lb_addres_nummer_gebruiker.Location = new System.Drawing.Point(281, 149);
            this.lb_addres_nummer_gebruiker.Name = "lb_addres_nummer_gebruiker";
            this.lb_addres_nummer_gebruiker.Size = new System.Drawing.Size(44, 13);
            this.lb_addres_nummer_gebruiker.TabIndex = 10;
            this.lb_addres_nummer_gebruiker.Text = "Number";
            // 
            // lb_addres_straat_gebruiker
            // 
            this.lb_addres_straat_gebruiker.AutoSize = true;
            this.lb_addres_straat_gebruiker.Location = new System.Drawing.Point(7, 145);
            this.lb_addres_straat_gebruiker.Name = "lb_addres_straat_gebruiker";
            this.lb_addres_straat_gebruiker.Size = new System.Drawing.Size(74, 13);
            this.lb_addres_straat_gebruiker.TabIndex = 9;
            this.lb_addres_straat_gebruiker.Text = "Addres: Street";
            // 
            // tb_straat_user
            // 
            this.tb_straat_user.Location = new System.Drawing.Point(96, 142);
            this.tb_straat_user.MaxLength = 255;
            this.tb_straat_user.Name = "tb_straat_user";
            this.tb_straat_user.Size = new System.Drawing.Size(179, 20);
            this.tb_straat_user.TabIndex = 8;
            // 
            // cb_land_gebruiker
            // 
            this.cb_land_gebruiker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_land_gebruiker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_land_gebruiker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_land_gebruiker.FormattingEnabled = true;
            this.cb_land_gebruiker.Items.AddRange(new object[] {
            "Alandseilanden",
            "Albanië",
            "Andorra",
            "Azerbeidzjan",
            "Belarus (Wit-Rusland)",
            "België",
            "Bosnië en Herzegovina",
            "Bulgarije",
            "Cyprus",
            "Denemarken",
            "Duitsland",
            "Engeland (Verenigd Koningrijk)",
            "Estland",
            "Farao Eilanden",
            "Finland",
            "Frankrijk",
            "Georgië",
            "Gibraltar",
            "Griekenland",
            "Guernsey",
            "Hongarije",
            "Ierland",
            "IJsland",
            "Italië",
            "Jan Mayen",
            "Jersey",
            "Kazachstan",
            "Kosovo",
            "Kroatië",
            "Letland",
            "Liechtenstein",
            "Litouwen",
            "Luxemburg",
            "Macedonië",
            "Malta",
            "Man",
            "Moldavië",
            "Monaco",
            "Montenegro",
            "Nederland",
            "Noorwegen",
            "Oekraïne",
            "Oostenrijk",
            "Polen",
            "Portugal",
            "Roemenië",
            "Rusland",
            "San Marino",
            "Schotland (Verenigd Koninkrijk)",
            "Servië",
            "Slovenië",
            "Slowakije",
            "Spanje",
            "Spitsbergen",
            "Tsjechië",
            "Turkije",
            "Vaticaanstad",
            "Zweden",
            "Zwitserland"});
            this.cb_land_gebruiker.Location = new System.Drawing.Point(96, 118);
            this.cb_land_gebruiker.Name = "cb_land_gebruiker";
            this.cb_land_gebruiker.Size = new System.Drawing.Size(324, 21);
            this.cb_land_gebruiker.Sorted = true;
            this.cb_land_gebruiker.TabIndex = 7;
            // 
            // lb_land_gebruiker
            // 
            this.lb_land_gebruiker.AutoSize = true;
            this.lb_land_gebruiker.Location = new System.Drawing.Point(7, 118);
            this.lb_land_gebruiker.Name = "lb_land_gebruiker";
            this.lb_land_gebruiker.Size = new System.Drawing.Size(46, 13);
            this.lb_land_gebruiker.TabIndex = 6;
            this.lb_land_gebruiker.Text = "Country:";
            // 
            // tb_email_gebruiker
            // 
            this.tb_email_gebruiker.Location = new System.Drawing.Point(96, 93);
            this.tb_email_gebruiker.MaxLength = 255;
            this.tb_email_gebruiker.Name = "tb_email_gebruiker";
            this.tb_email_gebruiker.Size = new System.Drawing.Size(324, 20);
            this.tb_email_gebruiker.TabIndex = 5;
            // 
            // lb_email_gebruiker
            // 
            this.lb_email_gebruiker.AutoSize = true;
            this.lb_email_gebruiker.Location = new System.Drawing.Point(7, 96);
            this.lb_email_gebruiker.Name = "lb_email_gebruiker";
            this.lb_email_gebruiker.Size = new System.Drawing.Size(39, 13);
            this.lb_email_gebruiker.TabIndex = 4;
            this.lb_email_gebruiker.Text = "E-Mail:";
            // 
            // dtp_geboortedatum_gebruiker
            // 
            this.dtp_geboortedatum_gebruiker.Location = new System.Drawing.Point(96, 68);
            this.dtp_geboortedatum_gebruiker.Name = "dtp_geboortedatum_gebruiker";
            this.dtp_geboortedatum_gebruiker.Size = new System.Drawing.Size(324, 20);
            this.dtp_geboortedatum_gebruiker.TabIndex = 3;
            this.dtp_geboortedatum_gebruiker.Value = new System.DateTime(2015, 4, 17, 9, 46, 0, 0);
            // 
            // lb_geboortedatum_gebruiker
            // 
            this.lb_geboortedatum_gebruiker.AutoSize = true;
            this.lb_geboortedatum_gebruiker.Location = new System.Drawing.Point(7, 74);
            this.lb_geboortedatum_gebruiker.Name = "lb_geboortedatum_gebruiker";
            this.lb_geboortedatum_gebruiker.Size = new System.Drawing.Size(52, 13);
            this.lb_geboortedatum_gebruiker.TabIndex = 2;
            this.lb_geboortedatum_gebruiker.Text = "Birthdate:";
            // 
            // lb_naam_gebruiker
            // 
            this.lb_naam_gebruiker.AutoSize = true;
            this.lb_naam_gebruiker.Location = new System.Drawing.Point(6, 47);
            this.lb_naam_gebruiker.Name = "lb_naam_gebruiker";
            this.lb_naam_gebruiker.Size = new System.Drawing.Size(60, 13);
            this.lb_naam_gebruiker.TabIndex = 1;
            this.lb_naam_gebruiker.Text = "First Name:";
            // 
            // tb_voornaam_gebruiker
            // 
            this.tb_voornaam_gebruiker.Location = new System.Drawing.Point(96, 45);
            this.tb_voornaam_gebruiker.MaxLength = 255;
            this.tb_voornaam_gebruiker.Name = "tb_voornaam_gebruiker";
            this.tb_voornaam_gebruiker.Size = new System.Drawing.Size(100, 20);
            this.tb_voornaam_gebruiker.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Aantal personen";
            // 
            // cbPersonsAmount
            // 
            this.cbPersonsAmount.FormattingEnabled = true;
            this.cbPersonsAmount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbPersonsAmount.Location = new System.Drawing.Point(113, 155);
            this.cbPersonsAmount.Name = "cbPersonsAmount";
            this.cbPersonsAmount.Size = new System.Drawing.Size(200, 21);
            this.cbPersonsAmount.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReserveringSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 819);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPersonsAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gb_gebruikercreatie);
            this.Controls.Add(this.cbPlaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpVertrek);
            this.Controls.Add(this.dtpAankomst);
            this.Controls.Add(this.cbEvents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAankomst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCampingPlaces);
            this.Name = "ReserveringSysteem";
            this.Text = "ReserveringSysteem";
            ((System.ComponentModel.ISupportInitialize)(this.pbCampingPlaces)).EndInit();
            this.gb_gebruikercreatie.ResumeLayout(false);
            this.gb_gebruikercreatie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCampingPlaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAankomst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.DateTimePicker dtpAankomst;
        private System.Windows.Forms.DateTimePicker dtpVertrek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPlaces;
        private System.Windows.Forms.GroupBox gb_gebruikercreatie;
        private System.Windows.Forms.ComboBox cB_Reservation_ID_User;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_achternaam_user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_password_gebruiker;
        private System.Windows.Forms.Button btn_Confirm_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_loginname_gebruiker;
        private System.Windows.Forms.TextBox tb_username_gebruiker;
        private System.Windows.Forms.Label lb_Username_gebruiker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_telnr_gebruiker;
        private System.Windows.Forms.Label lb_addres_stad_gebruiker;
        private System.Windows.Forms.TextBox tb_stad_user;
        private System.Windows.Forms.TextBox tb_number_user;
        private System.Windows.Forms.Label lb_addres_nummer_gebruiker;
        private System.Windows.Forms.Label lb_addres_straat_gebruiker;
        private System.Windows.Forms.TextBox tb_straat_user;
        private System.Windows.Forms.ComboBox cb_land_gebruiker;
        private System.Windows.Forms.Label lb_land_gebruiker;
        private System.Windows.Forms.TextBox tb_email_gebruiker;
        private System.Windows.Forms.Label lb_email_gebruiker;
        private System.Windows.Forms.DateTimePicker dtp_geboortedatum_gebruiker;
        private System.Windows.Forms.Label lb_geboortedatum_gebruiker;
        private System.Windows.Forms.Label lb_naam_gebruiker;
        private System.Windows.Forms.TextBox tb_voornaam_gebruiker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPersonsAmount;
        private System.Windows.Forms.Button button1;
    }
}