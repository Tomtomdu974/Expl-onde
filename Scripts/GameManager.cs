using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO collectObstacleChannel;
    [SerializeField] private IntEventChannelSO updateScoreChannel;
    [SerializeField] private IntEventChannelSO collectTransistorChannel;
    [SerializeField] private IntEventChannelSO updateTransistorChannel;
    public Material[] materialsWave;
    private ActiveGround activeGrounds;

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
        collectTransistorChannel.onEventRaised += AddTransistor;
    }

    private void OnDisable()
    {
        collectObstacleChannel.onEventRaised -= AddScore;
        collectTransistorChannel.onEventRaised -= AddTransistor;
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


    public void GameOverScene()
    {
        RecupScore.lastScore = score;
        RecupTransistor.lastTransistor = transistor;
        SceneManager.LoadScene("GameOver");
        activeGrounds.GameOver();
    }
}
