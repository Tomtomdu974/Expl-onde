using UnityEngine;

public class CollectableTransistor : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO updateTransistorChannel;
    [SerializeField] private int transistor = 1;

    private bool isCollected = false;

    public void OnCollected()
    {
        if (isCollected) return; 
        isCollected = true;
        
        updateTransistorChannel.RaiseEvent(transistor);
        Destroy(gameObject);
    }
}
