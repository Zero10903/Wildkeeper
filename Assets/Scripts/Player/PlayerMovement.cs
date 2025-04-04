using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour  {
    
    private Rigidbody2D _rb2D;
    private Vector2 _moveInput;
    
    [Header("Movement")]
    [SerializeField] private float speed = 4f;

    void Awake() {
        _rb2D = GetComponent<Rigidbody2D>();
    }
    
    void Update() {
        float moveX = Input.GetAxisRaw("Horizontal"); //? horizontal movement of the player
        float moveY = Input.GetAxisRaw("Vertical"); //? vertical movement of the player
        _moveInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate() {
        _rb2D.MovePosition(_rb2D.position + _moveInput * speed * Time.fixedDeltaTime);
    }
}
