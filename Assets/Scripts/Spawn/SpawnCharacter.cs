using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    private static GameObject _character;
    
    private void Start()
    {
        Spawn();
    }
    private void Spawn() => Instantiate(_character);
    public static void SetCharacter(GameObject character) => _character = character;
}
