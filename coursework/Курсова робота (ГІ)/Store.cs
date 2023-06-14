using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Coursework
{
    class Store
    {
        public static Store store = new Store();
        private List<Product> _products;
        public List<Product> products
        {
            get { return _products; }
            set { _products = value; }
        }
        public Store()
        {
            _products = new List<Product>();
        }

        public string AddProduct(Product product)
        {
            var item = products.Find(p => p.Name == product.Name);
            if (item == null )
            {
                products.Add(product);
                return ("Product added.");
            }
            else
            {
                return ("A product with this name already exists! Enter a different product name");
            }
        }
        public static string operator +(Store store, Product product)
        {
            return store.AddProduct(product);
        }
        public string AddOldProduct(string productName,int quantity, string clothingSize, int footwearSize)
        {
            var product = products.Find(p => p.Name == productName);
            if (product == null)
            {
                return ($"Product {productName} not found.");
            }
            else
            {
                if (isClothing(productName))
                {
                    Clothing clothing = products.Find(p => p.Name == productName) as Clothing;
                    if (clothing.Sizes.ContainsKey(clothingSize))
                    {
                        clothing.Sizes[clothingSize] += quantity;
                        int num = clothing.totalQuantity();
                    }
                    else
                    {
                        clothing.Sizes.Add(clothingSize, quantity);
                        int num = clothing.totalQuantity();
                    }
                    return ($"New quantity of \"{productName}\" product, size {clothingSize} - {clothing.Sizes[clothingSize]}");
                }
                else if (isFootwear(productName))
                {
                    Footwear footwear = products.Find(p => p.Name == productName) as Footwear;
                    if (footwear.Sizes.ContainsKey(footwearSize))
                    {
                        footwear.Sizes[footwearSize] += quantity;
                        int num = footwear.totalQuantity();
                    }
                    else
                    {
                        footwear.Sizes.Add(footwearSize, quantity);
                        int num = footwear.totalQuantity();
                    }
                    return ($"New quantity of \"{productName}\" product - {footwear.Sizes[footwearSize]}");
                }
                else
                {
                    product.Quantity += quantity;
                    return ($"New quantity of \"{productName}\" product - {product.Quantity}");
                }
            }
        }

        public string RemoveProduct(string productName)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                products.Remove(product);
                return ($"{productName} removed.");
            }
            else
            {
                return ($"Product {productName} not found.");
            }
        }
        public static string operator -(Store store, string productName)
        {
            return store.RemoveProduct(productName);
        }

        public string ApplyDiscount(string productName, double discount)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                if (discount <= 100 && discount >= 0)
                {
                    string message = $"{product.Name}:\r\nOld price: {product.Price} UAN";
                    product.Price -= product.Price * (discount / 100);
                    message += ($"\r\nNew price: {product.Price}.\r\nDiscount applied.");
                    return message;
                }
                else
                {
                    return "Discount must be greater than 0 and less than 100!";
                }
            }
            else
            {
                return ("Product not found.");
            }
        }

        public string SellProduct(ShoppingCart shoppingCart, string name, int quantity)
        {
            Product product = products.Find(p => p.Name == name);
            if (product.Quantity < quantity)
            {
                return "Not enough good in stock";
            }
            else if (quantity <= 0)
            {
                return "The quantity of the product must be greater than 0!";
            }
            else
            {
                double totalPrice = product.Price * quantity;
                product.Quantity -= quantity;
                return shoppingCart.AddItem(product, quantity, totalPrice);
            }
        }
        public string SellProduct(ShoppingCart shoppingCart, string name, string size, int quantity)
        {
            Clothing product = products.Find(p => p.Name == name) as Clothing;
            if (product.Sizes[size] < quantity)
            {
                return "Not enough good in stock";
            }
            else if (quantity <= 0)
            {
                return "The quantity of the product must be greater than 0!";
            }
            else
            {
                double totalPrice = product.Price * quantity;
                product.Sizes[size] -= quantity;
                return shoppingCart.AddItem(product, size, quantity, totalPrice);
            }
        }
        public string SellProduct(ShoppingCart shoppingCart, string name, int size, int quantity)
        {
            Footwear product = products.Find(p => p.Name == name) as Footwear;
            if (product.Sizes[size] < quantity)
            {
                return "Not enough good in stock";
            }
            else if (quantity <= 0)
            {
                return "The quantity of the product must be greater than 0!";
            }
            else
            {
                double totalPrice = product.Price * quantity;
                product.Sizes[size] -= quantity;
                return shoppingCart.AddItem(product, size, quantity, totalPrice);
            }
        }
        public void DatabaseAdjustments(string name, string clothingSize, int footwearSize, int quantity)
        {
            if (clothingSize != null)
            {
                Clothing product = products.Find(p => p.Name == name) as Clothing;
                product.Sizes[clothingSize] += quantity;
            }
            else if (footwearSize != 0)
            {
                Footwear product = products.Find(p => p.Name == name) as Footwear;
                product.Sizes[footwearSize] += quantity;
            }
            else
            {
                var product = products.Find(p => p.Name == name);
                product.Quantity += quantity;
            }
        }
        public string Inventory()
        {
            double totalValue = 0;
            string text = "";

            text = "Inventory:";
            text += $"\r\nProduct name        Quantity            Price";
            text += "\r\n-----------------------------------------------------------";
            foreach (var product in products)
            {
                double value = product.Price * product.Quantity;
                totalValue += value;
                text += $"\r\n{product.Name}";
                for (int i = 0; i <= 20 - product.Name.Length; i++)
                {
                    text += " ";
                }
                text += $"{product.Quantity}";
                string s = Convert.ToString(product.Quantity);
                for (int i = 0; i < 20 - s.Length; i++)
                {
                    text += " ";
                }
                text += product.Price + " UAH";
            }
            text += "\r\n-----------------------------------------------------------";
            text += $"\r\nTotal cost of goods: {totalValue} UAH";
            return text;
        }
        public bool isClothing(string nameProduct)
        {
            foreach (var product in products)
            {
                if (product.Name == nameProduct)
                {
                    if (product is Clothing)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool isFootwear(string nameProduct)
        {
            foreach (var product in products)
            {
                if (product.Name == nameProduct)
                {
                    if (product is Footwear)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public Dictionary<string, string> DisplayAllProducts()
        {
            Dictionary<string, string> displayAllProducts = new Dictionary<string, string>();
            foreach (var product in products)
            {
                displayAllProducts[product.Name] = product.PathImage;
            }
            return displayAllProducts;
        }
        public string PathImage(string productName)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                return product.PathImage;
            }
            else
            {
                return ("C:\\Users\\Віта\\Desktop\\фон\\no image.png");
            }
        }
        public Dictionary<int, int> FootwearSize(string productName)
        {
            Footwear product = products.Find(p => p.Name == productName) as Footwear;
            return product.Sizes;
        }
        public Dictionary<string, int> ClothingSize(string productName)
        {
            Clothing product = products.Find(p => p.Name == productName) as Clothing;
            return product.Sizes;
        }
        public string DisplayProductDetails(string productName)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                return product.DisplayInfo();
            }
            else
            {
                return ("Product not found.");
            }
        }
    }
}
