using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public abstract class CharacterMovement: MonoBehaviour
{
    protected int Speed;
    protected int JumpForce;
    protected int MaxJumpCount;
    [SerializeField]private int _maxJumpCountCurrent;

    protected Rigidbody2D Rb;

    private int _edgeMap = 28;

    private float _horizontalInput;
    public static CharacterMovement Instance;
    private void Awake()
    {
        Instance = this;
    }
    private void LateUpdate()
    {
        Move();
        Jump();
        EdgesMap();
    }
    private void Move()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * _horizontalInput * Speed * Time.deltaTime);
    }
    private void Jump()
    {
        if (_maxJumpCountCurrent >= 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            _maxJumpCountCurrent--;
        }
    }
    private void EdgesMap()
    {
        if (transform.position.x > _edgeMap) transform.position = new Vector2(-_edgeMap, transform.position.y);
        else if (transform.position.x < -_edgeMap) transform.position = new Vector2(_edgeMap, transform.position.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _maxJumpCountCurrent = MaxJumpCount;
        }
    }

    public void DeadStatePlayer()
    {
        Speed = 0;
        JumpForce = 0;
        MaxJumpCount = 0;
    }
}