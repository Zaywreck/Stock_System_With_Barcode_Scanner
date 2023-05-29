namespace Guven_Barkod
{
    partial class Sepet
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
            components = new System.ComponentModel.Container();
            Sepet_lbl = new Label();
            Toplam_txt_box = new TextBox();
            Toplam_lbl = new Label();
            btn_Onayla = new Button();
            Cart_dgw = new DataGridView();
            form1BindingSource = new BindingSource(components);
            btn_Urun_Ekleme = new Button();
            btn_Envanter = new Button();
            Barcode_txt_box = new TextBox();
            Barkod_lbl = new Label();
            btn_Remove_Product = new Button();
            btn_Close = new Button();
            Customer_Name_Surname_txt = new TextBox();
            Customer_PhoneNumber_txt = new TextBox();
            lbl_Customer_Name_Surname = new Label();
            lbl_Customer_PhoneNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)Cart_dgw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // Sepet_lbl
            // 
            Sepet_lbl.AutoSize = true;
            Sepet_lbl.Location = new Point(445, 47);
            Sepet_lbl.Name = "Sepet_lbl";
            Sepet_lbl.Size = new Size(38, 15);
            Sepet_lbl.TabIndex = 1;
            Sepet_lbl.Text = "SEPET";
            // 
            // Toplam_txt_box
            // 
            Toplam_txt_box.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            Toplam_txt_box.Location = new Point(810, 62);
            Toplam_txt_box.Name = "Toplam_txt_box";
            Toplam_txt_box.Size = new Size(174, 96);
            Toplam_txt_box.TabIndex = 2;
            // 
            // Toplam_lbl
            // 
            Toplam_lbl.AutoSize = true;
            Toplam_lbl.Location = new Point(751, 102);
            Toplam_lbl.Name = "Toplam_lbl";
            Toplam_lbl.Size = new Size(53, 15);
            Toplam_lbl.TabIndex = 3;
            Toplam_lbl.Text = "TOPLAM";
            // 
            // btn_Onayla
            // 
            btn_Onayla.Location = new Point(826, 164);
            btn_Onayla.Name = "btn_Onayla";
            btn_Onayla.Size = new Size(92, 70);
            btn_Onayla.TabIndex = 4;
            btn_Onayla.Text = "ONAYLA";
            btn_Onayla.UseVisualStyleBackColor = true;
            btn_Onayla.Click += btn_Sell_Click;
            // 
            // Cart_dgw
            // 
            Cart_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Cart_dgw.Location = new Point(256, 65);
            Cart_dgw.Name = "Cart_dgw";
            Cart_dgw.RowTemplate.Height = 25;
            Cart_dgw.Size = new Size(471, 325);
            Cart_dgw.TabIndex = 5;
            // 
            // btn_Urun_Ekleme
            // 
            btn_Urun_Ekleme.Location = new Point(826, 253);
            btn_Urun_Ekleme.Name = "btn_Urun_Ekleme";
            btn_Urun_Ekleme.Size = new Size(92, 72);
            btn_Urun_Ekleme.TabIndex = 6;
            btn_Urun_Ekleme.Text = "Ürün Ekleme";
            btn_Urun_Ekleme.UseVisualStyleBackColor = true;
            btn_Urun_Ekleme.Click += btn_productAdding_click;
            // 
            // btn_Envanter
            // 
            btn_Envanter.Location = new Point(826, 349);
            btn_Envanter.Name = "btn_Envanter";
            btn_Envanter.Size = new Size(92, 62);
            btn_Envanter.TabIndex = 7;
            btn_Envanter.Text = "Envanter";
            btn_Envanter.UseVisualStyleBackColor = true;
            btn_Envanter.Click += Envanter_Sayfası_Click;
            // 
            // Barcode_txt_box
            // 
            Barcode_txt_box.Location = new Point(32, 68);
            Barcode_txt_box.Name = "Barcode_txt_box";
            Barcode_txt_box.Size = new Size(133, 23);
            Barcode_txt_box.TabIndex = 0;
            Barcode_txt_box.TextChanged += eTextChange_Scanner;
            // 
            // Barkod_lbl
            // 
            Barkod_lbl.AutoSize = true;
            Barkod_lbl.Location = new Point(60, 50);
            Barkod_lbl.Name = "Barkod_lbl";
            Barkod_lbl.Size = new Size(63, 15);
            Barkod_lbl.TabIndex = 10;
            Barkod_lbl.Text = "Barkod No";
            // 
            // btn_Remove_Product
            // 
            btn_Remove_Product.Location = new Point(975, 164);
            btn_Remove_Product.Name = "btn_Remove_Product";
            btn_Remove_Product.Size = new Size(92, 70);
            btn_Remove_Product.TabIndex = 11;
            btn_Remove_Product.Text = "Ürün Çıkar";
            btn_Remove_Product.UseVisualStyleBackColor = true;
            btn_Remove_Product.Click += btn_Remove_Product_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(990, 28);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(135, 34);
            btn_Close.TabIndex = 12;
            btn_Close.Text = "Uygulamayı Kapat";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // Customer_Name_Surname_txt
            // 
            Customer_Name_Surname_txt.Location = new Point(32, 135);
            Customer_Name_Surname_txt.Name = "Customer_Name_Surname_txt";
            Customer_Name_Surname_txt.Size = new Size(133, 23);
            Customer_Name_Surname_txt.TabIndex = 13;
            // 
            // Customer_PhoneNumber_txt
            // 
            Customer_PhoneNumber_txt.Location = new Point(32, 189);
            Customer_PhoneNumber_txt.Name = "Customer_PhoneNumber_txt";
            Customer_PhoneNumber_txt.Size = new Size(133, 23);
            Customer_PhoneNumber_txt.TabIndex = 14;
            // 
            // lbl_Customer_Name_Surname
            // 
            lbl_Customer_Name_Surname.AutoSize = true;
            lbl_Customer_Name_Surname.Location = new Point(32, 117);
            lbl_Customer_Name_Surname.Name = "lbl_Customer_Name_Surname";
            lbl_Customer_Name_Surname.Size = new Size(106, 15);
            lbl_Customer_Name_Surname.TabIndex = 15;
            lbl_Customer_Name_Surname.Text = "Müşteri Adı Soyadı";
            // 
            // lbl_Customer_PhoneNumber
            // 
            lbl_Customer_PhoneNumber.AutoSize = true;
            lbl_Customer_PhoneNumber.Location = new Point(32, 171);
            lbl_Customer_PhoneNumber.Name = "lbl_Customer_PhoneNumber";
            lbl_Customer_PhoneNumber.Size = new Size(142, 15);
            lbl_Customer_PhoneNumber.TabIndex = 16;
            lbl_Customer_PhoneNumber.Text = "Müşteri Telefon Numarası";
            // 
            // Sepet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 482);
            Controls.Add(lbl_Customer_PhoneNumber);
            Controls.Add(lbl_Customer_Name_Surname);
            Controls.Add(Customer_PhoneNumber_txt);
            Controls.Add(Customer_Name_Surname_txt);
            Controls.Add(btn_Close);
            Controls.Add(btn_Remove_Product);
            Controls.Add(Barkod_lbl);
            Controls.Add(Barcode_txt_box);
            Controls.Add(btn_Envanter);
            Controls.Add(btn_Urun_Ekleme);
            Controls.Add(Cart_dgw);
            Controls.Add(btn_Onayla);
            Controls.Add(Toplam_lbl);
            Controls.Add(Toplam_txt_box);
            Controls.Add(Sepet_lbl);
            Name = "Sepet";
            Text = "Form2";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)Cart_dgw).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Sepet_lbl;
        private TextBox Toplam_txt_box;
        private Label Toplam_lbl;
        private Button btn_Onayla;
        private DataGridView Cart_dgw;
        private BindingSource form1BindingSource;
        private Button btn_Urun_Ekleme;
        private Button btn_Envanter;
        private TextBox Barcode_txt_box;
        private Label Barkod_lbl;
        private Button btn_Remove_Product;
        private Button btn_Close;
        private TextBox Customer_Name_Surname_txt;
        private TextBox Customer_PhoneNumber_txt;
        private Label lbl_Customer_Name_Surname;
        private Label lbl_Customer_PhoneNumber;
    }
}