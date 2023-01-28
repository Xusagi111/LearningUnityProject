using Assets.Strategy_Code.Entity;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Strategy_Code
{
    public class Player : MonoBehaviour, ISelectedElement, IMovePlayer
    {
        [field: SerializeField] private MeshRenderer _thisSelectionObjmeshren;
        [field: SerializeField] private Rigidbody _rg;
        [field: SerializeField] private Vector3 _endMovePos;
        [field: SerializeField] private bool _isMoveElement = false;
        [field: SerializeField] private NavMeshAgent _navMeshAgent;

        private void OnMouseDown()
        {
            OpenSelectedObj();
        }

        public void OpenSelectedObj()
        {
            if (_thisSelectionObjmeshren.gameObject.activeSelf == false)
            {
                _thisSelectionObjmeshren.gameObject.SetActive(true);
                EasyLink.Instance.ISavindSelectedUnit.AddElement(_rg);
            }
            else
            {
                _thisSelectionObjmeshren.gameObject.SetActive(false);
                EasyLink.Instance.IRemoveSelectedUnit.RemoveElement(_rg);
            }
        }

        public void MovePlayer(Vector3 EndMovePosition)
        {
            _navMeshAgent.SetDestination(EndMovePosition);
        }

        public void inactiveSelectedObj()
        {
            _thisSelectionObjmeshren.gameObject.SetActive(false);
        }
    }
}