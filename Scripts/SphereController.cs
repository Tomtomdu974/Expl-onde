using UnityEngine;

public class SphereController : MonoBehaviour
{
    private GameManager gameManager;
    private ActiveGround activeGround;
    public int lane;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        activeGround = GameObject.Find("ActiveGrounds").GetComponent<ActiveGround>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            if (other.GetComponent<Renderer>().material.color == GetComponent<Renderer>().material.color)
            {
                other.GetComponent<CollectableObstacle>().OnCollected();
            }
            else
            {
                activeGround.DesactiveGrounds(lane);
            }
        }
    }
}
