using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickUp : MonoBehaviour
{
    private int _minTimeToSpawnPickUp = 10;
    private int _maxTimeToSpawnPickUp = 20;

    private int _edgeSpawnX = 25;
    private int _edgeSpawnY = 19;
    private IEnumerator coroutineSpawn;
    private PickUpPool _pickUpPool;
    private void Awake()
    {
        GlobalEventManager.IsPlayerAlive.AddListener(Stop);
    }
    private void Start()
    {
        _pickUpPool = GetComponent<PickUpPool>();
        coroutineSpawn = Spawn();
        StartCoroutine(coroutineSpawn);
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            GameObject pickUp = _pickUpPool.Get();
            if (pickUp != null)
            {
                int randomPosition = Random.Range(-_edgeSpawnX, _edgeSpawnX);
                pickUp.transform.position = new Vector2(randomPosition, _edgeSpawnY);
                pickUp.gameObject.SetActive(true);
            }

            yield return new WaitForSeconds(GetRandomTimeSpawn());
        }
    }

    private int GetRandomTimeSpawn()
    {
        return Random.Range(_minTimeToSpawnPickUp, _maxTimeToSpawnPickUp);
    }

    private void Stop(bool isAlive)
    {
        if (!isAlive) StopCoroutine(coroutineSpawn);
    }
}
