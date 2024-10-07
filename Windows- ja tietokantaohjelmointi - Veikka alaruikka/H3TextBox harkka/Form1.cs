using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3TextBox_harkka
{
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
        }

        private void Paaikkuna_Load(object sender, EventArgs e)
        {

        }
        private void lauseTekstikentta_TextChanged(object sender, EventArgs e)
        {
            //1 Tässä tekstikentän taustaväri muutetaan.
            lauseTekstikentta.BackColor = Color.SkyBlue;

            //Seuraavassa olisi toinen tapa selvittää tapahtuman
            //aiheuttajaa ja määritellä sen taustaväri ilman 
            //tekstikentän nimen käyttöä.

            //TextBox aktiiviTekstikentta = (TextBox)(sender);
            //aktiiviTekstikentta.BackColor = Color.SkyBlue;


            //Tässä arkistoTekstikentta:n taustaväriksi
            //laitetaan oletusväriin.
            arkistoTekstikentta.BackColor = Color.White;
        }
        private void arkistoTekstikentta_TextChanged(object sender, EventArgs e)
        {
            arkistoTekstikentta.BackColor = Color.Cyan;
        }
        private void kopiointiPainike_Click(object sender, EventArgs e)
        {
            //Tässä arkistoTekstikentta:n taustaväriä muutetaan.
            arkistoTekstikentta.BackColor = Color.SeaGreen;

            //Tässä lauseTekstikentta:n sisältö lisätään arkistoTekstikentta:n alkuun.
            arkistoTekstikentta.Text = lauseTekstikentta.Text + " " + arkistoTekstikentta.Text;

            //Tässä kutsutaan arkistoTekstikentta:n TextChanged()-tapahtumankäsittelijä,
            //joka muuttaa arkistoTekstikentta:n taustaväriä.
            arkistoTekstikentta_TextChanged(sender, e);
        }
        private void salausPainike_Click(object sender, EventArgs e)
        {

            //4Tässä tarkistetaan onko salausmerkki määritelty tekstikentälle.
            //Jos on, se poistetaan laittamalla tekstikentän salausmerkiksi
            //näin: '\0'. Toisaalta, jos tekstikentälle ei ole määritelty
            //salausmerkkiä, se määritellään.
            if (arkistoTekstikentta.PasswordChar == '*')
                arkistoTekstikentta.PasswordChar = '\0';
            else
                arkistoTekstikentta.PasswordChar = '*';

            //Tässä viittaus tapahtumanaiheuttajaan sender muunnetaan
            //Button-tyypiseksi ja sitten sen tekstiä muutetaan.
            ((Button)sender).Text = "Kumoa tekstin salaus";
        }





    }
}