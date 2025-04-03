using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject CurrentCharacter;
    private void Awake()
    {
        if (Instance) Destroy(gameObject);
        else Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetCharacter(GameObject character)
    {
        CurrentCharacter = character;
    }
    //[SerializeField] private GameObject _screenOfDeath;
    //private bool _restartButton = false;
    //private void Awake()
    //{
    //    GlobalEventManager.DeathCharacter.AddListener(GameOver);
    //}
    //private void Update()
    //{
    //    if (_restartButton) RestartGame();
    //}
    //private void GameOver()
    //{
    //    _restartButton = true;
    //    CharacterMovement.Instance.DeadStatePlayer();
    //    _screenOfDeath.SetActive(true);
    //}
    //private void RestartGame()
    //{
    //    if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
}