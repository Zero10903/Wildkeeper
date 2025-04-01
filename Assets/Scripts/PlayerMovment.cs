using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    
    private Rigidbody2D playerRb2d;
    private Vector2 moveInput;
    void Start()
    {
        playerRb2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //inputs
        float moveX = Input.GetAxisRaw("Horizontal"); //horizontal movement of the player
        float moveY = Input.GetAxisRaw("Vertical"); //vertical movement of the player
        moveInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        playerRb2d.MovePosition(playerRb2d.position + moveInput * speed * Time.fixedDeltaTime);
    }
}
