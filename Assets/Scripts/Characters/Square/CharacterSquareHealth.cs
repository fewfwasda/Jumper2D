using UnityEngine;

public class CharacterSquareHealth : Healthable
{
    private int _maxHealth = 5;
    private void Start()
    {
        MaxHealth = _maxHealth;
        CurrentHealth = _maxHealth;
        GlobalEventManager.SendPlayerOnScene();
    }
}
