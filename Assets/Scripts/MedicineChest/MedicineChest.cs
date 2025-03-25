using UnityEngine;

public class MedicineChest : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) PickUpHealth();
    }
    private void PickUpHealth()
    {
        if (CharacterHealth.Instance.MaxHealth > CharacterHealth.Instance.CurrentHealth)
        {
            CharacterHealth.Instance.CurrentHealth++;
            GlobalEventManager.SendPickUp();
        }
        Destroy(gameObject);
    }
}