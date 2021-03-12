
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
            this.BtnNvArt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.FamilleTextBox = new System.Windows.Forms.TextBox();
            this.PrixTextBox = new System.Windows.Forms.TextBox();
            this.anneeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Année = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // BtnNvArt
            // 
            this.BtnNvArt.Location = new System.Drawing.Point(987, 423);
            this.BtnNvArt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNvArt.Name = "BtnNvArt";
            this.BtnNvArt.Size = new System.Drawing.Size(122, 59);
            this.BtnNvArt.TabIndex = 1;
            this.BtnNvArt.Text = "Nouvel Article";
            this.BtnNvArt.UseVisualStyleBackColor = true;
            this.BtnNvArt.Click += new System.EventHandler(this.BtnNvArt_Click);
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
            this.nomTextBox.Location = new System.Drawing.Point(934, 170);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(233, 27);
            this.nomTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(934, 216);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(233, 27);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // FamilleTextBox
            // 
            this.FamilleTextBox.Location = new System.Drawing.Point(934, 265);
            this.FamilleTextBox.Name = "FamilleTextBox";
            this.FamilleTextBox.Size = new System.Drawing.Size(233, 27);
            this.FamilleTextBox.TabIndex = 5;
            // 
            // PrixTextBox
            // 
            this.PrixTextBox.Location = new System.Drawing.Point(934, 362);
            this.PrixTextBox.Name = "PrixTextBox";
            this.PrixTextBox.Size = new System.Drawing.Size(233, 27);
            this.PrixTextBox.TabIndex = 6;
            // 
            // anneeTextBox
            // 
            this.anneeTextBox.Location = new System.Drawing.Point(934, 313);
            this.anneeTextBox.Name = "anneeTextBox";
            this.anneeTextBox.Size = new System.Drawing.Size(233, 27);
            this.anneeTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(791, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Famille";
            // 
            // Année
            // 
            this.Année.AutoSize = true;
            this.Année.Location = new System.Drawing.Point(791, 314);
            this.Année.Name = "Année";
            this.Année.Size = new System.Drawing.Size(51, 20);
            this.Année.TabIndex = 11;
            this.Année.Text = "Année";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(791, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prix";
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Année);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anneeTextBox);
            this.Controls.Add(this.PrixTextBox);
            this.Controls.Add(this.FamilleTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnNvArt);
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
        private System.Windows.Forms.Button BtnNvArt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox FamilleTextBox;
        private System.Windows.Forms.TextBox PrixTextBox;
        private System.Windows.Forms.TextBox anneeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Année;
        private System.Windows.Forms.Label label5;
    }
}