using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMarket2
{
    public partial class FormMain : Form
    {
        private static string datapath = ".\\Data\\data2.txt";
        //内存数据库
        private static CSuperMarket cmarket;
        //临时存储，同时存储位置标签
        private struct idepot
        {
            public static Depot depot;
            public static int index;

            public static void clear()
            {
                depot = new Depot();
                index = -1;
            }
        }
        private struct ishelf
        {
            public static Shelf shelf;
            public static int index;

            public static void clear()
            {
                shelf = new Shelf();
                index = -1;
            }
        }
        private struct icomm
        {
            public static Commodity comm;
            public static int index;

            public static void clear()
            {
                comm = new Commodity();
                index = -1;
            }
        }
        enum LevelState
        {
            MarketLevel,
            DepotLevel,
            ShelfLevel,
            CommLevel,
            ChangeLevel,
        }
        enum ChangeState
        {
            MarketChange,
            DepotChange,
            ShelfChange,
            CommChange,
        }
        //专用于提交的的标签
        private static byte levelstate = Byte.MaxValue;
        private static byte changestate = Byte.MaxValue;
        //出入库标签
        private static bool inStore = false;
        private static bool outStore = false;
        //弹出一个选择目录的对话框
        private string SelectPath()
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            return path.SelectedPath;
        }
        //弹出一个选择文件的对话框
        private void ShowMarket()
        {
            labelpath.Text = cmarket.MarketName + "\\";
            labelmain.Text = "*************输入仓库id，进入仓库：" + Environment.NewLine;
            labelmain.Text += cmarket.ShowLevelString();
            levelstate = (byte)LevelState.MarketLevel;
            idepot.clear();
            ishelf.clear();
            icomm.clear();
        }
        private void ShowDepots()
        {
            labelpath.Text = cmarket.MarketName + "\\" + "Depot: " + idepot.depot.DepotID + "\\";
            labelmain.Text = "*************输入货架id，进入货架：" + Environment.NewLine;
            labelmain.Text += idepot.depot.ShowLevelString();
            levelstate = (byte)LevelState.DepotLevel;
            ishelf.clear();
            icomm.clear();
        }
        private void ShowShelves()
        {
            labelpath.Text = cmarket.MarketName + "\\" + "Depot: " + idepot.depot.DepotID + "\\" + "Shelf: " + ishelf.shelf.ShelfID + "\\";
            labelmain.Text = "*************输入货物id，进入货物：" + Environment.NewLine;
            labelmain.Text += ishelf.shelf.ShowLevelString();
            levelstate = (byte)LevelState.ShelfLevel;
            icomm.clear();
        }
        private void ShowComm()
        {
            labelpath.Text = cmarket.MarketName + "\\" + "Depot: " + idepot.depot.DepotID + "\\" + "Shelf: " + ishelf.shelf.ShelfID + "\\" + "Comm: " + icomm.comm.ID + "\\";
            labelmain.Text = "*************商品层：" + Environment.NewLine;
            labelmain.Text += icomm.comm.ShowLevelString();
            levelstate = (byte)LevelState.ShelfLevel;
        }
        private bool SubmitEnterComm(string str)
        {
            for (int i = 0; i < ishelf.shelf.Commodities.Count; i++)
            {
                Commodity _comm = ishelf.shelf.Commodities[i];
                if (int.Parse(str) >= -1 && _comm.ID == int.Parse(str))
                {
                    icomm.comm = _comm;
                    icomm.index = i;
                    ShowComm();
                    return true;
                }
            }
            return false;
        }
        private bool SubmitEnterShelf(string str)
        {
            for (int i = 0; i < idepot.depot.Shelves.Count; i++)
            {
                Shelf _shelf = idepot.depot.Shelves[i];
                if (int.Parse(str) >= -1 && _shelf.ShelfID == int.Parse(str))
                {
                    ishelf.shelf = _shelf;
                    ishelf.index = i;
                    ShowShelves();
                    return true;
                }
            }
            return false;
        }
        private bool SubmitEnterDepot(string str)
        {
            for (int i = 0; i < cmarket.depots.Count; i++)
            {
                Depot _depot = cmarket.depots[i];
                if (int.Parse(str) >= -1 && _depot.DepotID == int.Parse(str))
                {
                    idepot.depot = _depot;
                    idepot.index = i;
                    ShowDepots();
                    return true;
                }
            }
            return false;
        }
        public FormMain()
        {
            InitializeComponent();
            labelpath.Text = "提示：文件-》(点击)打开";
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmarket = new CSuperMarket(datapath);
            ShowMarket();
        }
        private void 储存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmarket.SaveToDefault();
            labelmain.Text += Environment.NewLine + "***********Save OK";
        }
        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmarket.SaveToDir(SelectPath());
        }
        private void bSubmit_Click(object sender, EventArgs e)
        {
            string str = textIn.Text;
            switch (levelstate)
            {
                case (byte)LevelState.MarketLevel:
                    {
                        if (SubmitEnterDepot(str))
                        {
                            levelstate = (byte)LevelState.DepotLevel;
                        }
                        else
                        {
                            labelmain.Text += "************未找到，或格式错误";
                        }
                    }
                    break;
                case (byte)LevelState.DepotLevel:
                    {
                        if (SubmitEnterShelf(str))
                        {
                            levelstate = (byte)LevelState.ShelfLevel;
                        }
                        else
                        {
                            labelmain.Text += "************未找到，或格式错误";
                        }
                    }
                    break;
                case (byte)LevelState.ShelfLevel:
                    {
                        if (SubmitEnterComm(str))
                        {
                            levelstate = (byte)LevelState.CommLevel;
                        }
                        else
                        {
                            labelmain.Text += "************未找到，或格式错误";
                        }
                    }
                    break;
                case (byte)LevelState.CommLevel:
                    break;
                case (byte)LevelState.ChangeLevel:
                    {
                        switch (changestate)
                        {
                            case (byte)ChangeState.DepotChange:
                                {
                                    string[] split = textIn.Text.Split(new char[] { '、' });
                                    if (split.Length == 2)
                                    {
                                        cmarket.depots[idepot.index].DepotID = int.Parse(split[0]);
                                        cmarket.depots[idepot.index].Location = split[1];
                                        ShowMarket();
                                    }
                                    else
                                    {
                                        labelmain.Text += Environment.NewLine + "************格式错误";
                                    }
                                }
                                break;
                            case (byte)ChangeState.ShelfChange:
                                {
                                    string[] split = textIn.Text.Split(new char[] { '、' });
                                    if (split.Length == 2)
                                    {
                                        cmarket.depots[idepot.index].Shelves[ishelf.index].ShelfID = int.Parse(split[0]);
                                        cmarket.depots[idepot.index].Shelves[ishelf.index].LayerAmount = int.Parse(split[1]);
                                        ShowDepots();
                                    }
                                    else
                                    {
                                        labelmain.Text += Environment.NewLine + "************格式错误";
                                    }
                                }
                                break;
                            case (byte)ChangeState.CommChange:
                                {
                                    string[] split = textIn.Text.Split(new char[] { '、' });
                                    if (split.Length == 6)
                                    {
                                        cmarket.depots[idepot.index].Shelves[ishelf.index].Commodities[icomm.index].ID = int.Parse(split[0]);
                                        cmarket.depots[idepot.index].Shelves[ishelf.index].Commodities[icomm.index].Name = split[1];
                                        cmarket.depots[idepot.index].Shelves[ishelf.index].Commodities[icomm.index].Category = split[2];
                                        cmarket.depots[idepot.index].Shelves[ishelf.index].Commodities[icomm.index].Price = int.Parse(split[3]);
                                        cmarket.depots[idepot.index].Shelves[ishelf.index].Commodities[icomm.index].Units = split[4];
                                        cmarket.depots[idepot.index].Shelves[ishelf.index].Commodities[icomm.index].Amount = int.Parse(split[5]);
                                        ShowShelves();
                                    }
                                    else
                                    {
                                        labelmain.Text += Environment.NewLine + "************格式错误";
                                    }
                                }
                                break;
                            case (byte)ChangeState.MarketChange:
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
            textIn.Text = "";
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            switch (levelstate)
            {
                case (byte)LevelState.MarketLevel:
                    break;
                case (byte)LevelState.DepotLevel:
                    {
                        ShowMarket();
                        idepot.depot = new Depot();
                        ishelf.shelf = new Shelf();
                        icomm.comm = new Commodity();
                    }
                    break;
                case (byte)LevelState.ShelfLevel:
                    {
                        ShowDepots();
                        ishelf.shelf = new Shelf();
                        icomm.comm = new Commodity();
                    }
                    break;
                case (byte)LevelState.CommLevel:
                    {
                        ShowShelves();
                        icomm.comm = new Commodity();
                    }
                    break;
                default:
                    break;
            }
        }

        //仓库
        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (levelstate == (byte)LevelState.MarketLevel)
            {
                cmarket.depots.Add(new Depot());
                ShowMarket();
            }
            else
            {
                labelmain.Text += Environment.NewLine + "************增加一个空仓库，请定位到超市：";
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (levelstate == (byte)LevelState.DepotLevel)
            {
                cmarket.depots.Remove(idepot.depot);
                ShowMarket();
            }
            else
            {
                labelmain.Text += Environment.NewLine + "************定位到仓库路径，删除该仓库：";
            }
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelmain.Text += Environment.NewLine + "************在超市路径下操作，在下方输入查询id并提交";
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (levelstate == (byte)LevelState.DepotLevel)
            {
                textIn.Text = idepot.depot.DepotID + "、" + idepot.depot.Location;
                levelstate = (byte)LevelState.ChangeLevel;
                changestate = (byte)ChangeState.DepotChange;
                labelmain.Text += Environment.NewLine + "************在下方修改并提交：";
            }
            else
            {
                labelmain.Text += Environment.NewLine + "************请定位到需要修改的仓库下";
            }
        }

        //货架
        private void 增加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (levelstate == (byte)LevelState.DepotLevel)
            {
                cmarket.depots[idepot.index].Shelves.Add(new Shelf());
                ShowDepots();
            }
            else
            {
                labelmain.Text += Environment.NewLine + "************增加一个空货架，请定位到仓库";
            }
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (levelstate == (byte)LevelState.ShelfLevel)
            {
                cmarket.depots[idepot.index].Shelves.Remove(ishelf.shelf);
                ShowShelves();
            }
            else
            {
                labelmain.Text += Environment.NewLine + "************定位到货架，删除：";
            }
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelmain.Text += Environment.NewLine + "************在仓库路径下操作，在下方输入查询id并提交";
        }

        private void 修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (levelstate == (byte)LevelState.ShelfLevel)
            {
                textIn.Text = ishelf.shelf.ShelfID + "、" + ishelf.shelf.LayerAmount;
                levelstate = (byte)LevelState.ChangeLevel;
                changestate = (byte)ChangeState.ShelfChange;
                labelmain.Text += Environment.NewLine + "************在下方修改并提交：";
            }
            else
            {
                labelmain.Text += Environment.NewLine + "************定位到货架，然后修改该货架：";
            }
        }

        //商品
        private void 增加ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (levelstate == (byte)LevelState.ShelfLevel)
            {
                cmarket.depots[idepot.index].Shelves[ishelf.index].Commodities.Add(new Commodity());
                ShowShelves();
            }
            else
            {
                labelmain.Text += Environment.NewLine + "************增加一个空商品，请定位到货架：";
            }
        }

        private void 删除ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (levelstate == (byte)LevelState.CommLevel)
            {
                cmarket.depots[idepot.index].Shelves[ishelf.index].Commodities.Remove(icomm.comm);
                ShowShelves();
            }
            else
            {
                labelmain.Text += Environment.NewLine + "************定位到商品，删除：";
            }
        }

        private void 查找ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            labelmain.Text += Environment.NewLine + "************在货架路径下操作，在下方输入查询id并提交";
        }

        private void 修改ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (levelstate == (byte)LevelState.CommLevel)
            {
                textIn.Text = icomm.comm.ID + "、" + icomm.comm.Name + "、" + icomm.comm.Category + "、" + icomm.comm.Price + "、" + icomm.comm.Units + "、" + icomm.comm.Amount;
                levelstate = (byte)LevelState.ChangeLevel;
                changestate = (byte)ChangeState.CommChange;
                labelmain.Text += Environment.NewLine + "************在下方修改并提交：";
            }
            else
            {
                labelmain.Text += Environment.NewLine + "************定位到商品，然后修改该商品：";
            }
        }

        private void 统计前三ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Commodity> l_comm = new List<Commodity>();
            foreach (var depot in cmarket.depots)
            {
                foreach (var shelf in depot.Shelves)
                {
                    foreach (var comm in shelf.Commodities)
                    {
                        l_comm.Add(comm);
                        if (l_comm.Count > 3)
                        {
                            l_comm.Sort(SortList);
                            l_comm.RemoveAt(l_comm.Count - 1);
                        }
                    }
                }
            }
            foreach (var comm in l_comm)
            {
                labelmain.Text += Environment.NewLine + comm.ShowString();
            }
        }

        private int SortList(Commodity a, Commodity b) //a b表示列表中的元素
        {
            if (a.Amount > b.Amount) //这边的比较可以是任意的类型，只要是你可以比较的东西，比如student类中的年龄age stu1.age > stu2.age
            {
                return -1;
            }
            else if (a.Amount < b.Amount)
            {
                return
            }
            return 0;
        }

        private void 统计当前仓库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (levelstate == (byte)LevelState.DepotLevel)
            {
                float _m =0;

                foreach (var shelf in idepot.depot.Shelves)
                {
                    foreach (var comm in shelf.Commodities)
                    {
                        _m += comm.Price * comm.Amount;
                    }
                }
                labelmain.Text += Environment.NewLine + "当前仓库总价值： " + _m + "元";
            }
            else
            {
                labelmain.Text += Environment.NewLine + "************定位到仓库，计算总价值：";
            }

        }

        private void 出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!outStore)
            {
                textIn.Text ="出库、"+ "id" + "、" + "数量";
                labelmain.Text += Environment.NewLine + "************输入信息，再点击入库：";
                inStore = true;
            }
            else
            {
                string[] split = textIn.Text.Split(new char[] { '、' });

                List<Commodity> l_comm = new List<Commodity>();
                for (int i = 0; i < cmarket.depots.Count; i++)
                {
                    for (int i1 = 0; i1 < cmarket.depots[i].Shelves.Count; i1++)
                    {
                        for (int i2 = 0; i2 < cmarket.depots[i].Shelves[i1].Commodities.Count; i2++)
                        {
                            if (cmarket.depots[i].Shelves[i1].Commodities[i2].ID == int.Parse(split[1])) 
                            {
                                cmarket.depots[i].Shelves[i1].Commodities[i2].Amount += int.Parse(split[2]);
                            }
                        }
                    }
                }
                labelmain.Text += Environment.NewLine + "************出库成功：";
                outStore = false;
            }
        }

        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!inStore)
            {
                textIn.Text = "入库、" + "id" + "、" + "数量";
                labelmain.Text += Environment.NewLine + "************输入信息，再点击入库：";
                inStore = true;
            }
            else
            {
                string[] split = textIn.Text.Split(new char[] { '、' });
                for (int i = 0; i < cmarket.depots.Count; i++)
                {
                    for (int i1 = 0; i1 < cmarket.depots[i].Shelves.Count; i1++)
                    {
                        for (int i2 = 0; i2 < cmarket.depots[i].Shelves[i1].Commodities.Count; i2++)
                        {
                            if (cmarket.depots[i].Shelves[i1].Commodities[i2].ID == int.Parse(split[1]))
                            {
                                cmarket.depots[i].Shelves[i1].Commodities[i2].Amount += int.Parse(split[2]);
                            }
                        }
                    }
                }
                labelmain.Text += Environment.NewLine + "************入库成功：";
                inStore = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
            }
            if (keyData == Keys.Enter)
            {
                bSubmit.PerformClick();
            }
            if (keyData == Keys.Back)
            {
                bBack.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
