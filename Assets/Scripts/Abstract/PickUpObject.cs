using DG.Tweening;
using System.Collections;
using System.Xml.Serialization;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public abstract class PickUpObject : MonoBehaviour
{
    protected Vector2 UIPlace;
    protected SpriteRenderer Sprite;

    public IEnumerator coroutine { get; protected set; }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PickUped();
        }
        else InvokeRepeating(nameof(Blinking), 2, 0.4f);
    }
    protected virtual void PickUped()
    {

        MoveToUI(UIPlace);
        Invoke(nameof(Deactivate), 1f);

    }
    protected virtual void MoveToUI(Vector2 UI)
    {
        transform.DOMove(UI, 1);
    }
    public void Blinking()
    {
        Sprite.enabled = !Sprite.enabled;
        Invoke(nameof(Deactivate), 4f);
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
        CancelInvoke(nameof(Blinking));
    }
}
