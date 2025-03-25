using UnityEngine;

public class CircleCharacter : Character
{
    protected new void Start()
    {
        MaxJumpCount = 1;
        JumpForce = 5;
        Speed = 30;
        Rb = GetComponent<Rigidbody2D>();
    }
}