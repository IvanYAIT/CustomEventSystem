using deVoid.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMenuController : IUIController
{
    public UISwitcher UISwitcher { get; set; }
    private RemoveMenuView _removeMenu;
    private ResourcePool _pool;
    private RemoveButtonSignal _removeSignal;

    public RemoveMenuController(UISwitcher uISwitcher, ResourcePool pool, RemoveMenuView removeMenu)
    {
        UISwitcher = uISwitcher;
        _removeMenu = removeMenu;
        _pool = pool;
        _removeSignal = Signals.Get<RemoveButtonSignal>();
    }

    public void Enter()
    {
        _removeSignal.AddListener(Remove);
        _removeMenu.View();
    }

    public void Exit()
    {
        _removeSignal.RemoveListener(Remove);
        _removeMenu.UnView();
    }

    private void Remove(ResourceType resourceType, int amount) =>
        _pool.Remove(resourceType, amount);
}
