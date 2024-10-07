namespace H2Button_harkka
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
            this.ekaPainike = new System.Windows.Forms.Button();
            this.tokaPainike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekaPainike
            // 
            this.ekaPainike.Location = new System.Drawing.Point(202, 171);
            this.ekaPainike.Name = "ekaPainike";
            this.ekaPainike.Size = new System.Drawing.Size(127, 23);
            this.ekaPainike.TabIndex = 0;
            this.ekaPainike.Text = "Piilota 2. painike";
            this.ekaPainike.UseVisualStyleBackColor = true;
            this.ekaPainike.Click += new System.EventHandler(this.ekaPainike_Click);
            // 
            // tokaPainike
            // 
            this.tokaPainike.Location = new System.Drawing.Point(477, 170);
            this.tokaPainike.Name = "tokaPainike";
            this.tokaPainike.Size = new System.Drawing.Size(75, 23);
            this.tokaPainike.TabIndex = 1;
            this.tokaPainike.Text = "Painike 2";
            this.tokaPainike.UseVisualStyleBackColor = true;
            this.tokaPainike.Click += new System.EventHandler(this.tokaPainike_Click);
            this.tokaPainike.MouseLeave += new System.EventHandler(this.tokaPainike_MouseLeave);
            this.tokaPainike.MouseHover += new System.EventHandler(this.tokaPainike_MouseHover);
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tokaPainike);
            this.Controls.Add(this.ekaPainike);
            this.Name = "Paaikkuna";
            this.Text = "H2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ekaPainike;
        private System.Windows.Forms.Button tokaPainike;
    }
}

