using DG.Tweening;
using UnityEngine;

public class RotationCoinUI : MonoBehaviour
{
    void Start()
    {
        RotationCharacter();
    }
    private void RotationCharacter()
    {
        transform.DORotate(new Vector3(0, -360, 0), 1.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear).SetLink(gameObject);
    }
}
