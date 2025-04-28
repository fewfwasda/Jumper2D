using DG.Tweening;
using UnityEngine;

public class Heart : PickUpObject
{
    private int _heal = 1;
    private void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
        UIPlace = new Vector2(-20.3f, 14.3f);
    }
    protected override void PickUped()
    {
        GlobalEventManager.SendHealChatacter(_heal);
        base.PickUped();
    }
}
