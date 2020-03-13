namespace WinFormsMarket2
{
    internal interface ILineDataRead
    {
        Commodity ReadComm(string line);

        Shelf ReadShelf(string line);

        Depot ReadDepot(string line);

        CSuperMarket ReadMarket(string line);
    }
}