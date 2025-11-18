using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class Collectable : MonoBehaviour
{
    [SerializeField] private UnityEvent onCollected;
    [SerializeField] private string collectableTag = "Collectable";
    private Color obstacleColor;
    private ActiveGround activeGrounds;
    public int lane;

    void Start()
    {
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
            activeGrounds.DesactiveGrounds(lane);
        }

        if(other.gameObject.CompareTag("Transistor"))
        {
            onCollected?.Invoke();
        }
    }
}
