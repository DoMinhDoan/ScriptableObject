using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent gameEvent;
    public UnityEvent unityEvent;

    private void OnEnable()
    {
        gameEvent.AddEvent(this);
    }

    private void OnDisable()
    {
        gameEvent.RemoveEvent(this);
    }

    public void OnEventRaised()
    {
        unityEvent.Invoke();
    }
}
