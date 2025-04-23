using UnityEngine;

public class EnemySawDamage : Damageable
{
    private int _damage = 2;
    void Start()
    {
        Damage = _damage;
    }
}
