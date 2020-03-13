using System;

namespace WinFormsMarket2
{
    //商品
    public class Commodity : IShowInfo
    {
        private int id;
        private string name;
        private string category;
        private float price;
        private string units;
        private int amount;

        public Commodity(int id, string name, string category, float price, string units, int amount)
        {
            this.id = id;
            this.name = name;
            this.Category = category;
            this.price = price;
            this.units = units;
            this.amount = amount;
        }
        public Commodity()
        {
            this.id = -1;
            this.name = "null";
            this.Category = "null";
            this.price = -1;
            this.units = "null";
            this.amount = -1;
        }
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public string Units { get => units; set => units = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Category { get => category; set => category = value; }
        public void ShowDebug()
        {
            Console.WriteLine("ID: " + id + " Name: " + name + " 类别：" + category + " 单价： " + price + " 单位： " + units + " 数量： " + amount);
        }
        public string ShowLevelString()
        {
            return ShowString();
        }
        public string ShowString()
        {
            string str = "ID: " + id + " Name: " + name + " 类别：" + category + " 单价： " + price + " 单位： " + units + " 数量： " + amount + Environment.NewLine;
            return str;
        }
    }
}
