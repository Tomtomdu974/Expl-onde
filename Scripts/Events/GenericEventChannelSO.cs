using UnityEngine;
using UnityEngine.Events;

public abstract class GenericEventChannelSO<T> : ScriptableObject
{
    public UnityAction<T> onEventRaised;

    public void RaiseEvent(T value)
    {
        onEventRaised?.Invoke(value);
    }
}
