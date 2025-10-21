using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;

    private void Start()
    {
        StartCoroutine(spawnRoutine());
    }

    IEnumerator spawnRoutine()
    {
        float spawnInterval = Random.Range(0.5f, 4f);
        yield return new WaitForSeconds(spawnInterval);
        GameObject go = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        go.GetComponent<Obstacle>().setup(Random.ColorHSV());
        StartCoroutine(spawnRoutine());
    }
    
    
}
