using UnityEngine;

namespace Assets.Code.Rpg
{
    public class BaseEntity : MonoBehaviour
    {
        protected float Healf { get; private set; }
        protected float Damage { get; set; }
        protected float Armor { get; set; }

        public int CurrentIndex { get; private set; }

        private void Awake()
        {
            CurrentIndex = GetInstanceID();
        }

        public void GetDamage(float Damage)
        {
            float EndMinusHp = Damage;
            if (Armor != 0)
            {
                float DefficeDamage = Armor - Damage;
                if (DefficeDamage < 0)
                {
                    EndMinusHp = DefficeDamage * -1;
                    Armor = 0;
                }
                else if (DefficeDamage > 0)
                {
                    Armor = DefficeDamage;
                    EndMinusHp = 0;
                }
            }

            Healf -= EndMinusHp;

            if (Healf <= EndMinusHp)
            {
                Healf = 0;
                Debug.Log("Игрок умер!");
            }
        }
    }
}