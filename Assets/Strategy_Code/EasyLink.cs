using UnityEngine;

namespace Assets.Strategy_Code
{
    public class EasyLink : MonoBehaviour
    {
        public static EasyLink Instance;

        [field: SerializeField] private SavindSelectedUnit _savindSelectedUnit;
        [field: SerializeField] public ISelectedUnit ISavindSelectedUnit;
        [field: SerializeField] public IRemoveSelectedUnit IRemoveSelectedUnit;
        [field: SerializeField] public IGetAllSelectedUnit IGetAllSelectedUnit;
        
        private void Awake()
        {
            if (Instance != null) Destroy(Instance);
            Instance = this;

            TransformationСlassingToInterface();
        }

        private void TransformationСlassingToInterface()
        {
            try
            {
                ISavindSelectedUnit = _savindSelectedUnit;
                IRemoveSelectedUnit = _savindSelectedUnit;
                IGetAllSelectedUnit = _savindSelectedUnit;
            }
            catch (System.Exception)
            {
                Debug.LogError("ERROR TRANSFORMATION CLASS");
            }  
        } 
    }
}