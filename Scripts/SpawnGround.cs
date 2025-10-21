using UnityEngine;
using System.Collections;


public class SpawnGround : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;

    [SerializeField] int sizePrefab = 1;

    private void Start()
    {
        for (int i = 0; i < sizePrefab; i++)
        {
            Instantiate(prefabToSpawn, new Vector3(0, 0, i * 10), Quaternion.identity);
        }
    }

}
