using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RoomBaseType
{
    public abstract void enterType(RoomTypeManager room);

    public abstract void UpdateType(RoomTypeManager room);
    public abstract void OnCollisionEnter(RoomTypeManager room, Collision collision);

}
