using System.Collections.Generic;
using UnityEngine;

namespace Assets.Strategy_Code
{
    public interface IGetAllSelectedUnit
    {
        public List<Rigidbody> GetSelectedElement();
    }
}
