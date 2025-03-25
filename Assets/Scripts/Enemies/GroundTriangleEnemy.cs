using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;


public class GroundTriangleEnemy : Enemy
{
    private int _damage = 1;
    private int _speed = 10;
    private void Update()
    {
        MoveObstacle(_speed);
        DestroyOutOfBounds();
        SpinTriangleX();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Attack(_damage);
        }
    }
    private void SpinTriangleX()
    {
        transform.Rotate(Vector3.forward, 1);
    }
}