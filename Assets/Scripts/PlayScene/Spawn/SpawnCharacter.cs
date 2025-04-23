using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class SpawnCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _character;
    private void Start()
    {
        if (DataSaveLoad.LoadCharacter() != null) _character = DataSaveLoad.LoadCharacter();
        Spawn();
    }
    private void Spawn() => Instantiate(_character);
}
