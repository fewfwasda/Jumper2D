using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class SpawnHealthManager : MonoBehaviour
{
    [SerializeField] private GameObject _healthPrefabs;

    private int _minTimeToSpawnHealth;
    private int _maxTimeToSpawnHealth;

    private int _edgeSpawnX = 28;
    private int _edgeSpawnY = 23;

    private void Awake()
    {
        GlobalEventManager.DeathCharacter.AddListener(Stop);
    }

    private void Start()
    {
        _minTimeToSpawnHealth = 0;
        _maxTimeToSpawnHealth = 3;
        StartCoroutine(Spawn());
    }
    private Vector2 GetSpawnPosition()
    {
        int randomPosX = Random.Range(-_edgeSpawnX, _edgeSpawnX);
        return new Vector2(randomPosX, _edgeSpawnY);
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            
            Instantiate(_healthPrefabs, GetSpawnPosition(), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(_minTimeToSpawnHealth, _maxTimeToSpawnHealth));
        }
    }
    private void Stop()
    {
        Destroy(gameObject);
    }
}