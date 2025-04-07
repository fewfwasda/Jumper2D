using UnityEngine;

public class ScreenOfDeath : MonoBehaviour
{
    [SerializeField] GameObject _screenOfDeath;
    private void Awake()
    {
        GlobalEventManager.GameOver.AddListener(SetActiveScreen);
    }
    private void SetActiveScreen()
    {
        _screenOfDeath.SetActive(true);
    }
}
