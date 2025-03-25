using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    public int Speed;

    //две переменные прыжка для того, чтобы второй прыжок был слабее
    protected int JumpForce;

    public int MaxJumpCount;
    public int MaxJumpCountCurrent;

    protected Rigidbody2D Rb;

    private int _edgeMap = 28;

    private float _horizontalInput;
    public static Character Instance;
    private void Awake()
    {
        Instance = this;
    }
    protected void Start()
    {
        MaxJumpCount = 0;
        JumpForce = 0;
        Speed = 0;
        Rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
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
    protected virtual void Jump()
    {
        if (MaxJumpCountCurrent >= 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            MaxJumpCountCurrent--;
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
            MaxJumpCountCurrent = MaxJumpCount;
        }
    }
}