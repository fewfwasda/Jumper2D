using UnityEngine;
using UnityEngine.TextCore.Text;

public class SelectedCharacter : MonoBehaviour
{
    private static GameObject _character;

    public static void SetCharacter(GameObject character)
    {
        _character = character;
        DataSaveLoad.SaveCharacter(character);
        ShowSelectedCharacter.Instance.ShowCharacter(character);
    }
    public static GameObject GetCharacter()
    {
        return _character;
    }
}
