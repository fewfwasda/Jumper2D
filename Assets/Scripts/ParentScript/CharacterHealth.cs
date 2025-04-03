using UnityEngine;

public abstract class CharacterHealth : MonoBehaviour
{
    //свойство максимального здоровья нужно для изменения спрайта персонажа
    public int Max { get; protected set; }
    private int _current;
    //свойство текущего здоровья нужно для отображения на экране
    public int Current => _current;

    public static CharacterHealth Instance;
    protected virtual void Start()
    {
        _current = Max;
    }
    private void Awake()
    {
        Instance = this;
    }
    public void Add()
    {
        if (_current < Max)
        {
            _current++;
            GlobalEventManager.SendPickUp();
        }
    }
    public void Remove(int damage)
    {
        if (_current - damage <= 0)
        {
            _current = 0;
            GlobalEventManager.SendDeathPlayer();
        }
        else
        {
            _current -= damage;
            GlobalEventManager.SendDealDamagePlayer();
        }
    }
}