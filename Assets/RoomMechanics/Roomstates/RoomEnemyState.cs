using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEnemyState : RoomBaseState
{
    
    public override void enterState(RoomStateManager room)
    {
        //change sprite
    }

    public override void UpdateState(RoomStateManager room)
    {

    }
    public override void OnCollisionEnter(RoomStateManager room, Collision collision)
    {
        //The camera will shrink.
    }
}
