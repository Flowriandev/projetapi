
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID_Fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomFournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse_Fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articles_Fournisseurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modifier,
            this.ID_Fournisseur,
            this.NomFournisseur,
            this.Adresse_Fournisseur,
            this.Articles_Fournisseurs});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(598, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "";
            this.Modifier.Name = "Modifier";
            // 
            // ID_Fournisseur
            // 
            this.ID_Fournisseur.HeaderText = "ID";
            this.ID_Fournisseur.Name = "ID_Fournisseur";
            // 
            // NomFournisseur
            // 
            this.NomFournisseur.HeaderText = "NomFournisseur";
            this.NomFournisseur.Name = "NomFournisseur";
            // 
            // Adresse_Fournisseur
            // 
            this.Adresse_Fournisseur.HeaderText = "Adresse";
            this.Adresse_Fournisseur.Name = "Adresse_Fournisseur";
            // 
            // Articles_Fournisseurs
            // 
            this.Articles_Fournisseurs.HeaderText = "Articles";
            this.Articles_Fournisseurs.Name = "Articles_Fournisseurs";
            // 
            // Fournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fournisseurs";
            this.Text = "Fournisseurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Fournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomFournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse_Fournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articles_Fournisseurs;
    }
}