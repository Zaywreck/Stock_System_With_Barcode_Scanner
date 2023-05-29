using Guven_Barkod_BackEnd.Entities;
using System.IO;
namespace Helpers
{

    public class CreateFile
    {
        //private static string systemDirectory = "C:\\Users\\Asus\\OneDrive\\Masaüstü\\log"; // Guven
        private static string systemDirectory = "C:\\Users\\mgulle\\Desktop\\log"; // ben
        //private static string systemDirectory = "C:\\Users\\casper\\Desktop\\log"; // Aysi

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
            if (!File.Exists(file))
            {
                // Create a file to write to.
                File.Create(file);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.

            foreach (var cartItem in CartItems)
            {
                string log = cartItem.ToString();

                SaveFile(log);
            }
        }

        private void SaveFile(string log)
        {
            FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(file, Environment.NewLine + log);
        }
    }
}