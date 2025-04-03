using UnityEngine;

public class MedicineChest : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CharacterHealth.Instance.Add();
            Destroy(gameObject);
        }
    }
}