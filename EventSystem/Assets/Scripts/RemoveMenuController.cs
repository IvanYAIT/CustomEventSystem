using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMenuController : IUIController
{
    public UISwitcher UISwitcher { get; set; }
    private RemoveMenuView _removeMenu;

    public RemoveMenuController(UISwitcher uISwitcher, RemoveMenuView removeMenu)
    {
        UISwitcher = uISwitcher;
        _removeMenu = removeMenu;
    }

    public void Enter()
    {
        _removeMenu.View();
    }

    public void Exit()
    {
        _removeMenu.UnView();
    }
}
