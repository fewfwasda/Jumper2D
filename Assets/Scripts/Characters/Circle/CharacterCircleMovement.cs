using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterCircleMovement : Moveable
{
    private int _speed = 10;
    private int _maxJumpCount = 1;
    private int _jumpForce = 5;

    private float _horizontalInput;

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
    
    protected override void Move(Vector2 direction)
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(direction * _horizontalInput * Speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            MaxJumpCount = _maxJumpCount;
        }
    }
}
