using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class Collectable : MonoBehaviour
{
    [SerializeField] private UnityEvent onCollected;
    [SerializeField] private string collectableTag = "Collectable";
    private Color obstacleColor;
    private ActiveGround activeGround;
    public int lane;

    void Start()
    {
        activeGround = GameObject.Find("ActiveGrounds").GetComponent<ActiveGround>();
        GetComponent<Collider>().isTrigger = true;
        obstacleColor = GetComponent<Renderer>().material.color;
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(collectableTag) && obstacleColor == other.GetComponent<Renderer>().material.color)
        {
            onCollected?.Invoke();
        }
        else
        {
            // activeGround.DesactiveGrounds(lane);
            Debug.Log("Problème ");
        }

        if (other.gameObject.CompareTag("Transistor"))
        {
            onCollected?.Invoke();
        }
    }
}
