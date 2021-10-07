using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Rigidbody2D enemyRb;

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
}
