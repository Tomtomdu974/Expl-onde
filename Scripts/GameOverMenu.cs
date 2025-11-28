using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI restartButtonText;
    [SerializeField] TextMeshProUGUI quitButtonText;

    private void Start()
    {
        restartButtonText.text = "Rejouer";
        quitButtonText.text = "Quitter le jeu";
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
