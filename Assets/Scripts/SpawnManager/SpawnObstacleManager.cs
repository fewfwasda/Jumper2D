using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class SpawnObstacleManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _obstaclesPrefabs = new List<GameObject>();

    private int _minTimeToSpawnObstacle;
    private int _maxTimeToSpawnObstacle;

    private Vector3 _leftEdgeSpawn = new Vector3(-28, 1, 0);
    private Vector3 _rigthEdgeSpawn = new Vector3(28, 1, 0);

    private void Awake()
    {
        GlobalEventManager.DeathCharacter.AddListener(Stop);
    }

    private void Start()
    {
        _minTimeToSpawnObstacle = 0;
        _maxTimeToSpawnObstacle = 7;
        StartCoroutine(Spawn());
    }
    //рандомно вычисляем с какой стороны появится куб
    private Vector3 GetSpawnPosition()
    {
        int getEdge = Random.Range(0, 2);
        if (getEdge == 0) return _leftEdgeSpawn;
        return _rigthEdgeSpawn;
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            int indexObstacle = Random.Range(0, _obstaclesPrefabs.Count);
            Instantiate(_obstaclesPrefabs[indexObstacle], GetSpawnPosition(), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(_minTimeToSpawnObstacle, _maxTimeToSpawnObstacle));
        }
    }
    private void Stop()
    {
        Destroy(gameObject);
    }
}