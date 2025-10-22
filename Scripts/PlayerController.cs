using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private GameObject trailWave;
    [SerializeField] private GameObject prefabToPlayer;
    [SerializeField] private float playerSpeed = 0.5f;
    private GameManager gameManager;
    private Rigidbody rb;
    

    private void Awake()
    {
        //trailWave.SetActive(true);
        rb = GetComponent<Rigidbody>();
        GameObject playerObject = Instantiate(prefabToPlayer, transform.position, Quaternion.identity);
        playerObject.transform.SetParent(transform);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerObject.GetComponent<Renderer>().material = gameManager.materialsWave[0];
    }

    
    private void Update()
    {
        
    }
}
