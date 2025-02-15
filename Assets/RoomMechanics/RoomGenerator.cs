using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Pool;

public class RoomGenerator : MonoBehaviour
{
    public ObjectPool<Room> _pool;

    public Room[] rooms;
    [SerializeField] public int n = 15;

    [SerializeField] Room _room;
    [SerializeField] Transform _transform;

    private void Start()
    {
        rooms = CreateRoom();
       // _pool = new ObjectPool<Room>()
    }
    private Room[] CreateRoom()
    {

        rooms = new Room[n];
        for(int i = 0;i < n; i++)
        {
            rooms[i] = Instantiate(_room, new Vector3(transform.position.x - 25 + (5 * i), transform.position.y, transform.position.z), transform.rotation);

        }
        return rooms;
    }
    private void Update()
    {
        for (int i = 0; i < n; i++)
        {
            
        
            rooms[i].move();
        }
    }
}
