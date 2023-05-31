//using Guven_Barkod_BackEnd.Entities;
//using System.IO;
//namespace Helpers
//{

//    public class CreateFile
//    {
//        //private static string systemDirectory = "C:\\Users\\Asus\\OneDrive\\Masaüstü\\log"; // Guven
//        private static string systemDirectory = "C:\\Users\\mgulle\\Desktop\\log"; // ben
//        //private static string systemDirectory = "C:\\Users\\casper\\Desktop\\log"; // Aysi

//        private static string filePath = $"{systemDirectory}\\files";
//        private static string file = $"{systemDirectory}\\files\\{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.txt";
//        public List<CartItem> CartItems { get; set; }

//        public CreateFile(List<CartItem> cartItems)
//        {
//            this.CartItems = cartItems;
//        }

//        public void createLog()
//        {

//            if (!Directory.Exists(filePath))
//            {
//                // Try to create the directory.
//                DirectoryInfo di = Directory.CreateDirectory(filePath);
//            }

//            // This text is added only once to the file.
//            if (!File.Exists(file))
//            {
//                // Create a file to write to.
//                File.Create(file);
//            }

//            // This text is always added, making the file longer over time
//            // if it is not deleted.

//            foreach (var cartItem in CartItems)
//            {
//                string log = cartItem.ToString();

//                SaveFile(log);
//            }
//        }

//        private void SaveFile(string log)
//        {
//            FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
//            fs.Close();
//            File.AppendAllText(file, Environment.NewLine + log);
//        }
//    }
//}
using Guven_Barkod_BackEnd.Entities;

namespace Helpers
{
    public class Helper
    {
        private static string systemDirectory = "C:\\Users\\mgulle\\Desktop\\log";

        private static string filePath = $"{systemDirectory}\\files";
        private static string file = $"{systemDirectory}\\files\\{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.txt";

        public List<CartItem> CartItems { get; set; }

        public Helper(List<CartItem> cartItems)
        {
            this.CartItems = cartItems;
        }

        public void createLog()
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            using (StreamWriter sw = File.AppendText(file))
            {
                foreach (var cartItem in CartItems)
                {
                    sw.WriteLine(cartItem.ToString());
                }
            }
        }
        public void ConvertToPDF()
        {
            string html = GetHtmlFromText();
            var renderer = new HtmlToPdf();

            // Add a header to every page easily
            renderer.RenderingOptions.FirstPageNumber = 1; // use 2 if a cover page  will be appended
            renderer.RenderingOptions.TextHeader.DrawDividerLine = true;
            renderer.RenderingOptions.TextHeader.CenterText = "Güven Barkod Sistemi Günlük Satis Raporu";
            renderer.RenderingOptions.TextHeader.Font = IronPdf.Font.FontTypes.Helvetica;
            renderer.RenderingOptions.TextHeader.FontSize = 12;
            renderer.RenderingOptions.MarginTop = 25; //create 25mm space for header

            // Add a footer too
            renderer.RenderingOptions.TextFooter.DrawDividerLine = true;
            renderer.RenderingOptions.TextFooter.Font = IronPdf.Font.FontTypes.Arial;
            renderer.RenderingOptions.TextFooter.FontSize = 10;
            renderer.RenderingOptions.TextFooter.LeftText = "{date} {time}";
            renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";
            renderer.RenderingOptions.MarginTop = 25; //create 25mm space for footer
            var pdf = renderer.RenderHtmlAsPdf(html);
            var pdfFilePath = @"C:\Users\mgulle\Desktop\log\pdf\" + $"{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pdf";
            pdf.SaveAs(pdfFilePath);

        }

        private static string GetHtmlFromText()
        {
            string[] lines = File.ReadAllLines(file);

            string html = "<html><body>";
            foreach (var line in lines)
            {
                html += "<p>" + line + "</p>";
            }
            html += "</body></html>";
            return html;
        }
    }
}