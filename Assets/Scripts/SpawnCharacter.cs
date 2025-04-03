using UnityEngine;
using UnityEngine.TextCore.Text;

public class SpawnCharacter : MonoBehaviour
{
    private void Start()
    {
        Instantiate(GameManager.Instance.CurrentCharacter);
    }
}
