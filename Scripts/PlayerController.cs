using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private GameObject trailWave;
    [SerializeField] private GameObject prefabToPlayer;
    [SerializeField] private GameObject Wave1;
    [SerializeField] private GameObject Wave2;
    [SerializeField] private GameObject Wave3;
    private int actualColorIndex = 0;
    private GameManager gameManager;
    private GameObject sphere1;
    private GameObject sphere2;
    private GameObject sphere3; 

    private void Start()
    {
        //trailWave.SetActive(true);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        sphere1 = Instantiate(prefabToPlayer, Wave1.transform.position, Quaternion.identity);
        sphere1.GetComponent<SphereController>().lane = 0;
        sphere2 = Instantiate(prefabToPlayer, Wave2.transform.position, Quaternion.identity);
        sphere2.GetComponent<SphereController>().lane = 1;
        sphere3 = Instantiate(prefabToPlayer, Wave3.transform.position, Quaternion.identity);
        sphere3.GetComponent<SphereController>().lane = 2;
        sphere1.transform.SetParent(Wave1.transform);
        sphere2.transform.SetParent(Wave2.transform);
        sphere3.transform.SetParent(Wave3.transform);
        sphere1.GetComponent<Renderer>().material = gameManager.materialsWave[0];
        sphere2.GetComponent<Renderer>().material = gameManager.materialsWave[0];
        sphere3.GetComponent<Renderer>().material = gameManager.materialsWave[0];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            actualColorIndex += 1;
            if (actualColorIndex >= gameManager.materialsWave.Length)
            {

                actualColorIndex = 0;
            }

            if(sphere1 != null)
            {
                sphere1.GetComponent<Renderer>().material = gameManager.materialsWave[actualColorIndex];
            }
        }

        if (Input.GetKeyDown(KeyCode.E)|| Input.GetKeyDown(KeyCode.Keypad3))
        {
            actualColorIndex += 1;
            if (actualColorIndex >= gameManager.materialsWave.Length)
            {
                actualColorIndex = 0;
            }

            if(sphere2 != null)
            {
                sphere2.GetComponent<Renderer>().material = gameManager.materialsWave[actualColorIndex];
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Q)|| Input.GetKeyDown(KeyCode.Keypad1))
        {
            actualColorIndex += 1;
            if (actualColorIndex >= gameManager.materialsWave.Length)
            {
                actualColorIndex = 0;
            }

            if(sphere3 != null)
            {
                sphere3.GetComponent<Renderer>().material = gameManager.materialsWave[actualColorIndex];
            }
        }
    }
}
