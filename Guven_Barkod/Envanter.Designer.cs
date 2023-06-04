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
            sumOfPurchase_txt = new TextBox();
            sumOfSell_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Aprox_Profit_txt = new TextBox();
            label3 = new Label();
            btn_Show_Values = new Button();
            Inventory_Update_wExcel_btn = new Button();
            lbl_Excel = new Label();
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
            // sumOfPurchase_txt
            // 
            sumOfPurchase_txt.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            sumOfPurchase_txt.Location = new Point(79, 503);
            sumOfPurchase_txt.Name = "sumOfPurchase_txt";
            sumOfPurchase_txt.Size = new Size(209, 78);
            sumOfPurchase_txt.TabIndex = 35;
            // 
            // sumOfSell_txt
            // 
            sumOfSell_txt.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            sumOfSell_txt.Location = new Point(353, 503);
            sumOfSell_txt.Name = "sumOfSell_txt";
            sumOfSell_txt.Size = new Size(209, 78);
            sumOfSell_txt.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 485);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 37;
            label1.Text = "Toplam Alış Maliyeti";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 485);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 38;
            label2.Text = "Toplam Satış Geliri";
            // 
            // Aprox_Profit_txt
            // 
            Aprox_Profit_txt.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            Aprox_Profit_txt.Location = new Point(653, 503);
            Aprox_Profit_txt.Name = "Aprox_Profit_txt";
            Aprox_Profit_txt.Size = new Size(209, 78);
            Aprox_Profit_txt.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(694, 485);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 40;
            label3.Text = "Toplam Tahmini Kar";
            // 
            // btn_Show_Values
            // 
            btn_Show_Values.Location = new Point(927, 514);
            btn_Show_Values.Name = "btn_Show_Values";
            btn_Show_Values.Size = new Size(94, 58);
            btn_Show_Values.TabIndex = 41;
            btn_Show_Values.Text = "Değerleri Göster";
            btn_Show_Values.UseVisualStyleBackColor = true;
            btn_Show_Values.Click += btn_Show_Values_Click;
            // 
            // Inventory_Update_wExcel_btn
            // 
            Inventory_Update_wExcel_btn.Location = new Point(1121, 464);
            Inventory_Update_wExcel_btn.Name = "Inventory_Update_wExcel_btn";
            Inventory_Update_wExcel_btn.Size = new Size(94, 60);
            Inventory_Update_wExcel_btn.TabIndex = 42;
            Inventory_Update_wExcel_btn.Text = "Envanteri Güncelle";
            Inventory_Update_wExcel_btn.UseVisualStyleBackColor = true;
            Inventory_Update_wExcel_btn.Click += Inventory_Update_wExcel_btn_Click;
            // 
            // lbl_Excel
            // 
            lbl_Excel.AutoSize = true;
            lbl_Excel.Location = new Point(1066, 487);
            lbl_Excel.Name = "lbl_Excel";
            lbl_Excel.Size = new Size(49, 15);
            lbl_Excel.TabIndex = 43;
            lbl_Excel.Text = "Excel ile";
            // 
            // Envanter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 612);
            Controls.Add(lbl_Excel);
            Controls.Add(Inventory_Update_wExcel_btn);
            Controls.Add(btn_Show_Values);
            Controls.Add(label3);
            Controls.Add(Aprox_Profit_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sumOfSell_txt);
            Controls.Add(sumOfPurchase_txt);
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
        private TextBox sumOfPurchase_txt;
        private TextBox sumOfSell_txt;
        private Label label1;
        private Label label2;
        private TextBox Aprox_Profit_txt;
        private Label label3;
        private Button btn_Show_Values;
        private Button Inventory_Update_wExcel_btn;
        private Label lbl_Excel;
    }
}