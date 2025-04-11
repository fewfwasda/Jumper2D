using UnityEngine;

public class EnemyCircleMovement : Moveable
{
    private int _speed = 10;
    private Vector2 _direction;
    private void Start()
    {
        Speed = _speed;
        _direction = GetDirection();
    }
    void Update()
    {
        Move(_direction);
        EdgesMap();
    }
    protected override void Move(Vector2 direction)
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
    private Vector2 GetDirection()
    {
        if (transform.position.x > 0) return Vector2.left;
        return Vector2.right;
    }
    protected override void EdgesMap()
    {
        if (transform.position.x > EdgeMap || transform.position.x < -EdgeMap) Destroy(gameObject);
    }
}
