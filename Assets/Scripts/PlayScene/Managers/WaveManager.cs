using UnityEngine;
using System.Collections;

public class WaveManager : SpawnEnemies
{
    private int _timeToNextWave = 60;
    private void Awake()
    {
        GlobalEventManager.PlayerDead.AddListener(StopWave);
    }
    private void Start()
    {
        coroutineSpawn = Spawn();
        StartWave();
    }
    private void StartWave()
    {
        StartCoroutine(coroutineSpawn);
        Invoke(nameof(NextWave), _timeToNextWave);
    }
    private void NextWave()
    {
        StopCoroutine(coroutineSpawn);
        MaxTimeToSpawnEnemy--;
        Invoke(nameof(StartWave), 10);
    }
    private void StopWave()
    {
        StopCoroutine(coroutineSpawn);
        CancelInvoke();
    }
}
