using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private GameObject _character;
    private Button _button;
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Select);
    }
    private void Select()
    {
        GlobalEventManager.SendSelectCharacter(_character);
        //SpawnCharacter.SetCharacter(_character);
    }
}
