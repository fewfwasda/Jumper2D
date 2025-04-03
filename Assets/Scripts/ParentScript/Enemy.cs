using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class Enemy : MonoBehaviour
{
    private int _edgeMap = 28;
    private int _centreMap = 0;

    protected int Damage;
    protected int Speed;

    private Vector2 _directionX;

    public static Enemy Instance;
    protected virtual void Start()
    {
        Direction();
    }
    private void Awake()
    {
        Instance = this;
    }
    protected virtual void Update()
    {
        DestroyOutOfBounds();
        Move();
    }
    //выяснение в какую сторону держать путь препятствию
    private void Direction()
    {
        if (transform.position.x > _centreMap) _directionX = Vector2.left;
        else if (transform.position.x < _centreMap) _directionX = Vector2.right;
    }
    private void Move()
    {
        transform.Translate(10 * Time.deltaTime * _directionX, Space.World);
    }
    private void DestroyOutOfBounds()
    {
        if (transform.position.x > _edgeMap) Destroy(gameObject);
        else if (transform.position.x < -_edgeMap) Destroy(gameObject);
    }
    protected void Attack()
    {
        CharacterHealth.Instance.Remove(Damage);
    }
}