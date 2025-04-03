using UnityEngine;
using System.Collections.Generic;

public class SquareCharacter : CharacterMovement
{
    private void Start()
    {
        MaxJumpCount = 2;
        JumpForce = 5;
        Speed = 30;
        Rb = GetComponent<Rigidbody2D>();   
    }
}