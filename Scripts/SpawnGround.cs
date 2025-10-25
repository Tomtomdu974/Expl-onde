using UnityEngine;
public class SpawnGround : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;
    [SerializeField] float groundLength = 1f;
    [SerializeField] float spawnGroundDistance = 10f;
    [SerializeField] Transform targetToFollow;
    private float spawnGrounds = 0;

    private void Start()
    {
        spawnGrounds = groundLength;
        
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefabToSpawn, new Vector3(transform.position.x, 0, spawnGrounds), Quaternion.identity);
            spawnGrounds += groundLength;
        }
    }

    private void Update()
    {
        if (targetToFollow.position.z + spawnGroundDistance > spawnGrounds)
        {
            Instantiate(prefabToSpawn, new Vector3(transform.position.x, 0, spawnGrounds), Quaternion.identity);
            spawnGrounds += groundLength;
        }
    }
}
