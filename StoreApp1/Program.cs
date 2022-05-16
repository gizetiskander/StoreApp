using System;
using StoreApp1;


namespace StoreApp1
{
    class Program
    {
        public static List<Product> prod = new List<Product>();
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            Console.WriteLine("Выберите команду:");
            Console.WriteLine("1 - Показать товары");
            Console.WriteLine("2 - Выйти");
            String str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Operations.ShowProductList();
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
                        goto case "5";
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    goto case "1";
                case "3":
                    int b = 0;
                    Console.WriteLine("Введите название или описание товара:");
                    string s = Console.ReadLine();
                    var sorted1 = from p in 
                                  orderby  , p.Opisanie
                                  select p;

                    foreach (var p in sorted1)
                    {

                        if (s == p.Name || s == p.Opisanie)
                        {
                            cc = p.Coll;
                            //Console.WriteLine($"{p.Name} + {p.Id} ");
                            Console.WriteLine($"Номер(Id): {p.Id}, Наименование: {p.Name}, Описание: {p.Opisanie}, Производитель: {p.Proizvod}, Цена: {p.Price}руб., Активный:{p.Activity}, Количество:{p.Coll}");
                            b++;
                        }
                    }
                    if (b == 0)
                    {
                        Console.WriteLine("Такого товара нет!");
                    }
            }
        }

    }
}
