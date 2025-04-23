using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;
    private void Awake()
    {
        
        if (Instance != null) Destroy(gameObject);
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
}
