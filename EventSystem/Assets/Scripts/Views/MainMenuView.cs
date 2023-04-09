using deVoid.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private Button resetBtn;

    private void Start()
    {
        resetBtn.onClick.AddListener(Reset);
    }

    private void Reset()
    {
        Signals.Get<ResetButtonSignal>().Dispatch();
    }
    public void View() =>
        mainMenuPanel.SetActive(true);

    public void UnView() =>
        mainMenuPanel.SetActive(false);


}
