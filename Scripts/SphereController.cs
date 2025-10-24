using UnityEngine;

public class SphereController : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            if (other.GetComponent<Renderer>().material.color != GetComponent<Renderer>().material.color)
            {
                other.GetComponent<CollectableObstacle>().OnCollected();
                Destroy(gameObject);
            }
        }
    }
}
