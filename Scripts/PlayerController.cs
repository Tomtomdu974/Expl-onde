using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private GameObject trailWave;
    [SerializeField] private GameObject prefabToPlayer;
    [SerializeField] private Material[] materialsWave;
    [SerializeField] private float playerSpeed = 0.5f;
    


    private void Start()
    {
        //trailWave.SetActive(true);
        Instantiate(prefabToPlayer, transform.position, Quaternion.identity);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        
    }

}
