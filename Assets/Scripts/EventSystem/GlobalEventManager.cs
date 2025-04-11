using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager
{
    public static UnityEvent ChangeHealth = new UnityEvent();
    public static UnityEvent GameOver = new UnityEvent();
    public static UnityEvent CoinPickedUp = new UnityEvent();

    //событие отвечает за то, что находится игрок на сцене
    public static UnityEvent PlayerOnScene = new UnityEvent();

    public static void SendChangeHealth()
    {
        ChangeHealth.Invoke();
    }
    public static void SendGameOver()
    {
        GameOver.Invoke();
    }
    public static void SendCoinPickedUp()
    {
        CoinPickedUp.Invoke();
    }

    public static void SendPlayerOnScene()
    {
        PlayerOnScene.Invoke();
    }
}