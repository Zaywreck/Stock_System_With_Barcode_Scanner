using Guven_Barkod_BackEnd.Entities;
using OfficeOpenXml;
using Guven_Barkod_BackEnd.Services;

namespace Helpers
{
    public class Helper
    {
        //private static string systemDirectory = "C:\\Users\\Asus\\OneDrive\\Masaüstü\\log"; // Guven
        private static string systemDirectory = "C:\\Users\\mgulle\\Desktop\\log"; // ben
        //private static string systemDirectory = "C:\\Users\\casper\\Desktop\\log"; // Aysi

        private static string filePath = $"{systemDirectory}\\files";
        private static string file = $"{systemDirectory}\\files\\{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.txt";

        public List<CartItem> CartItems { get; set; }

        public Helper()
        {

        }
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
        public void ReadFromExcel()
        {
            string filePath = "C:\\Users\\mgulle\\Desktop\\log\\GB_Stok.xlsx"; // Update with the actual file path
            ProductService service = new ProductService();
            service.DeleteAllProducts();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Set the LicenseContext
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming data is on the first worksheet
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // Start from row 2 to skip header row
                {
                    string barcode = worksheet.Cells[row, 1].Value.ToString(); // Assuming column 1 contains the barcode
                    string productName = worksheet.Cells[row, 2].Value.ToString(); // Assuming column 2 contains the product name
                    string productModel = worksheet.Cells[row, 3].Value.ToString(); // Assuming column 3 contains the product model
                    string productColor = worksheet.Cells[row, 4].Value.ToString(); // Assuming column 4 contains the product color
                    string productSize = worksheet.Cells[row, 5].Value.ToString(); // Assuming column 5 contains the product size
                    int productQuantity = int.Parse(worksheet.Cells[row, 6].Value.ToString()); // Assuming column 6 contains the product quantity
                    double productPrice = double.Parse(worksheet.Cells[row, 7].Value.ToString()); // Assuming column 7 contains the product price
                    double productPurchasePrice = double.Parse(worksheet.Cells[row, 8].Value.ToString()); // Assuming column 8 contains the product purchase price

                    // Add the data to your database using EF Core
                    Product product = new Product()
                    {
                        Barcode_ID = barcode,
                        Product_Name = productName,
                        Product_Model = productModel,
                        Product_Color = productColor,
                        Product_Size = productSize,
                        Product_Quantity = productQuantity,
                        Product_Price = productPrice,
                        Product_Purch_Price = productPurchasePrice
                    };

                    service.CreateProduct(product);
                }
            }
        }

    }
}