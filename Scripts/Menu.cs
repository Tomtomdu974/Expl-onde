using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI newGameButtonText;
    [SerializeField] private TextMeshProUGUI scoreButtonText;
    [SerializeField] private TextMeshProUGUI controleButtonText;
    [SerializeField] private TextMeshProUGUI exitGameButtonText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newGameButtonText.text = "Nouvelle Partie";
        scoreButtonText.text = "Scores";
        controleButtonText.text = "Contrôles";
        exitGameButtonText.text = "Quitter";
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic can be added here if needed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
