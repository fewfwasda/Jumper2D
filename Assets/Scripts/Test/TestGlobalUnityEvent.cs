using UnityEngine;
using UnityEngine.Events;

public class TestGlobalUnityEvent
{
    public static UnityEvent<int> Coin = new UnityEvent<int>();
    public static void SendCoin(int value)
    {
        Coin.Invoke(value);
    }
}
