using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterRectangleMovement : Moveable
{
    private int _speed = 15;
    private float _horizontalInput;
    private int _maxJumpCount = 2;
    private int _jumpForce = 5;
    private int _valueRotationX = 360;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        MaxJumpCount = _maxJumpCount;
        JumpForce = _jumpForce;
        Speed = _speed;
    }
    void Update()
    {
        EdgesMap();
        Jump(_rb);
        Move(Vector2.right);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            MaxJumpCount = _maxJumpCount;
        }
    }
    protected override void Jump(Rigidbody2D rigidbody2D)
    {
        if (MaxJumpCount >= 1 && Input.GetKeyDown(KeyCode.Space) && _horizontalInput < 0)
        {
            rigidbody2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            MaxJumpCount--;
            RotationX(_valueRotationX);
        }
        else if (MaxJumpCount >= 1 && Input.GetKeyDown(KeyCode.Space) && _horizontalInput > 0)
        {
            rigidbody2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            MaxJumpCount--;
            RotationX(-_valueRotationX);
        }
        else base.Jump(_rb);
    }
    private void RotationX(int valueRotationX)
    {
        transform.DOLocalRotate(new Vector3(0, 0, valueRotationX), 1f, RotateMode.FastBeyond360);
    }
    protected override void Move(Vector2 direction)
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(direction * _horizontalInput * Speed * Time.deltaTime, Space.World);
    }
}