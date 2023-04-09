using deVoid.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceView : MonoBehaviour
{
    private GameObject _cellPrefab;
    private GameObject _grid;
    private ResourcePool _resourcePool;
    private AddButtonSignal _addSignal;
    private RemoveButtonSignal _removeSignal;
    private ResetButtonSignal _resetSignal;
    private Dictionary<ResourceType, GameObject> cells;
    void Awake()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject cell = Instantiate(_cellPrefab, _grid.transform);
            cell.GetComponent<ResourceCell>().SetName(((ResourceType)i).ToString());
            cell.GetComponent<ResourceCell>().SetAmount(_resourcePool.resources[(ResourceType)i]);
            cells.Add((ResourceType)i, cell);
        }
    }

    private void OnDestroy()
    {
        _addSignal.RemoveListener(UpdateResources);
        _removeSignal.RemoveListener(UpdateResources);
        _resetSignal.RemoveListener(ResetResources);
    }

    public void Construct(GameObject cellPrefab, GameObject grid, ResourcePool resourcePool)
    {
        cells = new Dictionary<ResourceType, GameObject>();
        _cellPrefab = cellPrefab;
        _grid = grid;
        _resourcePool = resourcePool;
        _addSignal = Signals.Get<AddButtonSignal>();
        _addSignal.AddListener(UpdateResources);
        _removeSignal = Signals.Get<RemoveButtonSignal>();
        _removeSignal.AddListener(UpdateResources);
        _resetSignal = Signals.Get<ResetButtonSignal>();
        _resetSignal.AddListener(ResetResources);
    }

    private void ResetResources()
    {
        for (int i = 0; i < _resourcePool.resources.Count; i++)
            cells[(ResourceType)i].GetComponent<ResourceCell>().SetAmount(_resourcePool.resources[(ResourceType)i]);
    }

    private void UpdateResources(ResourceType resourceType, int amount)
    {
        cells[resourceType].GetComponent<ResourceCell>().SetAmount(_resourcePool.resources[resourceType]);
    }
}
