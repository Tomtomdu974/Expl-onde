using UnityEngine;
using TMPro;

public class RecupScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    public static int lastScore;

    void Start()
    {
        int score = lastScore;
        scoreText.text = "Score : " + score.ToString();
        Debug.Log("Last Score: " + score);
    }
}
