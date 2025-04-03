using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CharacterHealthUI : MonoBehaviour
{
    private TextMeshProUGUI _healthUI;
    private void Awake()
    {
        GlobalEventManager.DealDamagePlayer.AddListener(ChangeHealth);
        GlobalEventManager.DeathCharacter.AddListener(ChangeHealth);
        GlobalEventManager.PickUp.AddListener(ChangeHealth);
    }
    private void Start()
    {
        _healthUI = GetComponent<TextMeshProUGUI>();
        _healthUI.text = $"Health: {CharacterHealth.Instance.Current}";
    }
    private void ChangeHealth()
    {
        _healthUI.text = $"Health: {CharacterHealth.Instance.Current}";
    }
}