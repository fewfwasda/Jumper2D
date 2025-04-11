using UnityEngine;
using UnityEngine.UIElements.Experimental;

public abstract class Healthable : MonoBehaviour
{
    public static int MaxHealth { get; protected set; }
    public static int CurrentHealth { get; protected set; }
    public static void AddHealth(int healing)
    {
        if(CurrentHealth < MaxHealth)
        {
            CurrentHealth += healing;
            GlobalEventManager.SendChangeHealth();
        }
    }
    public static void RemoveHealth(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0) GlobalEventManager.SendGameOver();
        else GlobalEventManager.SendChangeHealth();
    }
}