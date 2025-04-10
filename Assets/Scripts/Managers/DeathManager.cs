using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    [SerializeField] GameObject _screenOfDeath;
    private bool _playerDeath = false;
    private void Awake()
    {
        GlobalEventManager.GameOver.AddListener(GameOver);
    }
    private void Update()
    {
        RestartGame();
    }
    private void GameOver()
    {
        _playerDeath = true;
        SetActiveScreen();
        SaveLeveData();
    }
    private void SetActiveScreen()
    {
        _screenOfDeath.SetActive(true);
    }
    private void SaveLeveData()
    {
        DataSaveLoad.SaveSacoreCoin();
    }
    private void RestartGame()
    {
        if (_playerDeath && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
