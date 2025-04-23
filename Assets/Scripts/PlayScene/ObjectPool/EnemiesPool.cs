using System.Collections.Generic;
using UnityEngine;

public class EnemiesPool : MonoBehaviour
{
    [SerializeField] private List<GameObject> _enemies = new List<GameObject>();
    [SerializeField]private List<GameObject> _pool = new List<GameObject>();
    private int _amountEnemy = 4;
    public static EnemiesPool Instance;
    private void Awake()
    {
        Instance = this;
        AddPoolEnemy();
    }
    public void AddPoolEnemy()
    {
        for (int i = 0; i < _enemies.Count; i++)
        {
            for (int j = 0; j < _amountEnemy; j++)
            {
                var tmp = Instantiate(_enemies[i]);
                tmp.SetActive(false);
                _pool.Add(tmp);
            }
            _amountEnemy++;
        }
    }
    public GameObject Get()
    {
        for (int i = 0; i < _pool.Count; i++)
        {
            if (!_pool[i].activeInHierarchy) return _pool[i];
        }
        return null;
    }
}
