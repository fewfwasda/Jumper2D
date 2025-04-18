using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager
{
    public static UnityEvent CoinPickedUp = new UnityEvent();
    public static UnityEvent<bool> StatePlayer = new UnityEvent<bool>();
    public static UnityEvent ChangeHealth = new UnityEvent();
    public static UnityEvent NextWave = new UnityEvent();
    public static UnityEvent<bool> FinishGame = new UnityEvent<bool>();

    //событие отвечает за то, что находится игрок на сцене
    public static UnityEvent PlayerOnScene = new UnityEvent();
    public static void SendStatePlayer(bool statePLayer)
    {
        StatePlayer.Invoke(statePLayer);
    }
    public static void SendFinishGame(bool isFinish)
    {
        FinishGame.Invoke(isFinish);
    }
    public static void SendNextWave()
    {
        NextWave.Invoke();
    }
    public static void SendChangeHealth()
    {
        ChangeHealth.Invoke();
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