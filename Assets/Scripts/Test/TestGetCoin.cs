using UnityEngine;

public class TestGetCoin : MonoBehaviour
{
    int value = 6;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) TestGlobalUnityEvent.SendCoin(value);
    }
}
