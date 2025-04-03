using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.Universal;

[CreateAssetMenu (fileName = "New Character", menuName = "Character")]
public class TemplateCharacterUI : ScriptableObject
{
    public string Name;

    public Sprite Sprite;

    public int Price;
    public int JumpCount;
    public int HealthCount;
}
