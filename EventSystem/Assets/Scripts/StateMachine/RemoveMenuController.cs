using deVoid.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMenuController : IUIController, IGameEventListener
{
    public UISwitcher UISwitcher { get; set; }
    private RemoveMenuView _removeMenu;
    private ResourcePool _pool;
    private RemoveButtonSignal _removeSignal;
    private GameEventController _gameEventController;

    public RemoveMenuController(UISwitcher uISwitcher, ResourcePool pool, RemoveMenuView removeMenu, GameEventController gameEventController)
    {
        UISwitcher = uISwitcher;
        _removeMenu = removeMenu;
        _pool = pool;
        _gameEventController = gameEventController;
        _removeSignal = Signals.Get<RemoveButtonSignal>();
    }

    public void Enter()
    {
        _removeSignal.AddListener(Remove);
        _gameEventController.AddListener(this);
    }

    public void Exit()
    {
        _removeSignal.RemoveListener(Remove);
        _gameEventController.RemoveListener(this);
        _removeMenu.UnView();
    }

    private void Remove(ResourceType resourceType, int amount)
    {
        Debug.Log(_pool.resources[resourceType]);
        _pool.Remove(resourceType, amount);
    }
        

    public void Update()
    {
        _removeMenu.View();
    }
}
