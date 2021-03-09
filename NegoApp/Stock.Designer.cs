
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
            this.SuspendLayout();
            // 
            // btn_stock_add
            // 
            this.btn_stock_add.Location = new System.Drawing.Point(341, 208);
            this.btn_stock_add.Name = "btn_stock_add";
            this.btn_stock_add.Size = new System.Drawing.Size(119, 49);
            this.btn_stock_add.TabIndex = 3;
            this.btn_stock_add.Text = "Passer commande";
            this.btn_stock_add.UseVisualStyleBackColor = true;
            // 
            // btn_stock_list
            // 
            this.btn_stock_list.Location = new System.Drawing.Point(341, 116);
            this.btn_stock_list.Name = "btn_stock_list";
            this.btn_stock_list.Size = new System.Drawing.Size(119, 49);
            this.btn_stock_list.TabIndex = 4;
            this.btn_stock_list.Text = "Afficher le stock";
            this.btn_stock_list.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stock_list);
            this.Controls.Add(this.btn_stock_add);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_stock_add;
        private System.Windows.Forms.Button btn_stock_list;
    }
}