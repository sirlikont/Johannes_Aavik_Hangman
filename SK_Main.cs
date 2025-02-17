using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursusetöö_Kont
{
    public partial class SK_Main : Form
    {
        public SK_Main()
        {
            InitializeComponent();
            this.Load += SK_Main_Load; // Seome sündmuse

        }

        private void SK_Main_Load(object sender, EventArgs e)
        {
            SK_pic1.Image = Properties.Resources.johannes_aavik_vaike;

            SK_lblDescription.Text = "Johannes Aavik (1880–1973) oli eesti keeleteadlane, kirjanik ja pedagoog, " +
            "kes mängis olulist rolli eesti keele uuendamisel ja moderniseerimisel. " +
            "Ta oli üks silmapaistvamaid keeleuuendajaid, kes püüdis muuta eesti keelt väljendusrikkamaks ja kaunimaks." +
            "\r\n\r\nAavik tutvustas palju uusi sõnu ja grammatilisi vorme, millest paljud on tänapäeva eesti keeles omaks võetud." +
            "\r\n\r\n Selles mängus saad ära arvata Johannes Aaviku välja mõeldud sõnu. " +
            "Vajadusel küsi vihjet - saad teada sõna tähenduse. " +
            "Mäng on nagu poomismäng ikka - saad eksida kuni 6 korda. " +
            "\r\n\r\nEdu!";
        }

        private void SK_btnPlay_Click(object sender, EventArgs e)
        {
            SK_Form1 gameForm = new SK_Form1();
            gameForm.Show();
            this.Hide();
        }

        private void SK_btnExcit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
