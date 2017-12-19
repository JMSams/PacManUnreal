using UnityEngine;

[NodePath("FallingSloth/Debug")]
[FriendlyName("Debug Vector3")]
class DebugVector3 : uScriptLogic
{
    bool _continue = true;
    public bool Continue { get { return _continue; } }

    public void In(string name, Vector3 value)
    {
        Debug.Log(name + ": " + value);
    }
}
