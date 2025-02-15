using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] CorruptLine cr;
    private Transform trnsfrm;

    // Start is called before the first frame update
    void Start()
    {
        trnsfrm = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3((cr.transform.position.x - 2.5f), cr.transform.position.y,cr.transform.position.z);
    }
}
