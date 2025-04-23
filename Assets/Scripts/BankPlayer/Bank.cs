using UnityEngine;

public class Bank : MonoBehaviour
{
    public static int ScoreCoin { get; private set; }
    private void Start()
    {
        ScoreCoin = DataSaveLoad.LoadCoin();
    }
    public static void AddCoin(int coinValue)
    {
        ScoreCoin += coinValue;
        GlobalEventManager.SendCoinPickedUp();
    }
}