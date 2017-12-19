using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[NodePath("FallingSloth/Actions")]
[NodeAuthor("Falling Sloth", "http://fallingsloth.uk")]
public class ScreenToWorldPoint : uScriptLogic
{
    bool _continue = false;
    public bool Continue { get { return _continue; } }

    public Vector3 In(Vector2 screenPoint, Camera cam)
    {
        _continue = true;
        return cam.ScreenToWorldPoint(screenPoint);
    }
}