using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDeactiveState : RoomBaseState
{
    public override void enterState(RoomStateManager room)
    {
        room.sr.color = Color.gray;
    }

    public override void UpdateState(RoomStateManager room)
    {
        if (room.transform.position.x > room.line.transform.position.x)
        {
            room.switchState(room.NormalState);
        }
    }
    public override void OnCollisionEnter(RoomStateManager room, Collision collision)
    {

    }
}
