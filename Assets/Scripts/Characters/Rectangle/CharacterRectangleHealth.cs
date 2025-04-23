using UnityEngine;

public class CharacterRectangleHealth : Healthable
{
    private int _maxHealth = 5;
    private bool alivePlayer = true;
    private void Start()
    {
        MaxHealth = _maxHealth;
        CurrentHealth = _maxHealth;
        GlobalEventManager.SendIsAlivePlayer(alivePlayer);
    }
}
