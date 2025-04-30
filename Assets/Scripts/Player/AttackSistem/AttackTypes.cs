using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MeleeAttack : InterAttackStrategy
{
    private AttackArea _attackArea;

    public void SetAttackArea(AttackArea area) {_attackArea = area;} //Seteamos el area de ataque a melee

    public void Attack()
    {
        if (_attackArea != null) { _attackArea.EnableAttack(); }     //Se ejecuta el ataque
        else {Debug.LogWarning("No se encontró el área de ataque");}
    }
}