using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreCoinUI : MonoBehaviour
{
    private TextMeshProUGUI _scoreCoinText;
    private void Awake()
    {
        GlobalEventManager.CoinPickedUp.AddListener(SetScore);
    }
    private void Start()
    {
        _scoreCoinText = GetComponent<TextMeshProUGUI>();
        _scoreCoinText.text = Bank.Instance.ScoreCoin.ToString();
    }
    private void SetScore()
    {
        _scoreCoinText.text = Bank.Instance.ScoreCoin.ToString();
    }
}
