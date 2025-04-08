using UnityEngine;

public class EnemyCircleDamage : Damageable
{
    private int _damage = 1;
    void Start()
    {
        Damage = _damage;
    }
}
