
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
            this.btnClients = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnFournisseurs = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btnInventaire = new System.Windows.Forms.Button();
            this.btnArticles = new System.Windows.Forms.Button();
            this.btnCommandes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(237, 82);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(119, 49);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
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
            // btnFournisseurs
            // 
            this.btnFournisseurs.Location = new System.Drawing.Point(237, 193);
            this.btnFournisseurs.Name = "btnFournisseurs";
            this.btnFournisseurs.Size = new System.Drawing.Size(119, 49);
            this.btnFournisseurs.TabIndex = 1;
            this.btnFournisseurs.Text = "Fournisseurs";
            this.btnFournisseurs.UseVisualStyleBackColor = true;
            // 
            // btn_stock
            // 
            this.btn_stock.Location = new System.Drawing.Point(474, 82);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(119, 49);
            this.btn_stock.TabIndex = 2;
            this.btn_stock.Text = "Stock";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btnInventaire
            // 
            this.btnInventaire.Location = new System.Drawing.Point(474, 193);
            this.btnInventaire.Name = "btnInventaire";
            this.btnInventaire.Size = new System.Drawing.Size(119, 49);
            this.btnInventaire.TabIndex = 3;
            this.btnInventaire.Text = "Inventaire";
            this.btnInventaire.UseVisualStyleBackColor = true;
            // 
            // btnArticles
            // 
            this.btnArticles.Location = new System.Drawing.Point(237, 312);
            this.btnArticles.Name = "btnArticles";
            this.btnArticles.Size = new System.Drawing.Size(119, 49);
            this.btnArticles.TabIndex = 4;
            this.btnArticles.Text = "Articles";
            this.btnArticles.UseVisualStyleBackColor = true;
            // 
            // btnCommandes
            // 
            this.btnCommandes.Location = new System.Drawing.Point(474, 312);
            this.btnCommandes.Name = "btnCommandes";
            this.btnCommandes.Size = new System.Drawing.Size(119, 49);
            this.btnCommandes.TabIndex = 5;
            this.btnCommandes.Text = "Commandes";
            this.btnCommandes.UseVisualStyleBackColor = true;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 533);
            this.Controls.Add(this.btnCommandes);
            this.Controls.Add(this.btnArticles);
            this.Controls.Add(this.btnInventaire);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btnFournisseurs);
            this.Controls.Add(this.btnClients);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnFournisseurs;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btnInventaire;
        private System.Windows.Forms.Button btnArticles;
        private System.Windows.Forms.Button btnCommandes;
    }
}

