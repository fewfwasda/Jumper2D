using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    private Button button;
    public GameObject Character;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(() => GameManager.Instance.SetCharacter(Character));
    }
}
