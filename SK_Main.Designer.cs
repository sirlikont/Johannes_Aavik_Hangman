namespace Kursusetöö_Kont
{
    partial class SK_Main
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
            this.SK_lblHangman = new System.Windows.Forms.Label();
            this.SK_lblDescription = new System.Windows.Forms.Label();
            this.SK_btnExcit = new System.Windows.Forms.Button();
            this.SK_btnPlay = new System.Windows.Forms.Button();
            this.SK_pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SK_pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // SK_lblHangman
            // 
            this.SK_lblHangman.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_lblHangman.Location = new System.Drawing.Point(239, 45);
            this.SK_lblHangman.Name = "SK_lblHangman";
            this.SK_lblHangman.Size = new System.Drawing.Size(655, 50);
            this.SK_lblHangman.TabIndex = 16;
            this.SK_lblHangman.Text = "JOHANNES AAVIKU SÕNAMÄNG";
            this.SK_lblHangman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SK_lblDescription
            // 
            this.SK_lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SK_lblDescription.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_lblDescription.Location = new System.Drawing.Point(465, 126);
            this.SK_lblDescription.Name = "SK_lblDescription";
            this.SK_lblDescription.Size = new System.Drawing.Size(543, 421);
            this.SK_lblDescription.TabIndex = 15;
            this.SK_lblDescription.Text = "label1";
            this.SK_lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SK_btnExcit
            // 
            this.SK_btnExcit.BackColor = System.Drawing.Color.LightCoral;
            this.SK_btnExcit.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_btnExcit.ForeColor = System.Drawing.SystemColors.Control;
            this.SK_btnExcit.Location = new System.Drawing.Point(791, 567);
            this.SK_btnExcit.Name = "SK_btnExcit";
            this.SK_btnExcit.Size = new System.Drawing.Size(188, 53);
            this.SK_btnExcit.TabIndex = 14;
            this.SK_btnExcit.Text = "Välju";
            this.SK_btnExcit.UseVisualStyleBackColor = false;
            this.SK_btnExcit.Click += new System.EventHandler(this.SK_btnExcit_Click);
            // 
            // SK_btnPlay
            // 
            this.SK_btnPlay.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SK_btnPlay.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SK_btnPlay.ForeColor = System.Drawing.SystemColors.Control;
            this.SK_btnPlay.Location = new System.Drawing.Point(491, 567);
            this.SK_btnPlay.Name = "SK_btnPlay";
            this.SK_btnPlay.Size = new System.Drawing.Size(279, 53);
            this.SK_btnPlay.TabIndex = 13;
            this.SK_btnPlay.Text = "Alusta mängu";
            this.SK_btnPlay.UseVisualStyleBackColor = false;
            this.SK_btnPlay.Click += new System.EventHandler(this.SK_btnPlay_Click);
            // 
            // SK_pic1
            // 
            this.SK_pic1.Location = new System.Drawing.Point(92, 126);
            this.SK_pic1.Name = "SK_pic1";
            this.SK_pic1.Size = new System.Drawing.Size(350, 494);
            this.SK_pic1.TabIndex = 12;
            this.SK_pic1.TabStop = false;
            // 
            // SK_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 675);
            this.Controls.Add(this.SK_lblHangman);
            this.Controls.Add(this.SK_lblDescription);
            this.Controls.Add(this.SK_btnExcit);
            this.Controls.Add(this.SK_btnPlay);
            this.Controls.Add(this.SK_pic1);
            this.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SK_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SK_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SK_pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SK_lblHangman;
        private System.Windows.Forms.Label SK_lblDescription;
        private System.Windows.Forms.Button SK_btnExcit;
        private System.Windows.Forms.Button SK_btnPlay;
        private System.Windows.Forms.PictureBox SK_pic1;
    }
}

