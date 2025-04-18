using DG.Tweening;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private int _valueCoin = 1;
    private Vector2 _positionUICoins= new Vector2(22.5f, 15);
    private void Start()
    {
        Rotation();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Bank.AddCoin(_valueCoin);
            MoveToUICoins();
            Destroy(gameObject, 1);
        }
    }
    private void MoveToUICoins()
    {
        transform.DOMove(_positionUICoins, 1);
    }
    private void Rotation()
    {
        transform.DORotate(new Vector3(0, 360, 0), 1.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear).SetLink(gameObject);
    }
}