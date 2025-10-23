using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
