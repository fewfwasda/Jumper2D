using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreensManager : MonoBehaviour
{
    [SerializeField]private GameObject _screenOfDeath;
    [SerializeField]private GameObject _pauseScreen;
    public static ScreensManager Instance;
    private void Awake()
    {
        Instance = this;
        GlobalEventManager.IsPlayerAlive.AddListener(ScreenOfDeadthActivate);
    }
    private void ScreenOfDeadthActivate(bool alivePlayer)
    {
        if(!alivePlayer) _screenOfDeath.SetActive(true);
    }
    public void PauseScreen(bool isActive)
    {
        _pauseScreen.SetActive(isActive);
    }
}
