using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : IUIController
{
    public UISwitcher UISwitcher { get; set; }
    private MainMenuView _mainMenu;

    public MainMenuController(UISwitcher uISwitcher, MainMenuView mainMenu)
    {
        UISwitcher = uISwitcher;
        _mainMenu = mainMenu;
    }

    public void Enter()
    {
        _mainMenu.View();
    }

    public void Exit()
    {
        _mainMenu.UnView();
    }
}
