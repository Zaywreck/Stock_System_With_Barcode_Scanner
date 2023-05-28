namespace Guven_Barkod
{
    partial class Envanter
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
            Inventory_dgw = new DataGridView();
            btn_Sepet = new Button();
            btn_Urun_Ekleme = new Button();
            Envanter_lbl = new Label();
            btn_Product_remove = new Button();
            btn_Product_update = new Button();
            btn_Quantity_add = new Button();
            btn_Quantity_remove = new Button();
            btn_Close = new Button();
            ((System.ComponentModel.ISupportInitialize)Inventory_dgw).BeginInit();
            SuspendLayout();
            // 
            // Inventory_dgw
            // 
            Inventory_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Inventory_dgw.Location = new Point(30, 66);
            Inventory_dgw.Name = "Inventory_dgw";
            Inventory_dgw.RowTemplate.Height = 25;
            Inventory_dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Inventory_dgw.Size = new Size(966, 403);
            Inventory_dgw.TabIndex = 0;
            // 
            // btn_Sepet
            // 
            btn_Sepet.Location = new Point(1121, 378);
            btn_Sepet.Name = "btn_Sepet";
            btn_Sepet.Size = new Size(94, 58);
            btn_Sepet.TabIndex = 1;
            btn_Sepet.Text = "Satış Ekranı";
            btn_Sepet.UseVisualStyleBackColor = true;
            btn_Sepet.Click += Sepet_Click;
            // 
            // btn_Urun_Ekleme
            // 
            btn_Urun_Ekleme.Location = new Point(1121, 303);
            btn_Urun_Ekleme.Name = "btn_Urun_Ekleme";
            btn_Urun_Ekleme.Size = new Size(94, 58);
            btn_Urun_Ekleme.TabIndex = 2;
            btn_Urun_Ekleme.Text = "Ürün ekleme";
            btn_Urun_Ekleme.UseVisualStyleBackColor = true;
            btn_Urun_Ekleme.Click += Urun_Ekleme_Click;
            // 
            // Envanter_lbl
            // 
            Envanter_lbl.AutoSize = true;
            Envanter_lbl.Location = new Point(432, 32);
            Envanter_lbl.Name = "Envanter_lbl";
            Envanter_lbl.Size = new Size(53, 15);
            Envanter_lbl.TabIndex = 3;
            Envanter_lbl.Text = "Envanter";
            // 
            // btn_Product_remove
            // 
            btn_Product_remove.Location = new Point(1121, 155);
            btn_Product_remove.Name = "btn_Product_remove";
            btn_Product_remove.Size = new Size(94, 56);
            btn_Product_remove.TabIndex = 4;
            btn_Product_remove.Text = "Ürün Sil";
            btn_Product_remove.UseVisualStyleBackColor = true;
            btn_Product_remove.Click += Product_Remove_Click;
            // 
            // btn_Product_update
            // 
            btn_Product_update.Location = new Point(1121, 228);
            btn_Product_update.Name = "btn_Product_update";
            btn_Product_update.Size = new Size(94, 58);
            btn_Product_update.TabIndex = 5;
            btn_Product_update.Text = "Ürün Güncelle";
            btn_Product_update.UseVisualStyleBackColor = true;
            btn_Product_update.Click += Product_Update_Click;
            // 
            // btn_Quantity_add
            // 
            btn_Quantity_add.Location = new Point(1121, 68);
            btn_Quantity_add.Name = "btn_Quantity_add";
            btn_Quantity_add.Size = new Size(94, 23);
            btn_Quantity_add.TabIndex = 6;
            btn_Quantity_add.Text = "Miktar artır";
            btn_Quantity_add.UseVisualStyleBackColor = true;
            btn_Quantity_add.Click += Product_Quantity_Increase_Click;
            // 
            // btn_Quantity_remove
            // 
            btn_Quantity_remove.Location = new Point(1121, 108);
            btn_Quantity_remove.Name = "btn_Quantity_remove";
            btn_Quantity_remove.Size = new Size(94, 23);
            btn_Quantity_remove.TabIndex = 7;
            btn_Quantity_remove.Text = "Miktar azalt";
            btn_Quantity_remove.UseVisualStyleBackColor = true;
            btn_Quantity_remove.Click += Product_Quantity_Decrease_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(1111, 24);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(135, 34);
            btn_Close.TabIndex = 34;
            btn_Close.Text = "Uygulamayı Kapat";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // Envanter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 612);
            Controls.Add(btn_Close);
            Controls.Add(btn_Quantity_remove);
            Controls.Add(btn_Quantity_add);
            Controls.Add(btn_Product_update);
            Controls.Add(btn_Product_remove);
            Controls.Add(Envanter_lbl);
            Controls.Add(btn_Urun_Ekleme);
            Controls.Add(btn_Sepet);
            Controls.Add(Inventory_dgw);
            Name = "Envanter";
            Text = "Form3";
            Load += Envanter_Load;
            ((System.ComponentModel.ISupportInitialize)Inventory_dgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Inventory_dgw;
        private Button btn_Sepet;
        private Button btn_Urun_Ekleme;
        private Label Envanter_lbl;
        private Button btn_Product_remove;
        private Button btn_Product_update;
        private Button btn_Quantity_add;
        private Button btn_Quantity_remove;
        private Button btn_Close;
    }
}