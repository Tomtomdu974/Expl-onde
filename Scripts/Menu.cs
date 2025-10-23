using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI newGameButtonText;
    [SerializeField] private TextMeshProUGUI scoreButtonText;
    [SerializeField] private TextMeshProUGUI controleButtonText;
    [SerializeField] private TextMeshProUGUI exitGameButtonText;

    
    void Start()
    {
        newGameButtonText.text = "Nouvelle Partie";
        scoreButtonText.text = "Scores";
        controleButtonText.text = "Contrôles";
        exitGameButtonText.text = "Quitter";
    }

    public void newGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void exitGame()
    {
        Application.Quit();
    }

    public void controleGame()
    {
        SceneManager.LoadScene("Controle");
    }

    public void scoreGame()
    {
        SceneManager.LoadScene("Scores");
    }
    
    void Update()
    {
        // Update logic can be added here if needed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitGame();
        }
    }
}
