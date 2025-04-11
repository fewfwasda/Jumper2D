using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private GameObject _character;
    private Button _button;
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() => DataSaveLoad.SaveCharacter(_character));
        _button.onClick.AddListener(() => ShowSelectCharacter.Instance.SetCharacter(_character));
    }
}
