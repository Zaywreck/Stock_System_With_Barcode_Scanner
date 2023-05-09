using Guven_Barkod_BackEnd.Entities;
using Guven_Barkod_BackEnd.Services;
using System.IO.Ports;

namespace Guven_Barkod
{
    public partial class Sepet : Form
    {
        ProductService productService;
        List<Product> products;
        public Sepet()
        {
            products = new List<Product>();
            productService = new ProductService();
            InitializeComponent();
            SerialPort mySerialPort = new SerialPort("COM"); // Takılan cihazın com değeri buraya girilecek
            // buraya cihazın kalan port bilgileri girilecek
            // aygıt yöneticisi -> bağlanan usb -> port ayarları
            //mySerialPort.BaudRate = 9600;
            //mySerialPort.Parity = Parity.None;
            //mySerialPort.StopBits = StopBits.One; 
            //mySerialPort.DataBits = 8;
            //mySerialPort.Handshake = Handshake.None;
            //mySerialPort.RtsEnable = true;

            //mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            //mySerialPort.Open();
        }
        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort sp = (SerialPort)sender;
            //string data = sp.ReadExisting(); // barkod numarası

            //BeginInvoke((MethodInvoker)(() =>
            //{
            //    var date = DateTime.Now;
            //    textBox2.AppendText(data);
            //}));

            //var prd = productService.GetProductById(data);
            //products.Add(prd);
            //dataGridView1.DataSource = products;
            //textBox1.Text = products.Sum(x=>x.Product_Price).ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1200, 640);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = new Ms_Ekleme();
            form1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form3 = new Envanter();
            form3.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
