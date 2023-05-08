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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            form1BindingSource = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(445, 47);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "SEPET";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(810, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(751, 68);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "TOPLAM";
            // 
            // button1
            // 
            button1.Location = new Point(826, 164);
            button1.Name = "button1";
            button1.Size = new Size(92, 70);
            button1.TabIndex = 4;
            button1.Text = "ONAYLA";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(256, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(471, 325);
            dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(826, 253);
            button2.Name = "button2";
            button2.Size = new Size(92, 72);
            button2.TabIndex = 6;
            button2.Text = "Ürün Ekleme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(826, 349);
            button3.Name = "button3";
            button3.Size = new Size(92, 62);
            button3.TabIndex = 7;
            button3.Text = "Envanter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(983, 164);
            button4.Name = "button4";
            button4.Size = new Size(92, 70);
            button4.TabIndex = 8;
            button4.Text = "Barkod Oku";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 50);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 10;
            label3.Text = "Barkod No";
            // 
            // Sepet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 482);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Sepet";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource form1BindingSource;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private Label label3;
    }
}