using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursusetöö_Kont
{
    public partial class SK_Form1 : Form
    {
        private string[] arrWord = { "sämpsatus", "jallidus", "iletav", "kiuk", "nürbe", "hõllandus", "ilutsema", "tiiras", "jõõr", "hillitsema", "kihk", "äng", "vimm", "uje" };
        private string[] arrHint = { "segaseks minek (kohkumisest), kohkumus", "armukadedus", "vastik, jälk", "äge viha, ärritus", "tusane, pahane, haavatud", "igatsus, ihkamine, isu", "rõõmus olema, lõbutsema", "suguhimuline.", "himu, kiimalus.", "tagasi hoidma, taltsutama", "kirg, iha; lõikav valu, valuhoog", "rõhutud, surutud, kinnine olek, kitsikus", "kestev, küdev, kange viha", "kartlik, arglik" };
        private string currentWord;
        private string currentHint;
        private HashSet<char> guessedLetters = new HashSet<char>();
        private int mistakes = 0;
        private Random rand = new Random();

        public SK_Form1()
        {
            InitializeComponent();
            this.AcceptButton = SK_btnGuess; // Enter-klahv töötab
            StartNewGame();

        }

        private void SK_btnExcit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartNewGame()
        {
            int index = rand.Next(arrWord.Length);
            currentWord = arrWord[index].ToUpper();
            currentHint = arrHint[index];
            guessedLetters.Clear();
            mistakes = 0;

            UpdateWordDisplay();
            SK_lblGuesses.Text = "Pakkumised: ";
            SK_lblHint.Text = "";
            SK_picHangman.Image = Properties.Resources.hangman_0;

            SK_txtLetter.Focus();

            SK_btnHint.Enabled = true;

            SK_panelEndGame.Visible = false;
        }

        private void UpdateWordDisplay()
        {
            SK_lblWord.Text = string.Join(" ", currentWord.Select(c => guessedLetters.Contains(c) ? c.ToString() : "_"));
        }

        private void SK_btnGuess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SK_txtLetter.Text))
            {
                return; // Ei tee midagi, kui sisend on tühi
            }

            if (SK_txtLetter.Text.Length != 1 || !char.IsLetter(SK_txtLetter.Text[0]))
            {
                MessageBox.Show("Palun sisesta ainult tähti, üks täht korraga!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SK_txtLetter.Clear(); // Tühjendame sisendi, et kasutaja saaks õigesti sisestada
                return;
            }

            char letter = char.ToUpper(SK_txtLetter.Text[0]);
            SK_txtLetter.Text = "";

            if (guessedLetters.Contains(letter)) return;

            guessedLetters.Add(letter);
            SK_lblGuesses.Text = "Juba pakutud: " + string.Join(", ", guessedLetters);

            if (!currentWord.Contains(letter))
            {
                mistakes++;
                UpdateHangmanImage();
            }

            UpdateWordDisplay();

            if (!SK_lblWord.Text.Contains("_"))
            {
                // Kui sõna on ära arvatud, kuvame võidu ekraani
                ShowEndGameScreen(true);
            }
            else if (mistakes >= 6)
            {
                // Kui vigu on 6, kuvame kaotuse ekraani
                ShowEndGameScreen(false);
            }


            // Viime kursori tagasi tekstikasti
            SK_txtLetter.Focus();
        }

        private void SK_Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = SK_btnGuess; // Enter-klahv käivitab nuppu
            SK_txtLetter.Focus(); // Veendume, et kursor on tekstikastis
        }



        private void SK_btnHint_Click(object sender, EventArgs e)
        {
            SK_lblHint.Text = "Sõna tähendus on: " + currentHint;
            SK_btnHint.Enabled = false;
        }

        private void UpdateHangmanImage()
        {
            if (mistakes >= 0 && mistakes <= 6)
            {
                string resourceName = $"hangman-{mistakes}";
                SK_picHangman.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName);
            }
        }

        private void SK_btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void ShowEndGameScreen(bool isWin)
        {
            // Kuvame mängu lõpu paneeli
            SK_panelEndGame.Visible = true;

            if (isWin)
            {
                SK_lblEndGameText.Text = "PALJU ÕNNE! SA VÕITSID!";
                SK_picEndGame.Image = Properties.Resources.rõõmus; // Võidu pilt
            }
            else
            {
                SK_lblEndGameText.Text = $"KAHJUKS KAOTASID... ÕIGE SÕNA OLI: {currentWord}";
                SK_picEndGame.Image = Properties.Resources.kurb; // Kaotuse pilt
            }
        }

    }
}
