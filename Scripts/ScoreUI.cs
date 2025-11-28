using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO updateScoreChannel;
    private TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        updateScoreChannel.onEventRaised += UpdateScore;
    }

    private void OnDisable()
    {
        updateScoreChannel.onEventRaised -= UpdateScore;
    }

    private void UpdateScore(int score)
    {
        scoreText.text = "Temps : " + score.ToString();
    }
}