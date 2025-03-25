using UnityEngine;

public class CircleCharacterHealth : CharacterHealth
{
    public override void Start()
    {
        MaxHealth = 3;
        CurrentHealth = MaxHealth;
    }
}