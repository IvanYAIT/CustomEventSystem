using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEventController", menuName = "SO/NewGameEventController")]
public class GameEventController : ScriptableObject
{
    private List<IGameEventListener> gameEvents = new List<IGameEventListener>();

    public void AddListener(IGameEventListener gameEvent)
    {
        gameEvents.Add(gameEvent);
    }
    public void RemoveListener(IGameEventListener gameEvent)
    {
        if (gameEvents.Contains(gameEvent))
            gameEvents.Remove(gameEvent);
    }

    public void Invoke()
    {
        foreach (IGameEventListener gameEvent in gameEvents)
            gameEvent.Update();
    }
}
