using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private AttackControler _attackControler;
    void Start() { _attackControler.SetAttackStrategy(new MeleeAttack());} //Setea como estrategia principal el ataque a melee

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))  // Elegimos de forma manual el ataque a melee
        {
            _attackControler.SetAttackStrategy(new MeleeAttack());
            Debug.Log("Ahora peleas a Melee");
        }
    }
}
