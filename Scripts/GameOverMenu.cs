using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI gameOverButtonText;

    private void Start()
    {
        gameOverButtonText.text = "Restart";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
