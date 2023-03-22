using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RemoveMenuView : MonoBehaviour
{
    [SerializeField] private GameObject removeMenuPanel;
    [SerializeField] private TMP_Dropdown dropdown;

    private void Start()
    {
        dropdown.AddOptions(new List<string> { ResourceType.Apple.ToString(), ResourceType.Pineapple.ToString(), ResourceType.Peer.ToString() });
    }

    public void View() =>
        removeMenuPanel.SetActive(true);

    public void UnView() =>
        removeMenuPanel.SetActive(false);
}
