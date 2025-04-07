using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class CharacterJump : MonoBehaviour
{
    protected virtual int JumpForce { get; set; }
    protected virtual int MaxJumpCount { get; set; }
    protected void Jump(Rigidbody2D rigidbody2D)
    {
        if (MaxJumpCount >= 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(MaxJumpCount);
            rigidbody2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            MaxJumpCount--;
        }
    }
}
