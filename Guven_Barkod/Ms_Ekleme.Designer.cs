namespace Guven_Barkod
{
    partial class Ms_Ekleme
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
            Product_Size_txt = new TextBox();
            Product_model_txt = new TextBox();
            Product_Name_txt = new TextBox();
            Product_Color_txt = new TextBox();
            Barcode_No_txt = new TextBox();
            Barkod_lbl = new Label();
            PName_lbl = new Label();
            PModel_lbl = new Label();
            PColor_lbl = new Label();
            PSize_lbl = new Label();
            PQuantity_lbl = new Label();
            Product_Quantity_txt = new TextBox();
            btn_Envanter = new Button();
            btn_Add_Product = new Button();
            btn_Sepet = new Button();
            Product_Price_txt = new TextBox();
            PPrice_lbl = new Label();
            btn_Close = new Button();
            SuspendLayout();
            // 
            // Product_Size_txt
            // 
            Product_Size_txt.Location = new Point(516, 227);
            Product_Size_txt.Name = "Product_Size_txt";
            Product_Size_txt.Size = new Size(100, 23);
            Product_Size_txt.TabIndex = 0;
            // 
            // Product_model_txt
            // 
            Product_model_txt.Location = new Point(516, 138);
            Product_model_txt.Name = "Product_model_txt";
            Product_model_txt.Size = new Size(100, 23);
            Product_model_txt.TabIndex = 1;
            // 
            // Product_Name_txt
            // 
            Product_Name_txt.Location = new Point(516, 95);
            Product_Name_txt.Name = "Product_Name_txt";
            Product_Name_txt.Size = new Size(100, 23);
            Product_Name_txt.TabIndex = 2;
            // 
            // Product_Color_txt
            // 
            Product_Color_txt.Location = new Point(516, 183);
            Product_Color_txt.Name = "Product_Color_txt";
            Product_Color_txt.Size = new Size(100, 23);
            Product_Color_txt.TabIndex = 3;
            // 
            // Barcode_No_txt
            // 
            Barcode_No_txt.Location = new Point(516, 50);
            Barcode_No_txt.Name = "Barcode_No_txt";
            Barcode_No_txt.Size = new Size(100, 23);
            Barcode_No_txt.TabIndex = 4;
            // 
            // Barkod_lbl
            // 
            Barkod_lbl.AutoSize = true;
            Barkod_lbl.Location = new Point(447, 53);
            Barkod_lbl.Name = "Barkod_lbl";
            Barkod_lbl.Size = new Size(63, 15);
            Barkod_lbl.TabIndex = 5;
            Barkod_lbl.Text = "Barkod No";
            // 
            // PName_lbl
            // 
            PName_lbl.AutoSize = true;
            PName_lbl.Location = new Point(456, 98);
            PName_lbl.Name = "PName_lbl";
            PName_lbl.Size = new Size(54, 15);
            PName_lbl.TabIndex = 6;
            PName_lbl.Text = "Ürün Adı";
            // 
            // PModel_lbl
            // 
            PModel_lbl.AutoSize = true;
            PModel_lbl.Location = new Point(437, 141);
            PModel_lbl.Name = "PModel_lbl";
            PModel_lbl.Size = new Size(73, 15);
            PModel_lbl.TabIndex = 7;
            PModel_lbl.Text = "Ürün Modeli";
            // 
            // PColor_lbl
            // 
            PColor_lbl.AutoSize = true;
            PColor_lbl.Location = new Point(444, 186);
            PColor_lbl.Name = "PColor_lbl";
            PColor_lbl.Size = new Size(66, 15);
            PColor_lbl.TabIndex = 8;
            PColor_lbl.Text = "Ürün Rengi";
            // 
            // PSize_lbl
            // 
            PSize_lbl.AutoSize = true;
            PSize_lbl.Location = new Point(438, 230);
            PSize_lbl.Name = "PSize_lbl";
            PSize_lbl.Size = new Size(72, 15);
            PSize_lbl.TabIndex = 9;
            PSize_lbl.Text = "Ürün Bedeni";
            // 
            // PQuantity_lbl
            // 
            PQuantity_lbl.AutoSize = true;
            PQuantity_lbl.Location = new Point(443, 270);
            PQuantity_lbl.Name = "PQuantity_lbl";
            PQuantity_lbl.Size = new Size(67, 15);
            PQuantity_lbl.TabIndex = 10;
            PQuantity_lbl.Text = "Ürün Adedi";
            // 
            // Product_Quantity_txt
            // 
            Product_Quantity_txt.Location = new Point(516, 267);
            Product_Quantity_txt.Name = "Product_Quantity_txt";
            Product_Quantity_txt.Size = new Size(100, 23);
            Product_Quantity_txt.TabIndex = 11;
            // 
            // btn_Envanter
            // 
            btn_Envanter.Location = new Point(247, 359);
            btn_Envanter.Name = "btn_Envanter";
            btn_Envanter.Size = new Size(101, 62);
            btn_Envanter.TabIndex = 12;
            btn_Envanter.Text = "ENVANTER";
            btn_Envanter.UseVisualStyleBackColor = true;
            btn_Envanter.Click += Envanter_Click;
            // 
            // btn_Add_Product
            // 
            btn_Add_Product.Location = new Point(515, 359);
            btn_Add_Product.Name = "btn_Add_Product";
            btn_Add_Product.Size = new Size(101, 62);
            btn_Add_Product.TabIndex = 13;
            btn_Add_Product.Text = "Ürünü Ekle";
            btn_Add_Product.UseVisualStyleBackColor = true;
            btn_Add_Product.Click += Product_Add_Click;
            // 
            // btn_Sepet
            // 
            btn_Sepet.AutoSize = true;
            btn_Sepet.Location = new Point(775, 359);
            btn_Sepet.Name = "btn_Sepet";
            btn_Sepet.Size = new Size(101, 62);
            btn_Sepet.TabIndex = 14;
            btn_Sepet.Text = "Satış Ekranı";
            btn_Sepet.UseVisualStyleBackColor = true;
            btn_Sepet.Click += Sepet_Click;
            // 
            // Product_Price_txt
            // 
            Product_Price_txt.Location = new Point(516, 310);
            Product_Price_txt.Name = "Product_Price_txt";
            Product_Price_txt.Size = new Size(100, 23);
            Product_Price_txt.TabIndex = 15;
            // 
            // PPrice_lbl
            // 
            PPrice_lbl.AutoSize = true;
            PPrice_lbl.Location = new Point(478, 313);
            PPrice_lbl.Name = "PPrice_lbl";
            PPrice_lbl.Size = new Size(32, 15);
            PPrice_lbl.TabIndex = 16;
            PPrice_lbl.Text = "Fiyat";
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(990, 28);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(135, 34);
            btn_Close.TabIndex = 17;
            btn_Close.Text = "Uygulamayı Kapat";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // Ms_Ekleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 569);
            Controls.Add(btn_Close);
            Controls.Add(PPrice_lbl);
            Controls.Add(Product_Price_txt);
            Controls.Add(btn_Sepet);
            Controls.Add(btn_Add_Product);
            Controls.Add(btn_Envanter);
            Controls.Add(Product_Quantity_txt);
            Controls.Add(PQuantity_lbl);
            Controls.Add(PSize_lbl);
            Controls.Add(PColor_lbl);
            Controls.Add(PModel_lbl);
            Controls.Add(PName_lbl);
            Controls.Add(Barkod_lbl);
            Controls.Add(Barcode_No_txt);
            Controls.Add(Product_Color_txt);
            Controls.Add(Product_Name_txt);
            Controls.Add(Product_model_txt);
            Controls.Add(Product_Size_txt);
            Name = "Ms_Ekleme";
            Text = "Form1";
            Load += Ms_Ekleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Product_Size_txt;
        private TextBox Product_model_txt;
        private TextBox Product_Name_txt;
        private TextBox Product_Color_txt;
        private TextBox Barcode_No_txt;
        private Label Barkod_lbl;
        private Label PName_lbl;
        private Label PModel_lbl;
        private Label PColor_lbl;
        private Label PSize_lbl;
        private Label PQuantity_lbl;
        private TextBox Product_Quantity_txt;
        private Button btn_Envanter;
        private Button btn_Add_Product;
        private Button btn_Sepet;
        private TextBox Product_Price_txt;
        private Label PPrice_lbl;
        private Button btn_Close;
    }
}