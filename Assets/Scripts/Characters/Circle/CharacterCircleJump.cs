using UnityEngine;

public class CharacterCircleJump : CharacterJump
{
    private int _maxJumpCount = 1;
    private int _jumpForce = 5;

    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        MaxJumpCount = _maxJumpCount;
        JumpForce = _jumpForce;
    }
    void Update()
    {
        Jump(_rb);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            MaxJumpCount = _maxJumpCount;
        }
    }
}
