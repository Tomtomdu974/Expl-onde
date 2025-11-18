using UnityEngine;

public class CollectableTransistor : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO collectTransistorChannel;
    [SerializeField] private int transistor = 1;

    private bool isCollected = false;

    public void OnCollected()
    {
        if (isCollected) return; 
        isCollected = true;
        
        collectTransistorChannel.RaiseEvent(transistor);
        Destroy(gameObject);
        Debug.Log("Transistor Collected");
    }
}
