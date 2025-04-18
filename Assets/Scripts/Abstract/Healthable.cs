using UnityEngine;
using UnityEngine.UIElements.Experimental;

public abstract class Healthable : MonoBehaviour
{
    public static int MaxHealth { get; protected set; }
    public static int CurrentHealth { get; protected set; }

    private static bool _isDeath;
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
        GlobalEventManager.SendChangeHealth();
        if (CurrentHealth <= 0)
        {
            _isDeath = true;
            GlobalEventManager.SendStatePlayer(_isDeath);
        }
    }
}