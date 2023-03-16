using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUIController
{
    UISwitcher UISwitcher { get; set; }

    void Enter();
    void Exit();
}
