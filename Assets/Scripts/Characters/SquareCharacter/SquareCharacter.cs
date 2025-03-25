using UnityEngine;

public class SquareCharacter : Character
{
    protected new void Start()
    {
        MaxJumpCount = 2;
        JumpForce = 5;
        Speed = 50;
        Rb = GetComponent<Rigidbody2D>();
    }
}