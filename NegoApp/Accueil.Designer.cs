
namespace NegoApp
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnClient = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.BtnFournisseurs = new System.Windows.Forms.Button();
            this.BtnStock = new System.Windows.Forms.Button();
            this.BtnInventaire = new System.Windows.Forms.Button();
            this.BtnArticles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClient
            // 
            this.BtnClient.Location = new System.Drawing.Point(237, 82);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(119, 49);
            this.BtnClient.TabIndex = 0;
            this.BtnClient.Text = "Clients";
            this.BtnClient.UseVisualStyleBackColor = true;
            this.BtnClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(426, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(434, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(633, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // BtnFournisseurs
            // 
            this.BtnFournisseurs.Location = new System.Drawing.Point(237, 193);
            this.BtnFournisseurs.Name = "BtnFournisseurs";
            this.BtnFournisseurs.Size = new System.Drawing.Size(119, 49);
            this.BtnFournisseurs.TabIndex = 1;
            this.BtnFournisseurs.Text = "Fournisseurs";
            this.BtnFournisseurs.UseVisualStyleBackColor = true;
            // 
            // BtnStock
            // 
            this.BtnStock.Location = new System.Drawing.Point(474, 82);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(119, 49);
            this.BtnStock.TabIndex = 2;
            this.BtnStock.Text = "Stock";
            this.BtnStock.UseVisualStyleBackColor = true;
            this.BtnStock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // BtnInventaire
            // 
            this.BtnInventaire.Location = new System.Drawing.Point(474, 193);
            this.BtnInventaire.Name = "BtnInventaire";
            this.BtnInventaire.Size = new System.Drawing.Size(119, 49);
            this.BtnInventaire.TabIndex = 3;
            this.BtnInventaire.Text = "Inventaire";
            this.BtnInventaire.UseVisualStyleBackColor = true;
            // 
            // BtnArticles
            // 
            this.BtnArticles.Location = new System.Drawing.Point(237, 312);
            this.BtnArticles.Name = "BtnArticles";
            this.BtnArticles.Size = new System.Drawing.Size(119, 49);
            this.BtnArticles.TabIndex = 4;
            this.BtnArticles.Text = "Articles";
            this.BtnArticles.UseVisualStyleBackColor = true;
            this.BtnArticles.Click += new System.EventHandler(this.button9_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 533);
            this.Controls.Add(this.BtnArticles);
            this.Controls.Add(this.BtnInventaire);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.BtnFournisseurs);
            this.Controls.Add(this.BtnClient);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BtnFournisseurs;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button BtnInventaire;
        private System.Windows.Forms.Button BtnArticles;
    }
}

