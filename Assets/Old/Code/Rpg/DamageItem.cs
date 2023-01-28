using UnityEngine;

namespace Assets.Code.Rpg
{
    public class DamageItem : MonoBehaviour
    {
        private int _instanseIDToCurrentEntity; //Просмотреть относится ли это поле к неповторяемым значениям в юнити. 
        public int Damage { get; set; } //Добавить урон у передмета через код.

        public void Init(int indexId)
        {
            _instanseIDToCurrentEntity = indexId;
        }

        //Происходит соприкосновение с объектом
        private void OnCollisionEnter(Collision collision)
        {
            if (TryGetComponent(out BaseEntity Entyty))
            {
                if (Entyty.CurrentIndex != _instanseIDToCurrentEntity)
                {
                    Entyty.GetDamage(Damage);
                }
            }
        }
    }
}