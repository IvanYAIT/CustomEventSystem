using deVoid.Utils;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RemoveMenuView : MonoBehaviour
{
    [SerializeField] private GameObject removeMenuPanel;
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button removeBtn;

    private void Start()
    {
        dropdown.AddOptions(new List<string> { ResourceType.Apple.ToString(), ResourceType.Peer.ToString(), ResourceType.Pineapple.ToString() });
        removeBtn.onClick.AddListener(Remove);
    }

    private void Remove()
    {
        Signals.Get<RemoveButtonSignal>().Dispatch((ResourceType)dropdown.value, int.Parse(inputField.text));
    }

    public void View() =>
        removeMenuPanel.SetActive(true);

    public void UnView() =>
        removeMenuPanel.SetActive(false);
}
