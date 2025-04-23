using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPool : MonoBehaviour
{

    [SerializeField] private List<GameObject> _pickUp = new List<GameObject>();
    [SerializeField] private List<GameObject> _pool = new List<GameObject>();
    private int _amountPickUp = 2;
    private void Awake()
    {
        AddPoolEnemy();
        GlobalEventManager.IsPlayerAlive.AddListener(DeactivateAllObject);
    }
    public void AddPoolEnemy()
    {
        for (int i = 0; i < _pickUp.Count; i++)
        {
            for (int j = 0; j < _amountPickUp; j++)
            {
                var tmp = Instantiate(_pickUp[i]);
                tmp.SetActive(false);
                _pool.Add(tmp);
            }
        }
    }
    public GameObject Get()
    {
        int randomIndex = Random.Range(0, _pool.Count);
        if (!_pool[randomIndex].activeInHierarchy) return _pool[randomIndex];
        return null;
    }
    private void DeactivateAllObject(bool alivePlayer)
    {
        if (!alivePlayer)
        {
            foreach (var item in _pool)
            {
                item.SetActive(false);
            }
        }
    }
}
