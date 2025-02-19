using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTypeManager : MonoBehaviour
{
    [SerializeField] public RoomBaseType curType;
    public RoomTypeObstacle RoomTypeObstacle = new RoomTypeObstacle();
    public RoomTypeBasic RoomTypeBasic = new RoomTypeBasic();
    public RoomTypeItem RoomTypeItem = new RoomTypeItem();

    public SpriteRenderer sr;

    [SerializeField] public float RoomWidth = 5.0f;
    [SerializeField] public float RoomHeight = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        //line = GetComponent<CorruptLine>();
        curType = RoomTypeBasic;
        curType.enterType(this);
    }
    void OnCollisionEnter(Collision collision)
    {
        curType.OnCollisionEnter(this, collision);
    }
    // Update is called once per frame
    void Update()
    {
        curType.UpdateType(this);
    }

    public void switchState(RoomBaseType type)
    {
        curType = type;
        type.enterType(this);
    }
}