using System.Collections;
using UnityEngine;

public class ActiveGround : MonoBehaviour
{

    [SerializeField] private IntEventChannelSO updateScoreChannel;
    [SerializeField] private GameObject[] spawnGrounds;
    [SerializeField] private GameObject[] wave;
    [SerializeField] private GameObject[] obstacleSpawn;
    [SerializeField] private GameObject[] transistorSpawn;
   
    
    private void Start()
    {
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
            }
            else if (spawnGrounds[0].activeSelf == true && spawnGrounds[1].activeSelf == true && spawnGrounds[2].activeSelf == false)
            {
                spawnGrounds[2].SetActive(true);
                wave[2].SetActive(true);
                obstacleSpawn[2].SetActive(true);
                transistorSpawn[2].SetActive(true);
            }
            else if (spawnGrounds[0].activeSelf == false && spawnGrounds[1].activeSelf == true && spawnGrounds[2].activeSelf == true)
            {
                spawnGrounds[0].SetActive(true);
                wave[0].SetActive(true);
                obstacleSpawn[0].SetActive(true);
                transistorSpawn[0].SetActive(true);
            }
            else if (spawnGrounds[0].activeSelf == true && spawnGrounds[1].activeSelf == false && spawnGrounds[2].activeSelf == true)
            {
                spawnGrounds[1].SetActive(true);
                wave[1].SetActive(true);
                obstacleSpawn[1].SetActive(true);
                transistorSpawn[1].SetActive(true);
            }
            else if (spawnGrounds[0].activeSelf == false && spawnGrounds[1].activeSelf == true && spawnGrounds[2].activeSelf == false)
            {
                spawnGrounds[0].SetActive(true);
                wave[0].SetActive(true);
                obstacleSpawn[0].SetActive(true);
                transistorSpawn[0].SetActive(true);
            }
            else if (spawnGrounds[0].activeSelf == false && spawnGrounds[1].activeSelf == false && spawnGrounds[2].activeSelf == true)
            {
                spawnGrounds[1].SetActive(true);
                wave[1].SetActive(true);
                obstacleSpawn[1].SetActive(true);
                transistorSpawn[1].SetActive(true);
            }
        }
    }

    public void DesactiveGrounds(int lane)
    {
        spawnGrounds[lane].SetActive(false);
        wave[lane].SetActive(false);
        obstacleSpawn[lane].SetActive(false);
        transistorSpawn[lane].SetActive(false);
    }

    private void OnEnable()
    {
        updateScoreChannel.onEventRaised += ActiveGrounds;
    }

    private void OnDisable()
    {
        updateScoreChannel.onEventRaised -= ActiveGrounds;
    }
    
}
