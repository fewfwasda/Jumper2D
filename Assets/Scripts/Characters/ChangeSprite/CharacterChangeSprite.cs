using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterChangeSprite : MonoBehaviour
{
    [SerializeField] private Sprite _lowHPSprite;
    [SerializeField] private Sprite _deadSprite;
    private SpriteRenderer _spriteRenderer;
    private int _maxHealthCharacter;
    private void Awake()
    {
        GlobalEventManager.ChangeHealth.AddListener(LowHP);
        GlobalEventManager.GameOver.AddListener(Dead);
        GlobalEventManager.StartGame.AddListener(SetMaxHealth);
    }
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void SetMaxHealth()
    {
        _maxHealthCharacter = Healthable.Instance.Health;
    }
    private void LowHP()
    {        
        if (Healthable.Instance.Health <= _maxHealthCharacter / 2)
        {
            _spriteRenderer.sprite = _lowHPSprite;
        }
    }
    private void Dead()
    {
        _spriteRenderer.sprite = _deadSprite;
    }
}
