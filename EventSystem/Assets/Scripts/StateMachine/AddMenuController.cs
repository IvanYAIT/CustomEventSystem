using deVoid.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMenuController : IUIController, IGameEventListener
{
    public UISwitcher UISwitcher { get; set; }
    private AddMenuView _addMenu;
    private AddButtonSignal _addSignal;
    private ResourcePool _pool;
    private GameEventController _gameEventController;

    public AddMenuController(UISwitcher uISwitcher,ResourcePool pool, AddMenuView addMenu, GameEventController gameEventController)
    {
        UISwitcher = uISwitcher;
        _addMenu = addMenu;
        _pool = pool;
        _gameEventController = gameEventController;
        _addSignal = Signals.Get<AddButtonSignal>();
    }

    public void Enter()
    {
        _addSignal.AddListener(Add);
        _gameEventController.AddListener(this);
    }

    public void Exit()
    {
        _addSignal.RemoveListener(Add);
        _gameEventController.RemoveListener(this);
        _addMenu.UnView();
    }

    private void Add(ResourceType resourceType, int amount)=>
        _pool.Add(resourceType, amount);

    public void Update()
    {
        _addMenu.View();
    }
}
