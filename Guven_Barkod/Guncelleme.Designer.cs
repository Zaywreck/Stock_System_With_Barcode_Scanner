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
            Fiyat = new Label();
            Product_Price_txt = new TextBox();
            Product_Quantity_txt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Barcode_No_txt = new TextBox();
            Product_Color_txt = new TextBox();
            Product_Name_txt = new TextBox();
            Product_model_txt = new TextBox();
            Product_Size_txt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Fiyat
            // 
            Fiyat.AutoSize = true;
            Fiyat.Location = new Point(466, 335);
            Fiyat.Name = "Fiyat";
            Fiyat.Size = new Size(32, 15);
            Fiyat.TabIndex = 30;
            Fiyat.Text = "Fiyat";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(431, 292);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 27;
            label6.Text = "Ürün Adedi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 252);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 26;
            label5.Text = "Ürün Bedeni";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 208);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 25;
            label4.Text = "Ürün Rengi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 163);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 24;
            label3.Text = "Ürün Modeli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 120);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 23;
            label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(435, 75);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 22;
            label1.Text = "Barkod No";
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
            // button1
            // 
            button1.Location = new Point(504, 380);
            button1.Name = "button1";
            button1.Size = new Size(100, 54);
            button1.TabIndex = 31;
            button1.Text = "Onayla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(222, 380);
            button2.Name = "button2";
            button2.Size = new Size(96, 54);
            button2.TabIndex = 32;
            button2.Text = "Envanter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 562);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Fiyat);
            Controls.Add(Product_Price_txt);
            Controls.Add(Product_Quantity_txt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Barcode_No_txt);
            Controls.Add(Product_Color_txt);
            Controls.Add(Product_Name_txt);
            Controls.Add(Product_model_txt);
            Controls.Add(Product_Size_txt);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Fiyat;
        private TextBox Product_Price_txt;
        private TextBox Product_Quantity_txt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Barcode_No_txt;
        private TextBox Product_Color_txt;
        private TextBox Product_Name_txt;
        private TextBox Product_model_txt;
        private TextBox Product_Size_txt;
        private Button button1;
        private Button button2;
    }
}