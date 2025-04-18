using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterChangeSprite : MonoBehaviour
{
    //[SerializeField] private Sprite _lowHPSprite;
    //[SerializeField] private Sprite _normalSprite;
    //[SerializeField] private Sprite _deadSprite;
    //private SpriteRenderer _spriteRenderer;
    //private void Awake()
    //{
    //    GlobalEventManager.ChangeHealth.AddListener(ChangeSprite);
    //}
    //private void Start()
    //{
    //    _spriteRenderer = GetComponent<SpriteRenderer>();
    //}

    //private void ChangeSprite()
    //{
    //    if (Healthable.CurrentHealth <= Healthable.MaxHealth / 2) _spriteRenderer.sprite = _lowHPSprite;
    //    else _spriteRenderer.sprite = _normalSprite;
    //}
    //private void Dead() => _spriteRenderer.sprite = _deadSprite;
}
