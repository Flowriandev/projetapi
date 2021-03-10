
namespace NegoApp
{
    partial class Commandes
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Expedition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_order = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modifier,
            this.ID,
            this.ID_Client,
            this.Date_Commande,
            this.Date_Expedition,
            this.Detail_Article});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(586, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "";
            this.Modifier.Name = "Modifier";
            this.Modifier.Width = 25;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ID_Client
            // 
            this.ID_Client.HeaderText = "ID_Client";
            this.ID_Client.Name = "ID_Client";
            // 
            // Date_Commande
            // 
            this.Date_Commande.HeaderText = "Date_Commande";
            this.Date_Commande.Name = "Date_Commande";
            // 
            // Date_Expedition
            // 
            this.Date_Expedition.HeaderText = "Date_Expedition";
            this.Date_Expedition.Name = "Date_Expedition";
            // 
            // Detail_Article
            // 
            this.Detail_Article.HeaderText = "Detail_Article";
            this.Detail_Article.Name = "Detail_Article";
            // 
            // new_order
            // 
            this.new_order.Location = new System.Drawing.Point(632, 203);
            this.new_order.Name = "new_order";
            this.new_order.Size = new System.Drawing.Size(136, 54);
            this.new_order.TabIndex = 1;
            this.new_order.Text = "Nouvelle Commande";
            this.new_order.UseVisualStyleBackColor = true;
            this.new_order.Click += new System.EventHandler(this.new_order_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NegoApp.Properties.Resources.home_large;
            this.pictureBox1.Location = new System.Drawing.Point(674, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 53);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Commandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.new_order);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Commandes";
            this.Text = "Commandes";
            this.Load += new System.EventHandler(this.Commandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Expedition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail_Article;
        private System.Windows.Forms.Button new_order;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}