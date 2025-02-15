using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RoomBaseState
{
    public abstract void enterState(RoomStateManager room);

    public abstract void UpdateState(RoomStateManager room);
    public abstract void OnCollisionEnter(RoomStateManager room, Collision collision);

}
