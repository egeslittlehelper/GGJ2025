using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Room : MonoBehaviour
{
    [SerializeField] float Speed = 2f;
    [SerializeField] private float destroyTimer = 3f;
    [SerializeField] public Transform transform;
    [SerializeField] public RoomStateManager RSM;
    [SerializeField] public RoomGenerator _roomGenerator;
    [SerializeField] Vector3 _movement;

    private ObjectPool<Room> _pool;

    private Coroutine _deactivateRoomAfterCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        RSM = GetComponent<RoomStateManager>();
        transform = GetComponent<Transform>();
        _roomGenerator = GetComponent<RoomGenerator>();
    }
    private void OnEnable()
    {
        transform.position = _roomGenerator.RoomspawnPoint;
    }
    // Update is called once per frame
    void Update()
    {
        _movement = new Vector3(1, 0, 0).normalized;

    }
    private void FixedUpdate()
    {
        move();
        if(RSM.curState == RSM.deactiveState)
        {
            _deactivateRoomAfterCoroutine = StartCoroutine(DeactivateBulletAfterTime());
        }
    }
    public void SetPool(ObjectPool<Room> pool)
    {
        _pool = pool;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RoomKillPoint")
        {
            _pool.Release(this);
        }
    }
    public void move()
    {
        transform.position = new Vector3( transform.position.x + Speed * Time.deltaTime,transform.position.y,transform.position.z);

    }
    private IEnumerator DeactivateBulletAfterTime()
    {
        float elapsedTime = 0f;
        while(elapsedTime < destroyTimer)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        _pool.Release(this);
        
    }
}
