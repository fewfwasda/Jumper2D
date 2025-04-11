using UnityEngine;

public class TestSetCoin : MonoBehaviour
{
    int value;
    private void Awake()
    {
        TestGlobalUnityEvent.Coin.AddListener(A);
    }
    private void A(int za)
    {
        value = za;
        Debug.Log(value);
    }
}
