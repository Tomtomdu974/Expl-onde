using UnityEngine;
public class SpawnGround : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;
    [SerializeField] float groundLength = 1f;
    [SerializeField] Transform targetToFollow;
    private float nextSpawnZ = 0;

    private void Start()
    {
        nextSpawnZ = groundLength;
    }

    private void Update()
    {
        if (targetToFollow.position.z + groundLength > nextSpawnZ)
        {
            Instantiate(prefabToSpawn, new Vector3(0, 0, nextSpawnZ), Quaternion.identity);
            nextSpawnZ += groundLength;
        }
    }
}
