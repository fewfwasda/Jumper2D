using UnityEngine;

public class EnemyTriangleDamage : Damageable
{
    private int _damage = 2;
    void Start()
    {
        Damage = _damage;
    }
}
