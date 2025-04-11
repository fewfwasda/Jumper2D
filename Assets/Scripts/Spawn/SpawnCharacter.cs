using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    private GameObject _character;
    private void Start()
    {
        _character = DataSaveLoad.LoadCharacter();
        Spawn();
    }
    private void Spawn() => Instantiate(_character);
}
