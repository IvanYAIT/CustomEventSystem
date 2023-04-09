using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceCell : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI amountText;

    private ResourcePool _resourcePool;

    public void SetName(string name) => nameText.text = $"{name}";

    public void SetAmount(int amount) => amountText.text = $"{amount}";
}
