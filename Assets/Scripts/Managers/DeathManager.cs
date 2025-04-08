using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    [SerializeField] GameObject _screenOfDeath;
    private bool _playerDeath = false;
    private void Awake()
    {
        GlobalEventManager.GameOver.AddListener(SetActiveScreen);
    }
    private void Update()
    {
        RestartGame();
    }
    private void SetActiveScreen()
    {
        _screenOfDeath.SetActive(true);
        _playerDeath = true;
    }
    private void RestartGame()
    {
        if (_playerDeath && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
