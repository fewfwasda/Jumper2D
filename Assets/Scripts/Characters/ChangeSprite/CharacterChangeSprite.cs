using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterChangeSprite : MonoBehaviour
{
    [SerializeField] private Sprite _lowHPSprite;
    [SerializeField] private Sprite _normalSprite;
    [SerializeField] private Sprite _deadSprite;
    private SpriteRenderer _spriteRenderer;
    private void Awake()
    {
        GlobalEventManager.ChangeHealth.AddListener(ChangeSprite);
        GlobalEventManager.GameOver.AddListener(Dead);
    }
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void ChangeSprite()
    {
        if (Healthable.Instance.CurrentHealth <= Healthable.Instance.MaxHealth / 2) _spriteRenderer.sprite = _lowHPSprite;
        else _spriteRenderer.sprite = _normalSprite;
    }
    private void Dead() => _spriteRenderer.sprite = _deadSprite;
}
