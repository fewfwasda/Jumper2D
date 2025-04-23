using UnityEngine;
using UnityEngine.TextCore.Text;

public class SaveSelectedCharacter : MonoBehaviour
{
    public static void SaveCharacter(GameObject character)
    {
        DataSaveLoad.SaveCharacter(character);
        
    }
}
