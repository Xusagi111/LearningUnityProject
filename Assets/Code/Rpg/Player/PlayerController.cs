using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [field: SerializeField] private ParticleSystem _particleAttackPlayer { get; set; }
    [field: SerializeField] private float _distanseAttack { get; set; } = 5f;
    //Так же добавить воспроизведение анимации игрока при атаке.

    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _particleAttackPlayer.Play();
            Debug.Log("Pressed primary button.");
        }

        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");
    }
}
