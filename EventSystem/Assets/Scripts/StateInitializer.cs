using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateInitializer
{
    private MainMenuView _mainMenu;
    private AddMenuView _addMenu;
    private RemoveMenuView _removeMenu;
    private ResourcePool _pool;

    public StateInitializer(MainMenuView mainMenu, AddMenuView addMenu, RemoveMenuView removeMenu, ResourcePool pool)
    {
        _mainMenu = mainMenu;
        _addMenu = addMenu;
        _removeMenu = removeMenu;
        _pool = pool;
    }

    public Dictionary<Type, IUIController> Init(UISwitcher uISwitcher)
    {
        Dictionary<Type, IUIController> states = new Dictionary<Type, IUIController>();
        states.Add(typeof(MainMenuController), new MainMenuController(uISwitcher, _pool, _mainMenu));
        states.Add(typeof(AddMenuController), new AddMenuController(uISwitcher, _pool, _addMenu));
        states.Add(typeof(RemoveMenuController), new RemoveMenuController(uISwitcher, _pool, _removeMenu));
        return states;
    }
}
