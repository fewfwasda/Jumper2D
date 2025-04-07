using UnityEngine;

public class CharacterCircleHealth : Healthable
{
    private int _maxHealth = 3;
    private void Start()
    {
        Health = _maxHealth;
        GlobalEventManager.SendStartGame();
    }
}
