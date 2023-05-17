using Guven_Barkod_BackEnd.Entities;
using System.IO;
namespace Helpers
{
    public class CreateFile
    {
        private static string systemDirectory = AppContext.BaseDirectory.Replace("bin\\Debug\\net6.0-windows10.0.19041.0\\", "");

        private static string filePath = $"{systemDirectory}\\files";
        private static string file = $"{systemDirectory}\\files\\{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.txt";
        public List<CartItem> CartItems { get; set; }

        public CreateFile(List<CartItem> cartItems)
        {
            this.CartItems = cartItems;
        }

        public void createLog()
        {

            if (!Directory.Exists(filePath))
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(filePath);
            }

            // This text is added only once to the file.
            if (!File.Exists(filePath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    foreach (var cartItem in CartItems)
                    {
                        string log=cartItem.ToString();
                        sw.WriteLine(log);
                    }
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(file))
            {
                foreach (var cartItem in CartItems)
                {
                    string log = cartItem.ToString();
                    sw.WriteLine(log);
                }
            }

            //// Open the file to read from.
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s = "";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
        }

    }
}