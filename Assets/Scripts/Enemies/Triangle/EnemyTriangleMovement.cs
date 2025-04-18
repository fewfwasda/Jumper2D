using DG.Tweening;
using UnityEngine;

public class EnemyTriangleMovement : Moveable
{
    private int _speed = 10;
    private Vector2 _direction;
    private void Start()
    {
        Speed = _speed;
        RotationTringle();
    }
    void Update()
    {
        Move(_direction);
        EdgesMap();
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
    protected override void EdgesMap()
    {
        if (transform.position.x > EdgeMap || transform.position.x < -EdgeMap) gameObject.SetActive(false);
    }
    private void RotationTringle()
    {
        transform.DORotate(new Vector3(0, 0, 360), 1.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear).SetLink(gameObject);
    }
    void OnEnable()
    {
        _direction = GetDirection();
    }
}