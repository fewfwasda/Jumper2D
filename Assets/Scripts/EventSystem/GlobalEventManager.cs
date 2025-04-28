using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager
{
    public static UnityEvent PlayerLive = new UnityEvent();
    public static UnityEvent PlayerDead = new UnityEvent();
    public static UnityEvent<int> HurtChatacter = new UnityEvent<int>();
    public static UnityEvent<int> HealChatacter = new UnityEvent<int>();
    public static UnityEvent<int> CoinPickedUp = new UnityEvent<int>();
    public static void SendPlayerLive()
    {
        PlayerLive.Invoke();
    }
    public static void SendPlayerDead()
    {
        PlayerDead.Invoke();
    }
    public static void SendHurtChatacter(int damage)
    {
        HurtChatacter.Invoke(damage);
    }
    public static void SendHealChatacter(int heal)
    {
        HealChatacter.Invoke(heal);
    }
    public static void SendCoinPickedUp(int value)
    {
        CoinPickedUp.Invoke(value);
    }
}