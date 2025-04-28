using UnityEngine;
using UnityEngine.UIElements.Experimental;

public abstract class Healthable : MonoBehaviour
{
    public static int MaxHealth { get; protected set; }
    public static int CurrentHealth { get; protected set; }

    private static bool alivePlayer;
    private void Awake()
    {
        GlobalEventManager.HurtChatacter.AddListener(RemoveHealth);
        GlobalEventManager.HealChatacter.AddListener(AddHealth);
    }
    public void AddHealth(int healing)
    {
        if(CurrentHealth < MaxHealth)
        {
            CurrentHealth += healing;
        }
    }
    public void RemoveHealth(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0)
        {
            alivePlayer = false;
            GlobalEventManager.SendIsAlivePlayer(alivePlayer);
        }
    }
}