using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int MaxHealth { get; set; }
    public int CurrentHealth;

    public static CharacterHealth Instance;
    private void Awake()
    {
        Instance = this;
    }
    public virtual void Start()
    {
        MaxHealth = 3;
        CurrentHealth = MaxHealth;
        Debug.Log(CurrentHealth);
    }
}