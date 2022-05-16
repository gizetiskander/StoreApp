using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp1
{
    class Operations
    {
        public static List<Product> prod = new List<Product>();
        public static void ShowProductList()
        {
            Console.WriteLine("Список товаров:");
            prod.Add(new Product() { ID = 01, Name = "Пеленка", Description = "Одноразовые пеленки 60х90", Maker = "Helen Harper", Price = 687.70, Availaible = true, Count = 5 });
            prod.Add(new Product() { ID = 02, Name = "Памперсы", Description = "Японские памперсы 9-14кг", Maker = "Momi", Price = 999.99, Availaible = true, Count = 6 });
            prod.Add(new Product() { ID = 03, Name = "Коляска", Description = "Коляска-Трансформер 2 в 1", Maker = "LINDA", Price = 20010.05, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 04, Name = "Бутылочка", Description = "Силиконовая бутылочка для кормления", Maker = "Olobaby", Price = 2745.50, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 05, Name = "Детская смесь", Description = "Молочко детское", Maker = "Nestle", Price = 889.90, Availaible = false, Count = 0 });
            
            Console.WriteLine();
            foreach (Product p in prod)
            {
                Console.WriteLine($"ID товара: {p.ID}", p.ID);
                Console.WriteLine($"Название товара: {p.Name}", p.Name);
                Console.WriteLine($"Описание товара: {p.Description}", p.Description);
                Console.WriteLine($"Производитель товара: {p.Maker}", p.Maker);
                Console.WriteLine($"Доступность товара: {p.Availaible}", p.Availaible);
                Console.WriteLine($"Кол-во товара: {p.Count}", p.Count);
            }
        }

        public static void PayProduct(Payment payment, double pay, int delivery, string address)
        {
            double result = 0;
            result = pay;
            Console.WriteLine($"Товар куплен{result}", result);
        }


    }
}
