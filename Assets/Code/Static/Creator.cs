using Assets.Code.CellElement;
using UnityEngine;

namespace Assets.Code.Static
{
    public static class Creator
    {
        public static BaseCellElement CreateUICellElement(BaseCellElement SampleCreateElement, Transform ParentGameObj)
        {
            return GameObject.Instantiate(SampleCreateElement, Vector3.zero, Quaternion.identity, ParentGameObj);
        } 
    }
}