using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private GameObject trailWave;
    [SerializeField] private GameObject prefabToPlayer;
    private GameManager gameManager;
    [SerializeField] private GameObject Wave1;
    [SerializeField] private GameObject Wave2;
    [SerializeField] private GameObject Wave3;
    private int actualColorIndex = 0;

    private GameObject sphere1;
    private GameObject sphere2;
    private GameObject sphere3; 

    private void Start()
    {
        sphere1 = Instantiate(prefabToPlayer, Wave1.transform.position, Quaternion.identity);
        sphere2 = Instantiate(prefabToPlayer, Wave2.transform.position, Quaternion.identity);
        sphere3 = Instantiate(prefabToPlayer, Wave3.transform.position, Quaternion.identity);
        //trailWave.SetActive(true);
        sphere1.transform.SetParent(transform);
        sphere2.transform.SetParent(transform);
        sphere3.transform.SetParent(transform);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        sphere1.GetComponent<Renderer>().material = gameManager.materialsWave[0];
        sphere2.GetComponent<Renderer>().material = gameManager.materialsWave[0];
        sphere3.GetComponent<Renderer>().material = gameManager.materialsWave[0];
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            actualColorIndex += 1;
            if (actualColorIndex >= gameManager.materialsWave.Length)
            {

                actualColorIndex = 0;
            }
            sphere1.GetComponent<Renderer>().material = gameManager.materialsWave[actualColorIndex];
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            actualColorIndex += 1;
            if (actualColorIndex >= gameManager.materialsWave.Length)
            {
                actualColorIndex = 0;
            }
            sphere2.GetComponent<Renderer>().material = gameManager.materialsWave[actualColorIndex];
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            actualColorIndex += 1;
            if (actualColorIndex >= gameManager.materialsWave.Length)
            {
                actualColorIndex = 0;
            }
            sphere3.GetComponent<Renderer>().material = gameManager.materialsWave[actualColorIndex];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            gameManager.AddScore(100);
        }
    }
}
