using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager
{
    public static UnityEvent ChangeHealth = new UnityEvent();
    public static UnityEvent StartGame = new UnityEvent();
    public static UnityEvent GameOver = new UnityEvent();
    public static void SendChangeHealth()
    {
        ChangeHealth.Invoke();
    }
    public static void SendStartGame()
    {
        StartGame.Invoke();
    }
    public static void SendGameOver()
    {
        GameOver.Invoke();
    }
}