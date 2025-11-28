using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveGround : MonoBehaviour
{

    [SerializeField] private IntEventChannelSO updateTransistorChannel;
    [SerializeField] private GameObject[] spawnGrounds;
    [SerializeField] private GameObject[] wave;
    [SerializeField] private GameObject[] obstacleSpawn;
    [SerializeField] private GameObject[] transistorSpawn;
    [SerializeField] private PlayerController playerController;
    
    private GameManager gameManager;
   
    
    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (spawnGrounds.Length > 0)
        {
            spawnGrounds[0].SetActive(true);
        }

        if (wave.Length > 0)
        {
            wave[0].SetActive(true);
        }

        if (obstacleSpawn.Length > 0)
        {
            obstacleSpawn[0].SetActive(true);
        }

        if (transistorSpawn.Length > 0)
        {
            transistorSpawn[0].SetActive(true);
        }
    }

    private void ActiveGrounds(int score)
    {
        if (score % 500 == 0 && score > 0)
        {
            if (spawnGrounds[0].activeSelf == true && spawnGrounds[1].activeSelf == false && spawnGrounds[2].activeSelf == false)
            {
                spawnGrounds[1].SetActive(true);
                wave[1].SetActive(true);
                obstacleSpawn[1].SetActive(true);
                transistorSpawn[1].SetActive(true);
                playerController.sphere2.SetActive(true);
            }
            else if (spawnGrounds[0].activeSelf == true && spawnGrounds[1].activeSelf == true && spawnGrounds[2].activeSelf == false)
            {
                spawnGrounds[2].SetActive(true);
                wave[2].SetActive(true);
                obstacleSpawn[2].SetActive(true);
                transistorSpawn[2].SetActive(true);
                playerController.sphere3.SetActive(true);
            }
            else if (spawnGrounds[0].activeSelf == false && spawnGrounds[1].activeSelf == true && spawnGrounds[2].activeSelf == true)
            {
                spawnGrounds[0].SetActive(true);
                wave[0].SetActive(true);
                obstacleSpawn[0].SetActive(true);
                transistorSpawn[0].SetActive(true);
                playerController.sphere1.SetActive(true);
            }
            else if (spawnGrounds[0].activeSelf == true && spawnGrounds[1].activeSelf == false && spawnGrounds[2].activeSelf == true)
            {
                spawnGrounds[1].SetActive(true);
                wave[1].SetActive(true);
                obstacleSpawn[1].SetActive(true);
                transistorSpawn[1].SetActive(true);
                playerController.sphere2.SetActive(true);
            }
            else if (spawnGrounds[0].activeSelf == false && spawnGrounds[1].activeSelf == true && spawnGrounds[2].activeSelf == false)
            {
                spawnGrounds[0].SetActive(true);
                wave[0].SetActive(true);
                obstacleSpawn[0].SetActive(true);
                transistorSpawn[0].SetActive(true);
                playerController.sphere1.SetActive(true);
            }
            else if (spawnGrounds[0].activeSelf == false && spawnGrounds[1].activeSelf == false && spawnGrounds[2].activeSelf == true)
            {
                spawnGrounds[1].SetActive(true);
                wave[1].SetActive(true);
                obstacleSpawn[1].SetActive(true);
                transistorSpawn[1].SetActive(true);
                playerController.sphere2.SetActive(true);
            }
        }
    }

    public void DesactiveGrounds(int lane)
    {
        spawnGrounds[lane].SetActive(false);
        wave[lane].SetActive(false);
        obstacleSpawn[lane].SetActive(false);
        transistorSpawn[lane].SetActive(false);

            switch(lane)
            {
                case 0:
                    if (playerController.sphere1 != null) 
                        playerController.sphere1.SetActive(false);
                    break;
                case 1:
                    if (playerController.sphere2 != null) 
                        playerController.sphere2.SetActive(false);
                    break;
                case 2:
                    if (playerController.sphere3 != null) 
                        playerController.sphere3.SetActive(false);
                    break;
            }
    }

    private void OnEnable()
    {
        updateTransistorChannel.onEventRaised += ActiveGrounds;
    }

    private void OnDisable()
    {
        updateTransistorChannel.onEventRaised -= ActiveGrounds;
    }

    // void Update()
    // {
    //     if()
    //         {
    //             gameManager.GameOverScene();
    //         }
    // }
}
