using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    
    private Rigidbody2D _playerRb2d;
    private Vector2 _moveInput;
    void Start()
    {
        _playerRb2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //inputs
        float moveX = Input.GetAxisRaw("Horizontal"); //horizontal movement of the player
        float moveY = Input.GetAxisRaw("Vertical"); //vertical movement of the player
        _moveInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        _playerRb2d.MovePosition(_playerRb2d.position + _moveInput * speed * Time.fixedDeltaTime);
    }
}
