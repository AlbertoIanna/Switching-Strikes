using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  abstract class EnemyBase : MonoBehaviour, IEnemy {

    float speed;

    public abstract void DealDamage();
    public abstract void EnemyMovement();

  
}
