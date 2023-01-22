using Assets.Code.CellElement;

namespace Assets.Code.Static
{
    public static class InitializationData
    {
        public static  void InitCellElement(BaseCellElement baseCellElement, Shop.ShopData Data, int DebugAddNameElement = 0)
        {
            string DebugElement = DebugAddNameElement != 0 ? DebugAddNameElement.ToString() : "";
            baseCellElement.NameCell.text = Data.NameCell + DebugElement;
            baseCellElement.Description.text = Data.Price.ToString();
        }
    }
}
