using UnityEngine;
using TMPro;

public class RecupTransistor : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI transistorText;
    public static int lastTransistor;

    void Start()
    {
        transistorText.text = "Transistor : " + lastTransistor.ToString();
        Debug.Log("Last Transistor: " + lastTransistor);
    }
}
