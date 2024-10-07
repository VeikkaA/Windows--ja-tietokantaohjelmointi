using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2Button_harkka
{
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
            this.MouseClick += new MouseEventHandler(ekaPainike_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ekaPainike_Click(object sender, EventArgs e)
        {
            //1 Seuraavassa tarkistetaan onko tokaPainike näkyvissä 
            //vai ei. Jos se on näkyvissä, suoritetaan toisenlaiset
            //toimenpiteet, kuin jos se ei ole näkyvissä.
            if (tokaPainike.Visible)
            {
                //Tässä tokaPainike piilotetaan.
                tokaPainike.Visible = false;

                //Tässä suoritetaan tyyppimuunnos ja sen jälkeen 
                //ekaPainike:n teksti muutetaan.
                ((Button)sender).Text = "Näytä Painike 2";

                //Tässä pääikkunan taustaväri muutetaan.
                this.BackColor = Color.CadetBlue;
            }
            else
            {
                //Tässä tokaPainike saadan näkyviin jos se on piilossa.
                tokaPainike.Visible = true;

                //Tässä suoritetaan tyyppimuunnos ja sen jälkeen 
                //ekaPainike:n teksti muutetaan.
                ((Button)sender).Text = "Piilota Painike 2";

                //Tässä pääikkunan taustaväri muutetaan.
                this.BackColor = Color.Coral;
            }
            

        }
        private void tokaPainike_Click(object sender, EventArgs e)
        {
            //2 Tässä sovelluksen varaamat resurssit vapautetaan.
            this.Dispose();
        }
        private void tokaPainike_MouseHover(object sender, EventArgs e)
        {
            //3 Tässä tokaPainike:n taustaväri muutetaan. Huomaa, että
            //tässä painikkeeseen viitataan suoraan sen nimellä.
            tokaPainike.BackColor = Color.DeepSkyBlue;
        }
        private void tokaPainike_MouseLeave(object sender, EventArgs e)
        {

            //4 Tässä tokaPainike:n taustaväri muutetaan. Huomaa, että
            //tässä painikkeeseen viitataan suorittamalla tyyppimuunnosta
            //sender-oliolla.
            ((Button)sender).BackColor = Color.DeepPink;
        }




    }
}
