using UnityEngine;
using UnityEngine.UIElements.Experimental;

public abstract class Healthable : MonoBehaviour
{
    public static int MaxHealth { get; protected set; }
    public static int CurrentHealth { get; protected set; }

    private static bool alivePlayer;
    [SerializeField] private AudioSource _audioSFX;
    [SerializeField] private AudioClip _damageSound;
    public static void AddHealth(int healing)
    {
        if(CurrentHealth < MaxHealth)
        {
            CurrentHealth += healing;
            GlobalEventManager.SendChangeHealth();
        }
    }
    public  void RemoveHealth(int damage)
    {
        CurrentHealth -= damage;
        //PlayDamageSound();
        GlobalEventManager.SendChangeHealth();
        if (CurrentHealth <= 0)
        {
            alivePlayer = false;
            GlobalEventManager.SendIsAlivePlayer(alivePlayer);
        }
    }
    private void PlayDamageSound()
    {
        _audioSFX.PlayOneShot(_damageSound);
    }
}