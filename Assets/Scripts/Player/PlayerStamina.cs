using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    [SerializeField] private float _actualStamina;
    [SerializeField] private float _maxStamina;
    [SerializeField] private float _runStaminaCost;
    [SerializeField] private float _walkSpeed = 4f;
    [SerializeField] private float _runSpeed = 6f;
    [SerializeField] private float _staminaRegenPerSecond = 5f;
    private bool _isRunning = false;
    public PlayerMovement playerMovement;

    private void Start(){ playerMovement.SetSpeed(_walkSpeed); }
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.LeftShift) && _actualStamina > 0f) 
      {
         if(_isRunning != true) {
            _isRunning = true;
            playerMovement.SetSpeed(_runSpeed);
         }
         _actualStamina -= _runStaminaCost * Time.deltaTime;
         _actualStamina = Mathf.Clamp(_actualStamina, 0f, _maxStamina);
        if(_actualStamina <= 0f)
        {
           _isRunning = false;
           playerMovement.SetSpeed(_walkSpeed);
        } 
      }
      else
      {
         if(_isRunning == true) {        
            _isRunning= false;
            playerMovement.SetSpeed(_walkSpeed);
         }
         _actualStamina += _staminaRegenPerSecond * Time.deltaTime;
         _actualStamina = Mathf.Clamp(_actualStamina,0f, _maxStamina);
      }
    }
}
