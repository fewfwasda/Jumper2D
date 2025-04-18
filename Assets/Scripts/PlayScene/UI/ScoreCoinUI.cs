using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreCoinUI : MonoBehaviour
{
    private static TextMeshProUGUI _scoreCoinText;
    private void Awake()
    {
        GlobalEventManager.CoinPickedUp.AddListener(SetScore);
    }
    private void Start()
    {
        _scoreCoinText = GetComponent<TextMeshProUGUI>();
        _scoreCoinText.text = Bank.ScoreCoin.ToString();
    }
    private static void SetScore()
    {
        _scoreCoinText.text = Bank.ScoreCoin.ToString();
    }
}
