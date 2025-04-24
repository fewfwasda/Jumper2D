using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtons : MonoBehaviour
{
    private bool _statePlayer = false;
    private bool _isPause = false;
    private void Awake()
    {
        GlobalEventManager.IsPlayerAlive.AddListener(Restart);
    }
    private void Update()
    {
        Restart(_statePlayer);
        Pause();
    }
    private void Restart(bool statePlayer)
    {
        _statePlayer = statePlayer;
        if (!_statePlayer && Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    private void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_isPause)
        {
            _isPause = true;
            ScreensManager.Instance.PauseScreen(_isPause);
            Time.timeScale = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && _isPause)
        {
            _isPause = false;
            ScreensManager.Instance.PauseScreen(_isPause);
            Time.timeScale = 1;
        }
    }
    public void Play()
    {
        _isPause = false;
        ScreensManager.Instance.PauseScreen(_isPause);
        Time.timeScale = 1;
    }
}
