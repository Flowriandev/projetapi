
namespace NegoApp
{
    partial class Stock
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
            this.btn_stock_add = new System.Windows.Forms.Button();
            this.btn_stock_list = new System.Windows.Forms.Button();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.pnl_stock_list = new System.Windows.Forms.Panel();
            this.btn_back1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_cmd = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_btn.SuspendLayout();
            this.pnl_stock_list.SuspendLayout();
            this.pnl_cmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_stock_add
            // 
            this.btn_stock_add.Location = new System.Drawing.Point(44, 51);
            this.btn_stock_add.Name = "btn_stock_add";
            this.btn_stock_add.Size = new System.Drawing.Size(119, 49);
            this.btn_stock_add.TabIndex = 3;
            this.btn_stock_add.Text = "Passer commande";
            this.btn_stock_add.UseVisualStyleBackColor = true;
            this.btn_stock_add.Click += new System.EventHandler(this.btn_stock_add_Click);
            // 
            // btn_stock_list
            // 
            this.btn_stock_list.Location = new System.Drawing.Point(44, 0);
            this.btn_stock_list.Name = "btn_stock_list";
            this.btn_stock_list.Size = new System.Drawing.Size(119, 49);
            this.btn_stock_list.TabIndex = 4;
            this.btn_stock_list.Text = "Afficher le stock";
            this.btn_stock_list.UseVisualStyleBackColor = true;
            this.btn_stock_list.Click += new System.EventHandler(this.btn_stock_list_Click);
            // 
            // pnl_btn
            // 
            this.pnl_btn.Controls.Add(this.btn_stock_list);
            this.pnl_btn.Controls.Add(this.btn_stock_add);
            this.pnl_btn.Location = new System.Drawing.Point(298, 168);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(200, 100);
            this.pnl_btn.TabIndex = 5;
            // 
            // pnl_stock_list
            // 
            this.pnl_stock_list.Controls.Add(this.dataGridView1);
            this.pnl_stock_list.Controls.Add(this.btn_back1);
            this.pnl_stock_list.Controls.Add(this.label1);
            this.pnl_stock_list.Location = new System.Drawing.Point(0, 0);
            this.pnl_stock_list.Name = "pnl_stock_list";
            this.pnl_stock_list.Size = new System.Drawing.Size(788, 438);
            this.pnl_stock_list.TabIndex = 6;
            // 
            // btn_back1
            // 
            this.btn_back1.Location = new System.Drawing.Point(12, 415);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Size = new System.Drawing.Size(75, 23);
            this.btn_back1.TabIndex = 8;
            this.btn_back1.Text = "Retour";
            this.btn_back1.UseVisualStyleBackColor = true;
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stocks";
            // 
            // pnl_cmd
            // 
            this.pnl_cmd.Controls.Add(this.btn_back);
            this.pnl_cmd.Controls.Add(this.label2);
            this.pnl_cmd.Location = new System.Drawing.Point(0, 2);
            this.pnl_cmd.Name = "pnl_cmd";
            this.pnl_cmd.Size = new System.Drawing.Size(788, 456);
            this.pnl_cmd.TabIndex = 7;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 415);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Retour";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Passer commande";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(664, 360);
            this.dataGridView1.TabIndex = 9;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_stock_list);
            this.Controls.Add(this.pnl_cmd);
            this.Controls.Add(this.pnl_btn);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.pnl_btn.ResumeLayout(false);
            this.pnl_stock_list.ResumeLayout(false);
            this.pnl_stock_list.PerformLayout();
            this.pnl_cmd.ResumeLayout(false);
            this.pnl_cmd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_stock_add;
        private System.Windows.Forms.Button btn_stock_list;
        private System.Windows.Forms.Panel pnl_btn;
        private System.Windows.Forms.Panel pnl_stock_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_cmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_back1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}