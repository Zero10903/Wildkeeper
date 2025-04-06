using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _actualHealth;
    [SerializeField] private float _maxHealth;

    private void Start()
    {
        _actualHealth = _maxHealth;
        Debug.Log($"Actual Health ={_actualHealth}");
    }

    public void Damage(float damage) { _actualHealth -= damage; }

    public void Heal(float heal)
    {
        if (_actualHealth >= _maxHealth) { return; }
        if (_actualHealth <= _maxHealth) { _actualHealth += heal; }
    }
    void Update() { if (_actualHealth <= 0) { return; } }
}