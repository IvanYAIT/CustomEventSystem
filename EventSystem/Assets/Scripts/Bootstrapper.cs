using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private MainMenuView mainMenu;
    [SerializeField] private AddMenuView addMenu;
    [SerializeField] private RemoveMenuView removeMenu;
    [SerializeField] private Button mainMenuButton;
    [SerializeField] private Button addMenuButton;
    [SerializeField] private Button removeMenuButton;
    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private GameObject grid;
    [SerializeField] private ResourceView resourceView;
    [SerializeField] private GameEventController gameEventController;

    private ResourcePool _resourcePool;
    private StateInitializer _stateInitializer;
    private UISwitcher _uISwitcher;

    void Start()
    {
        _resourcePool = new ResourcePool();
        _resourcePool.Init();
        _stateInitializer = new StateInitializer(mainMenu, addMenu, removeMenu, _resourcePool);
        resourceView.Construct(cellPrefab, grid, _resourcePool);
        _uISwitcher = new UISwitcher(_stateInitializer, mainMenuButton, addMenuButton, removeMenuButton, gameEventController);
    }

    void Update()
    {
        
    }
}
