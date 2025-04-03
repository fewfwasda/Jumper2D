using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ChangeSpriteCharacter : MonoBehaviour
{
    [SerializeField] private Sprite _lowHPSprite;
    [SerializeField] private Sprite _deadSprite;
    private SpriteRenderer _spriteRenderer;
    private void Awake()
    {
        GlobalEventManager.DealDamagePlayer.AddListener(LowHP);
        GlobalEventManager.DeathCharacter.AddListener(Dead);
    }
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void LowHP()
    {
        if (CharacterHealth.Instance.Current <= CharacterHealth.Instance.Max / 2)
        {
            _spriteRenderer.sprite = _lowHPSprite;
        }
    }
    private void Dead()
    {
        _spriteRenderer.sprite = _deadSprite;
    }
}
