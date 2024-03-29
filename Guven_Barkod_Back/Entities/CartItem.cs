﻿namespace Guven_Barkod_BackEnd.Entities
{
    public class CartItem
    {
        public Product Product { get; set; }
        public string? Barcode_Id { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }
        public string? TotalPrice { get; set; }
        public string? CustomerInfo { get; set; }
        public string? CustomerPhoneNumber { get; set; }
        public DateTime date = DateTime.Now;

        public override string ToString()
        {
            return $"=> Ürün Adı:{Product.Product_Name} || Satış Miktari:{Quantity} || Toplam Fiyat: {Quantity*Product.Product_Price} || Elde edilen Kar : {Quantity*(Product.Product_Price - Product.Product_Purch_Price)} || Alınan Ücret: {TotalPrice} || Müşteri Adı : {CustomerInfo} || Müşteri Telefon : {CustomerPhoneNumber} || Satış Saati:  {date.Hour}:{date.Minute}" + "\n";
        }
    }
}
