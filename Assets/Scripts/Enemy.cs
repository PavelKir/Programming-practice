using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Rigidbody2D enemyRb;
    protected int damage = 10;
    protected int enemyHP = 20;

    private void Awake()
    {
        enemyRb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Start()
    {
        InvokeRepeating("Moving", 0, 1.5f);
    }

    protected virtual void Moving()
    {

    }
    protected void DamageReceived(int damage)
    {
        enemyHP -= damage;
        if (enemyHP <=0)
        {
            Destroy(gameObject);
        }
    }
}
