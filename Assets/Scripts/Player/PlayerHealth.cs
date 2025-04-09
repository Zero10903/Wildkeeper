using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _actualHealth;
    [SerializeField] private float _maxHealth;

    private void Start() {_actualHealth = _maxHealth;}

    public void Damage(float damage) 
    { 
        _actualHealth -= damage;
        if (_actualHealth < 0)
        {
            Death();
        }
    }

    public void Heal(float heal)
    {
        if (_actualHealth > _maxHealth) { _actualHealth = _maxHealth; }
        if (_actualHealth < _maxHealth) { _actualHealth += heal; }
        if (_actualHealth == _maxHealth) { Debug.Log("No puedes curarte mas, Vida maxima alcanzada"); }
    }

    public void Death() {Debug.Log("Dead");}
}