using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] Transform transform;
    [SerializeField] RoomStateManager RSM;


    // Start is called before the first frame update
    void Start()
    {
        RSM = GetComponent<RoomStateManager>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void move()
    {
        
    }
}
