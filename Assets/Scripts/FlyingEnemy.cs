using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : Enemy
{
    bool isFlyToRight = true;
    Vector2 startPos;
    [SerializeField]
    float flyDistance = 4;
    float flyingSpeed = 3;

    // Update is called once per frame

    protected override void Start()
    {
        base.Start();
        startPos = transform.position;
    }

    protected override void Moving()
    {
        if (isFlyToRight)
        {
            Vector2 targetPos = new Vector2(startPos.x + flyDistance, startPos.y);
            enemyRb.velocity = (targetPos - startPos).normalized * flyingSpeed;
            isFlyToRight = false;
        }
        else
        {
            Vector2 targetPos = new Vector2(startPos.x - flyDistance, startPos.y);
            enemyRb.velocity = (targetPos - startPos).normalized * flyingSpeed;
            isFlyToRight = true;
        }
    }
}
