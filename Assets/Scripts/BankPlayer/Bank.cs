using UnityEngine;

public class Bank : MonoBehaviour
{
    public static int ScoreCoin { get; private set; }
    public static void AddCoin(int coinValue)
    {
        ScoreCoin += coinValue;
        GlobalEventManager.SendCoinPickedUp();
    }
}
