using UnityEngine;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO updateScoreChannel;
    public Material[] materialsWave;

    private int score = 0;

    private void Start()
    {
        updateScoreChannel.RaiseEvent(this.score);
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    public void AddScore(int score)
    {
        this.score += score;
        updateScoreChannel.RaiseEvent(this.score);
    }
}

