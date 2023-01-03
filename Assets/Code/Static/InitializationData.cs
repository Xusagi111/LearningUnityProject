using Assets.Code.CellElement;

namespace Assets.Code.Static
{
    public static class InitializationData
    {
        public static  void InitCellElement(BaseCellElement baseCellElement, Shop.ShopData Data)
        {
            baseCellElement.NameCell.text = Data.NameCell;
            baseCellElement.Description.text = Data.Price.ToString();
        }
    }
}
