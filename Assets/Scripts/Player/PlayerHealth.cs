using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float ActualHealth;
    [SerializeField] private float MaxHealth;

    private void Start()
    {
        ActualHealth = MaxHealth;
        Debug.Log($"Actual Health ={ActualHealth}");
    }

    public void Damage(float damage) { ActualHealth -= damage; }

    public void Heal(float heal)
    {
        if (ActualHealth >= MaxHealth) { return; }
        if (ActualHealth <= MaxHealth) { ActualHealth += heal; }
    }
    void Update() { if (ActualHealth <= 0) { return; } }
}