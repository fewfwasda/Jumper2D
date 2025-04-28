using UnityEngine;

public class Bank : MonoBehaviour
{
    public static int ScoreCoin { get; private set; }
    private void Awake()
    {
        GlobalEventManager.CoinPickedUp.AddListener(AddCoin);
    }
    private void Start()
    {
        ScoreCoin = GetCoin();
    }
    public static void AddCoin(int coinValue)
    {
        ScoreCoin += coinValue;
    }
    public static int GetCoin()
    {
        return DataSaveLoad.LoadCoin();
    }
    public static void SaveCoin()
    {
        DataSaveLoad.SaveCoin(ScoreCoin);
    }
}