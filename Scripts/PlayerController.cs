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
    

    private void Start()
    {

        //trailWave.SetActive(true);
        GameObject playerObject = Instantiate(prefabToPlayer, transform.position, Quaternion.identity);
        playerObject.transform.SetParent(transform);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerObject.GetComponent<Renderer>().material = gameManager.materialsWave[0];
        playerObject.GetComponent<Renderer>().material = gameManager.materialsWave[actualColorIndex];
        // Wave2.GetComponent<Renderer>().material = gameManager.materialsWave[actualColorIndex + 1];
        // Wave3.GetComponent<Renderer>().material = gameManager.materialsWave[actualColorIndex + 2];

    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            actualColorIndex += 1;
            if (actualColorIndex > gameManager.materialsWave.Length)
            {
                actualColorIndex = 0;
            }
            Wave1.GetComponent<Renderer>().material = gameManager.materialsWave[actualColorIndex];
            
        }
    }
}
