using UnityEngine;

namespace Assets.Strategy_Code.Entity
{
    public interface IMovePlayer
    {
        public void MovePlayer(Vector3 EndMovePosition);
    }
}
