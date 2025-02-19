using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class RoomGenerator : MonoBehaviour
{
    public ObjectPool<Room> _pool;

    //public Room[] rooms;
    [Header ("Room Settings")]
    [SerializeField] public float roomFrequency = 1.0f;
    [SerializeField] public int initalSize = 30;
    [SerializeField] public int maxSize = 100;

    [Header("Related Objects")]
    [SerializeField] Room _room;
    [SerializeField] Transform _transform;
    [SerializeField] public Vector3 RoomspawnPoint;

    private void Awake()
    {
        _pool = new ObjectPool<Room>( CreateRoom, OnTakeRoomFromPool, OnReturnRoomToPool, OnDestroyRoom, true, initalSize, maxSize);
      
        RoomspawnPoint = transform.position;

        setUpRoom();
    }
    private void setUpRoom()
    {
        for (int i = 0; i < initalSize; i++)
        {
            Room temp = _pool.Get();
            RoomspawnPoint = RoomspawnPoint + new Vector3(temp.RTM. RoomWidth, 0, 0);
        }
    }
    private void Update()
    {
       
    }

    private void generateRoom()
    {
        _pool.Get();
    }

    // Methods for setting up the room pool
    private Room CreateRoom()
    {
        Room room = Instantiate(_room,transform.position,transform.rotation);

        room.SetPool(_pool);

        return room;
    }

    //what to do when we eant to take an object from the object pool
    private void OnTakeRoomFromPool(Room room)
    {
        //Set the transform and rotation
        room.transform.position = RoomspawnPoint;
        room.transform.rotation = Quaternion.identity;

        //Activate
        room.gameObject.SetActive(true);
        room.RSM.switchState(room.RSM.NormalState);
    }
    //what to do when we want to return an object to the object pool
    private void OnReturnRoomToPool(Room room)
    {
        room.gameObject.SetActive(false);
    }
    // When we want to destroy the object instead of returning it
    private void OnDestroyRoom(Room room)
    {
        Destroy(room.gameObject);
    }
}

