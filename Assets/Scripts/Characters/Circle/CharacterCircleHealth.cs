using UnityEngine;

public class CharacterCircleHealth : Healthable
{
    private int _maxHealth = 3;
    private bool alivePlayer = true;
    private void Start()
    {
        MaxHealth = _maxHealth;
        CurrentHealth = _maxHealth;
        GlobalEventManager.SendIsAlivePlayer(alivePlayer);
    }
}
