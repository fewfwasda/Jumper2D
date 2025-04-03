using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowCharacterUI : MonoBehaviour
{
    public TemplateCharacterUI TemplateCharacter;
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI PriceText;
    public TextMeshProUGUI JumpCountText;
    public TextMeshProUGUI HealthCountText;

    public Image CharacterImage;

    private void Start()
    {
        NameText.text = TemplateCharacter.Name;
        PriceText.text = TemplateCharacter.Price.ToString();
        JumpCountText.text = $"Jump Count: {TemplateCharacter.JumpCount.ToString()}";
        HealthCountText.text = $"Health: {TemplateCharacter.HealthCount.ToString()}";

        CharacterImage.sprite = TemplateCharacter.Sprite;
    }
}
