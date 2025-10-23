using UnityEngine;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO updateScoreChannel;
    [SerializeField] private IntEventChannelSO collectObstacleChannel;
    public Material[] materialsWave;


    private int score = 0;

    private void Start()
    {

        updateScoreChannel.RaiseEvent(this.score);
    }

    private void OnEnable()
    {
        collectObstacleChannel.onEventRaised += AddScore;
    }

    private void OnDisable()
    {
        collectObstacleChannel.onEventRaised -= AddScore;
    }

    public void AddScore(int score)
    {
        this.score += score;
        updateScoreChannel.RaiseEvent(this.score);
    }
}
