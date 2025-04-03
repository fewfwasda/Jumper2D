using UnityEngine;

public class CircleCharacterHealth : CharacterHealth
{
    protected override void Start()
    {
        Max = 3;
        base.Start();
    }
}