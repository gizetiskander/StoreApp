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
            Console.WriteLine("Добро пожаловать в магазин игрушек!");
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
                    Console.WriteLine("Добро пожаловать в магазин игрушек!");
                    Console.WriteLine("Выберите команду:");
                    Console.WriteLine("3 - Найти товар по названию и описанию");
                    Console.WriteLine("4 - Сортировка товара по возрастанию цены и фильтрация производителя");
                    Console.WriteLine("5 - Сортировка товара по убыванию цены и фильтрация производителя");
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
                       goto case "5";
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
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    goto case "6";
                case "4":
                    Console.WriteLine("Введите Сортировка или Фильтрация:");
                    string str3 = Console.ReadLine();
                    if (str3 == "Сортировка")
                    {
                        var sortedPrice = from p in prod
                                          orderby p.Price ascending
                                          select p;
                        foreach (var p in sortedPrice)
                            Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    if (str3 == "Фильтрация")
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
                        else if (str4 == "LINDA")
                        {
                            var selectedMaker = from p in prod
                                                where p.Maker == "LINDA"
                                                select p;

                            foreach (Product p in selectedMaker)
                                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                        }
                        else if (str4 == "Olobaby")
                        {
                            var selectedMaker = from p in prod
                                                where p.Maker == "Olobaby"
                                                select p;

                            foreach (Product p in selectedMaker)
                                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                        }
                        else if (str4 == "Nestle")
                        {
                            var selectedMaker = from p in prod
                                                where p.Maker == "Nestle"
                                                select p;

                            foreach (Product p in selectedMaker)
                                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка");
                        }
                    }

                    goto case "2";

                case "5":
                    Console.WriteLine("Введите Сортировка или Фильтрация:");
                    string str_ = Console.ReadLine();
                    if (str_ == "Сортировка")
                    {
                        var sortedPrice = from p in prod
                                          orderby p.Price descending
                                          select p;
                        foreach (var p in sortedPrice)
                            Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    if (str_ == "Фильтрация")
                    {
                        Console.WriteLine("Введите производителя:");
                        string str_1 = Console.ReadLine();
                        if (str_1 == "Helen Harper")
                        {
                            var selectedMaker = from p in prod
                                                where p.Maker == "Helen Harper"
                                                select p;

                            foreach (Product p in selectedMaker)
                                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                        }
                        else if (str_1 == "Momi")
                        {
                            var selectedMaker = from p in prod
                                                where p.Maker == "Momi"
                                                select p;

                            foreach (Product p in selectedMaker)
                                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                        }
                        else if (str_1 == "LINDA")
                        {
                            var selectedMaker = from p in prod
                                                where p.Maker == "LINDA"
                                                select p;

                            foreach (Product p in selectedMaker)
                                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                        }
                        else if (str_1 == "Olobaby")
                        {
                            var selectedMaker = from p in prod
                                                where p.Maker == "Olobaby"
                                                select p;

                            foreach (Product p in selectedMaker)
                                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                        }
                        else if (str_1 == "Nestle")
                        {
                            var selectedMaker = from p in prod
                                                where p.Maker == "Nestle"
                                                select p;

                            foreach (Product p in selectedMaker)
                                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка");
                        }
                    }
                        goto case "2";
                case "6":
                    Console.WriteLine("Вы хотите купить товар?");
                    string str5 = Console.ReadLine();
                    if (str5 == "Да")
                    {
                        goto case "7";
                    }
                    else if (str5 == "Нет")
                    {
                        goto case "2";
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    goto case "2";
                case "7":
                    Console.WriteLine("Введите название товара для покупки:");
                    string str6 = Console.ReadLine();
                    if (str6 == "Пеленка")
                    {
                        Product product = prod.Find(x => x.Name.Contains("Пеленка"));
                        Console.WriteLine("Название:{0}, Цена:{1}, Доступность:{2}", product.Name, product.Price, product.Availaible);
                        if (product.Availaible == false)
                        {
                            Console.WriteLine("Извините, но товар недоступен!");
                            goto case "2";
                        }
                    }
                    else if (str6 == "Памперсы")
                    {
                        Product product = prod.Find(x => x.Name.Contains("Памперсы"));
                        Console.WriteLine("Название:{0}, Цена:{1}, Доступность:{2}", product.Name, product.Price, product.Availaible);
                        if (product.Availaible == false)
                        {
                            Console.WriteLine("Извините, но товар недоступен!");
                            goto case "2";
                        }
                    }
                    else if (str6 == "Коляска")
                    {
                        Product product = prod.Find(x => x.Name.Contains("Коляска"));
                        Console.WriteLine("Название:{0}, Цена:{1}, Доступность:{2}", product.Name, product.Price, product.Availaible);
                        if (product.Availaible == false)
                        {
                            Console.WriteLine("Извините, но товар недоступен!");
                            goto case "2";
                        }
                    }
                    else if (str6 == "Бутылочка")
                    {
                        Product product = prod.Find(x => x.Name.Contains("Бутылочка"));
                        Console.WriteLine("Название:{0}, Цена:{1}, Доступность:{2}", product.Name, product.Price, product.Availaible);
                        if (product.Availaible == false)
                        {
                            Console.WriteLine("Извините, но товар недоступен!");
                            goto case "2";
                        }
                    }
                    else if (str6 == "Детская смесь")
                    {
                        Product product = prod.Find(x => x.Name.Contains("Детская смесь"));
                        Console.WriteLine("Название:{0}, Цена:{1}, Доступность:{2}", product.Name, product.Price, product.Availaible);
                        if (product.Availaible == false)
                        {
                            Console.WriteLine("Извините, но товар недоступен!");
                            goto case "2";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    goto case "8";
                case "8":
                    Console.WriteLine("Выберите вид оплаты:");
                    Console.WriteLine("1 - Банковская карта");
                    Console.WriteLine("2 - Я pay");
                    Console.WriteLine("3 - Мир pay");
                    Console.WriteLine("4 - Наличные");
                    string str7 = Console.ReadLine();
                    if (str7 == "1")
                    {
                        goto case "9";
                    }
                    else if (str7 == "2")
                    {
                        goto case "9";
                    }
                    else if (str7 == "3")
                    {
                        goto case "9";
                    }
                    else if (str7 == "4")
                    {
                        goto case "9";
                    }
                    goto case "2";

                case "9":
                    Console.WriteLine("Введите ваше ФИО и номер телефона для связи с вами");
                    string str8 = Console.ReadLine();
                    Console.WriteLine("Выберите вид доставки:");
                    Console.WriteLine("1 - Самовывоз");
                    Console.WriteLine("2 - Доставка");
                    Console.WriteLine("3 - Срочная доставка");
                    string stra = Console.ReadLine();
                    if (stra == "1")
                    {
                        goto case "10";
                    }
                    else if (stra == "2")
                    {
                        goto case "10";
                    }
                    else if (stra == "3")
                    {
                        goto case "10";
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    goto case "2";
                case "10":
                    Console.WriteLine("Введите адрес(улица, дом квартира):");
                    string strb = Console.ReadLine();
                    if (strb != null)
                    {
                        Console.WriteLine("Заказ оформлен!");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    goto case "2";
               
            }
        }

    }
}
