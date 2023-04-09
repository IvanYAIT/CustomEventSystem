using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISwitcher
{
    private Dictionary<Type, IUIController> states;
    private IUIController currentState;
    private GameEventController _gameEventController;

    public UISwitcher(StateInitializer stateInitializer, Button mainMenuButton, Button addMenuButton, Button removeMenuButton, GameEventController gameEventController)
    {
        _gameEventController = gameEventController;
        states = stateInitializer.Init(this, gameEventController);
        mainMenuButton.onClick.AddListener(() => ChangeState(typeof(MainMenuController)));
        addMenuButton.onClick.AddListener(() => ChangeState(typeof(AddMenuController)));
        removeMenuButton.onClick.AddListener(() => ChangeState(typeof(RemoveMenuController)));
    }

    public void ChangeState(Type state)
    {
        if (currentState != null)
            currentState.Exit();
        currentState = states[state];
        currentState.Enter();
        _gameEventController.Invoke();
    }

}
