using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}