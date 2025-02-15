using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomNormalState : RoomBaseState
{
    public override void enterState(RoomStateManager room)
    {

    }

    public override void UpdateState(RoomStateManager room)
    {
        if (room.transform.position.x < room.line.transform.position.x)
        {
            room.switchState(room.deactiveState);
        }
    }
    public override void OnCollisionEnter(RoomStateManager room, Collision collision)
    {

    }
}
