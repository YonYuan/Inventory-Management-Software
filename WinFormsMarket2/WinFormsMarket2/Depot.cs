using System;
using System.Collections.Generic;

namespace WinFormsMarket2
{
    //仓库
    public class Depot : IShowInfo
    {
        private int depotID;
        private string location;
        private List<Shelf> shelves;

        //
        //构造函数
        public Depot(int depotID, string location)
        {
            this.depotID = depotID;
            this.location = location;
            this.shelves = new List<Shelf>();
        }
        public Depot()
        {
            this.depotID = -1;
            this.location = "null";
            this.shelves = new List<Shelf>();
        }

        //
        //方法
        public void Add(Shelf shelf)
        {
            shelves.Add(shelf);
        }
        public bool Remov(Shelf shelf)
        {
            return shelves.Remove(shelf);
        }
        public int Find(Shelf shelf)
        {
            return (shelves.FindIndex(s => s.ShelfID.Equals(shelf.ShelfID)));
        }
        public bool Modif(int id, Shelf newShelf)
        {
            id = shelves.FindIndex(s => s.ShelfID.Equals(id));
            if (id > 0)
            {
                return false;
            }
            else
            {
                shelves[id].ShelfID = newShelf.ShelfID;
                shelves[id].LayerAmount = newShelf.LayerAmount;
                return true;
            }
        }

        //属性封装
        public int DepotID { get => depotID; set => depotID = value; }
        public string Location { get => location; set => location = value; }
        public List<Shelf> Shelves { get => shelves; set => shelves = value; }

        //接口
        public void ShowDebug()
        {
            Console.WriteLine("DepotID: " + depotID + " 位址: " + location);
        }
        public string ShowString()
        {
            string str = "DepotID: " + depotID + " 位址: " + location + Environment.NewLine;
            return str;
        }
        public string ShowLevelString()
        {
            string str = ShowString();
            str+="货架信息: " + Environment.NewLine;
            foreach (var shelf in shelves)
            {
                str += shelf.ShowString();
            }
            return str;
        }
    }
}
