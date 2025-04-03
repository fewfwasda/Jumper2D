using UnityEngine;

public class SquareCharacterHealth : CharacterHealth
{
    protected override void Start()
    {
        Max = 5;
        base.Start();
    }
}