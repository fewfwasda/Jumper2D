using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    private GameObject _player;
    void Start()
    {
        
    }
    protected void SetPlayer(GameObject player)
    {
        _player = player;
        Instantiate(_player);
    }
}
