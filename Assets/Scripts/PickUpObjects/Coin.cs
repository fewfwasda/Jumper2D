using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Coin : PickUpObject
{
    private int _valueCoin = 1;
    private void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
        UIPlace = new Vector2(22.5f, 15);
    }
    protected override void PickUped()
    {
        GlobalEventManager.SendCoinPickedUp(_valueCoin);
        base.PickUped();
    }
}