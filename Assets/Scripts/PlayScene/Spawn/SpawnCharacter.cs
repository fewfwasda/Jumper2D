using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _character;
    private void Start()
    {
        Spawn();
    }
    private void Spawn() => Instantiate(_character);
}
