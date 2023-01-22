using System.Collections;
using UnityEngine;

namespace Assets.Testing_Zenject.Code
{
    public class TestInstanse : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("Start");
        }
    }

    public class CubeElement
    {
        public void Move()
        {
            Debug.Log("Transfer Cube");
        }
    }
}