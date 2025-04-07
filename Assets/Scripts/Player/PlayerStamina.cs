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
    [SerializeField] private float _staminaRegenPerSecond = 3f;
    private bool _isRunning = false;
    public PlayerMovement playerMovement;

    private void Start(){ playerMovement.SetSpeed(_walkSpeed); }
    void Update()
    { 
        if(Input.GetKey(KeyCode.LeftShift) && _actualStamina > 0f) { 
         if(playerMovement.IsMoving){ Run();}
         else{ RegenStamina();}
        }else { RegenStamina(); }  
    }
    void Run()
    { 
      playerMovement.SetSpeed(_runSpeed);
      _actualStamina -= _runStaminaCost * Time.deltaTime;
      _actualStamina = Mathf.Clamp(_actualStamina, 0f, _maxStamina);
    }
    void RegenStamina() 
    {
        playerMovement.SetSpeed(_walkSpeed);
        _actualStamina += _staminaRegenPerSecond * Time.deltaTime;
        _actualStamina = Mathf.Clamp(_actualStamina,0f, _maxStamina);
    }
}
