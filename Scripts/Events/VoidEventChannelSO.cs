using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Void Event Channel", fileName = "VoidEventChannel_SO")]
public class VoidEventChannelSO : ScriptableObject
{
    public UnityAction onEventRaised;

    public void RaiseEvent()
    {
        onEventRaised?.Invoke();
    }
}
