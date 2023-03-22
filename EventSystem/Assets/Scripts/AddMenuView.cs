using deVoid.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddMenuView : MonoBehaviour
{
    [SerializeField] private GameObject addMenuPanel;
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button addBtn;

    private void Start()
    {
        dropdown.AddOptions(new List<string> { ResourceType.Apple.ToString(), ResourceType.Peer.ToString(), ResourceType.Pineapple.ToString()});
        addBtn.onClick.AddListener(Add);
    }

    private void Add()
    {
        Signals.Get<AddButtonSignal>().Dispatch((ResourceType)dropdown.value, int.Parse(inputField.text));
    }


    public void View() =>
        addMenuPanel.SetActive(true);

    public void UnView() =>
        addMenuPanel.SetActive(false);
}
