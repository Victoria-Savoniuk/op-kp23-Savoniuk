using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework;

namespace Coursework
{
    class ShoppingCart
    {
        public static ShoppingCart shoppingCart = new ShoppingCart();
        private List<ShoppingCartItem> items;
        public ShoppingCart()
        {
            items = new List<ShoppingCartItem>();
        }

        public string AddItem(Product product, int quantity, double totalPrice)
        {
            var item = items.Find(p => p.Product.Name == product.Name);
            if (item == null)
            {
                items.Add(new ShoppingCartItem { Product = product, Quantity = quantity, TotalPrice = totalPrice });
                return ($"{product.Name}, quantity - {quantity} added to the shopping cart. \r\nTotal cost: {totalPrice}");
            }
            else
            {
                item.Quantity += quantity;
                item.TotalPrice += totalPrice;
                return ($"{product.Name}, quantity - {quantity} added to the shopping cart. \r\nTotal cost: {totalPrice}");
            }
        }
        public string AddItem(Product product, string size, int quantity, double totalPrice)
        {
            var item = items.Find(p => p.Product.Name == product.Name);
            if (item == null || item.ClothingSize != size)
            {
                items.Add(new ShoppingCartItem { Product = product, Quantity = quantity, TotalPrice = totalPrice, ClothingSize = size });
                return ($"{product.Name}, size {size}, quantity - {quantity} added to the shopping cart. \r\nTotal cost: {totalPrice}");
            }
            else
            {
                item.Quantity += quantity;
                item.TotalPrice += totalPrice;
                return ($"{product.Name}, size {size}, quantity - {quantity} added to the shopping cart. \r\nTotal cost: {totalPrice}");
            }
        }
        public string AddItem(Product product, int size, int quantity, double totalPrice)
        {
            var item = items.Find(p => p.Product.Name == product.Name);
            if (item == null || item.FootwearSize != size)
            {
                items.Add(new ShoppingCartItem { Product = product, Quantity = quantity, TotalPrice = totalPrice, FootwearSize = size });
                return ($"{product.Name}, size {size}, quantity - {quantity} added to the shopping cart. \r\nTotal cost: {totalPrice}");
            }
            else
            {
                item.Quantity += quantity;
                item.TotalPrice += totalPrice;
                return ($"{product.Name}, size {size}, quantity - {quantity} added to the shopping cart. \r\nTotal cost: {totalPrice}");
            }
        }
        public string RemoveItem(Store store, string productName, string clothingSize, int footwearSize)
        {
            var product = items.Find(p => p.Product.Name == productName);
            if (store.isClothing(productName))
            {
                if (product != null && product.ClothingSize == clothingSize)
                {
                    store.DatabaseAdjustments(product.Product.Name, product.ClothingSize, product.FootwearSize, product.Quantity);
                    items.Remove(product);
                    return ($"{product.Product.Name} removed from the shopping cart.");
                }
                return ($"Product {productName} not found.");
            }
            else if (store.isFootwear(productName))
            {
                if (product != null && product.FootwearSize == footwearSize)
                {
                    store.DatabaseAdjustments(product.Product.Name, product.ClothingSize, product.FootwearSize, product.Quantity);
                    items.Remove(product);
                    return ($"{product.Product.Name} removed from the shopping cart.");
                }
                return ($"Product {productName} not found.");
            }
            else
            {
                if (product != null)
                {
                    store.DatabaseAdjustments(product.Product.Name, product.ClothingSize, product.FootwearSize, product.Quantity);
                    items.Remove(product);
                    return ($"{product.Product.Name} removed from the shopping cart.");
                }
                return ($"Product {productName} not found.");
            }
        }

        public string ClearCart(Store store)
        {
            foreach (var item in items)
            {
                store.DatabaseAdjustments(item.Product.Name, item.ClothingSize, item.FootwearSize, item.Quantity);
            }
            items.Clear();
            return ("Shopping cart cleared.");
        }

        public List<ShoppingCartItem> ViewCartItems()
        {
            return items;
        }
        public string Checkout()
        {
            if (items.Count == 0)
            {
                return ("Your shopping basket is empty");
            }
            else
            {
                string message = "\tThe Victoria Boutique\r\n";
                double totalValue = 0;
                foreach (var item in items)
                {
                    string nameAndQuantity = ($"{item.Product.Name}, {item.Quantity}");
                    message += ($"\r\n{nameAndQuantity}");
                    for (int i = 0; i < 35 - nameAndQuantity.Length; i++)
                    {
                        message += ".";
                    }
                    message += ($"{item.TotalPrice} UAN");
                    totalValue += item.TotalPrice;
                }
                message += ("\r\n=======================================");
                message += ($"\r\nTOTAL PURCHASE COST: {totalValue} UAN\r\n");
                message += ("\r\n=======================================");
                message += ("\r\n\tBuyer data:");
                message += ($"\r\nName: {StartBuyerPage.buyer.FirstName} {StartBuyerPage.buyer.LastName}");
                message += ($"\r\nPhone number: {StartBuyerPage.buyer.PhoneNumber}");
                message += ($"\r\nThe address to which the purchase was sent: \r\n{StartBuyerPage.buyer.ShippingAddress}");
                items.Clear();
                return (message);
            }
        }
        public void WriteCheckoutToFile(string checkout, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(checkout);
            }
        }
    }
}
