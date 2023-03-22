using deVoid.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMenuController : IUIController
{
    public UISwitcher UISwitcher { get; set; }
    private AddMenuView _addMenu;
    private AddButtonSignal _addSignal;
    private ResourcePool _pool;

    public AddMenuController(UISwitcher uISwitcher,ResourcePool pool, AddMenuView addMenu)
    {
        UISwitcher = uISwitcher;
        _addMenu = addMenu;
        _pool = pool;
        _addSignal = Signals.Get<AddButtonSignal>();
    }

    public void Enter()
    {
        _addSignal.AddListener(Add);
        _addMenu.View();
    }

    public void Exit()
    {
        _addSignal.RemoveListener(Add);
        _addMenu.UnView();
    }

    private void Add(ResourceType resourceType, int amount)=>
        _pool.Add(resourceType, amount);
}
