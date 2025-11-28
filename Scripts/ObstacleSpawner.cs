using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;

    IEnumerator spawnRoutine()
    {
        float spawnInterval = Random.Range(1f, 4f);
        yield return new WaitForSeconds(spawnInterval);
        GameObject go = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        // go.GetComponent<Obstacle>();
        StartCoroutine(spawnRoutine());
    }

    private void OnEnable()
    {
        StartCoroutine(spawnRoutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}