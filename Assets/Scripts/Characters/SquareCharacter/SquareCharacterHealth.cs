using UnityEngine;

public class SquareCharacterHealth : CharacterHealth
{
    public override void Start()
    {
        MaxHealth = 5;
        CurrentHealth = MaxHealth;
    }
}