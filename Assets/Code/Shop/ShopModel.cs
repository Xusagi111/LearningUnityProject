﻿using Assets.Code.Test;
using UnityEngine;

namespace Assets.Code.Shop
{
    public class ShopModel : MonoBehaviour
    {
        [SerializeField] private ShopView _shopView;
        [SerializeField] private ShopData[] _shopData;

        //private void Awake()
        //{
        //    GetServerData();
        //}

        public void GetServerData()
        {
            int constCountIntValue = TestShop.CountSpawnElement;
            _shopData = new ShopData[constCountIntValue];

            //Test
            for (int i = 0; i < _shopData.Length; i++)
            {
                _shopData[i] = new ShopData();
                _shopData[i].NameCell = "Name";
                _shopData[i].Price = 0;
            }

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