using Assets.Code.Shop;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.Test
{
    public class TestShop : MonoBehaviour
    {
        public ShopModel Shop;
        public static bool isDestroyGameObj = true;
        public static int CountSpawnElement;

        public TMP_InputField InputValueSpawn;
        public Toggle ToggleElement;
        

        [ContextMenu("CreateElement")]
        public void CreateElement()
        {
            Shop.Create();
        }

        [ContextMenu("CreateElement")]
        public void StartCountSpawnElement()
        {
            CountSpawnElement = int.Parse(InputValueSpawn.text.Trim());
            isDestroyGameObj = ToggleElement.isOn;
        }
    }
}