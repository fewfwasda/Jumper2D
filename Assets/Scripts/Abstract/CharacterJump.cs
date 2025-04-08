using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class CharacterJump : MonoBehaviour
{
    protected virtual int JumpForce { get; set; }
    protected virtual int MaxJumpCount { get; set; }
    protected virtual void Jump(Rigidbody2D rigidbody2D)
    {
        if (MaxJumpCount >= 1 && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            MaxJumpCount--;
        }
    }
}
