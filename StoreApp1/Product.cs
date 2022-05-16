using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp1
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Maker { get; set; }
        public double Price { get; set; }
        public bool Availaible { get; set; }
        public int Count { get; set; }


    }

    class Payment : Product
    {
        public int delivery { get; set; }
        public double pay { get; set; }
        public string address { get; set; }
    }

    interface StoreAction
    {
        void Action();
    }
}
