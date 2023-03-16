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

    public void Reset()
    {
        foreach (ResourceType key in resources.Keys)
            resources[key] = 0;
    }
}


public enum ResourceType
{
    Apple,
    Pineapple,
    Peer
}