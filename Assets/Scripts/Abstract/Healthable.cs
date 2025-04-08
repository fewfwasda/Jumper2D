using UnityEngine;
using UnityEngine.UIElements.Experimental;

public abstract class Healthable : MonoBehaviour
{
    public virtual int Health { get; protected set; }
    public static Healthable Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
    }
    public void AddHealth(int healing)
    {
        Health += healing;
        GlobalEventManager.SendChangeHealth();
    }
    public void RemoveHealth(int damage)
    {
        Health -= damage;
        if (Health <= 0) GlobalEventManager.SendGameOver();
        else GlobalEventManager.SendChangeHealth();
    }
}