using UnityEngine;
using TMPro;

public class TransistorUI : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO updateTransistorChannel;
    private TextMeshProUGUI transistorText;

    private void Awake()
    {
        transistorText = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        updateTransistorChannel.onEventRaised += UpdateTransistor;
    }

    private void OnDisable()
    {
        updateTransistorChannel.onEventRaised -= UpdateTransistor;
    }
        private void UpdateTransistor(int transistor)
    {
        transistorText.text = "Transistor : " + transistor.ToString();
    }
}
