using DG.Tweening;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private void Start()
    {
        Rotation();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GlobalEventManager.SendCoinPickedUp();
            transform.DOMove(new Vector2(21, 17), 1);
            Destroy(gameObject, 1);
        }
    }
    private void Rotation()
    {
        transform.DORotate(new Vector3(0, 360, 0), 1.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear).SetLink(gameObject);
    }
}