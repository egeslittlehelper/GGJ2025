using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorruptLine : MonoBehaviour
{
    [SerializeField] public Transform transform;
    [SerializeField] GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        Instantiate(enemy, transform.position + new Vector3(+2.5f, 0, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
