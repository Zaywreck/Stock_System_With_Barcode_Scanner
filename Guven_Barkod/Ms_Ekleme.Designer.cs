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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Product_Quantity_txt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Product_Price_txt = new TextBox();
            Fiyat = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 53);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 5;
            label1.Text = "Barkod No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 98);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 141);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 7;
            label3.Text = "Ürün Modeli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 186);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "Ürün Rengi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 230);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 9;
            label5.Text = "Ürün Bedeni";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 270);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 10;
            label6.Text = "Ürün Adedi";
            // 
            // Product_Quantity_txt
            // 
            Product_Quantity_txt.Location = new Point(516, 267);
            Product_Quantity_txt.Name = "Product_Quantity_txt";
            Product_Quantity_txt.Size = new Size(100, 23);
            Product_Quantity_txt.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(247, 359);
            button1.Name = "button1";
            button1.Size = new Size(101, 62);
            button1.TabIndex = 12;
            button1.Text = "ENVANTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(515, 359);
            button2.Name = "button2";
            button2.Size = new Size(101, 62);
            button2.TabIndex = 13;
            button2.Text = "Ürünü Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(775, 359);
            button3.Name = "button3";
            button3.Size = new Size(101, 62);
            button3.TabIndex = 14;
            button3.Text = "Satış Ekranı";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Product_Price_txt
            // 
            Product_Price_txt.Location = new Point(516, 310);
            Product_Price_txt.Name = "Product_Price_txt";
            Product_Price_txt.Size = new Size(100, 23);
            Product_Price_txt.TabIndex = 15;
            // 
            // Fiyat
            // 
            Fiyat.AutoSize = true;
            Fiyat.Location = new Point(478, 313);
            Fiyat.Name = "Fiyat";
            Fiyat.Size = new Size(32, 15);
            Fiyat.TabIndex = 16;
            Fiyat.Text = "Fiyat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 569);
            Controls.Add(Fiyat);
            Controls.Add(Product_Price_txt);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Product_Size_txt;
        private TextBox Product_model_txt;
        private TextBox Product_Name_txt;
        private TextBox Product_Color_txt;
        private TextBox Barcode_No_txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Product_Quantity_txt;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox Product_Price_txt;
        private Label Fiyat;
    }
}