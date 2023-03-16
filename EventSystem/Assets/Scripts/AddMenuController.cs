using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMenuController : IUIController
{
    public UISwitcher UISwitcher { get; set; }
    private AddMenuView _addMenu;

    public AddMenuController(UISwitcher uISwitcher, AddMenuView addMenu)
    {
        UISwitcher = uISwitcher;
        _addMenu = addMenu;
    }

    public void Enter()
    {
        _addMenu.View();
    }

    public void Exit()
    {
        _addMenu.UnView();
    }
}
