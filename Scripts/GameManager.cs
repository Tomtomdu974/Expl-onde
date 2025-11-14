using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO updateScoreChannel;
    [SerializeField] private IntEventChannelSO updateTransistorChannel;
    [SerializeField] private IntEventChannelSO collectObstacleChannel;
    public Material[] materialsWave;

    private int score = 0;
    private int transistor = 0;

    private void Start()
    {
        updateScoreChannel.RaiseEvent(this.score);
        updateTransistorChannel.RaiseEvent(this.transistor);
    }

    private void OnEnable()
    {
        collectObstacleChannel.onEventRaised += AddScore;
        collectObstacleChannel.onEventRaised += AddTransistor;
    }

    private void OnDisable()
    {
        collectObstacleChannel.onEventRaised -= AddScore;
        collectObstacleChannel.onEventRaised -= AddTransistor;
    }

    public void AddScore(int score)
    {
        this.score += score;
        updateScoreChannel.RaiseEvent(this.score);
    }

    public void AddTransistor(int transistor)
    {
        this.transistor += transistor;
        updateTransistorChannel.RaiseEvent(this.transistor);
    }


    public void GameOver()
    {
        ScoreManager.lastScore = score;
        
        SceneManager.LoadScene("GameOver");

    }
}
