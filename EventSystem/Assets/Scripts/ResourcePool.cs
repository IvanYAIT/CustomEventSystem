using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcePool
{
    private Dictionary<ResourceType, int> resources;

    public void Init()
    {
        resources = new Dictionary<ResourceType, int>();
        resources.Add(ResourceType.Apple, 0);
        resources.Add(ResourceType.Peer, 0);
        resources.Add(ResourceType.Pineapple, 0);
    }

    public void Add(ResourceType resourceType, int amount) =>
        resources[resourceType] += amount;

    public void Remove(ResourceType resourceType, int amount)
    {
        if (resources[resourceType] >= amount)
            resources[resourceType] = 0;
        else
            resources[resourceType] -= amount;
    }

    public void Reset()
    {
        foreach (ResourceType key in resources.Keys)
            resources[key] = 0;
    }
}


public enum ResourceType
{
    Apple = 0,
    Pineapple = 1,
    Peer = 2
}