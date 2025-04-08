using UnityEngine;

public class CharacterSquareHealth : Healthable
{
    private int _maxHealth = 5;
    private void Start()
    {
        Health = _maxHealth;
        GlobalEventManager.SendStartGame();
    }
}
