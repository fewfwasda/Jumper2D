using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    private int _edgeMap = 28;
    private int _centreMap = 0;

    private Vector2 directionX;

    public static Enemy Instance;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        //выяснение в какую сторону держать путь препятствию
        if (transform.position.x > _centreMap) directionX = Vector2.left;
        else if (transform.position.x < _centreMap) directionX = Vector2.right;
    }
    public void MoveObstacle(int speed)
    {
        transform.Translate(directionX * Time.deltaTime * speed, Space.World);
    }
    public void DestroyOutOfBounds()
    {
        if (transform.position.x > _edgeMap) Destroy(gameObject);
        else if (transform.position.x < -_edgeMap) Destroy(gameObject);
    }
    public void Attack(int damage)
    {
        if (CharacterHealth.Instance.CurrentHealth - damage <= 0)
        {
            GlobalEventManager.SendDeathPlayer();
        }
        else
        {
            CharacterHealth.Instance.CurrentHealth -= damage;
            GlobalEventManager.SendCollisionEnemy();
        }
    }
}