using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private Image _fullHeartUI;
    [SerializeField] private Sprite _fullHeartSprite;
    [SerializeField] private Sprite _emptyHearSprite;
    [SerializeField]private List<Image> _hearts = new List<Image>();
    private int _spaceBetweenHearts = 80;
    private Vector2 _positionHeart = new Vector2(0, 0);
    private void Awake()
    {
        GlobalEventManager.IsPlayerAlive.AddListener(SpawnIUHeart);
        GlobalEventManager.ChangeHealth.AddListener(ChangeHeart);
    }
    private void SpawnIUHeart(bool alivePlayer)
    {
        if (alivePlayer)
        {
            for (int i = 0; i < Healthable.MaxHealth; i++)
            {
                Image heart = Instantiate(_fullHeartUI, _positionHeart, Quaternion.identity);
                heart.transform.SetParent(gameObject.transform, false);
                _hearts.Add(heart);
                _positionHeart += new Vector2(_spaceBetweenHearts, 0);
            }
        }
    }
    private void ChangeHeart()
    {
        foreach (Image item in _hearts)
        {
            item.sprite = _emptyHearSprite;
        }
        for (int i = 0; i < Healthable.CurrentHealth; i++)
        {
            _hearts[i].sprite = _fullHeartSprite;
        }
    }
}