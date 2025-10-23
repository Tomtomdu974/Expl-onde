using UnityEngine;

public class CollectableObstacle : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO CollectedEvent;
    [SerializeField] private int score = 100;

    public void OnCollected()
    {
        CollectedEvent.RaiseEvent(score);
        Destroy(gameObject);
    }
}
