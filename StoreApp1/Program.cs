using System;
using System.Collections.Generic;
using StoreApp1;
using System.Linq;
using System.Xml.Linq;


namespace StoreApp1
{
    class Program 
    {
        public static List<Product> prod = new List<Product>();

        static void Main(string[] args)
        {

            Console.WriteLine("Выберите команду:");
            Console.WriteLine("1 - Показать товары");
            Console.WriteLine("2 - Выйти");
            String str = Console.ReadLine();
            switch (str)
            {
                case "1":
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
                        Console.WriteLine();
                    }
                    goto case "2";
                case "2":
                    Console.WriteLine("Выберите команду:");
                    Console.WriteLine("3- Найти товар по названию и описанию");
                    Console.WriteLine("4- Сортировка товара по возрастанию цены и фильтрация производителя");
                    Console.WriteLine("5- Сортировка товара по убыванию цены и фильтрация производителя");
                    string str1 = Console.ReadLine();
                    if (str1 == "3")
                    {
                        goto case "3";
                    }
                    else if (str1 == "4")
                    {
                       goto case "4";
                    }
                    else if (str1 == "5")
                    {
                      //  goto case "5";
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    goto case "1";
                case "3":
                    Console.WriteLine("Введите название товара:");
                    string str2 = Console.ReadLine();
                    if (str2 == "Пеленка" || str2 == "Одноразовые пеленки 60x90")
                    {
                        Product product = prod.Find(x => x.Name.Contains("Пеленка"));
                        Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
                    }
                    else if(str2 == "Памперсы" || str2 == "Японские памперсы 9-14кг")
                    {
                        Product product = prod.Find(x => x.Name.Contains("Памперсы"));
                        Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
                    }
                    else if (str2 == "Коляска" || str2 == "Коляска-Трансформер 2 в 1")
                    {
                        Product product = prod.Find(x => x.Name.Contains("Коляска"));
                        Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
                    }
                    else if (str2 == "Бутылочка" || str2 == "Силиконовая бутылочка для кормления")
                    {
                        Product product = prod.Find(x => x.Name.Contains("Бутылочка"));
                        Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
                    }
                    else if (str2 == "Детская смесь" || str2 == "Молочко детское")
                    {
                        Product product = prod.Find(x => x.Name.Contains("Детская смесь"));
                        Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
                    }
                    goto case "2";
                case "4":
                    Console.WriteLine("Введите Сортировка или Фильтрация:");
                    string str3 = Console.ReadLine();
                    if (str3 == "Сортировка")
                    {
                        var sortedPrice = from p in prod
                                          orderby p.Price
                                          select p;
                        foreach (var p in sortedPrice)
                            Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                    }
                    else if (str3 == "Фильтрация")
                    {
                        Console.WriteLine("Введите производителя:");
                        string str4 = Console.ReadLine();
                        if (str4 == "Helen Harper")
                        {
                            var selectedMaker = from p in prod
                                                 where p.Maker == "Helen Harper"
                                                select p;

                            foreach (Product p in selectedMaker)
                                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                        }
                        else if (str4 == "Momi")
                        {
                            var selectedMaker = from p in prod
                                                where p.Maker == "Momi"
                                                select p;

                            foreach (Product p in selectedMaker)
                                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                        }
                    }

                    goto case "2";


                    //case "4":
                    //  Operations.prod.Sort(delegate (Product prod1, Product prod2) { return prod1.Name.CompareTo(prod2.Name); });
            }
        }

    }
}
