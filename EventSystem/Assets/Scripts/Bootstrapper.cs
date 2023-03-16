using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private ResourcePool _resourcePool;
    void Start()
    {
        _resourcePool = new ResourcePool();
        _resourcePool.Init();
    }

    void Update()
    {
        
    }
}
