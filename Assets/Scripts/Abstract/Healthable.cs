using UnityEngine;
using UnityEngine.UIElements.Experimental;

public abstract class Healthable : MonoBehaviour
{
    public virtual int MaxHealth { get; protected set; }
    public virtual int CurrentHealth { get; protected set; }
    public static Healthable Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
    }
    public void AddHealth(int healing)
    {
        if(CurrentHealth < MaxHealth)
        {
            CurrentHealth += healing;
            GlobalEventManager.SendChangeHealth();
        }
    }
    public void RemoveHealth(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0) GlobalEventManager.SendGameOver();
        else GlobalEventManager.SendChangeHealth();
    }
}