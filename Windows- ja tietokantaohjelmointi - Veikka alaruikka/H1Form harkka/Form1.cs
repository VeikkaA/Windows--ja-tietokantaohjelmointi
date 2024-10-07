using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H1Form_harkka
{
    public partial class Paaikkuna : Form
    {
        private int laskuri = 0;
        public Paaikkuna()
        {
            InitializeComponent();
            this.MouseClick += new MouseEventHandler(H1Form_MouseClick);
            this.MouseMove += new MouseEventHandler(H1Form_Move);
        }



        private void Paaikkuna_Load(object sender, EventArgs e)
        {
            //Tässä Paaikkunan otsikoksi laitetaan oma teksti ja tämän hetken 
            //päivämäärä ja aika. 
            this.Text = "Tervetuloa ohjelmaan! " + DateTime.Now;

            
        }
       
        private void H1Form_MouseClick(object sender, MouseEventArgs e)
        {

            //Tässä luodaan uusiIkkuna Form-olio
            Form uusiIkkuna = new Form();

            //Tässä määritellään uusiIkkunan otsikkoteksti;
            uusiIkkuna.Text = "Ikkuna " + ++laskuri;

            //Tässä määritellään uusiIkkunan taustaväri.
            uusiIkkuna.BackColor = Color.Aqua;

            //Tässä määritellään uusiIkkunan koko.
            uusiIkkuna.Size = new Size(250, 250);

            //Tässä määritellään uusiIkkunan sijainti suhteessa tietokoneruudun
            //vasempaan ylänurkkaan.
            uusiIkkuna.Location = new Point(50, 50);

            //Tässä uusIkkuna näytetään. Huomaa, että ilman seuraavaa riviä
            //uusiIkkunaa ei ilmestyisi käyttäjälle vaikka se olisikin 
            //olemassa tietokoneen muistissa.
            uusiIkkuna.Show();

        }
        private void H1Form_Move(object sender, EventArgs e)
        {

            //Tässä luodaan Random-olio satunnaislukujen generoimiseksi. 
            Random r = new Random();

            //Tässä luodaan Color-olio taustaVari, joka alustetaan Color-luokan
            //FromArgb()-metodilla, joka voidaan kutsua komella kokonaisluvulla,
            //jotka voivat olla 0-255 välillä. r.Next(256)-metodi luo vastaavat 
            //luvut satunnaisesti.
            Color taustaVari = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));

            //Tässä ikkunan taustaväriksi laitetaan äsken satunnaisesti määritelty väri. 
            this.BackColor = taustaVari;
        }


    }
}
