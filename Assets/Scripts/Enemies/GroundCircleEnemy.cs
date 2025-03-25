using UnityEngine;

public class GroundCircleEnemy : Enemy
{
    private int _damage = 2;
    private int _speed = 20;
    private void Update()
    {
        MoveObstacle(_speed);
        DestroyOutOfBounds();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Attack(_damage);
        }
    }
}