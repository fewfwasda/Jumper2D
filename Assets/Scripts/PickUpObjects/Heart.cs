using DG.Tweening;
using UnityEngine;

public class Heart : MonoBehaviour
{
    private int _heal = 1;
    private Vector2 _positionUIHearts = new Vector2(-16f, 14.2f);
    private void Start()
    {
        Rotation();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Healthable.AddHealth(_heal);
            MoveToUIHearts();
            Destroy(gameObject, 1);
        }
    }
    private void MoveToUIHearts()
    {
        transform.DOMove(_positionUIHearts, 1);
    }
    private void Rotation()
    {
        transform.DORotate(new Vector3(0, 360, 0), 1.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear).SetLink(gameObject);
    }
}
