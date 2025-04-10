using DG.Tweening;
using UnityEngine;

public class Heart : MonoBehaviour
{
    private int _heal = 1;
    private void Start()
    {
        Rotation();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Healthable.Instance.AddHealth(_heal);
            Destroy(gameObject);
        }
    }
    private void Rotation()
    {
        transform.DORotate(new Vector3(0, 360, 0), 1.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear).SetLink(gameObject);
    }
}
