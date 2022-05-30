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
        public static List<Pharmacist> pharm = new List<Pharmacist>();

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в магазин игрушек!");
            Console.WriteLine("Выберите команду:");
            Console.WriteLine("1 - Показать товары и фармацевтов");
            Console.WriteLine("2 - Выйти");
            String str = Console.ReadLine();
            switch (str)
            {
                case "1":
               
                    prod.Add(new Product() { ID = 01, Name = "Банеоцин", Description = "Порошок для наружного применения 10г", Maker = "Монтавит", Price = 449.70, Availaible = true, Count = 5 });
                    prod.Add(new Product() { ID = 02, Name = "Пенталгин", Description = "Таблетки покрыт.плен.об. 12 шт.", Maker = "Фармстандарт-Лексредства", Price = 119.99, Availaible = true, Count = 6 });
                    prod.Add(new Product() { ID = 03, Name = "Фосфалюгель", Description = "Гель для приема внутрь 20 шт.", Maker = "Фарматис", Price = 489.05, Availaible = false, Count = 0 });
                    prod.Add(new Product() { ID = 04, Name = "Либридерм", Description = "Серацин матирующий дневной крем 50 мл", Maker = "Дина+", Price = 409.50, Availaible = false, Count = 0 });
                    prod.Add(new Product() { ID = 05, Name = "Риностоп", Description = "Капли назальные 0,1% 10 мл", Maker = "Лекко ЗАО", Price = 33.90, Availaible = false, Count = 0 });

                    pharm.Add(new Pharmacist() { ID = 01, FirstName = "Влад", SurName = "Рыбачков",Post = "Младший фармацевт", Age = 1994 , Experience = "1 год" , Salary = 20000});
                    pharm.Add(new Pharmacist() { ID = 02, FirstName = "Булат", SurName = "Шакур", Post = "Старший фармацевт", Age = 1990, Experience = "5 лет", Salary = 25000 });
                    pharm.Add(new Pharmacist() { ID = 03, FirstName = "Талгат", SurName = "Яруллин", Post = "Стажер", Age = 2001, Experience = "2 месяца", Salary = 13500 });
                    pharm.Add(new Pharmacist() { ID = 04, FirstName = "Искандер", SurName = "Гизетдинов", Post = "Менеджер", Age = 1984, Experience = "10 лет", Salary = 50000 });
                    pharm.Add(new Pharmacist() { ID = 05, FirstName = "Данил", SurName = "Левачков", Post = "Уборщик", Age = 1941, Experience = "23 года", Salary = 1000 });

                    Console.WriteLine();
                    Console.WriteLine("Товары");
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
                    Console.WriteLine();
                    Console.WriteLine("Фармацевты");
                    foreach (Pharmacist p in pharm)
                    {
                        Console.WriteLine($"ID фармацевт: {p.ID}", p.ID);
                        Console.WriteLine($"Имя: {p.FirstName}", p.FirstName);
                        Console.WriteLine($"Фамилия: {p.SurName}", p.SurName);
                        Console.WriteLine($"Должность: {p.Post}", p.Post);
                        Console.WriteLine($"Год рождения: {p.Age}", p.Age);
                        Console.WriteLine($"Стаж: {p.Experience}", p.Experience);
                        Console.WriteLine($"Зарплата: {p.Salary}", p.Salary);
                        Console.WriteLine();
                    }
                    goto case "2";
                case "2":
                    Console.WriteLine("Выберите команду:");
                    Console.WriteLine("1- Получение списка по названию лекарства");
                    Console.WriteLine("2- Получение списка по названию производителя");
                    Console.WriteLine("3- Получение самого дорогого лекарства");
                    Console.WriteLine("4- Сортировка товара по возрастанию цены ");
                    Console.WriteLine("5- Сортировка товара по убыванию цены ");
                    Console.WriteLine("6- Список лекарств которые есть в наличие");
                    Console.WriteLine("7- Список формацевтов родившихся в определённом году");
                    string str1 = Console.ReadLine();
                    if (str1 == "1")
                    {
                        Operations.ShowNameOfProduct();
                        goto case "2";
                    }
                    else if (str1 == "2")
                    {
                        Operations.ShowMakerOfProduct();
                        goto case "2";
                    }
                    else if (str1 == "3")
                    {
                        Operations.ShowMostRichProd();
                        goto case "2";
                    }
                    else if (str1 == "4")
                    {
                        Operations.SortByAscendingPrice();
                        goto case "2";
                    }
                    else if (str1 == "5")
                    {
                        Operations.SortByDescndingPrice();
                        goto case "2";
                    }
                    else if (str1 == "6")
                    {
                        Operations.ShowAvailaibleProdList();
                        goto case "2";
                    }
                    else if (str1 == "7")
                    {
                        Operations.ShowBirthdayOfPharmacist();
                        goto case "2";
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    goto case "1";
            }
        }

    }
}
