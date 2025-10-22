using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI newGameButtonText;
    [SerializeField] private TextMeshProUGUI scoreButtonText;
    [SerializeField] private TextMeshProUGUI controleButtonText;
    [SerializeField] private TextMeshProUGUI exitGameButtonText;

    public void newGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void exitGame()
    {
        Application.Quit();
    }
    
    void Start()
    {
        newGameButtonText.text = "Nouvelle Partie";
        scoreButtonText.text = "Scores";
        controleButtonText.text = "Contrôles";
        exitGameButtonText.text = "Quitter";
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
