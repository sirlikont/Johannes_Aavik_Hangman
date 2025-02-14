namespace Kursusetöö_Kont
{
    partial class SK_Form1
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
            this.SK_lblHangman2 = new System.Windows.Forms.Label();
            this.SK_lblWord = new System.Windows.Forms.Label();
            this.SK_picHangman = new System.Windows.Forms.PictureBox();
            this.SK_lblGuesses = new System.Windows.Forms.Label();
            this.SK_txtLetter = new System.Windows.Forms.TextBox();
            this.SK_btnGuess = new System.Windows.Forms.Button();
            this.SK_btnHint = new System.Windows.Forms.Button();
            this.SK_lblHint = new System.Windows.Forms.Label();
            this.SK_btnExcit = new System.Windows.Forms.Button();
            this.SK_btnNewGame = new System.Windows.Forms.Button();
            this.SK_panelEndGame = new System.Windows.Forms.Panel();
            this.SK_picEndGame = new System.Windows.Forms.PictureBox();
            this.SK_lblEndGameText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SK_picHangman)).BeginInit();
            this.SK_panelEndGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SK_picEndGame)).BeginInit();
            this.SuspendLayout();
            // 
            // SK_lblHangman2
            // 
            this.SK_lblHangman2.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_lblHangman2.Location = new System.Drawing.Point(235, 47);
            this.SK_lblHangman2.Name = "SK_lblHangman2";
            this.SK_lblHangman2.Size = new System.Drawing.Size(655, 50);
            this.SK_lblHangman2.TabIndex = 16;
            this.SK_lblHangman2.Text = "JOHANNES AAVIKU SÕNAMÄNG";
            this.SK_lblHangman2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SK_lblWord
            // 
            this.SK_lblWord.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_lblWord.Location = new System.Drawing.Point(215, 170);
            this.SK_lblWord.Name = "SK_lblWord";
            this.SK_lblWord.Size = new System.Drawing.Size(355, 50);
            this.SK_lblWord.TabIndex = 17;
            this.SK_lblWord.Text = "SIIN ON SÕNA";
            this.SK_lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SK_picHangman
            // 
            this.SK_picHangman.Image = global::Kursusetöö_Kont.Properties.Resources.hangman_0;
            this.SK_picHangman.Location = new System.Drawing.Point(598, 147);
            this.SK_picHangman.Name = "SK_picHangman";
            this.SK_picHangman.Size = new System.Drawing.Size(388, 380);
            this.SK_picHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SK_picHangman.TabIndex = 18;
            this.SK_picHangman.TabStop = false;
            // 
            // SK_lblGuesses
            // 
            this.SK_lblGuesses.Location = new System.Drawing.Point(159, 267);
            this.SK_lblGuesses.Name = "SK_lblGuesses";
            this.SK_lblGuesses.Size = new System.Drawing.Size(433, 30);
            this.SK_lblGuesses.TabIndex = 20;
            this.SK_lblGuesses.Text = "Siin on arvatud tähed";
            this.SK_lblGuesses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SK_txtLetter
            // 
            this.SK_txtLetter.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_txtLetter.Location = new System.Drawing.Point(291, 336);
            this.SK_txtLetter.Name = "SK_txtLetter";
            this.SK_txtLetter.Size = new System.Drawing.Size(70, 53);
            this.SK_txtLetter.TabIndex = 21;
            // 
            // SK_btnGuess
            // 
            this.SK_btnGuess.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SK_btnGuess.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_btnGuess.ForeColor = System.Drawing.SystemColors.Control;
            this.SK_btnGuess.Location = new System.Drawing.Point(389, 336);
            this.SK_btnGuess.Name = "SK_btnGuess";
            this.SK_btnGuess.Size = new System.Drawing.Size(175, 53);
            this.SK_btnGuess.TabIndex = 22;
            this.SK_btnGuess.Text = "Pakun";
            this.SK_btnGuess.UseVisualStyleBackColor = false;
            this.SK_btnGuess.Click += new System.EventHandler(this.SK_btnGuess_Click);
            // 
            // SK_btnHint
            // 
            this.SK_btnHint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SK_btnHint.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_btnHint.ForeColor = System.Drawing.SystemColors.Control;
            this.SK_btnHint.Location = new System.Drawing.Point(352, 413);
            this.SK_btnHint.Name = "SK_btnHint";
            this.SK_btnHint.Size = new System.Drawing.Size(212, 53);
            this.SK_btnHint.TabIndex = 24;
            this.SK_btnHint.Text = "Anna vihje!";
            this.SK_btnHint.UseVisualStyleBackColor = false;
            this.SK_btnHint.Click += new System.EventHandler(this.SK_btnHint_Click);
            // 
            // SK_lblHint
            // 
            this.SK_lblHint.Location = new System.Drawing.Point(154, 498);
            this.SK_lblHint.Name = "SK_lblHint";
            this.SK_lblHint.Size = new System.Drawing.Size(425, 62);
            this.SK_lblHint.TabIndex = 25;
            this.SK_lblHint.Text = "Siia tuleb vihje kui küsida";
            this.SK_lblHint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SK_btnExcit
            // 
            this.SK_btnExcit.BackColor = System.Drawing.Color.LightCoral;
            this.SK_btnExcit.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_btnExcit.ForeColor = System.Drawing.SystemColors.Control;
            this.SK_btnExcit.Location = new System.Drawing.Point(597, 578);
            this.SK_btnExcit.Name = "SK_btnExcit";
            this.SK_btnExcit.Size = new System.Drawing.Size(188, 53);
            this.SK_btnExcit.TabIndex = 27;
            this.SK_btnExcit.Text = "Välju";
            this.SK_btnExcit.UseVisualStyleBackColor = false;
            this.SK_btnExcit.Click += new System.EventHandler(this.SK_btnExcit_Click);
            // 
            // SK_btnNewGame
            // 
            this.SK_btnNewGame.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SK_btnNewGame.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_btnNewGame.ForeColor = System.Drawing.SystemColors.Control;
            this.SK_btnNewGame.Location = new System.Drawing.Point(352, 578);
            this.SK_btnNewGame.Name = "SK_btnNewGame";
            this.SK_btnNewGame.Size = new System.Drawing.Size(218, 53);
            this.SK_btnNewGame.TabIndex = 26;
            this.SK_btnNewGame.Text = "Uus mäng";
            this.SK_btnNewGame.UseVisualStyleBackColor = false;
            this.SK_btnNewGame.Click += new System.EventHandler(this.SK_btnNewGame_Click);
            // 
            // SK_panelEndGame
            // 
            this.SK_panelEndGame.Controls.Add(this.SK_lblEndGameText);
            this.SK_panelEndGame.Controls.Add(this.SK_picEndGame);
            this.SK_panelEndGame.Location = new System.Drawing.Point(119, 245);
            this.SK_panelEndGame.Name = "SK_panelEndGame";
            this.SK_panelEndGame.Size = new System.Drawing.Size(460, 315);
            this.SK_panelEndGame.TabIndex = 28;
            // 
            // SK_picEndGame
            // 
            this.SK_picEndGame.Location = new System.Drawing.Point(160, 0);
            this.SK_picEndGame.Name = "SK_picEndGame";
            this.SK_picEndGame.Size = new System.Drawing.Size(300, 200);
            this.SK_picEndGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SK_picEndGame.TabIndex = 0;
            this.SK_picEndGame.TabStop = false;
            // 
            // SK_lblEndGameText
            // 
            this.SK_lblEndGameText.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_lblEndGameText.Location = new System.Drawing.Point(3, 213);
            this.SK_lblEndGameText.Name = "SK_lblEndGameText";
            this.SK_lblEndGameText.Size = new System.Drawing.Size(457, 69);
            this.SK_lblEndGameText.TabIndex = 1;
            this.SK_lblEndGameText.Text = "Siia tuleb mängu lõpu tekst";
            this.SK_lblEndGameText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SK_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 675);
            this.Controls.Add(this.SK_panelEndGame);
            this.Controls.Add(this.SK_btnExcit);
            this.Controls.Add(this.SK_btnNewGame);
            this.Controls.Add(this.SK_lblHint);
            this.Controls.Add(this.SK_btnHint);
            this.Controls.Add(this.SK_btnGuess);
            this.Controls.Add(this.SK_txtLetter);
            this.Controls.Add(this.SK_lblGuesses);
            this.Controls.Add(this.SK_picHangman);
            this.Controls.Add(this.SK_lblWord);
            this.Controls.Add(this.SK_lblHangman2);
            this.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SK_Form1";
            this.Text = "SK_Form1";
            this.Load += new System.EventHandler(this.SK_btnGuess_Click);
            ((System.ComponentModel.ISupportInitialize)(this.SK_picHangman)).EndInit();
            this.SK_panelEndGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SK_picEndGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SK_lblHangman2;
        private System.Windows.Forms.Label SK_lblWord;
        private System.Windows.Forms.PictureBox SK_picHangman;
        private System.Windows.Forms.Label SK_lblGuesses;
        private System.Windows.Forms.TextBox SK_txtLetter;
        private System.Windows.Forms.Button SK_btnGuess;
        private System.Windows.Forms.Button SK_btnHint;
        private System.Windows.Forms.Label SK_lblHint;
        private System.Windows.Forms.Button SK_btnExcit;
        private System.Windows.Forms.Button SK_btnNewGame;
        private System.Windows.Forms.Panel SK_panelEndGame;
        private System.Windows.Forms.PictureBox SK_picEndGame;
        private System.Windows.Forms.Label SK_lblEndGameText;
    }
}