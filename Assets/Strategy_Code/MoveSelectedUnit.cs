using Assets.Strategy_Code.Entity;
using DG.Tweening;
using UnityEngine;


namespace Assets.Strategy_Code
{
    public class MoveSelectedUnit : MonoBehaviour
    {
        //[field: SerializeField] private MeshRenderer _thisSelectionObjmeshren;
        //[field: SerializeField] private Material _activeMat;
        //[field: SerializeField] private Material _inactiveMat;

        [field: SerializeField] private float _testSpeedMoveElement = 5;


        private void OnMouseDown()
        {
            OpenSelectedObj();
        }

        private void OpenSelectedObj()
        {
            var easyLink = EasyLink.Instance;
            var AllUnit = easyLink.IGetAllSelectedUnit.GetSelectedElement();

            Vector3 worldPosition = RayCastTOObjCurrentCurrentPos(new Vector3());
            worldPosition += new Vector3(0, 1.3f, 0);

            foreach (var item in AllUnit)
            {
                item.velocity = Vector3.zero;
                item.GetComponent<IMovePlayer>().MovePlayer(worldPosition);
                //Вот это надо убирать, надо делать через риджид юади.
                //item.transform.DOMove(worldPosition, _testSpeedMoveElement).OnComplete(() => {

                //    Debug.Log("Конец перемещения игрока!");
                //});
            }

            foreach (var item in AllUnit)
            {
                item.GetComponent<ISelectedElement>().inactiveSelectedObj();
            }

            easyLink.IRemoveSelectedUnit.RemoveAllElement();
        }

        private Vector3 RayCastTOObjCurrentCurrentPos(Vector3 worldPosition)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitData;

            if (Physics.Raycast(ray, out hitData, 1000))
            {
                worldPosition = hitData.point;
            }

            return worldPosition;
        }

        private void AnimationGround()
        {

        }

        //private void CheckPlayerClick()
        //{
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        Debug.Log("Pressed primary button.");
        //    }

        //    //if (Input.GetMouseButtonDown(1))
        //    //    Debug.Log("Pressed secondary button.");

        //    //if (Input.GetMouseButtonDown(2))
        //    //    Debug.Log("Pressed middle click.");
        //}
    }
}