using deVoid.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : IUIController
{
    public UISwitcher UISwitcher { get; set; }
    private MainMenuView _mainMenu;
    private ResourcePool _pool;
    private ResetButtonSignal _resetSignal;

    public MainMenuController(UISwitcher uISwitcher, ResourcePool pool, MainMenuView mainMenu)
    {
        UISwitcher = uISwitcher;
        _mainMenu = mainMenu;
        _pool = pool;
        _resetSignal = Signals.Get<ResetButtonSignal>();
    }

    public void Enter()
    {
        _resetSignal.AddListener(Reset);
        _mainMenu.View();
    }

    public void Exit()
    {
        _resetSignal.RemoveListener(Reset);
        _mainMenu.UnView();
    }

    private void Reset() =>
        _pool.Reset();
}
