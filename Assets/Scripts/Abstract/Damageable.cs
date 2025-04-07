using UnityEngine;

public abstract class Damageable : MonoBehaviour
{
    protected virtual int Damage { get; set; }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Healthable.Instance.RemoveHealth(Damage);
        }
    }
}
