using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager
{
    public static UnityEvent CoinPickedUp = new UnityEvent();
    public static UnityEvent<bool> IsPlayerAlive = new UnityEvent<bool>();
    public static UnityEvent ChangeHealth = new UnityEvent();
    public static void SendIsAlivePlayer(bool statePlayer)
    {
        IsPlayerAlive.Invoke(statePlayer);
    }
    public static void SendChangeHealth()
    {
        ChangeHealth.Invoke();
    }
    public static void SendCoinPickedUp()
    {
        CoinPickedUp.Invoke();
    }
}