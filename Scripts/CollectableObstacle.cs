using UnityEngine;

public class CollectableObstacle : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO collectObstacleChannel;
    [SerializeField] private int score = 1;

    private bool isCollected = false;

    public void OnCollected()
    {
        if (isCollected) return; 
        isCollected = true;
        
        collectObstacleChannel.RaiseEvent(score);
        Destroy(gameObject);
    }

}
