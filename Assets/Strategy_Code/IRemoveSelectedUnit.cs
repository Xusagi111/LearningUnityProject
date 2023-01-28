using UnityEngine;

namespace Assets.Strategy_Code
{
    public interface IRemoveSelectedUnit
    {
        public void RemoveElement(Rigidbody rigidbody);
        public void RemoveAllElement();
    }
}
