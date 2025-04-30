using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InterAttackStrategy 
{
    void Attack();
    void SetAttackArea(AttackArea area);
}
