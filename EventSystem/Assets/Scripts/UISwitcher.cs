using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISwitcher
{
    private Dictionary<Type, IUIController> states;
    private IUIController currentState;

    public UISwitcher()
    {
        states = new Dictionary<Type, IUIController>();
        
    }

    public void ChangeState(Type state)
    {
        currentState.Exit();
        currentState = states[state];
        currentState.Enter();
    }
}
