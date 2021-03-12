
namespace NegoApp
{
    partial class Fournisseurs
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
            this.dataGridFournisseur = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFournisseur
            // 
            this.dataGridFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Adresse,
            this.Ville,
            this.CodePostal,
            this.Pays});
            this.dataGridFournisseur.Location = new System.Drawing.Point(12, 33);
            this.dataGridFournisseur.Name = "dataGridFournisseur";
            this.dataGridFournisseur.RowTemplate.Height = 25;
            this.dataGridFournisseur.Size = new System.Drawing.Size(776, 405);
            this.dataGridFournisseur.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "CodePostal";
            this.CodePostal.Name = "CodePostal";
            // 
            // Pays
            // 
            this.Pays.HeaderText = "Pays";
            this.Pays.Name = "Pays";
            // 
            // Fournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridFournisseur);
            this.Name = "Fournisseurs";
            this.Text = "Fournisseurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFournisseur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pays;
    }
}