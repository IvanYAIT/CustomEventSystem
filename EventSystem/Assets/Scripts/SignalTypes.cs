using deVoid.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButtonSignal : ASignal<ResourceType, int> {}
public class RemoveButtonSignal : ASignal<ResourceType, int> {}
public class ResetButtonSignal : ASignal {}