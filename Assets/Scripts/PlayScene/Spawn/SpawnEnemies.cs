using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using JetBrains.Annotations;
using System.Security.Cryptography;

public class SpawnEnemies : MonoBehaviour
{
    private int _minTimeToSpawnObstacle = 1;
    private int _maxTimeToSpawnObstacle = 4;
    private Vector3 _leftSide = new Vector2(-26, -2.5f);
    private Vector3 _rigthSide = new Vector2(26, -2.5f);
    IEnumerator coroutine;
    private void Awake()
    {
        GlobalEventManager.NextWave.AddListener(() => StartCoroutine(NextWave()));
    }
    private void Start()
    {
        coroutine = Spawn();
        StartCoroutine(coroutine);
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            var obg = EnemiesPool.Instance.Get();
            obg.transform.position = GetRandomSide();
            obg.gameObject.SetActive(true);
            yield return new WaitForSeconds(GetRandomTimeSpawn());
        }
    }
    private int GetRandomTimeSpawn()
    {
        return Random.Range(_minTimeToSpawnObstacle, _maxTimeToSpawnObstacle);
    }
    private Vector2 GetRandomSide()
    {
        int getEdge = Random.Range(0, 2);
        if (getEdge == 0) return _leftSide;
        return _rigthSide;
    }
    private IEnumerator NextWave()
    {
        StopSpawn();
        _maxTimeToSpawnObstacle--;
        yield return new WaitForSeconds(10);
        StartCoroutine(coroutine);
    }
    private void StopSpawn()
    {
        StopCoroutine(coroutine);
    }
}
