using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;

    private void Start()
    {
        StartCoroutine(spawnRoutine());
    }

    IEnumerator spawnRoutine()
    {
        float spawnInterval = Random.Range(1f, 4f);
        yield return new WaitForSeconds(spawnInterval);
        GameObject go = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        go.GetComponent<Obstacle>();
        StartCoroutine(spawnRoutine());
    }
}

        // obstacle1 = Instantiate(prefabToSpawn, obstacleSpawner1.transform.position, Quaternion.identity);
        // obstacle2 = Instantiate(prefabToSpawn, obstacleSpawner2.transform.position, Quaternion.identity);
        // obstacle3 = Instantiate(prefabToSpawn, obstacleSpawner3.transform.position, Quaternion.identity);
        // obstacle1.transform.SetParent(obstacleSpawner1.transform);
        // obstacle2.transform.SetParent(obstacleSpawner2.transform);
        // obstacle3.transform.SetParent(obstacleSpawner3.transform);
        // obstacle1.GetComponent<Obstacle>();
        // obstacle2.GetComponent<Obstacle>();
        // obstacle3.GetComponent<Obstacle>();