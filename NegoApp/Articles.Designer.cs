
namespace NegoApp
{
    partial class Articles
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
            this.NvArticle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.FamilleTextBox = new System.Windows.Forms.TextBox();
            this.PrixTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(746, 567);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NvArticle
            // 
            this.NvArticle.Location = new System.Drawing.Point(1131, 300);
            this.NvArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NvArticle.Name = "NvArticle";
            this.NvArticle.Size = new System.Drawing.Size(122, 59);
            this.NvArticle.TabIndex = 1;
            this.NvArticle.Text = "Nouvel Article";
            this.NvArticle.UseVisualStyleBackColor = true;
            this.NvArticle.Click += new System.EventHandler(this.NvArticle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(791, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 72);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(791, 171);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(125, 27);
            this.nomTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(791, 220);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(125, 27);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // FamilleTextBox
            // 
            this.FamilleTextBox.Location = new System.Drawing.Point(791, 265);
            this.FamilleTextBox.Name = "FamilleTextBox";
            this.FamilleTextBox.Size = new System.Drawing.Size(125, 27);
            this.FamilleTextBox.TabIndex = 5;
            // 
            // PrixTextBox
            // 
            this.PrixTextBox.Location = new System.Drawing.Point(791, 354);
            this.PrixTextBox.Name = "PrixTextBox";
            this.PrixTextBox.Size = new System.Drawing.Size(125, 27);
            this.PrixTextBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(791, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 600);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PrixTextBox);
            this.Controls.Add(this.FamilleTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NvArticle);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Articles";
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.Articles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button NvArticle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox FamilleTextBox;
        private System.Windows.Forms.TextBox PrixTextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}