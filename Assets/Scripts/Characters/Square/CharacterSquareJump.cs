using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterSquareJump : CharacterJump
{
    private int _maxJumpCount = 2;
    private int _jumpForce = 8;
    private int _valueRotationX = 90;
    private int _rotationX = 0;
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
    protected override void Jump(Rigidbody2D rigidbody2D)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rotationX += _valueRotationX;
            transform.DOLocalRotateQuaternion(Quaternion.Euler(0, 0, _rotationX), 2);
        }
    }
}