using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMenuView : MonoBehaviour
{
    [SerializeField] private GameObject addMenuPanel;

    public void View() =>
        addMenuPanel.SetActive(true);

    public void UnView() =>
        addMenuPanel.SetActive(false);
}
