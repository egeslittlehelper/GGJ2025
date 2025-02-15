using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float Speed = 10f;
    [SerializeField] float DriftSpeed = 8f;

    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] Vector3 _movement;
    [SerializeField] Animator animator;

    private SpriteRenderer spriteRenderer;
    private float moveInput;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal"); // Get input (-1 for left, 1 for right)

        if (moveInput > 0)
            spriteRenderer.flipX = false; // Face right
        else if (moveInput < 0)
            spriteRenderer.flipX = true; // Face left

        _movement = new Vector3(moveInput,Input.GetAxis("Vertical"),0 ).normalized;
    }
    private void FixedUpdate()
    {
        moveCharacter(_movement);
    }
    void moveCharacter(Vector2 direction) 
    {   rb2d.velocity = direction * Speed - new Vector2( DriftSpeed,0);
        animator.SetFloat("Movement", Mathf.Abs(direction.x));
    }
}
