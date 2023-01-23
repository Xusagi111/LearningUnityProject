using Assets.Code.Rpg;
using UnityEngine;


public class PlayerController : BaseEntity
{
    [field: SerializeField] private ParticleSystem _particleAttackPlayer { get; set; }
    [field: SerializeField] private float _distanseAttack { get; set; } = 5f;

    //“ак же добавить воспроизведение анимации игрока при атаке.
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(this.gameObject.transform.position, _distanseAttack);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _particleAttackPlayer.Play();
            AttackPlayer();
            Debug.Log("Pressed primary button.");
        }

        //if (Input.GetMouseButtonDown(1))
        //    Debug.Log("Pressed secondary button.");

        //if (Input.GetMouseButtonDown(2))
        //    Debug.Log("Pressed middle click.");
    }

    //Ётот метод будет активировать атаку мечЄм игрока, то есть урон будет проноситьс€ с помощью анимации.
    private void AttackPlayer()
    {
      
   //Ѕудет замахиватьс€ дл€ удара, и аттакавать.
    
    }
}
