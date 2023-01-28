using Assets.Code.Rpg;
using UnityEngine;


public class PlayerController : BaseEntity
{
    [field: SerializeField] private ParticleSystem _particleAttackPlayer { get; set; }
    [field: SerializeField] private float _distanseAttack { get; set; } = 5f;

    //��� �� �������� ��������������� �������� ������ ��� �����.
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

    //���� ����� ����� ������������ ����� ����� ������, �� ���� ���� ����� ����������� � ������� ��������.
    private void AttackPlayer()
    {
      
   //����� ������������ ��� �����, � ����������.
    
    }
}
