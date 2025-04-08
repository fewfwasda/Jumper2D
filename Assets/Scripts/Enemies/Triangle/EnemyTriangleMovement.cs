using UnityEngine;

public class EnemyTriangleMovement : Moveable
{
    private int _speed = 5;
    private Vector2 _direction;
    private void Start()
    {
        Speed = _speed;
        _direction = GetDirection();
    }
    void Update()
    {
        Move(_direction);
        SpinX();
    }
    protected override void Move(Vector2 direction)
    {
        transform.Translate(direction * Speed * Time.deltaTime, Space.World);
    }
    private Vector2 GetDirection()
    {
        if (transform.position.x > 0) return Vector2.left;
        return Vector2.right;
    }
    private void SpinX()
    {
        transform.Rotate(Vector3.forward, 1);
    }
}