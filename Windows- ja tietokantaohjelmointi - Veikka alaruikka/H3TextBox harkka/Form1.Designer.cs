namespace H3TextBox_harkka
{
    partial class Paaikkuna
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
            this.kopiointiPainike = new System.Windows.Forms.Button();
            this.salausPainike = new System.Windows.Forms.Button();
            this.lauseTekstikentta = new System.Windows.Forms.TextBox();
            this.arkistoTekstikentta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kopiointiPainike
            // 
            this.kopiointiPainike.Location = new System.Drawing.Point(546, 174);
            this.kopiointiPainike.Name = "kopiointiPainike";
            this.kopiointiPainike.Size = new System.Drawing.Size(131, 34);
            this.kopiointiPainike.TabIndex = 2;
            this.kopiointiPainike.Text = "kopioi teksti arkistoon";
            this.kopiointiPainike.UseVisualStyleBackColor = true;
            this.kopiointiPainike.Click += new System.EventHandler(this.kopiointiPainike_Click);
            // 
            // salausPainike
            // 
            this.salausPainike.Location = new System.Drawing.Point(546, 236);
            this.salausPainike.Name = "salausPainike";
            this.salausPainike.Size = new System.Drawing.Size(131, 34);
            this.salausPainike.TabIndex = 3;
            this.salausPainike.Text = "salaa tekstiä";
            this.salausPainike.UseVisualStyleBackColor = true;
            this.salausPainike.Click += new System.EventHandler(this.salausPainike_Click);
            // 
            // lauseTekstikentta
            // 
            this.lauseTekstikentta.Location = new System.Drawing.Point(135, 148);
            this.lauseTekstikentta.Name = "lauseTekstikentta";
            this.lauseTekstikentta.Size = new System.Drawing.Size(211, 20);
            this.lauseTekstikentta.TabIndex = 0;
            this.lauseTekstikentta.Text = "Kirjoita lause tähän";
            this.lauseTekstikentta.TextChanged += new System.EventHandler(this.lauseTekstikentta_TextChanged);
            // 
            // arkistoTekstikentta
            // 
            this.arkistoTekstikentta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arkistoTekstikentta.Location = new System.Drawing.Point(135, 183);
            this.arkistoTekstikentta.Multiline = true;
            this.arkistoTekstikentta.Name = "arkistoTekstikentta";
            this.arkistoTekstikentta.Size = new System.Drawing.Size(211, 121);
            this.arkistoTekstikentta.TabIndex = 1;
            this.arkistoTekstikentta.TextChanged += new System.EventHandler(this.arkistoTekstikentta_TextChanged);
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arkistoTekstikentta);
            this.Controls.Add(this.lauseTekstikentta);
            this.Controls.Add(this.salausPainike);
            this.Controls.Add(this.kopiointiPainike);
            this.Name = "Paaikkuna";
            this.Text = "H3";
            this.Load += new System.EventHandler(this.Paaikkuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kopiointiPainike;
        private System.Windows.Forms.Button salausPainike;
        private System.Windows.Forms.TextBox lauseTekstikentta;
        private System.Windows.Forms.TextBox arkistoTekstikentta;
    }
}

