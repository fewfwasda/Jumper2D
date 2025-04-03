using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _screenOfDeath;
    private bool _restartButton = false;
    private void Awake()
    {
        GlobalEventManager.DeathCharacter.AddListener(GameOver);
    }
    private void Update()
    {
        if (_restartButton) RestartGame();
    }
    private void GameOver()
    {
        _restartButton = true;
        CharacterMovement.Instance.DeadStatePlayer();
        _screenOfDeath.SetActive(true);
    }
    private void RestartGame()
    {
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}