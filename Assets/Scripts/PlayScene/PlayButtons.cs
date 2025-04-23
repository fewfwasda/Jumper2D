using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtons : MonoBehaviour
{
    private bool _statePlayer = false;
    private void Awake()
    {
        GlobalEventManager.IsPlayerAlive.AddListener(Restart);
    }
    private void Update()
    {
        Restart(_statePlayer);
        GoToMenu();
    }
    private void Restart(bool statePlayer)
    {
        _statePlayer = statePlayer;
        if (!_statePlayer && Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void GoToMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) SceneManager.LoadScene(0);
    }
}
