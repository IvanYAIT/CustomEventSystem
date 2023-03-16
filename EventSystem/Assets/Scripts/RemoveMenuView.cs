using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMenuView : MonoBehaviour
{
    [SerializeField] private GameObject removeMenuPanel;

    public void View() =>
        removeMenuPanel.SetActive(true);

    public void UnView() =>
        removeMenuPanel.SetActive(false);
}
