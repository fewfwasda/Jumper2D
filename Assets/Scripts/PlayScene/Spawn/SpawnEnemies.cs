using System.Collections;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    protected int MinTimeToSpawnEnemy = 1;
    protected int MaxTimeToSpawnEnemy = 4;
    private Vector3 _leftSide = new Vector2(-26, -2.5f);
    private Vector3 _rigthSide = new Vector2(26, -2.5f);
    protected IEnumerator coroutineSpawn;
    protected IEnumerator Spawn()
    {
        while (true)
        {
            GameObject enemy = EnemiesPool.Instance.Get();
            if (enemy != null)
            {
                enemy.transform.position = GetRandomSide();
                enemy.gameObject.SetActive(true);
            }
            yield return new WaitForSeconds(GetRandomTimeSpawn());
        }
    }
    private int GetRandomTimeSpawn()
    {
        return Random.Range(MinTimeToSpawnEnemy, MaxTimeToSpawnEnemy);
    }
    private Vector2 GetRandomSide()
    {
        int getEdge = Random.Range(0, 2);
        if (getEdge == 0) return _leftSide;
        return _rigthSide;
    }
}
