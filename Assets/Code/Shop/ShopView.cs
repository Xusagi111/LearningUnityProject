using Assets.Code.CellElement;
using Assets.Code.Static;
using Assets.Code.Test;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Shop
{
    public class ShopView : MonoBehaviour 
    {
        [field: SerializeField] private Transform _pointSpawnAllElement { get; set; }

        [field: SerializeField] private BaseCellElement _prefabCellElement { get; set; } 

        private List<BaseCellElement> _allCreateElement { get; set; } = new List<BaseCellElement>();

        private void RemoveAllElement()
        {
            for (int i = 0; i < _allCreateElement.Count; i++)
            {
                Destroy(_allCreateElement[i].gameObject);
            }
            _allCreateElement.Clear();
        }

        public void  CreateUIElement(ShopData[] AllSpawnElement)
        {
            if (TestShop.isDestroyGameObj == true)
            {
                RemoveAllElement();
                for (int i = 0; i < AllSpawnElement.Length; i++)
                {
                    BaseCellElement CellElement = Creator.CreateUICellElement(_prefabCellElement, _pointSpawnAllElement);
                    InitializationData.InitCellElement(CellElement, AllSpawnElement[i], i);
                    _allCreateElement.Add(CellElement);
                }
            }
            else if(TestShop.isDestroyGameObj == false)
            {
                var DefficeElement = AllSpawnElement.Length - _allCreateElement.Count;
                
                if (DefficeElement > 0)
                {
                    for (int i = 0; i < DefficeElement; i++)
                    {
                        _allCreateElement.Add(Instantiate(_prefabCellElement, Vector3.zero, Quaternion.identity, _pointSpawnAllElement));
                    }
                }

                for (int i = 0; i < AllSpawnElement.Length; i++)
                {
                    if (i == _allCreateElement.Count)
                    {
                        Debug.LogError("Ошибка в создание данных!");
                        break;
                    }
                    InitializationData.InitCellElement(_allCreateElement[i], AllSpawnElement[i], i);
                }
            }
            Debug.Log("AllSpawnElement: " +  _allCreateElement.Count);
        }
    }

}