using UnityEngine;

public class CircleCharacter : CharacterMovement
{
    private void Start()
    {
        MaxJumpCount = 1;
        JumpForce = 5;
        Speed = 15;
        Rb = GetComponent<Rigidbody2D>();
    }
}