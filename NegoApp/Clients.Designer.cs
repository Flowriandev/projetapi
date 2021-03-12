
namespace NegoApp
{
    partial class Clients
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
            this.Nouveau_client = new System.Windows.Forms.Button();
            this.BackAccueil = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BackAccueil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nouveau_client
            // 
            this.Nouveau_client.Location = new System.Drawing.Point(638, 220);
            this.Nouveau_client.Name = "Nouveau_client";
            this.Nouveau_client.Size = new System.Drawing.Size(138, 50);
            this.Nouveau_client.TabIndex = 1;
            this.Nouveau_client.Text = "Nouveau Client";
            this.Nouveau_client.UseVisualStyleBackColor = true;
            // 
            // BackAccueil
            // 
            this.BackAccueil.Location = new System.Drawing.Point(668, 31);
            this.BackAccueil.Name = "BackAccueil";
            this.BackAccueil.Size = new System.Drawing.Size(49, 53);
            this.BackAccueil.TabIndex = 2;
            this.BackAccueil.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(620, 426);
            this.dataGridView1.TabIndex = 3;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackAccueil);
            this.Controls.Add(this.Nouveau_client);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackAccueil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Nouveau_client;
        private System.Windows.Forms.PictureBox BackAccueil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}