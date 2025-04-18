using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickUp : MonoBehaviour
{
    private int _minTimeToSpawn = 1;
    private int _maxTimeToSpawn = 5;

    private int _edgeSpawnX = 25;
    private int _edgeSpawnY = 19;

    [SerializeField] List<GameObject> _pickUpObjects = new List<GameObject>();

    private void Awake()
    {
        //GlobalEventManager.StatePlayer.AddListener(Stop);
    }
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            int randomPosition = Random.Range(-_edgeSpawnX, _edgeSpawnX);
            int randomObject = Random.Range(0, _pickUpObjects.Count);
            Instantiate(_pickUpObjects[randomObject], new Vector2(randomPosition, _edgeSpawnY), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(_minTimeToSpawn, _maxTimeToSpawn));
        }
    }
    private void Stop()
    {
        Destroy(gameObject);
    }
}
