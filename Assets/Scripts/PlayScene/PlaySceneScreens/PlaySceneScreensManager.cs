using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySceneScreensManager : MonoBehaviour
{
    [SerializeField] GameObject _screenOfDeath;
    public void StateScreenOfDeadth(bool statePlayer)
    {
        _screenOfDeath.SetActive(statePlayer);
    }
}
