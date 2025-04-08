using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterSquareMovement : Moveable
{
    private int _speed = 15;
    private float _horizontalInput;
    private SpriteRenderer _spriteRenderer;
    private void Start()
    {
        Speed = _speed;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void LateUpdate()
    {
        Move(Vector2.right);
    }
    protected override void Move(Vector2 direction)
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(direction * _horizontalInput * Speed * Time.deltaTime, Space.World);
    }
}