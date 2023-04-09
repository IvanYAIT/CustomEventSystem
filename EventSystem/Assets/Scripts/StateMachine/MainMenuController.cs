using deVoid.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : IUIController, IGameEventListener
{
    public UISwitcher UISwitcher { get; set; }
    private MainMenuView _mainMenu;
    private ResourcePool _pool;
    private ResetButtonSignal _resetSignal;
    private GameEventController _gameEventController;

    public MainMenuController(UISwitcher uISwitcher, ResourcePool pool, MainMenuView mainMenu, GameEventController gameEventController)
    {
        UISwitcher = uISwitcher;
        _mainMenu = mainMenu;
        _pool = pool;
        _gameEventController = gameEventController;
        _resetSignal = Signals.Get<ResetButtonSignal>();
    }

    public void Enter()
    {
        _resetSignal.AddListener(Reset);
        _gameEventController.AddListener(this);
    }

    public void Exit()
    {
        _resetSignal.RemoveListener(Reset);
        _gameEventController.RemoveListener(this);
        _mainMenu.UnView();
    }

    private void Reset() =>
        _pool.Reset();

    public void Update()
    {
        _mainMenu.View();
    }
}
