using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsMarket2
{
    public class CSuperMarket : IShowInfo
    {
        private static string datapath = ".\\Data\\data2.txt";
        public string MarketName;
        public List<Depot> depots;    //所有仓库数据库
        //
        //构造函数
        public CSuperMarket(string txtpath)
        {
            StreamReader sr = new StreamReader(txtpath, Encoding.Default);
            string line;

            //序列参数
            int depotindex = 0;
            int shlefindex = 0;
            int commindex = 0;

            while ((line = sr.ReadLine()) != null)
            {
                int lineFlag = LineFlag(line); ;//1：超市、2：仓库、3：货架、4：商品、0：无效行
                switch (lineFlag)
                {
                    case 0:
                        Console.WriteLine("errRead");
                        break;
                    case 1:     //读取超市名
                        {
                            this.MarketName = ReadMarket(line).MarketName;
                            this.depots = new List<Depot>();    //所有仓库数据库
                        }
                        break;
                    case 2:     //读取仓库信息
                        {
                            this.depots.Add(ReadDepot(line));
                            ++depotindex;
                            shlefindex = 0;
                            commindex = 0;
                        }
                        break;
                    case 3:     //读取货架信息
                        {
                            this.depots[depotindex - 1].Shelves.Add(ReadShelf(line));
                            ++shlefindex;
                            commindex = 0;
                        }
                        break;
                    case 4:     //读取商品信息
                        {
                            this.depots[depotindex - 1].Shelves[shlefindex - 1].Commodities.Add(ReadComm(line));
                            ++commindex;
                        }
                        break;
                    default:
                        Console.WriteLine("errRead");
                        break;
                }
            }
            sr.Close();
        }
        public CSuperMarket(string marketName, List<Depot> depots)
        {
            MarketName = marketName;
            this.depots = depots;
        }
        //
        //方法
        public void Add(Depot depot)
        {
            depots.Add(depot);
        }
        public bool Remov(Depot depot)
        {
            return depots.Remove(depot);
        }
        public int Find(Depot depot)
        {
            return (depots.FindIndex(s => s.DepotID.Equals(depot.DepotID)));
        }
        public bool Modif(int id,Depot newdepot)
        {
            id = depots.FindIndex(s => s.DepotID.Equals(id));
            if (id>0)
            {
                return false;
            }
            else
            {
                depots[id].DepotID = newdepot.DepotID;
                depots[id].Location = newdepot.Location;
                return true;
            }
        }
        //
        //选择目录路径
        public void SaveToDir(string dirpath)
        {
            dirpath += "\\data2.txt";
            SaveToTxt(dirpath);
        }
        //选择文件路径
        public void SaveToTxt(string txtpath)
        {
            //FileStream fs = new FileStream(txtpath, FileMode.Create);
            StreamWriter sw = new StreamWriter(txtpath, false, Encoding.Default);
            //StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write("超市名#" + MarketName + Environment.NewLine);
            foreach (var depot in depots)
            {
                sw.Write("仓库#" + depot.DepotID + "|" + depot.Location + Environment.NewLine);
                foreach (var shelf in depot.Shelves)
                {
                    sw.Write("货架#" + shelf.ShelfID + "|" + shelf.LayerAmount + Environment.NewLine);
                    foreach (var comm in shelf.Commodities)
                    {
                        sw.Write("商品#" + comm.ID + "|" + comm.Name + "|" + comm.Category + "|" + comm.Price + "|" + comm.Units + "|" + comm.Amount + Environment.NewLine);
                    }
                }
            }
            sw.Write("~Save");
            sw.Close();
        }
        //存储到默认
        public void SaveToDefault()
        {
            SaveToTxt(datapath);
        }
        //
        //接口
        public string ShowString()
        {
            string str = MarketName + Environment.NewLine;
            foreach (var depot in depots)
            {
                str += depot.ShowString();
                foreach (var shelf in depot.Shelves)
                {
                    str += shelf.ShowString();
                    foreach (var comm in shelf.Commodities)
                    {
                        str += comm.ShowString();
                    }
                }
            }
            return str;
        }
        public string ShowLevelString()
        {
            string str = MarketName + Environment.NewLine;
            str += "仓库信息：" + Environment.NewLine;
            foreach (var depot in depots)
            {
                str += depot.ShowString();
            }
            return str;
        }
        public void ShowDebug()
        {
            Console.WriteLine(MarketName);
            foreach (var depot in depots)
            {
                depot.ShowDebug();
                foreach (var shelf in depot.Shelves)
                {
                    shelf.ShowDebug();
                    foreach (var comm in shelf.Commodities)
                    {
                        comm.ShowDebug();
                    }
                }
            }
        }
        //
        //私有方法
        private static int LineFlag(string line)
        {
            int flag = 0;
            if (line.Contains("超市名#"))
            {
                flag = 1;
            }
            if (line.Contains("仓库#"))
            {
                flag = 2;
            }
            if (line.Contains("货架#"))
            {
                flag = 3;
            }
            if (line.Contains("商品#"))
            {
                flag = 4;
            }
            return flag;
        }
        private static Commodity ReadComm(string line)
        {
            string[] split = line.Split(new char[] { '#' }, 2);
            string[] _split = split[1].Split(new char[] { '|' });
            //读取商品
            Commodity _commodity = new Commodity(int.Parse(_split[0]), _split[1], _split[2], float.Parse(_split[3]), _split[4], int.Parse(_split[5]));
            return _commodity;
        }
        private static Shelf ReadShelf(string line)
        {
            string[] split = line.Split(new char[] { '#' }, 2);
            string[] _split = split[1].Split(new char[] { '|' });
            //读取货架
            Shelf _shelf = new Shelf(int.Parse(_split[0]), int.Parse(_split[1]));
            return _shelf;
        }
        private static Depot ReadDepot(string line)
        {
            string[] split = line.Split(new char[] { '#' }, 2);
            string[] _split = split[1].Split(new char[] { '|' });
            //读取当前仓库
            Depot _depot = new Depot(int.Parse(_split[0]), _split[1]);
            return _depot;
        }
        private static CSuperMarket ReadMarket(string line)
        {
            string[] split = line.Split(new char[] { '#' }, 2);
            CSuperMarket _cSuperMarket = new CSuperMarket(split[1], new List<Depot>());
            return _cSuperMarket;
        }
    }
}
