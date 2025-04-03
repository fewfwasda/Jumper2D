using UnityEngine;

public class GroundCircleEnemy : Enemy
{
    protected override void Start()
    {
        Damage = 1;
        Speed = 10;
        base.Start();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CharacterHealth.Instance.Remove(Damage);
        }
    }
}