using UnityEngine;

public class SFXCharacter : MonoBehaviour
{
    [SerializeField]private AudioSource _damageSound;
    [SerializeField]private AudioSource _healSound;
    [SerializeField]private AudioSource _coinSound;
    private void Awake()
    {
        GlobalEventManager.HealChatacter.AddListener(HealPickUpSound);
        GlobalEventManager.HurtChatacter.AddListener(DamageSound);
        GlobalEventManager.CoinPickedUp.AddListener(CoinPickUpSound);
    }
    private void DamageSound(int stub)
    {
        _damageSound.Play();
    }
    private void HealPickUpSound(int stub)
    {
        _healSound.Play();
    }
    private void CoinPickUpSound(int stub)
    {
        _coinSound.Play();
    }
}
