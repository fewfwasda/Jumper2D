using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager : MonoBehaviour
{
    public static UnityEvent DealDamagePlayer = new UnityEvent();
    public static UnityEvent DeathCharacter = new UnityEvent();
    public static UnityEvent PickUp = new UnityEvent();
    public static void SendDealDamagePlayer()
    {
        DealDamagePlayer.Invoke();
    }
    public static void SendDeathPlayer()
    {
        DeathCharacter.Invoke();
    }
    public static void SendPickUp()
    {
        PickUp.Invoke();
    }
}