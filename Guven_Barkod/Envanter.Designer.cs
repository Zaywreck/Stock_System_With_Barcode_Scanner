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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(859, 403);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1000, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 58);
            button1.TabIndex = 1;
            button1.Text = "Satış Ekranı";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1000, 307);
            button2.Name = "button2";
            button2.Size = new Size(94, 58);
            button2.TabIndex = 2;
            button2.Text = "Ürün ekleme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 32);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Envanter";
            // 
            // button3
            // 
            button3.Location = new Point(1000, 159);
            button3.Name = "button3";
            button3.Size = new Size(94, 56);
            button3.TabIndex = 4;
            button3.Text = "Ürün Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1000, 232);
            button4.Name = "button4";
            button4.Size = new Size(94, 58);
            button4.TabIndex = 5;
            button4.Text = "Ürün Güncelle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1000, 72);
            button5.Name = "button5";
            button5.Size = new Size(94, 23);
            button5.TabIndex = 6;
            button5.Text = "Miktar artır";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1000, 112);
            button6.Name = "button6";
            button6.Size = new Size(94, 23);
            button6.TabIndex = 7;
            button6.Text = "Miktar azalt";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 558);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}