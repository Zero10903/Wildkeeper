using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour //AttackArea se le asigna al puntero del ataque a melee
{
    private bool _isAttacking = false;

    public void EnableAttack()
    {                                           
        _isAttacking = true;                  
        Invoke(nameof(DisableAttack), 0.02f); // se desactiva después de un corto tiempo
    }

    private void DisableAttack() { _isAttacking = false;}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_isAttacking && other.CompareTag("Enemy"))
        {
            Debug.Log("Detecté al enemigo");
        }
    }
}
