using UnityEngine;

public abstract class Moveable : MonoBehaviour
{
    protected virtual int Speed { get; set; }
    protected virtual int JumpForce { get; set; }
    protected virtual int MaxJumpCount { get; set; }
    protected virtual int EdgeMap { get; set; } = 27;
    
    private void Awake()
    {
        GlobalEventManager.GameOver.AddListener(MoveableStatsAfterDead);
    }
    protected virtual void Move(Vector2 direction)
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
    protected virtual void Jump(Rigidbody2D rigidbody2D)
    {
        if (MaxJumpCount >= 1 && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            MaxJumpCount--;
        }
    }
    protected virtual void EdgesMap()
    {
        if (transform.position.x > EdgeMap) transform.position = new Vector2(-EdgeMap, transform.position.y);
        else if (transform.position.x < -EdgeMap) transform.position = new Vector2(EdgeMap, transform.position.y);
    }
    private void MoveableStatsAfterDead()
    {
        Speed = 0;
        MaxJumpCount = 0;
    }
}