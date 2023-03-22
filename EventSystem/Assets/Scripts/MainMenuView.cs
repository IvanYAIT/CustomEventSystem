using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuView : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;

    public void View() =>
        mainMenuPanel.SetActive(true);

    public void UnView() =>
        mainMenuPanel.SetActive(false);


}
