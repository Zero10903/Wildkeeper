using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackControler : MonoBehaviour //AttackControler se le asigna al player
{
    [SerializeField] private InterAttackStrategy _attackStrategy;
    [SerializeField] private AttackArea _attackArea;

    public void SetAttackStrategy(InterAttackStrategy newStrategy)
    {
        _attackStrategy = newStrategy;
        _attackStrategy.SetAttackArea(_attackArea);
    }

    private void Update()
    {
        if(Input.GetButtonDown("Attack") && _attackStrategy != null) //Agregado desde el InputManager de ProjectSettings
        {
            _attackStrategy.Attack();
        }
    }
}
