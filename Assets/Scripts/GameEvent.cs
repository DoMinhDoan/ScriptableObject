using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "GameEvent", order = 52)]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> gameEventListeners = new List<GameEventListener>();
    
    public void RaiseEvent()
    {
        for(int i = gameEventListeners.Count - 1; i >= 0; i--)
        {
            gameEventListeners[i].OnEventRaised();
        }
    }

    public void AddEvent(GameEventListener _event)
    {
        gameEventListeners.Add(_event);
    }

    public void RemoveEvent(GameEventListener _event)
    {
        gameEventListeners.Remove(_event);
    }
}
