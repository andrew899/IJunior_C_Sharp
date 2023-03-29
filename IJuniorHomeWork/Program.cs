using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Trader trader = new Trader();
            Player player = new Player();

            Console.WriteLine("Weclome to shop.");

            bool isWorking = true;
            do
            {
                Console.WriteLine("1. Trader show all products.");
                Console.WriteLine("2. Player show all products.");
                Console.WriteLine("3. Trader give Player product.");
                Console.WriteLine("4. Exit.");
                if (Int32.TryParse(Console.ReadLine(), out int menuItem))
                {
                    switch (menuItem)
                    {   
                        case 1:
                            trader.ShowAllProducts();
                            break;
                        case 2:
                            player.ShowAllProducts();
                            break;
                        case 3:
                            Console.Write("Enter index of product to get from Trader: ");
                            if (Int32.TryParse(Console.ReadLine(), out int productIndex))
                            {
                                if(trader.GiveProduct(productIndex, out Product productForPlayer));
                                    player.AddProduct(productForPlayer);
                            }
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Wrong menu item try again.");
                            break;
                    }
                }

            } while (isWorking);
        }
    }

    public class Player
    {
        private List<Product> _products = new List<Product>();
        private int _productAmount => _products.Count;

        public Player()
        {
        }

        public void ShowAllProducts()
        {
            if (_productAmount == 0)
            {
                Console.WriteLine("Player has no products.");
                return;
            }

            foreach (var product in _products)
            {
                Console.WriteLine($"Product name: {product.Name}");
            }
        }

        public void AddProduct (Product productToAdd)
        {
            _products.Add(productToAdd);
        }
    }

    public class Trader
    {
        private List<Product> _products = new List<Product>();
        private int _productAmount => _products.Count;

        public Trader()
        {
            _products.Add(new Product("Axe"));
            _products.Add(new Product("Sword"));
            _products.Add(new Product("Shield"));
            _products.Add(new Product("Potion"));
        }

        public void ShowAllProducts()
        {
            if (_productAmount == 0)
            {
                Console.WriteLine("Trader has no products.");
                return;
            }

            for (int i = 0; i < _productAmount; i++)
            {
                Console.WriteLine($"Product index: {i} name: {_products[i].Name}");
            } 
        }

        public bool GiveProduct(int productIndex, out Product productToGive)
        {
            bool isGiven = true;
            if (_productAmount == 0 || productIndex > _productAmount)
            {
                Console.WriteLine("Trader has no such product.");
                productToGive = null;
                isGiven = false;
                return isGiven;
            }

            productToGive = _products[productIndex];
            _products.RemoveAt(productIndex);
            return isGiven;
        }
    }

    public class Product
    {
        public string Name { get; }

        public Product(string name)
        {
            Name = name;
        }
    }
}
