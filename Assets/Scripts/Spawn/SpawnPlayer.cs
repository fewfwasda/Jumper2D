using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] GameObject _player;
    void Start()
    {
        Instantiate(_player);
    }
}
