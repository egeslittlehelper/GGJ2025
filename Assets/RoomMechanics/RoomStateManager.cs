using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomStateManager : MonoBehaviour
{
    [SerializeField] RoomBaseState curState;
    public RoomDeactiveState deactiveState = new RoomDeactiveState();
    public RoomEnemyState enemyState = new RoomEnemyState();
    public RoomNormalState NormalState = new RoomNormalState();
    public RoomWarningState WarningState = new RoomWarningState();

    public SpriteRenderer sr;
    [SerializeField] public CorruptLine line;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        //line = GetComponent<CorruptLine>();
        curState = NormalState;
        curState.enterState(this);
    }
    void OnCollisionEnter(Collision collision)
    {
        curState.OnCollisionEnter(this, collision);
    }
    // Update is called once per frame
    void Update()
    {
        curState.UpdateState(this);
    }

    public void switchState(RoomBaseState state)
    {
        curState=state;
        state.enterState(this);
    }
}
