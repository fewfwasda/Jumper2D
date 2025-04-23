using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreensManager : MonoBehaviour
{
    [SerializeField] GameObject _screenOfDeath;
    private void Awake()
    {
        GlobalEventManager.IsPlayerAlive.AddListener(ScreenOfDeadthActivate);
    }
    public void ScreenOfDeadthActivate(bool alivePlayer)
    {
        if(!alivePlayer) _screenOfDeath.SetActive(true);
    }
}
