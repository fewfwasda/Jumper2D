using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private Image _fullHeartUI;
    [SerializeField] private Sprite _fullHeartSprite;
    [SerializeField] private Sprite _emptyHearSprite;
    [SerializeField] private List<Image> _hearts = new List<Image>();
    private int _spaceBetweenHearts = 80;
    private Vector2 _positionHeart = new Vector2(0, 0);
    private int _maxCountHeart;
    private int _currentCountHeart;
    private void Awake()
    {
        GlobalEventManager.IsPlayerAlive.AddListener(FillIUHeart);
        GlobalEventManager.HurtChatacter.AddListener(RemoveHeart);
        GlobalEventManager.HealChatacter.AddListener(AddHeart);
    }
    private void FillIUHeart(bool alivePlayer)
    {
        if (alivePlayer)
        {
            _maxCountHeart = Healthable.MaxHealth;
            _currentCountHeart = Healthable.MaxHealth;
            for (int i = 0; i < _maxCountHeart; i++)
            {
                Image heart = Instantiate(_fullHeartUI, _positionHeart, Quaternion.identity);
                heart.transform.SetParent(gameObject.transform, false);
                _hearts.Add(heart);
                _positionHeart += new Vector2(_spaceBetweenHearts, 0);
            }
        }
        else
        {
            for (int i = 0; i < _maxCountHeart; i++)
            {
                _hearts[i].sprite = _emptyHearSprite;
            }
        }
    }
    private void RemoveHeart(int emtyHeart)
    {
        if(_currentCountHeart - emtyHeart > 0)
        {
            for (int i = _currentCountHeart - 1; i >= _currentCountHeart - emtyHeart; i--)
            {
                _hearts[i].sprite = _emptyHearSprite;
            }
            _currentCountHeart -= emtyHeart;
        }
    }
    private void AddHeart(int emtyHeart)
    {
        if (_currentCountHeart < _maxCountHeart)
        {
            for (int i = _currentCountHeart; i < _currentCountHeart + emtyHeart; i++)
            {
                _hearts[i].sprite = _fullHeartSprite;
            }
            _currentCountHeart += emtyHeart;
        }
    }
}