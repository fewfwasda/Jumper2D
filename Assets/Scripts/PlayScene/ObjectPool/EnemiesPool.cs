using System.Collections.Generic;
using UnityEngine;

public class EnemiesPool : MonoBehaviour
{
    public static EnemiesPool Instance;
    [SerializeField] private List<GameObject> enemies = new List<GameObject>();
    [SerializeField]private List<GameObject> _pool = new List<GameObject>();
    private int _amountEnemy = 4;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        AddPoolEnemy();
    }
    public void AddPoolEnemy()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            for (int j = 0; j < _amountEnemy; j++)
            {
                var tmp = Instantiate(enemies[i]);
                tmp.SetActive(false);
                _pool.Add(tmp);
            }
        }
    }
    public GameObject Get()
    {
        for (int i = 0; i < _pool.Count; i++)
        {
            if (!_pool[i].activeInHierarchy)
            {
                return _pool[i];
            }
        }
        return null;
    }
}
