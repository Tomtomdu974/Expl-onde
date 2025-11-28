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
        exitGameButtonText.text = "Quitter le jeu";
    }

    public void newGame()
    {
        SceneManager.LoadScene("Tuto");
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitGame();
        }
    }
}
