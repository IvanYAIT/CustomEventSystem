using System;
using System.Collections.Generic;

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

    public Dictionary<Type, IUIController> Init(UISwitcher uISwitcher, GameEventController gameEventController)
    {
        Dictionary<Type, IUIController> states = new Dictionary<Type, IUIController>();
        states.Add(typeof(MainMenuController), new MainMenuController(uISwitcher, _pool, _mainMenu, gameEventController));
        states.Add(typeof(AddMenuController), new AddMenuController(uISwitcher, _pool, _addMenu, gameEventController));
        states.Add(typeof(RemoveMenuController), new RemoveMenuController(uISwitcher, _pool, _removeMenu, gameEventController));
        return states;
    }
}
