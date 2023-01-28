using System.Collections.Generic;
using UnityEngine;

namespace Assets.Strategy_Code
{
    public class SavindSelectedUnit : MonoBehaviour, ISelectedUnit, IRemoveSelectedUnit, IGetAllSelectedUnit
    {
        [field: SerializeField] private List<Rigidbody> AllMoveElement = new List<Rigidbody>();

        public void AddElement(Rigidbody rigidbody)
        {
            AllMoveElement.Add(rigidbody);
        }

        public void RemoveElement(Rigidbody rigidbody)
        {
            int ItemIndex = 0;
            bool isСoincidence = false;

            foreach (var item in AllMoveElement)
            {
                ItemIndex++;

                if (rigidbody == item)
                {
                    isСoincidence = true;
                    break;
                }
            }
            if (isСoincidence == true)
            {
                AllMoveElement.Remove(rigidbody);
            }
        }

        public void RemoveAllElement()
        {
            AllMoveElement.Clear();
        }

        public List<Rigidbody> GetSelectedElement()
        {
            //Посмотреть как будет лучше, клонировать и возвращать список, или передавать его так.
            return AllMoveElement;
        }

        [ContextMenu("SelectedAllPlayer")]
        public void AllSelectedUnit()
        {
            //Усовершенствовать, так как в данный момент будет не предсказуемая логика с выдением объектов.
            var AllUnits = Resources.FindObjectsOfTypeAll<Player>();
            foreach (var item in AllUnits)
            {
                item.OpenSelectedObj();
            }
        }
    }
}