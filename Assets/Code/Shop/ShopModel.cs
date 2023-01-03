using System.Collections;
using UnityEngine;

namespace Assets.Code.Shop
{
    public class ShopModel : MonoBehaviour
    {
        [SerializeField] private ShopView _shopView;
        [SerializeField] private ShopData[] _shopData;

        private void Awake()
        {
            GetServerData();
        }

        public void GetServerData()
        {
            int constCountIntValue = 10;
            _shopData = new ShopData[10];
            Create();
        }

        public void Create()
        {
            _shopView.CreateUIElement(_shopData);
        }

    }

    public struct ShopData
    {
        public string NameCell;
        public double Price;
    }
}