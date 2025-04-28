using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreCoinUI : MonoBehaviour
{
    private TextMeshProUGUI _scoreCoinText;
    private int scoreCoin;

    private void Awake()
    {
        GlobalEventManager.CoinPickedUp.AddListener(ShowCoinScore);
    }
    private void Start()
    {
        _scoreCoinText = GetComponent<TextMeshProUGUI>();
        SetCoinScore();
    }
    private void SetCoinScore()
    {
        scoreCoin = DataSaveLoad.LoadCoin();
        _scoreCoinText.text = scoreCoin.ToString();
    }
    private void ShowCoinScore(int valueCoin)
    {
        scoreCoin += valueCoin;
        _scoreCoinText.text = scoreCoin.ToString();
    }
}
