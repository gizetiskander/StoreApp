using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StoreApp1
{
    class Operations
    {
        public static List<Product> prod = new List<Product>();
        public static List<Pharmacist> pharm = new List<Pharmacist>();

        public static void ShowNameOfProduct()
        {
            prod.Add(new Product() { ID = 01, Name = "Банеоцин", Description = "Порошок для наружного применения 10г", Maker = "Монтавит", Price = 449.70, Availaible = true, Count = 5 });
            prod.Add(new Product() { ID = 02, Name = "Пенталгин", Description = "Таблетки покрыт.плен.об. 12 шт.", Maker = "Фармстандарт-Лексредства", Price = 119.99, Availaible = true, Count = 6 });
            prod.Add(new Product() { ID = 03, Name = "Фосфалюгель", Description = "Гель для приема внутрь 20 шт.", Maker = "Фарматис", Price = 489.05, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 04, Name = "Либридерм", Description = "Серацин матирующий дневной крем 50 мл", Maker = "Дина+", Price = 409.50, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 05, Name = "Риностоп", Description = "Капли назальные 0,1% 10 мл", Maker = "Лекко ЗАО", Price = 33.90, Availaible = false, Count = 0 });

            pharm.Add(new Pharmacist() { ID = 01, FirstName = "Влад", SurName = "Рыбачков", Post = "Младший фармацевт", Age = 1994, Experience = "1 год", Salary = 20000 });
            pharm.Add(new Pharmacist() { ID = 02, FirstName = "Булат", SurName = "Шакур", Post = "Старший фармацевт", Age = 1990, Experience = "5 лет", Salary = 25000 });
            pharm.Add(new Pharmacist() { ID = 03, FirstName = "Талгат", SurName = "Яруллин", Post = "Стажер", Age = 2001, Experience = "2 месяца", Salary = 13500 });
            pharm.Add(new Pharmacist() { ID = 04, FirstName = "Искандер", SurName = "Гизетдинов", Post = "Менеджер", Age = 1984, Experience = "10 лет", Salary = 50000 });
            pharm.Add(new Pharmacist() { ID = 05, FirstName = "Данил", SurName = "Левачков", Post = "Уборщик", Age = 1941, Experience = "23 года", Salary = 1000 });
            Console.WriteLine("Введите название товара:");
            string str2 = Console.ReadLine();
            if (str2 == "Банеоцин" || str2 == "Порошок для наружного применения 10г")
            {
                Product product = prod.Find(x => x.Name.Contains("Банеоцин"));
                Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
            }
            else if (str2 == "Пенталгин" || str2 == "Таблетки покрыт.плен.об. 12 шт.")
            {
                Product product = prod.Find(x => x.Name.Contains("Пенталгин"));
                Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
            }
            else if (str2 == "Фосфалюгель" || str2 == "Гель для приема внутрь 20 шт.")
            {
                Product product = prod.Find(x => x.Name.Contains("Фосфалюгель"));
                Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
            }
            else if (str2 == "Либридерм" || str2 == "Серацин матирующий дневной крем 50 мл")
            {
                Product product = prod.Find(x => x.Name.Contains("Либридерм"));
                Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
            }
            else if (str2 == "Риностоп" || str2 == "Капли назальные 0,1% 10 мл")
            {
                Product product = prod.Find(x => x.Name.Contains("Риностоп"));
                Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }


        public static void ShowMakerOfProduct()
        {
            prod.Add(new Product() { ID = 01, Name = "Банеоцин", Description = "Порошок для наружного применения 10г", Maker = "Монтавит", Price = 449.70, Availaible = true, Count = 5 });
            prod.Add(new Product() { ID = 02, Name = "Пенталгин", Description = "Таблетки покрыт.плен.об. 12 шт.", Maker = "Фармстандарт-Лексредства", Price = 119.99, Availaible = true, Count = 6 });
            prod.Add(new Product() { ID = 03, Name = "Фосфалюгель", Description = "Гель для приема внутрь 20 шт.", Maker = "Фарматис", Price = 489.05, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 04, Name = "Либридерм", Description = "Серацин матирующий дневной крем 50 мл", Maker = "Дина+", Price = 409.50, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 05, Name = "Риностоп", Description = "Капли назальные 0,1% 10 мл", Maker = "Лекко ЗАО", Price = 33.90, Availaible = false, Count = 0 });

            pharm.Add(new Pharmacist() { ID = 01, FirstName = "Влад", SurName = "Рыбачков", Post = "Младший фармацевт", Age = 1994, Experience = "1 год", Salary = 20000 });
            pharm.Add(new Pharmacist() { ID = 02, FirstName = "Булат", SurName = "Шакур", Post = "Старший фармацевт", Age = 1990, Experience = "5 лет", Salary = 25000 });
            pharm.Add(new Pharmacist() { ID = 03, FirstName = "Талгат", SurName = "Яруллин", Post = "Стажер", Age = 2001, Experience = "2 месяца", Salary = 13500 });
            pharm.Add(new Pharmacist() { ID = 04, FirstName = "Искандер", SurName = "Гизетдинов", Post = "Менеджер", Age = 1984, Experience = "10 лет", Salary = 50000 });
            pharm.Add(new Pharmacist() { ID = 05, FirstName = "Данил", SurName = "Левачков", Post = "Уборщик", Age = 1941, Experience = "23 года", Salary = 1000 });
            Console.WriteLine("Введите название производителя:");
            string str2 = Console.ReadLine();
            if (str2 == "Монтавит")
            {
                Product product = prod.Find(x => x.Maker.Contains("Монтавит"));
                Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
            }
            else if (str2 == "Фармстандарт-Лексредства")
            {
                Product product = prod.Find(x => x.Maker.Contains("Фармстандарт-Лексредства"));
                Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
            }
            else if (str2 == "Фарматис")
            {
                Product product = prod.Find(x => x.Maker.Contains("Фарматис"));
                Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
            }
            else if (str2 == "Дина+")
            {
                Product product = prod.Find(x => x.Maker.Contains("Дина+"));
                Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
            }
            else if (str2 == "Лекко ЗАО")
            {
                Product product = prod.Find(x => x.Maker.Contains("Лекко ЗАО"));
                Console.WriteLine("Название:{0}, Описание:{1}", product.Name, product.Description);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }

        public static void ShowMostRichProd()
        {
            prod.Add(new Product() { ID = 01, Name = "Банеоцин", Description = "Порошок для наружного применения 10г", Maker = "Монтавит", Price = 449.70, Availaible = true, Count = 5 });
            prod.Add(new Product() { ID = 02, Name = "Пенталгин", Description = "Таблетки покрыт.плен.об. 12 шт.", Maker = "Фармстандарт-Лексредства", Price = 119.99, Availaible = true, Count = 6 });
            prod.Add(new Product() { ID = 03, Name = "Фосфалюгель", Description = "Гель для приема внутрь 20 шт.", Maker = "Фарматис", Price = 489.05, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 04, Name = "Либридерм", Description = "Серацин матирующий дневной крем 50 мл", Maker = "Дина+", Price = 409.50, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 05, Name = "Риностоп", Description = "Капли назальные 0,1% 10 мл", Maker = "Лекко ЗАО", Price = 33.90, Availaible = false, Count = 0 });

            pharm.Add(new Pharmacist() { ID = 01, FirstName = "Влад", SurName = "Рыбачков", Post = "Младший фармацевт", Age = 1994, Experience = "1 год", Salary = 20000 });
            pharm.Add(new Pharmacist() { ID = 02, FirstName = "Булат", SurName = "Шакур", Post = "Старший фармацевт", Age = 1990, Experience = "5 лет", Salary = 25000 });
            pharm.Add(new Pharmacist() { ID = 03, FirstName = "Талгат", SurName = "Яруллин", Post = "Стажер", Age = 2001, Experience = "2 месяца", Salary = 13500 });
            pharm.Add(new Pharmacist() { ID = 04, FirstName = "Искандер", SurName = "Гизетдинов", Post = "Менеджер", Age = 1984, Experience = "10 лет", Salary = 50000 });
            pharm.Add(new Pharmacist() { ID = 05, FirstName = "Данил", SurName = "Левачков", Post = "Уборщик", Age = 1941, Experience = "23 года", Salary = 1000 });
            double maxPrice = prod.Max(p => p.Price);
            Console.WriteLine($"Самый дорогой товар: {maxPrice}");
        }

        public static void SortByDescndingPrice()
        {
            prod.Add(new Product() { ID = 01, Name = "Банеоцин", Description = "Порошок для наружного применения 10г", Maker = "Монтавит", Price = 449.70, Availaible = true, Count = 5 });
            prod.Add(new Product() { ID = 02, Name = "Пенталгин", Description = "Таблетки покрыт.плен.об. 12 шт.", Maker = "Фармстандарт-Лексредства", Price = 119.99, Availaible = true, Count = 6 });
            prod.Add(new Product() { ID = 03, Name = "Фосфалюгель", Description = "Гель для приема внутрь 20 шт.", Maker = "Фарматис", Price = 489.05, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 04, Name = "Либридерм", Description = "Серацин матирующий дневной крем 50 мл", Maker = "Дина+", Price = 409.50, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 05, Name = "Риностоп", Description = "Капли назальные 0,1% 10 мл", Maker = "Лекко ЗАО", Price = 33.90, Availaible = false, Count = 0 });

            pharm.Add(new Pharmacist() { ID = 01, FirstName = "Влад", SurName = "Рыбачков", Post = "Младший фармацевт", Age = 1994, Experience = "1 год", Salary = 20000 });
            pharm.Add(new Pharmacist() { ID = 02, FirstName = "Булат", SurName = "Шакур", Post = "Старший фармацевт", Age = 1990, Experience = "5 лет", Salary = 25000 });
            pharm.Add(new Pharmacist() { ID = 03, FirstName = "Талгат", SurName = "Яруллин", Post = "Стажер", Age = 2001, Experience = "2 месяца", Salary = 13500 });
            pharm.Add(new Pharmacist() { ID = 04, FirstName = "Искандер", SurName = "Гизетдинов", Post = "Менеджер", Age = 1984, Experience = "10 лет", Salary = 50000 });
            pharm.Add(new Pharmacist() { ID = 05, FirstName = "Данил", SurName = "Левачков", Post = "Уборщик", Age = 1941, Experience = "23 года", Salary = 1000 });
            var sortedPrice = from p in prod
                              orderby p.Price descending
                              select p;
            foreach (var p in sortedPrice)
                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
        }

        public static void SortByAscendingPrice()
        {
            prod.Add(new Product() { ID = 01, Name = "Банеоцин", Description = "Порошок для наружного применения 10г", Maker = "Монтавит", Price = 449.70, Availaible = true, Count = 5 });
            prod.Add(new Product() { ID = 02, Name = "Пенталгин", Description = "Таблетки покрыт.плен.об. 12 шт.", Maker = "Фармстандарт-Лексредства", Price = 119.99, Availaible = true, Count = 6 });
            prod.Add(new Product() { ID = 03, Name = "Фосфалюгель", Description = "Гель для приема внутрь 20 шт.", Maker = "Фарматис", Price = 489.05, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 04, Name = "Либридерм", Description = "Серацин матирующий дневной крем 50 мл", Maker = "Дина+", Price = 409.50, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 05, Name = "Риностоп", Description = "Капли назальные 0,1% 10 мл", Maker = "Лекко ЗАО", Price = 33.90, Availaible = false, Count = 0 });

            pharm.Add(new Pharmacist() { ID = 01, FirstName = "Влад", SurName = "Рыбачков", Post = "Младший фармацевт", Age = 1994, Experience = "1 год", Salary = 20000 });
            pharm.Add(new Pharmacist() { ID = 02, FirstName = "Булат", SurName = "Шакур", Post = "Старший фармацевт", Age = 1990, Experience = "5 лет", Salary = 25000 });
            pharm.Add(new Pharmacist() { ID = 03, FirstName = "Талгат", SurName = "Яруллин", Post = "Стажер", Age = 2001, Experience = "2 месяца", Salary = 13500 });
            pharm.Add(new Pharmacist() { ID = 04, FirstName = "Искандер", SurName = "Гизетдинов", Post = "Менеджер", Age = 1984, Experience = "10 лет", Salary = 50000 });
            pharm.Add(new Pharmacist() { ID = 05, FirstName = "Данил", SurName = "Левачков", Post = "Уборщик", Age = 1941, Experience = "23 года", Salary = 1000 });
            var sortedPrice = from p in prod
                              orderby p.Price ascending
                              select p;
            foreach (var p in sortedPrice)
                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
        }

        public static void ShowAvailaibleProdList()
        {
            prod.Add(new Product() { ID = 01, Name = "Банеоцин", Description = "Порошок для наружного применения 10г", Maker = "Монтавит", Price = 449.70, Availaible = true, Count = 5 });
            prod.Add(new Product() { ID = 02, Name = "Пенталгин", Description = "Таблетки покрыт.плен.об. 12 шт.", Maker = "Фармстандарт-Лексредства", Price = 119.99, Availaible = true, Count = 6 });
            prod.Add(new Product() { ID = 03, Name = "Фосфалюгель", Description = "Гель для приема внутрь 20 шт.", Maker = "Фарматис", Price = 489.05, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 04, Name = "Либридерм", Description = "Серацин матирующий дневной крем 50 мл", Maker = "Дина+", Price = 409.50, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 05, Name = "Риностоп", Description = "Капли назальные 0,1% 10 мл", Maker = "Лекко ЗАО", Price = 33.90, Availaible = false, Count = 0 });

            pharm.Add(new Pharmacist() { ID = 01, FirstName = "Влад", SurName = "Рыбачков", Post = "Младший фармацевт", Age = 1994, Experience = "1 год", Salary = 20000 });
            pharm.Add(new Pharmacist() { ID = 02, FirstName = "Булат", SurName = "Шакур", Post = "Старший фармацевт", Age = 1990, Experience = "5 лет", Salary = 25000 });
            pharm.Add(new Pharmacist() { ID = 03, FirstName = "Талгат", SurName = "Яруллин", Post = "Стажер", Age = 2001, Experience = "2 месяца", Salary = 13500 });
            pharm.Add(new Pharmacist() { ID = 04, FirstName = "Искандер", SurName = "Гизетдинов", Post = "Менеджер", Age = 1984, Experience = "10 лет", Salary = 50000 });
            pharm.Add(new Pharmacist() { ID = 05, FirstName = "Данил", SurName = "Левачков", Post = "Уборщик", Age = 1941, Experience = "23 года", Salary = 1000 });
            var sortedPrice = from p in prod
                              where p.Availaible == true
                              select p;
            foreach (var p in sortedPrice)
                Console.WriteLine($"Название - {p.Name}, Описание - {p.Description}, Доступность - {p.Availaible}, Цена - {p.Price}");
        }

        public static void ShowBirthdayOfPharmacist()
        {
            prod.Add(new Product() { ID = 01, Name = "Банеоцин", Description = "Порошок для наружного применения 10г", Maker = "Монтавит", Price = 449.70, Availaible = true, Count = 5 });
            prod.Add(new Product() { ID = 02, Name = "Пенталгин", Description = "Таблетки покрыт.плен.об. 12 шт.", Maker = "Фармстандарт-Лексредства", Price = 119.99, Availaible = true, Count = 6 });
            prod.Add(new Product() { ID = 03, Name = "Фосфалюгель", Description = "Гель для приема внутрь 20 шт.", Maker = "Фарматис", Price = 489.05, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 04, Name = "Либридерм", Description = "Серацин матирующий дневной крем 50 мл", Maker = "Дина+", Price = 409.50, Availaible = false, Count = 0 });
            prod.Add(new Product() { ID = 05, Name = "Риностоп", Description = "Капли назальные 0,1% 10 мл", Maker = "Лекко ЗАО", Price = 33.90, Availaible = false, Count = 0 });

            pharm.Add(new Pharmacist() { ID = 01, FirstName = "Влад", SurName = "Рыбачков", Post = "Младший фармацевт", Age = 1994, Experience = "1 год", Salary = 20000 });
            pharm.Add(new Pharmacist() { ID = 02, FirstName = "Булат", SurName = "Шакур", Post = "Старший фармацевт", Age = 1990, Experience = "5 лет", Salary = 25000 });
            pharm.Add(new Pharmacist() { ID = 03, FirstName = "Талгат", SurName = "Яруллин", Post = "Стажер", Age = 2001, Experience = "2 месяца", Salary = 13500 });
            pharm.Add(new Pharmacist() { ID = 04, FirstName = "Искандер", SurName = "Гизетдинов", Post = "Менеджер", Age = 1984, Experience = "10 лет", Salary = 50000 });
            pharm.Add(new Pharmacist() { ID = 05, FirstName = "Данил", SurName = "Левачков", Post = "Уборщик", Age = 1941, Experience = "23 года", Salary = 1000 });
            Console.WriteLine("Введите год рождения:");
            string str2 = Console.ReadLine();
            if (str2 == "1994")
            {
                Pharmacist pharmacist = pharm.Find(x => x.Age == 1994);
                Console.WriteLine("Имя:{0}, Фамилия:{1}", pharmacist.FirstName, pharmacist.SurName);
            }
            else if (str2 == "1990")
            {
                Pharmacist pharmacist = pharm.Find(x => x.Age == 1990);
                Console.WriteLine("Имя:{0}, Фамилия:{1}", pharmacist.FirstName, pharmacist.SurName);
            }
            else if (str2 == "2001")
            {
                Pharmacist pharmacist = pharm.Find(x => x.Age == 2001);
                Console.WriteLine("Имя:{0}, Фамилия:{1}", pharmacist.FirstName, pharmacist.SurName);
            }
            else if (str2 == "1984")
            {
                Pharmacist pharmacist = pharm.Find(x => x.Age == 1984);
                Console.WriteLine("Имя:{0}, Фамилия:{1}", pharmacist.FirstName, pharmacist.SurName);
            }
            else if (str2 == "1941")
            {
                Pharmacist pharmacist = pharm.Find(x => x.Age == 1941);
                Console.WriteLine("Имя:{0}, Фамилия:{1}", pharmacist.FirstName, pharmacist.SurName);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }

    }
}
