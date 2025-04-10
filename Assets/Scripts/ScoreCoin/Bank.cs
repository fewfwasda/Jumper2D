using UnityEngine;

public class Bank : MonoBehaviour
{
    public int ScoreCoin { get; private set; }
    private int _coinValue = 1;
    public static Bank Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        GlobalEventManager.CoinPickedUp.AddListener(AddCoin);
    }
    private void Start()
    {
        ScoreCoin = DataSaveLoad.LoadScoreCoin();
    }
    private void AddCoin()
    {
        ScoreCoin += _coinValue;
    }
}
