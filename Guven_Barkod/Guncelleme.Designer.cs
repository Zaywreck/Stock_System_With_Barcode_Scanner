namespace Guven_Barkod
{
    partial class Guncelleme
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
            PPrice_lbl = new Label();
            Product_Price_txt = new TextBox();
            Product_Quantity_txt = new TextBox();
            PQuantity_lbl = new Label();
            PSize_lbl = new Label();
            PColor_lbl = new Label();
            PModel_lbl = new Label();
            PName_lbl = new Label();
            Barkod_lbl = new Label();
            Barcode_No_txt = new TextBox();
            Product_Color_txt = new TextBox();
            Product_Name_txt = new TextBox();
            Product_model_txt = new TextBox();
            Product_Size_txt = new TextBox();
            btn_Update = new Button();
            btn_Envanter = new Button();
            btn_Close = new Button();
            SuspendLayout();
            // 
            // PPrice_lbl
            // 
            PPrice_lbl.AutoSize = true;
            PPrice_lbl.Location = new Point(466, 335);
            PPrice_lbl.Name = "PPrice_lbl";
            PPrice_lbl.Size = new Size(32, 15);
            PPrice_lbl.TabIndex = 30;
            PPrice_lbl.Text = "Fiyat";
            // 
            // Product_Price_txt
            // 
            Product_Price_txt.Location = new Point(504, 332);
            Product_Price_txt.Name = "Product_Price_txt";
            Product_Price_txt.Size = new Size(100, 23);
            Product_Price_txt.TabIndex = 29;
            // 
            // Product_Quantity_txt
            // 
            Product_Quantity_txt.Location = new Point(504, 289);
            Product_Quantity_txt.Name = "Product_Quantity_txt";
            Product_Quantity_txt.Size = new Size(100, 23);
            Product_Quantity_txt.TabIndex = 28;
            // 
            // PQuantity_lbl
            // 
            PQuantity_lbl.AutoSize = true;
            PQuantity_lbl.Location = new Point(431, 292);
            PQuantity_lbl.Name = "PQuantity_lbl";
            PQuantity_lbl.Size = new Size(67, 15);
            PQuantity_lbl.TabIndex = 27;
            PQuantity_lbl.Text = "Ürün Adedi";
            // 
            // PSize_lbl
            // 
            PSize_lbl.AutoSize = true;
            PSize_lbl.Location = new Point(426, 252);
            PSize_lbl.Name = "PSize_lbl";
            PSize_lbl.Size = new Size(72, 15);
            PSize_lbl.TabIndex = 26;
            PSize_lbl.Text = "Ürün Bedeni";
            // 
            // PColor_lbl
            // 
            PColor_lbl.AutoSize = true;
            PColor_lbl.Location = new Point(432, 208);
            PColor_lbl.Name = "PColor_lbl";
            PColor_lbl.Size = new Size(66, 15);
            PColor_lbl.TabIndex = 25;
            PColor_lbl.Text = "Ürün Rengi";
            // 
            // PModel_lbl
            // 
            PModel_lbl.AutoSize = true;
            PModel_lbl.Location = new Point(425, 163);
            PModel_lbl.Name = "PModel_lbl";
            PModel_lbl.Size = new Size(73, 15);
            PModel_lbl.TabIndex = 24;
            PModel_lbl.Text = "Ürün Modeli";
            // 
            // PName_lbl
            // 
            PName_lbl.AutoSize = true;
            PName_lbl.Location = new Point(444, 120);
            PName_lbl.Name = "PName_lbl";
            PName_lbl.Size = new Size(54, 15);
            PName_lbl.TabIndex = 23;
            PName_lbl.Text = "Ürün Adı";
            // 
            // Barkod_lbl
            // 
            Barkod_lbl.AutoSize = true;
            Barkod_lbl.Location = new Point(435, 75);
            Barkod_lbl.Name = "Barkod_lbl";
            Barkod_lbl.Size = new Size(63, 15);
            Barkod_lbl.TabIndex = 22;
            Barkod_lbl.Text = "Barkod No";
            // 
            // Barcode_No_txt
            // 
            Barcode_No_txt.Location = new Point(504, 72);
            Barcode_No_txt.Name = "Barcode_No_txt";
            Barcode_No_txt.Size = new Size(100, 23);
            Barcode_No_txt.TabIndex = 21;
            // 
            // Product_Color_txt
            // 
            Product_Color_txt.Location = new Point(504, 205);
            Product_Color_txt.Name = "Product_Color_txt";
            Product_Color_txt.Size = new Size(100, 23);
            Product_Color_txt.TabIndex = 20;
            // 
            // Product_Name_txt
            // 
            Product_Name_txt.Location = new Point(504, 117);
            Product_Name_txt.Name = "Product_Name_txt";
            Product_Name_txt.Size = new Size(100, 23);
            Product_Name_txt.TabIndex = 19;
            // 
            // Product_model_txt
            // 
            Product_model_txt.Location = new Point(504, 160);
            Product_model_txt.Name = "Product_model_txt";
            Product_model_txt.Size = new Size(100, 23);
            Product_model_txt.TabIndex = 18;
            // 
            // Product_Size_txt
            // 
            Product_Size_txt.Location = new Point(504, 249);
            Product_Size_txt.Name = "Product_Size_txt";
            Product_Size_txt.Size = new Size(100, 23);
            Product_Size_txt.TabIndex = 17;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(504, 380);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(100, 54);
            btn_Update.TabIndex = 31;
            btn_Update.Text = "Onayla";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += Update_Click;
            // 
            // btn_Envanter
            // 
            btn_Envanter.Location = new Point(222, 380);
            btn_Envanter.Name = "btn_Envanter";
            btn_Envanter.Size = new Size(96, 54);
            btn_Envanter.TabIndex = 32;
            btn_Envanter.Text = "Envanter";
            btn_Envanter.UseVisualStyleBackColor = true;
            btn_Envanter.Click += Envanter_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(990, 28);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(135, 34);
            btn_Close.TabIndex = 33;
            btn_Close.Text = "Uygulamayı Kapat";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // Guncelleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 562);
            Controls.Add(btn_Close);
            Controls.Add(btn_Envanter);
            Controls.Add(btn_Update);
            Controls.Add(PPrice_lbl);
            Controls.Add(Product_Price_txt);
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
            Name = "Guncelleme";
            Text = "Form4";
            Load += Update_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PPrice_lbl;
        private TextBox Product_Price_txt;
        private TextBox Product_Quantity_txt;
        private Label PQuantity_lbl;
        private Label PSize_lbl;
        private Label PColor_lbl;
        private Label PModel_lbl;
        private Label PName_lbl;
        private Label Barkod_lbl;
        private TextBox Barcode_No_txt;
        private TextBox Product_Color_txt;
        private TextBox Product_Name_txt;
        private TextBox Product_model_txt;
        private TextBox Product_Size_txt;
        private Button btn_Update;
        private Button btn_Envanter;
        private Button btn_Close;
    }
}