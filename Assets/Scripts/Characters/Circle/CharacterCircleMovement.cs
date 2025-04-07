using UnityEngine;

public class CharacterCircleMovement : Moveable
{
    private int _speed = 100;
    private float _horizontalInput;
    private void Start()
    {
        Speed = _speed;
    }
    void Update()
    {
        Move(Vector2.right);
    }
    protected override void Move(Vector2 direction)
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(direction * _horizontalInput * Speed * Time.deltaTime);
    }
}
