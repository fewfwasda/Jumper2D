using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerUI : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
