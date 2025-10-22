using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        int n = Random.Range(0, gameManager.materialsWave.Length);
        GetComponent<Renderer>().material = gameManager.materialsWave[n];
    }
}
