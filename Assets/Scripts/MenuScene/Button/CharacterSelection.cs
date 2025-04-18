using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private GameObject _character;
    private Button _button;
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() => SelectedCharacter.SetCharacter(_character));
    }
}
