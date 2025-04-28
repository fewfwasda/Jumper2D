using UnityEngine;

public abstract class Damageable : MonoBehaviour
{
    protected int Damage { get; set; }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GlobalEventManager.SendHurtChatacter(Damage);
        }
    }
}
